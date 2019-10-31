<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lbscore = New System.Windows.Forms.Label()
        Me.lbscorecount = New System.Windows.Forms.Label()
        Me.lbpause = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.shooterenemy4 = New System.Windows.Forms.PictureBox()
        Me.shotenemy4 = New System.Windows.Forms.PictureBox()
        Me.shooterenemy3 = New System.Windows.Forms.PictureBox()
        Me.shotenemy3 = New System.Windows.Forms.PictureBox()
        Me.shooterenemy2 = New System.Windows.Forms.PictureBox()
        Me.shotenemy2 = New System.Windows.Forms.PictureBox()
        Me.shooterenemy1 = New System.Windows.Forms.PictureBox()
        Me.shotenemy1 = New System.Windows.Forms.PictureBox()
        Me.shooterenemy = New System.Windows.Forms.PictureBox()
        Me.shotenemy = New System.Windows.Forms.PictureBox()
        Me.shot = New System.Windows.Forms.PictureBox()
        Me.shooter = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.shooterenemy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shotenemy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shooterenemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shotenemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shooterenemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shotenemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shooterenemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shotenemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shooterenemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shotenemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shooter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        Me.Timer2.Interval = 30
        '
        'lbscore
        '
        Me.lbscore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbscore.AutoSize = True
        Me.lbscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbscore.ForeColor = System.Drawing.Color.White
        Me.lbscore.Location = New System.Drawing.Point(7, 415)
        Me.lbscore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbscore.Name = "lbscore"
        Me.lbscore.Size = New System.Drawing.Size(53, 17)
        Me.lbscore.TabIndex = 13
        Me.lbscore.Text = "Score :"
        '
        'lbscorecount
        '
        Me.lbscorecount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbscorecount.AutoSize = True
        Me.lbscorecount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbscorecount.ForeColor = System.Drawing.Color.White
        Me.lbscorecount.Location = New System.Drawing.Point(59, 415)
        Me.lbscorecount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbscorecount.Name = "lbscorecount"
        Me.lbscorecount.Size = New System.Drawing.Size(16, 17)
        Me.lbscorecount.TabIndex = 14
        Me.lbscorecount.Text = "0"
        '
        'lbpause
        '
        Me.lbpause.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbpause.AutoSize = True
        Me.lbpause.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpause.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbpause.Location = New System.Drawing.Point(250, 126)
        Me.lbpause.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbpause.Name = "lbpause"
        Me.lbpause.Size = New System.Drawing.Size(277, 26)
        Me.lbpause.TabIndex = 15
        Me.lbpause.Text = "PERMAINAN MENEMBAK"
        Me.lbpause.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(75, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(602, 40)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Gerakkan Cowboy dengan panah kiri untuk ke kiri dan panah kanan untuk ke kanan." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
            "Gunakan spacebar untuk menembak musuh." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Visible = False
        '
        'shooterenemy4
        '
        Me.shooterenemy4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.shooterenemy4.BackColor = System.Drawing.Color.Red
        Me.shooterenemy4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shooterenemy4.Location = New System.Drawing.Point(351, -6)
        Me.shooterenemy4.Margin = New System.Windows.Forms.Padding(2)
        Me.shooterenemy4.Name = "shooterenemy4"
        Me.shooterenemy4.Size = New System.Drawing.Size(35, 8)
        Me.shooterenemy4.TabIndex = 12
        Me.shooterenemy4.TabStop = False
        '
        'shotenemy4
        '
        Me.shotenemy4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.shotenemy4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.shotenemy4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.shotenemy4.Location = New System.Drawing.Point(364, 2)
        Me.shotenemy4.Margin = New System.Windows.Forms.Padding(2)
        Me.shotenemy4.Name = "shotenemy4"
        Me.shotenemy4.Size = New System.Drawing.Size(8, 17)
        Me.shotenemy4.TabIndex = 11
        Me.shotenemy4.TabStop = False
        '
        'shooterenemy3
        '
        Me.shooterenemy3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shooterenemy3.BackColor = System.Drawing.Color.Red
        Me.shooterenemy3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shooterenemy3.Location = New System.Drawing.Point(682, -6)
        Me.shooterenemy3.Margin = New System.Windows.Forms.Padding(2)
        Me.shooterenemy3.Name = "shooterenemy3"
        Me.shooterenemy3.Size = New System.Drawing.Size(35, 8)
        Me.shooterenemy3.TabIndex = 9
        Me.shooterenemy3.TabStop = False
        '
        'shotenemy3
        '
        Me.shotenemy3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shotenemy3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.shotenemy3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.shotenemy3.Location = New System.Drawing.Point(698, 2)
        Me.shotenemy3.Margin = New System.Windows.Forms.Padding(2)
        Me.shotenemy3.Name = "shotenemy3"
        Me.shotenemy3.Size = New System.Drawing.Size(8, 17)
        Me.shotenemy3.TabIndex = 8
        Me.shotenemy3.TabStop = False
        '
        'shooterenemy2
        '
        Me.shooterenemy2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shooterenemy2.BackColor = System.Drawing.Color.Red
        Me.shooterenemy2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shooterenemy2.Location = New System.Drawing.Point(517, -6)
        Me.shooterenemy2.Margin = New System.Windows.Forms.Padding(2)
        Me.shooterenemy2.Name = "shooterenemy2"
        Me.shooterenemy2.Size = New System.Drawing.Size(35, 8)
        Me.shooterenemy2.TabIndex = 7
        Me.shooterenemy2.TabStop = False
        '
        'shotenemy2
        '
        Me.shotenemy2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shotenemy2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.shotenemy2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.shotenemy2.Location = New System.Drawing.Point(531, 2)
        Me.shotenemy2.Margin = New System.Windows.Forms.Padding(2)
        Me.shotenemy2.Name = "shotenemy2"
        Me.shotenemy2.Size = New System.Drawing.Size(8, 17)
        Me.shotenemy2.TabIndex = 6
        Me.shotenemy2.TabStop = False
        '
        'shooterenemy1
        '
        Me.shooterenemy1.BackColor = System.Drawing.Color.Red
        Me.shooterenemy1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shooterenemy1.Location = New System.Drawing.Point(185, -6)
        Me.shooterenemy1.Margin = New System.Windows.Forms.Padding(2)
        Me.shooterenemy1.Name = "shooterenemy1"
        Me.shooterenemy1.Size = New System.Drawing.Size(35, 8)
        Me.shooterenemy1.TabIndex = 5
        Me.shooterenemy1.TabStop = False
        '
        'shotenemy1
        '
        Me.shotenemy1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.shotenemy1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.shotenemy1.Location = New System.Drawing.Point(199, 2)
        Me.shotenemy1.Margin = New System.Windows.Forms.Padding(2)
        Me.shotenemy1.Name = "shotenemy1"
        Me.shotenemy1.Size = New System.Drawing.Size(8, 17)
        Me.shotenemy1.TabIndex = 4
        Me.shotenemy1.TabStop = False
        '
        'shooterenemy
        '
        Me.shooterenemy.BackColor = System.Drawing.Color.Red
        Me.shooterenemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shooterenemy.Location = New System.Drawing.Point(20, -6)
        Me.shooterenemy.Margin = New System.Windows.Forms.Padding(2)
        Me.shooterenemy.Name = "shooterenemy"
        Me.shooterenemy.Size = New System.Drawing.Size(35, 8)
        Me.shooterenemy.TabIndex = 3
        Me.shooterenemy.TabStop = False
        '
        'shotenemy
        '
        Me.shotenemy.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.shotenemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.shotenemy.Location = New System.Drawing.Point(33, 2)
        Me.shotenemy.Margin = New System.Windows.Forms.Padding(2)
        Me.shotenemy.Name = "shotenemy"
        Me.shotenemy.Size = New System.Drawing.Size(8, 17)
        Me.shotenemy.TabIndex = 2
        Me.shotenemy.TabStop = False
        '
        'shot
        '
        Me.shot.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.shot.BackColor = System.Drawing.Color.Transparent
        Me.shot.Image = CType(resources.GetObject("shot.Image"), System.Drawing.Image)
        Me.shot.Location = New System.Drawing.Point(357, 356)
        Me.shot.Margin = New System.Windows.Forms.Padding(2)
        Me.shot.Name = "shot"
        Me.shot.Size = New System.Drawing.Size(22, 28)
        Me.shot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shot.TabIndex = 1
        Me.shot.TabStop = False
        '
        'shooter
        '
        Me.shooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.shooter.Image = CType(resources.GetObject("shooter.Image"), System.Drawing.Image)
        Me.shooter.Location = New System.Drawing.Point(350, 386)
        Me.shooter.Margin = New System.Windows.Forms.Padding(2)
        Me.shooter.Name = "shooter"
        Me.shooter.Size = New System.Drawing.Size(38, 27)
        Me.shooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shooter.TabIndex = 0
        Me.shooter.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 396)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nama"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(326, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(736, 435)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbpause)
        Me.Controls.Add(Me.lbscorecount)
        Me.Controls.Add(Me.lbscore)
        Me.Controls.Add(Me.shooterenemy4)
        Me.Controls.Add(Me.shotenemy4)
        Me.Controls.Add(Me.shooterenemy3)
        Me.Controls.Add(Me.shotenemy3)
        Me.Controls.Add(Me.shooterenemy2)
        Me.Controls.Add(Me.shotenemy2)
        Me.Controls.Add(Me.shooterenemy1)
        Me.Controls.Add(Me.shotenemy1)
        Me.Controls.Add(Me.shooterenemy)
        Me.Controls.Add(Me.shotenemy)
        Me.Controls.Add(Me.shot)
        Me.Controls.Add(Me.shooter)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shoot_fish"
        CType(Me.shooterenemy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shotenemy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shooterenemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shotenemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shooterenemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shotenemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shooterenemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shotenemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shooterenemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shotenemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shooter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents shooter As System.Windows.Forms.PictureBox
    Friend WithEvents shot As System.Windows.Forms.PictureBox
    Friend WithEvents TimerMain As System.Windows.Forms.Timer
    Friend WithEvents shotenemy As System.Windows.Forms.PictureBox
    Friend WithEvents shooterenemy As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents shotenemy1 As System.Windows.Forms.PictureBox
    Friend WithEvents shooterenemy1 As System.Windows.Forms.PictureBox
    Friend WithEvents shooterenemy3 As System.Windows.Forms.PictureBox
    Friend WithEvents shotenemy3 As System.Windows.Forms.PictureBox
    Friend WithEvents shooterenemy2 As System.Windows.Forms.PictureBox
    Friend WithEvents shotenemy2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents shooterenemy4 As System.Windows.Forms.PictureBox
    Friend WithEvents shotenemy4 As System.Windows.Forms.PictureBox
    Friend WithEvents lbscore As System.Windows.Forms.Label
    Friend WithEvents lbscorecount As System.Windows.Forms.Label
    Friend WithEvents lbpause As System.Windows.Forms.Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
