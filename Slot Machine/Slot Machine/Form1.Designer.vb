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
        Me.Spin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Prize = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WheelControl3 = New Slot_Machine.WheelControl()
        Me.WheelControl2 = New Slot_Machine.WheelControl()
        Me.WheelControl1 = New Slot_Machine.WheelControl()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Spin
        '
        Me.Spin.Location = New System.Drawing.Point(612, 93)
        Me.Spin.Name = "Spin"
        Me.Spin.Size = New System.Drawing.Size(75, 70)
        Me.Spin.TabIndex = 3
        Me.Spin.Text = "Button1"
        Me.Spin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(612, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 70)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(841, 70)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 69)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Dollar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(841, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 69)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Dimes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Location = New System.Drawing.Point(841, 295)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 69)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Nickles"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(841, 145)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(77, 69)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Quarter"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(854, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Label4"
        '
        'Timer1
        '
        '
        'Prize
        '
        Me.Prize.AutoSize = True
        Me.Prize.Location = New System.Drawing.Point(214, 272)
        Me.Prize.Name = "Prize"
        Me.Prize.Size = New System.Drawing.Size(48, 16)
        Me.Prize.TabIndex = 25
        Me.Prize.Text = "Label5"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(203, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 69)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Collect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WheelControl3
        '
        Me.WheelControl3.ItemValue = 0
        Me.WheelControl3.Location = New System.Drawing.Point(364, 16)
        Me.WheelControl3.Name = "WheelControl3"
        Me.WheelControl3.Size = New System.Drawing.Size(170, 151)
        Me.WheelControl3.SpinTime = 2000
        Me.WheelControl3.TabIndex = 6
        '
        'WheelControl2
        '
        Me.WheelControl2.ItemValue = 0
        Me.WheelControl2.Location = New System.Drawing.Point(188, 16)
        Me.WheelControl2.Name = "WheelControl2"
        Me.WheelControl2.Size = New System.Drawing.Size(170, 151)
        Me.WheelControl2.SpinTime = 2000
        Me.WheelControl2.TabIndex = 5
        '
        'WheelControl1
        '
        Me.WheelControl1.ItemValue = 0
        Me.WheelControl1.Location = New System.Drawing.Point(12, 12)
        Me.WheelControl1.Name = "WheelControl1"
        Me.WheelControl1.Size = New System.Drawing.Size(170, 151)
        Me.WheelControl1.SpinTime = 2000
        Me.WheelControl1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(377, 207)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 65)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 596)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Prize)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WheelControl3)
        Me.Controls.Add(Me.WheelControl2)
        Me.Controls.Add(Me.WheelControl1)
        Me.Controls.Add(Me.Spin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Spin As Button
    Friend WithEvents WheelControl1 As WheelControl
    Friend WithEvents WheelControl2 As WheelControl
    Friend WithEvents WheelControl3 As WheelControl
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Prize As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
