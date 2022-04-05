<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Articles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Textrecherhe = New System.Windows.Forms.TextBox()
        Me.Comborecherche = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextQuantites = New System.Windows.Forms.TextBox()
        Me.TextNom = New System.Windows.Forms.TextBox()
        Me.TextZS = New System.Windows.Forms.TextBox()
        Me.TextType = New System.Windows.Forms.TextBox()
        Me.TextPrix = New System.Windows.Forms.TextBox()
        Me.TextReference = New System.Windows.Forms.TextBox()
        Me.ComboCategories = New System.Windows.Forms.ComboBox()
        Me.ComboFournisseurs = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Reference = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(11, 50)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1154, 194)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Reference"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Quantites"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Categories"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Type"
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ZS"
        Me.ColumnHeader5.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Fournisseurs"
        Me.ColumnHeader6.Width = 90
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nom"
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Prix"
        Me.ColumnHeader8.Width = 90
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(785, 529)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Modifier"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(912, 529)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Ajouter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1039, 529)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Supprimer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Textrecherhe)
        Me.Panel2.Controls.Add(Me.Comborecherche)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(12, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1153, 41)
        Me.Panel2.TabIndex = 13
        '
        'Textrecherhe
        '
        Me.Textrecherhe.Location = New System.Drawing.Point(570, 9)
        Me.Textrecherhe.Name = "Textrecherhe"
        Me.Textrecherhe.Size = New System.Drawing.Size(291, 20)
        Me.Textrecherhe.TabIndex = 2
        '
        'Comborecherche
        '
        Me.Comborecherche.FormattingEnabled = True
        Me.Comborecherche.Items.AddRange(New Object() {"Reference", "Quantites", "Categories", "Affectation", "Fournisseurs", "Ressources", "Prix"})
        Me.Comborecherche.Location = New System.Drawing.Point(398, 9)
        Me.Comborecherche.Name = "Comborecherche"
        Me.Comborecherche.Size = New System.Drawing.Size(121, 21)
        Me.Comborecherche.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(289, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Recherche"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextQuantites)
        Me.Panel1.Controls.Add(Me.TextNom)
        Me.Panel1.Controls.Add(Me.TextZS)
        Me.Panel1.Controls.Add(Me.TextType)
        Me.Panel1.Controls.Add(Me.TextPrix)
        Me.Panel1.Controls.Add(Me.TextReference)
        Me.Panel1.Controls.Add(Me.ComboCategories)
        Me.Panel1.Controls.Add(Me.ComboFournisseurs)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Reference)
        Me.Panel1.Location = New System.Drawing.Point(217, 250)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 273)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(303, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "EUR"
        '
        'TextQuantites
        '
        Me.TextQuantites.Location = New System.Drawing.Point(176, 149)
        Me.TextQuantites.Name = "TextQuantites"
        Me.TextQuantites.Size = New System.Drawing.Size(121, 20)
        Me.TextQuantites.TabIndex = 15
        '
        'TextNom
        '
        Me.TextNom.Location = New System.Drawing.Point(490, 34)
        Me.TextNom.Name = "TextNom"
        Me.TextNom.Size = New System.Drawing.Size(121, 20)
        Me.TextNom.TabIndex = 14
        '
        'TextZS
        '
        Me.TextZS.Location = New System.Drawing.Point(490, 214)
        Me.TextZS.Name = "TextZS"
        Me.TextZS.Size = New System.Drawing.Size(121, 20)
        Me.TextZS.TabIndex = 13
        '
        'TextType
        '
        Me.TextType.Location = New System.Drawing.Point(490, 152)
        Me.TextType.Name = "TextType"
        Me.TextType.Size = New System.Drawing.Size(121, 20)
        Me.TextType.TabIndex = 12
        '
        'TextPrix
        '
        Me.TextPrix.Location = New System.Drawing.Point(176, 214)
        Me.TextPrix.Name = "TextPrix"
        Me.TextPrix.Size = New System.Drawing.Size(121, 20)
        Me.TextPrix.TabIndex = 11
        '
        'TextReference
        '
        Me.TextReference.Location = New System.Drawing.Point(176, 38)
        Me.TextReference.Name = "TextReference"
        Me.TextReference.Size = New System.Drawing.Size(121, 20)
        Me.TextReference.TabIndex = 10
        '
        'ComboCategories
        '
        Me.ComboCategories.FormattingEnabled = True
        Me.ComboCategories.Location = New System.Drawing.Point(490, 95)
        Me.ComboCategories.Name = "ComboCategories"
        Me.ComboCategories.Size = New System.Drawing.Size(121, 21)
        Me.ComboCategories.TabIndex = 9
        '
        'ComboFournisseurs
        '
        Me.ComboFournisseurs.FormattingEnabled = True
        Me.ComboFournisseurs.Location = New System.Drawing.Point(176, 95)
        Me.ComboFournisseurs.Name = "ComboFournisseurs"
        Me.ComboFournisseurs.Size = New System.Drawing.Size(121, 21)
        Me.ComboFournisseurs.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(390, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Prix"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(371, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Zone de stockage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantites"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(391, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nom article"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fournisseurs"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(391, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Categories"
        '
        'Reference
        '
        Me.Reference.AutoSize = True
        Me.Reference.Location = New System.Drawing.Point(92, 41)
        Me.Reference.Name = "Reference"
        Me.Reference.Size = New System.Drawing.Size(57, 13)
        Me.Reference.TabIndex = 0
        Me.Reference.Text = "Reference"
        '
        'Articles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 576)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Articles"
        Me.Text = "Articles"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Textrecherhe As System.Windows.Forms.TextBox
    Friend WithEvents Comborecherche As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextQuantites As System.Windows.Forms.TextBox
    Friend WithEvents TextNom As System.Windows.Forms.TextBox
    Friend WithEvents TextZS As System.Windows.Forms.TextBox
    Friend WithEvents TextType As System.Windows.Forms.TextBox
    Friend WithEvents TextPrix As System.Windows.Forms.TextBox
    Friend WithEvents TextReference As System.Windows.Forms.TextBox
    Friend WithEvents ComboCategories As System.Windows.Forms.ComboBox
    Friend WithEvents ComboFournisseurs As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Reference As System.Windows.Forms.Label

End Class
