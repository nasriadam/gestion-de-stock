Imports System.Data
Imports System.Data.SqlClient

Public Class changer_mot_de_passe
    Public dr As SqlDataReader
    Public cmd As New SqlCommand
    Dim Email As String = Verification_de_code.toUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Textnvp.Text.Length < 8 And TextBox1.Text.Length < 8) Then
            MessageBox.Show("Le mot de passe doit contennir au moins 8 caracters")
        End If
        cn.Open()
        Dim str As String = "UPDATE Users SET  Mot_de_passe ='" & Textnvp.Text & "' where id_user ='" & Textid_user.Text & "'"
        cmd = New SqlCommand(str, cn)
        cmd.ExecuteNonQuery()
        MsgBox("Modifé avec succès :)")
        cn.Close()
    End Sub

  
End Class