Public Class Acceuil

  

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick, Label_date.Click
        Label_date.Text = Date.Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Articles.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Fournisseurs.Show()

    End Sub

    Private Sub Acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class