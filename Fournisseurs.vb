Imports System.Data.SqlClient

Public Class Fournisseurs
    Public dr As SqlDataReader
    Public cmd As New SqlCommand
    Private Sub afficher()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from Fournisseurs "
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()

        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_fournisseur"))
            listems.SubItems.Add(dr("Nom"))
            listems.SubItems.Add(dr("Adresse"))
            listems.SubItems.Add(dr("Numero_telephone"))
            listems.SubItems.Add(dr("Numero_fax"))
            listems.SubItems.Add(dr("E_mail"))
            listems.SubItems.Add(dr("Chiffres_annuel"))
        End While
        dr.Close()
        cn.Close()


    End Sub

    Private Sub Fournisseurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Textid.Text = Nothing Or TextNom.Text = Nothing Or TextAdresse.Text = Nothing Or TextTelephone.Text = Nothing Or TextFax.Text = Nothing Or TextMail.Text = Nothing Or TextCH.Text = Nothing Then

            MsgBox("Remplir tous les champs pour ajouter un fournisseur!")

        Else

            If MsgBox("Voulez-vous ajouté un nouvel fournisseur?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " insert into Fournisseurs values ('" & Textid.Text & "','" & TextNom.Text & "','" & TextAdresse.Text & "','" & TextTelephone.Text & "','" & TextFax.Text & "','" & TextMail.Text & "','" & TextCH.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("Ajouté avec succès :)")
                cn.Close()
                afficher()




            End If
        End If

        Textid.Text = Nothing
        TextNom.Text = Nothing
        TextAdresse.Text = Nothing
        TextTelephone.Text = Nothing
        TextFax.Text = Nothing
        TextMail.Text = Nothing
        TextCH.Text = Nothing
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Selectionner un fournisseur!")
        Else
            cn.Open()
            cmd.CommandText = "select * from Fournisseurs where id_fournisseur = '" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                Me.Textid.Text = dr.Item(0).ToString
                Me.TextNom.Text = dr.Item(1).ToString
                Me.TextAdresse.Text = dr.Item(2).ToString
                Me.TextTelephone.Text = dr.Item(3).ToString
                Me.TextFax.Text = dr.Item(4).ToString
                Me.TextMail.Text = dr.Item(5).ToString
                Me.TextCH.Text = dr.Item(6).ToString
            End If
            cn.Close()
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Textid.Text = Nothing Or TextNom.Text = Nothing Or TextAdresse.Text = Nothing Or TextTelephone.Text = Nothing Or TextFax.Text = Nothing Or TextMail.Text = Nothing Or TextCH.Text = Nothing Then
            MsgBox("Selectioner un fournisseur pour supprimer!")

        Else
            If MsgBox("Voulez-vous supprimé cet fournisseur?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                Dim str As String = "delete from Fournisseurs where id_fournisseur = '" & Textid.Text & "'"
                cmd = New SqlCommand(str, cn)
                cmd.ExecuteNonQuery()
                MsgBox("supprission avec succès :)")
                cn.Close()
                afficher()


            End If
        End If
        Textid.Text = Nothing
        TextNom.Text = Nothing
        TextAdresse.Text = Nothing
        TextTelephone.Text = Nothing
        TextFax.Text = Nothing
        TextMail.Text = Nothing
        TextCH.Text = Nothing
    End Sub



    Private Sub Comborecherche_TextChanged(sender As Object, e As EventArgs) Handles Comborecherche.TextChanged
        Textrecherhe.Text = Nothing
        Textrecherhe.Focus()
    End Sub

    Private Sub Textrecherhe_TextChanged(sender As Object, e As EventArgs) Handles Textrecherhe.TextChanged
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from Fournisseurs  where " & Comborecherche.Text & " like '%' + @1 + '%' "
        cmd = New SqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@1", Textrecherhe.Text)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()

        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_fournisseur"))
            listems.SubItems.Add(dr("Nom"))
            listems.SubItems.Add(dr("Adresse"))
            listems.SubItems.Add(dr("Numero_telephone"))
            listems.SubItems.Add(dr("Numero_fax"))
            listems.SubItems.Add(dr("E_mail"))
            listems.SubItems.Add(dr("Chiffres_annuel"))
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Textid.Text = Nothing Or TextNom.Text = Nothing Or TextAdresse.Text = Nothing Or TextTelephone.Text = Nothing Or TextFax.Text = Nothing Or TextMail.Text = Nothing Or TextCH.Text = Nothing Then
            MsgBox("Remplir tous les champs pour modifer un fournisseur!")

        Else
            If MsgBox("Voulez-vous modifié cet fournisseur?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                Dim str As String = "UPDATE Fournisseurs SET id_fournisseur = " & Textid.Text & ", Nom ='" & TextNom.Text & "', Adresse ='" & TextAdresse.Text & "', Numero_telephone ='" & TextTelephone.Text & "', Numero_fax ='" & TextFax.Text & "', E_mail ='" & TextMail.Text & "', Chiffres_annuel ='" & TextCH.Text & "'where id_fournisseur ='" & Textid.Text & "'"
                cmd = New SqlCommand(str, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Modifé avec succès :)")
                cn.Close()
                afficher()


            End If
        End If
        Textid.Text = Nothing
        TextNom.Text = Nothing
        TextAdresse.Text = Nothing
        TextTelephone.Text = Nothing
        TextFax.Text = Nothing
        TextMail.Text = Nothing
        TextCH.Text = Nothing

    End Sub


End Class