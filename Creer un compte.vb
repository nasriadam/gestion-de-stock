Imports System.Data
Imports System.Data.SqlClient
Public Class Creer_un_compte



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Textid_user.Text = Nothing Or TextE_mail.Text = Nothing Or TextMot_de_passe.Text = Nothing Then
            MsgBox("Remplir tous les champs pour ajouter un nouvel compte!")
        Else
            If MsgBox("Voulez-vous créer un nouvel compte?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then


                Dim con As SqlConnection = New SqlConnection("Data Source=ADAM;Initial Catalog=TEST1;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand(" insert into Users values ('" & Textid_user.Text & "','" & TextE_mail.Text & "','" & TextMot_de_passe.Text & "','" & ComboBox1.Text & "')", con)
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox(" Crée avec succès :)")
                con.Close()
        End If
        End If

        Textid_user.Text = Nothing
        TextE_mail.Text = Nothing
        TextMot_de_passe.Text = Nothing
        ComboBox1.Text = Nothing

    End Sub
    Private Sub Creer_un_compte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class