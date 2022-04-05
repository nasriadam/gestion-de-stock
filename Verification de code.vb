Imports System.Net
Imports System.Net.Mail

Public Class Verification_de_code
    Dim randomcode As String
    Public Shared toUser As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Not TextEmail.Text.Contains("@")) Then
            MessageBox.Show("veuillez entrez un E-mail valide")
        End If
        Dim from, pass, messgeBody As String
        Dim rand As Random = New Random()
        randomcode = (rand.Next(9999)).ToString()
        Dim message As MailMessage = New MailMessage()
        toUser = TextEmail.Text
        from = "nasriadam333@gmail.com"
        pass = "dfebrpgyjinroiuf"
        messgeBody = "votre code de verification est:" + randomcode
        message.To.Add(toUser)
        message.From = New MailAddress(from)
        message.Body = messgeBody
        message.Subject = "mot de passe oublié "
        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.DeliveryMethod = smtp.DeliveryMethod.Network
        smtp.Credentials = New NetworkCredential(from, pass)
        Try
            smtp.Send(message)
            MessageBox.Show("verifier votre email pour avoir le code ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextCode.Text.Equals(randomcode)) Then
            toUser = TextEmail.Text
            Dim reset As changer_mot_de_passe = New changer_mot_de_passe()
            reset.Show()
            Dim sc As Verification_de_code = New Verification_de_code
            sc.Hide()
        Else
            MessageBox.Show("code incorrecte")

        End If
    End Sub
End Class