Imports System.Data.SqlClient
Public Class Authentification
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Creer_un_compte.ShowDialog()
        Creer_un_compte.Hide()
        Me.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Textlogin.Text = Nothing Or Textmotdepasse.Text = Nothing Then
            MsgBox("Remplir tous les champs pour se connecter!")
        ElseIf (Not Textlogin.Text.Contains("@")) Then
            MessageBox.Show("veuillez entrez un E-mail valide")
        ElseIf (Textmotdepasse.Text.Length < 8) Then
            MessageBox.Show("Le mot de passe doit contennir au moins 8 caracters")
        Else
            Dim con As New SqlConnection("Data Source=ADAM;Initial Catalog=TEST1;Integrated Security=True")
            Dim cmd As New SqlCommand("select * from Users where E_mail = @E_mail and Mot_de_passe =@Mot_de_passe and Type_utlisateur=@Type_utlisateur", con)
            cmd.Parameters.Add("@E_mail", SqlDbType.VarChar, 50).Value = Textlogin.Text
            cmd.Parameters.Add("@Mot_de_passe", SqlDbType.VarChar, 50).Value = Textmotdepasse.Text
            cmd.Parameters.Add("@Type_utlisateur", SqlDbType.VarChar, 50).Value = ComboBox1.Text
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            sda.Fill(dt)

            If (dt.Rows.Count() > 0) Then
                MessageBox.Show("connexion avec succes :)")
                If (ComboBox1.SelectedIndex = 0) Then
                    Acceuil.Show()
                    Me.Hide()
                ElseIf (ComboBox1.SelectedIndex = 1) Then
                    Acceuil1.Show()
                    Me.Hide()
                ElseIf (ComboBox1.SelectedIndex = 2) Then
                    Acceuil2.Show()
                    Me.Hide()

                End If
            Else
                MessageBox.Show("Login ou mot de passe incorrecte !")

            End If
        End If


    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Verification_de_code.Show()
        Me.Hide()
    

    End Sub

   
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Textmotdepasse.UseSystemPasswordChar Then
            Textmotdepasse.UseSystemPasswordChar = False
        Else
            Textmotdepasse.UseSystemPasswordChar = True
        End If
    End Sub
End Class