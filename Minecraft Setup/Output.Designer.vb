<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Output
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
        Me.TxtBoxTeams = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxPlayers = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxHealth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBoxColor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtBoxTeams
        '
        Me.TxtBoxTeams.Location = New System.Drawing.Point(12, 277)
        Me.TxtBoxTeams.Multiline = True
        Me.TxtBoxTeams.Name = "TxtBoxTeams"
        Me.TxtBoxTeams.Size = New System.Drawing.Size(190, 141)
        Me.TxtBoxTeams.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Teams"
        '
        'TxtBoxPlayers
        '
        Me.TxtBoxPlayers.Location = New System.Drawing.Point(208, 277)
        Me.TxtBoxPlayers.Multiline = True
        Me.TxtBoxPlayers.Name = "TxtBoxPlayers"
        Me.TxtBoxPlayers.Size = New System.Drawing.Size(152, 141)
        Me.TxtBoxPlayers.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Players"
        '
        'TxtBoxHealth
        '
        Me.TxtBoxHealth.Location = New System.Drawing.Point(12, 153)
        Me.TxtBoxHealth.Multiline = True
        Me.TxtBoxHealth.Name = "TxtBoxHealth"
        Me.TxtBoxHealth.Size = New System.Drawing.Size(116, 105)
        Me.TxtBoxHealth.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Health"
        '
        'TxtBoxColor
        '
        Me.TxtBoxColor.Location = New System.Drawing.Point(134, 153)
        Me.TxtBoxColor.Multiline = True
        Me.TxtBoxColor.Name = "TxtBoxColor"
        Me.TxtBoxColor.Size = New System.Drawing.Size(163, 105)
        Me.TxtBoxColor.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Colors"
        '
        'Output
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 430)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtBoxColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtBoxHealth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBoxPlayers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxTeams)
        Me.Name = "Output"
        Me.Text = "Output"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBoxTeams As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtBoxPlayers As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtBoxHealth As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtBoxColor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
