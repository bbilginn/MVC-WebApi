Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization
Imports System.Net.Mail

Public Class IletisimModel
    Implements IIletisimForm

    Private IsimVal As String
    <Required>
    Public Property Isim() As String
        Get
            Return IsimVal
        End Get
        Set(ByVal value As String)
            IsimVal = value
        End Set
    End Property

    Private MailVal As String
    <Required>
    Public Property Mail() As String
        Get
            Return MailVal
        End Get
        Set(ByVal value As String)
            MailVal = value
        End Set
    End Property

    Private MesajVal As String
    <Required>
    Public Property Mesaj() As String
        Get
            Return MesajVal
        End Get
        Set(ByVal value As String)
            MesajVal = value
        End Set
    End Property

    Public Function MesajAt() As Boolean Implements IIletisimForm.MesajAt
        Dim eMail As New MailMessage()

        eMail.From = New MailAddress("webapidemos@gmail.com", "Web Api")
        eMail.To.Add(Mail)
        eMail.Subject = "Client ile Mail Gönderimi"
        'nie 3 kez geldi :D

        eMail.Body = Mesaj
        'gmail yazıyordu orada
        Dim smtp As New SmtpClient()
        smtp.Host = "smtp.gmail.com"
        smtp.Port = "587"
        smtp.EnableSsl = True
        smtp.Credentials = New Net.NetworkCredential("webapidemos@gmail.com", "/8520/8520")
        Try
            smtp.Send(eMail)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class

Public Interface IIletisimForm
    Function MesajAt() As Boolean
End Interface