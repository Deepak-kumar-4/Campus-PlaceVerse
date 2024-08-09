<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CirProg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CirProg))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Prog = New CircularProgressBar.CircularProgressBar()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
        '
        'Timer2
        '
        Me.Timer2.Interval = 30
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(1, -11)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(944, 587)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'Prog
        '
        Me.Prog.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.Prog.AnimationSpeed = 500
        Me.Prog.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Prog.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prog.ForeColor = System.Drawing.Color.Black
        Me.Prog.InnerColor = System.Drawing.Color.Black
        Me.Prog.InnerMargin = 2
        Me.Prog.InnerWidth = 4
        Me.Prog.Location = New System.Drawing.Point(331, 153)
        Me.Prog.MarqueeAnimationSpeed = 2000
        Me.Prog.Name = "Prog"
        Me.Prog.OuterColor = System.Drawing.Color.White
        Me.Prog.OuterMargin = -25
        Me.Prog.OuterWidth = 26
        Me.Prog.ProgressColor = System.Drawing.Color.Black
        Me.Prog.ProgressWidth = 25
        Me.Prog.SecondaryFont = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prog.Size = New System.Drawing.Size(300, 280)
        Me.Prog.StartAngle = 270
        Me.Prog.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.Prog.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Prog.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.Prog.SubscriptText = ""
        Me.Prog.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Prog.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.Prog.SuperscriptText = ""
        Me.Prog.TabIndex = 4
        Me.Prog.Text = "0%"
        Me.Prog.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.Prog.Value = 66
        '
        'CirProg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 572)
        Me.Controls.Add(Me.Prog)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CirProg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circular Progressbar"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Prog As CircularProgressBar.CircularProgressBar
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
