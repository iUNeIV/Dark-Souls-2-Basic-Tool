<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CCAPI_Box
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CCAPI_Box))
        Me.InfluenceTheme1 = New Dark_Souls_2_Basic_Tool.InfluenceTheme()
        Me.SimplaTheme1 = New Dark_Souls_2_Basic_Tool.SimplaTheme()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SimplaButton1 = New Dark_Souls_2_Basic_Tool.SimplaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InfluenceTheme1.SuspendLayout()
        Me.SimplaTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InfluenceTheme1
        '
        Me.InfluenceTheme1.CloseButtonExitsApp = False
        Me.InfluenceTheme1.Controls.Add(Me.SimplaTheme1)
        Me.InfluenceTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfluenceTheme1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.InfluenceTheme1.Location = New System.Drawing.Point(0, 0)
        Me.InfluenceTheme1.MinimizeButton = False
        Me.InfluenceTheme1.Name = "InfluenceTheme1"
        Me.InfluenceTheme1.Size = New System.Drawing.Size(299, 321)
        Me.InfluenceTheme1.TabIndex = 0
        Me.InfluenceTheme1.Text = "Select a console..."
        '
        'SimplaTheme1
        '
        Me.SimplaTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.SimplaTheme1.Controls.Add(Me.ListBox2)
        Me.SimplaTheme1.Controls.Add(Me.Label2)
        Me.SimplaTheme1.Controls.Add(Me.SimplaButton1)
        Me.SimplaTheme1.Controls.Add(Me.Label1)
        Me.SimplaTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SimplaTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SimplaTheme1.Name = "SimplaTheme1"
        Me.SimplaTheme1.Size = New System.Drawing.Size(299, 321)
        Me.SimplaTheme1.TabIndex = 1
        Me.SimplaTheme1.Text = "CCAPI"
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox2.ForeColor = System.Drawing.Color.White
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(12, 48)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(275, 210)
        Me.ListBox2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Select a console wihin this grid."
        '
        'SimplaButton1
        '
        Me.SimplaButton1.BackColor = System.Drawing.Color.Transparent
        Me.SimplaButton1.ColorScheme = Dark_Souls_2_Basic_Tool.SimplaButton.ColorSchemes.DarkGray
        Me.SimplaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.SimplaButton1.Location = New System.Drawing.Point(12, 285)
        Me.SimplaButton1.Name = "SimplaButton1"
        Me.SimplaButton1.Size = New System.Drawing.Size(275, 24)
        Me.SimplaButton1.TabIndex = 5
        Me.SimplaButton1.Text = "Connection"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(274, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X"
        '
        'CCAPI_Box
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 321)
        Me.Controls.Add(Me.InfluenceTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CCAPI_Box"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select a console..."
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.InfluenceTheme1.ResumeLayout(False)
        Me.SimplaTheme1.ResumeLayout(False)
        Me.SimplaTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InfluenceTheme1 As Dark_Souls_2_Basic_Tool.InfluenceTheme
    Friend WithEvents SimplaTheme1 As Dark_Souls_2_Basic_Tool.SimplaTheme
    Friend WithEvents SimplaButton1 As Dark_Souls_2_Basic_Tool.SimplaButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Private WithEvents Label1 As System.Windows.Forms.Label
End Class
