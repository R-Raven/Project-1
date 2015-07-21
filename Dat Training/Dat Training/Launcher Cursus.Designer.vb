<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Launcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NieuweCursist = New System.Windows.Forms.Button()
        Me.HuidigeCursisten = New System.Windows.Forms.Button()
        Me.CursusData = New System.Windows.Forms.Button()
        Me.Opties = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Exitbutton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(720, 112)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'NieuweCursist
        '
        Me.NieuweCursist.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NieuweCursist.Location = New System.Drawing.Point(26, 140)
        Me.NieuweCursist.Margin = New System.Windows.Forms.Padding(10)
        Me.NieuweCursist.Name = "NieuweCursist"
        Me.NieuweCursist.Size = New System.Drawing.Size(163, 32)
        Me.NieuweCursist.TabIndex = 1
        Me.NieuweCursist.Text = "Nieuwe cursist"
        Me.NieuweCursist.UseVisualStyleBackColor = True
        '
        'HuidigeCursisten
        '
        Me.HuidigeCursisten.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HuidigeCursisten.Location = New System.Drawing.Point(209, 140)
        Me.HuidigeCursisten.Margin = New System.Windows.Forms.Padding(10)
        Me.HuidigeCursisten.Name = "HuidigeCursisten"
        Me.HuidigeCursisten.Size = New System.Drawing.Size(163, 32)
        Me.HuidigeCursisten.TabIndex = 2
        Me.HuidigeCursisten.Text = "Huidige cursisten"
        Me.HuidigeCursisten.UseVisualStyleBackColor = True
        '
        'CursusData
        '
        Me.CursusData.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CursusData.Location = New System.Drawing.Point(392, 140)
        Me.CursusData.Margin = New System.Windows.Forms.Padding(10)
        Me.CursusData.Name = "CursusData"
        Me.CursusData.Size = New System.Drawing.Size(163, 32)
        Me.CursusData.TabIndex = 3
        Me.CursusData.Text = "Cursus data"
        Me.CursusData.UseVisualStyleBackColor = True
        '
        'Opties
        '
        Me.Opties.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opties.Location = New System.Drawing.Point(575, 192)
        Me.Opties.Margin = New System.Windows.Forms.Padding(10)
        Me.Opties.Name = "Opties"
        Me.Opties.Size = New System.Drawing.Size(163, 32)
        Me.Opties.TabIndex = 4
        Me.Opties.Text = "Opties"
        Me.Opties.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(575, 140)
        Me.Button5.Margin = New System.Windows.Forms.Padding(10)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(163, 32)
        Me.Button5.TabIndex = 5
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Exitbutton
        '
        Me.Exitbutton.Font = New System.Drawing.Font("Arial Narrow", 12.25!)
        Me.Exitbutton.Location = New System.Drawing.Point(575, 582)
        Me.Exitbutton.Name = "Exitbutton"
        Me.Exitbutton.Size = New System.Drawing.Size(138, 35)
        Me.Exitbutton.TabIndex = 76
        Me.Exitbutton.Text = "Afsluiten"
        Me.Exitbutton.UseVisualStyleBackColor = True
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 629)
        Me.Controls.Add(Me.Exitbutton)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Opties)
        Me.Controls.Add(Me.CursusData)
        Me.Controls.Add(Me.HuidigeCursisten)
        Me.Controls.Add(Me.NieuweCursist)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Launcher"
        Me.Text = "DAT Training"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NieuweCursist As System.Windows.Forms.Button
    Friend WithEvents HuidigeCursisten As System.Windows.Forms.Button
    Friend WithEvents CursusData As System.Windows.Forms.Button
    Friend WithEvents Opties As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Exitbutton As System.Windows.Forms.Button
End Class
