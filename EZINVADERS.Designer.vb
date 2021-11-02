<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EZINVADERS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EZINVADERS))
        Me.Timermain = New System.Windows.Forms.Timer(Me.components)
        Me.shot = New System.Windows.Forms.PictureBox()
        Me.PNGshooter = New System.Windows.Forms.PictureBox()
        CType(Me.shot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PNGshooter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timermain
        '
        Me.Timermain.Enabled = True
        Me.Timermain.Interval = 1
        '
        'shot
        '
        Me.shot.BackColor = System.Drawing.Color.CornflowerBlue
        Me.shot.Location = New System.Drawing.Point(273, 450)
        Me.shot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.shot.Name = "shot"
        Me.shot.Size = New System.Drawing.Size(12, 24)
        Me.shot.TabIndex = 1
        Me.shot.TabStop = False
        '
        'PNGshooter
        '
        Me.PNGshooter.BackColor = System.Drawing.SystemColors.Control
        Me.PNGshooter.Image = Global.EZINVADERS.My.Resources.Resources.rocket__1_
        Me.PNGshooter.InitialImage = CType(resources.GetObject("PNGshooter.InitialImage"), System.Drawing.Image)
        Me.PNGshooter.Location = New System.Drawing.Point(273, 694)
        Me.PNGshooter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PNGshooter.Name = "PNGshooter"
        Me.PNGshooter.Size = New System.Drawing.Size(130, 145)
        Me.PNGshooter.TabIndex = 0
        Me.PNGshooter.TabStop = False
        '
        'EZINVADERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 857)
        Me.Controls.Add(Me.shot)
        Me.Controls.Add(Me.PNGshooter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "EZINVADERS"
        Me.Text = "EZ INVADERS"
        CType(Me.shot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PNGshooter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNGshooter As PictureBox
    Friend WithEvents Timermain As Timer
    Friend WithEvents shot As PictureBox
End Class
