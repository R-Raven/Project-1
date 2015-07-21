<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NieuweCursist
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DatabaseCursisten = New DATtraining.DatabaseCursisten()
        Me.CursistenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DatabaseCursisten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursistenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursistenBindingSource, "Achternaam", True))
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox1.Location = New System.Drawing.Point(7, 45)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(327, 26)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursistenBindingSource, "Initialen", True))
        Me.TextBox2.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox2.Location = New System.Drawing.Point(348, 45)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(103, 26)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursistenBindingSource, "BIG Nummer", True))
        Me.TextBox3.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox3.Location = New System.Drawing.Point(7, 107)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(227, 26)
        Me.TextBox3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Achternaam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(344, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Initialen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "BIG nummer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(12, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Postcode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(12, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Adres"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(12, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Geboortedatum"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursistenBindingSource, "Postcode", True))
        Me.TextBox4.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox4.Location = New System.Drawing.Point(7, 293)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(112, 26)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursistenBindingSource, "Adres", True))
        Me.TextBox5.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox5.Location = New System.Drawing.Point(7, 231)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(327, 26)
        Me.TextBox5.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label8.Location = New System.Drawing.Point(27, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 22)
        Me.Label8.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(12, 339)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(217, 23)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Factuuradres indien afwijkend"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label10.Location = New System.Drawing.Point(344, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 22)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Huisnummer"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label11.Location = New System.Drawing.Point(129, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 22)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Woonplaats"
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursistenBindingSource, "Woonplaats", True))
        Me.TextBox10.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox10.Location = New System.Drawing.Point(133, 293)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(331, 26)
        Me.TextBox10.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label7.Location = New System.Drawing.Point(129, 476)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 22)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Woonplaats"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox7.Location = New System.Drawing.Point(133, 505)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(331, 26)
        Me.TextBox7.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label12.Location = New System.Drawing.Point(344, 374)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 22)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Nummer"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label13.Location = New System.Drawing.Point(12, 476)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 22)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Postcode"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label14.Location = New System.Drawing.Point(12, 374)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 22)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Adres"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox9.Location = New System.Drawing.Point(7, 505)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(112, 26)
        Me.TextBox9.TabIndex = 26
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox11.Location = New System.Drawing.Point(7, 443)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(327, 26)
        Me.TextBox11.TabIndex = 25
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursistenBindingSource, "Huisnummer", True))
        Me.TextBox6.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox6.Location = New System.Drawing.Point(348, 231)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(103, 26)
        Me.TextBox6.TabIndex = 33
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox12.Location = New System.Drawing.Point(348, 403)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(106, 26)
        Me.TextBox12.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label16.Location = New System.Drawing.Point(12, 538)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 22)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Beroepsvereniging"
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox8.Location = New System.Drawing.Point(7, 567)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(327, 26)
        Me.TextBox8.TabIndex = 35
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox13.Location = New System.Drawing.Point(7, 403)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(327, 26)
        Me.TextBox13.TabIndex = 37
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(386, 580)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(191, 59)
        Me.TableLayoutPanel1.TabIndex = 40
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.OK_Button.Location = New System.Drawing.Point(7, 9)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(81, 41)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Opslaan"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Cancel_Button.Location = New System.Drawing.Point(98, 9)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 41)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annuleren"
        '
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox14.Location = New System.Drawing.Point(7, 169)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(52, 26)
        Me.TextBox14.TabIndex = 41
        '
        'TextBox15
        '
        Me.TextBox15.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox15.Location = New System.Drawing.Point(94, 169)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(52, 26)
        Me.TextBox15.TabIndex = 42
        '
        'TextBox16
        '
        Me.TextBox16.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.TextBox16.Location = New System.Drawing.Point(181, 169)
        Me.TextBox16.Margin = New System.Windows.Forms.Padding(7)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(61, 26)
        Me.TextBox16.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label15.Location = New System.Drawing.Point(69, 173)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 22)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Label17.Location = New System.Drawing.Point(156, 173)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 22)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "-"
        '
        'DatabaseCursisten
        '
        Me.DatabaseCursisten.DataSetName = "DatabaseCursisten"
        Me.DatabaseCursisten.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CursistenBindingSource
        '
        Me.CursistenBindingSource.DataMember = "Cursisten"
        Me.CursistenBindingSource.DataSource = Me.DatabaseCursisten
        '
        'NieuweCursist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 651)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NieuweCursist"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nieuwe Cursist"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DatabaseCursisten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursistenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CursistenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseCursisten As DATtraining.DatabaseCursisten

End Class
