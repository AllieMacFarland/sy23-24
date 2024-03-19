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
        Me.timerRight = New System.Windows.Forms.Timer(Me.components)
        Me.timerLeft = New System.Windows.Forms.Timer(Me.components)
        Me.timerUp = New System.Windows.Forms.Timer(Me.components)
        Me.timerGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.timerGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.mousePictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.MousePB = New System.Windows.Forms.PictureBox()
        Me.MousePicbox = New System.Windows.Forms.PictureBox()
        Me.Picturebox4 = New System.Windows.Forms.PictureBox()
        Me.BadGuy = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Mover5 = New WindowsApp1.Mover()
        Me.Mover1 = New WindowsApp1.Mover()
        Me.Mover2 = New WindowsApp1.Mover()
        Me.Mover3 = New WindowsApp1.Mover()
        Me.Mover4 = New WindowsApp1.Mover()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mousePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MousePB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MousePicbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picturebox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BadGuy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerRight
        '
        '
        'timerLeft
        '
        '
        'timerUp
        '
        '
        'timerGameLogic
        '
        '
        'timerGravity
        '
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox5.Location = New System.Drawing.Point(-3, 27)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(46, 12)
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox3.Location = New System.Drawing.Point(449, 157)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(175, 12)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'mousePictureBox
        '
        Me.mousePictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.mousePictureBox.Location = New System.Drawing.Point(87, 207)
        Me.mousePictureBox.Name = "mousePictureBox"
        Me.mousePictureBox.Size = New System.Drawing.Size(31, 27)
        Me.mousePictureBox.TabIndex = 5
        Me.mousePictureBox.TabStop = False
        Me.mousePictureBox.Tag = "coin"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Location = New System.Drawing.Point(367, 301)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(175, 12)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(97, 215)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 12)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'picPlayer
        '
        Me.picPlayer.Image = Global.WindowsApp1.My.Resources.Resources.lambo
        Me.picPlayer.Location = New System.Drawing.Point(534, 364)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(69, 42)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer.TabIndex = 1
        Me.picPlayer.TabStop = False
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picGround.Location = New System.Drawing.Point(-3, 402)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(807, 50)
        Me.picGround.TabIndex = 0
        Me.picGround.TabStop = False
        '
        'MousePB
        '
        Me.MousePB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MousePB.Location = New System.Drawing.Point(-3, 29)
        Me.MousePB.Name = "MousePB"
        Me.MousePB.Size = New System.Drawing.Size(31, 27)
        Me.MousePB.TabIndex = 11
        Me.MousePB.TabStop = False
        Me.MousePB.Tag = "coin"
        '
        'MousePicbox
        '
        Me.MousePicbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MousePicbox.Location = New System.Drawing.Point(439, 149)
        Me.MousePicbox.Name = "MousePicbox"
        Me.MousePicbox.Size = New System.Drawing.Size(31, 27)
        Me.MousePicbox.TabIndex = 14
        Me.MousePicbox.TabStop = False
        Me.MousePicbox.Tag = "oin"
        '
        'Picturebox4
        '
        Me.Picturebox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Picturebox4.Location = New System.Drawing.Point(357, 294)
        Me.Picturebox4.Name = "Picturebox4"
        Me.Picturebox4.Size = New System.Drawing.Size(31, 27)
        Me.Picturebox4.TabIndex = 15
        Me.Picturebox4.TabStop = False
        Me.Picturebox4.Tag = "coin"
        '
        'BadGuy
        '
        Me.BadGuy.BackColor = System.Drawing.Color.Maroon
        Me.BadGuy.Location = New System.Drawing.Point(196, 69)
        Me.BadGuy.Name = "BadGuy"
        Me.BadGuy.Size = New System.Drawing.Size(57, 52)
        Me.BadGuy.TabIndex = 19
        Me.BadGuy.TabStop = False
        Me.BadGuy.Tag = "Lose"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox7.Location = New System.Drawing.Point(206, 68)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(175, 16)
        Me.PictureBox7.TabIndex = 17
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "bound"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Location = New System.Drawing.Point(740, 5)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(14, 16)
        Me.ScoreLabel.TabIndex = 20
        Me.ScoreLabel.Text = "0"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-3, 430)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 21
        '
        'Mover5
        '
        Me.Mover5.BackColor = System.Drawing.Color.Transparent
        Me.Mover5.interval = 500
        Me.Mover5.Location = New System.Drawing.Point(206, 59)
        Me.Mover5.Name = "Mover5"
        Me.Mover5.Size = New System.Drawing.Size(175, 12)
        Me.Mover5.speed = 10
        Me.Mover5.sprite = Me.BadGuy
        Me.Mover5.TabIndex = 18
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(97, 197)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(175, 12)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.mousePictureBox
        Me.Mover1.TabIndex = 9
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.interval = 500
        Me.Mover2.Location = New System.Drawing.Point(-3, 9)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(46, 12)
        Me.Mover2.speed = 10
        Me.Mover2.sprite = Me.MousePB
        Me.Mover2.TabIndex = 12
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Transparent
        Me.Mover3.interval = 500
        Me.Mover3.Location = New System.Drawing.Point(449, 139)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(175, 12)
        Me.Mover3.speed = 10
        Me.Mover3.sprite = Me.MousePicbox
        Me.Mover3.TabIndex = 13
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Transparent
        Me.Mover4.interval = 500
        Me.Mover4.Location = New System.Drawing.Point(367, 284)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(175, 11)
        Me.Mover4.speed = 10
        Me.Mover4.sprite = Me.Picturebox4
        Me.Mover4.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.BadGuy)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Mover5)
        Me.Controls.Add(Me.Picturebox4)
        Me.Controls.Add(Me.MousePicbox)
        Me.Controls.Add(Me.MousePB)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.mousePictureBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mousePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MousePB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MousePicbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picturebox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BadGuy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timerRight As Timer
    Friend WithEvents timerLeft As Timer
    Friend WithEvents timerUp As Timer
    Friend WithEvents timerGameLogic As Timer
    Friend WithEvents timerGravity As Timer
    Friend WithEvents picGround As PictureBox
    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents mousePictureBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Mover1 As Mover
    Friend WithEvents MousePB As PictureBox
    Friend WithEvents Mover2 As Mover
    Friend WithEvents Mover3 As Mover
    Friend WithEvents MousePicbox As PictureBox
    Friend WithEvents Picturebox4 As PictureBox
    Friend WithEvents Mover4 As Mover
    Friend WithEvents BadGuy As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Mover5 As Mover
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents TextBox1 As TextBox
End Class
