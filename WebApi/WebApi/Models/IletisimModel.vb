Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization
Imports System.Net.Mail

Public MustInherit Class IletisimModel
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

    Public Overridable Function MesajAt() As String Implements IIletisimForm.MesajAt
        Dim eMail As New MailMessage()

        eMail.From = New MailAddress("email@xxx.com", "XXX XXX")
        eMail.To.Add(Mail)
        eMail.Subject = "Client ile Mail Gönderimi"

        eMail.Body = Mesaj

        Dim smtp As New SmtpClient()
        smtp.Host = "ghs.google.com"
        smtp.Port = "578"
        smtp.EnableSsl = True
        smtp.Credentials = New Net.NetworkCredential("email@gmail.com", "Şifre")
        Try
            smtp.Send(eMail)
            Return "İşlem Başarılı !"
        Catch ex As Exception
            Return "İşlem Başarısız !"
        End Try
    End Function

End Class

Public Interface IIletisimForm
    Function MesajAt() As String
End Interface