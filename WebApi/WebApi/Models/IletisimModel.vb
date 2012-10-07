Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization

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

    Public Overridable Function MesajAt() As Boolean Implements IIletisimForm.MesajAt
        'Mesaj Gönderme yada db işlemleri işlemleri
        Return True
    End Function

End Class

Public Interface IIletisimForm
    Function MesajAt() As Boolean
End Interface