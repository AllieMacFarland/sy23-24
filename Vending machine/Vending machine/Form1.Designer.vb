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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Dimes = New System.Windows.Forms.PictureBox()
        Me.Dollars = New System.Windows.Forms.PictureBox()
        Me.Nickles = New System.Windows.Forms.PictureBox()
        Me.Quarter = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProductControl1 = New Vending_machine.ProductControl()
        CType(Me.Dimes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dollars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nickles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quarter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(362, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 48)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Coin Return"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Dimes
        '
        Me.Dimes.Image = Global.Vending_machine.My.Resources.Resources.dime
        Me.Dimes.Location = New System.Drawing.Point(468, 347)
        Me.Dimes.Name = "Dimes"
        Me.Dimes.Size = New System.Drawing.Size(118, 91)
        Me.Dimes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Dimes.TabIndex = 9
        Me.Dimes.TabStop = False
        Me.Dimes.Visible = False
        '
        'Dollars
        '
        Me.Dollars.Image = Global.Vending_machine.My.Resources.Resources.Dollar
        Me.Dollars.Location = New System.Drawing.Point(592, 347)
        Me.Dollars.Name = "Dollars"
        Me.Dollars.Size = New System.Drawing.Size(126, 91)
        Me.Dollars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Dollars.TabIndex = 8
        Me.Dollars.TabStop = False
        Me.Dollars.Visible = False
        '
        'Nickles
        '
        Me.Nickles.Image = Global.Vending_machine.My.Resources.Resources.nickles
        Me.Nickles.Location = New System.Drawing.Point(344, 347)
        Me.Nickles.Name = "Nickles"
        Me.Nickles.Size = New System.Drawing.Size(118, 91)
        Me.Nickles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Nickles.TabIndex = 7
        Me.Nickles.TabStop = False
        Me.Nickles.Visible = False
        '
        'Quarter
        '
        Me.Quarter.Image = Global.Vending_machine.My.Resources.Resources.Quart
        Me.Quarter.Location = New System.Drawing.Point(202, 347)
        Me.Quarter.Name = "Quarter"
        Me.Quarter.Size = New System.Drawing.Size(136, 91)
        Me.Quarter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Quarter.TabIndex = 6
        Me.Quarter.TabStop = False
        Me.Quarter.Visible = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Vending_machine.My.Resources.Resources.Dollar
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(261, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 69)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Dollar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Vending_machine.My.Resources.Resources.dime
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(178, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 69)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Dimes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Vending_machine.My.Resources.Resources.nickles
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(95, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 69)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Nickles"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Vending_machine.My.Resources.Resources.Quart
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 69)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Quarter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProductControl1
        '
        Me.ProductControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl1.Count = 0
        Me.ProductControl1.Location = New System.Drawing.Point(523, 113)
        Me.ProductControl1.Name = "ProductControl1"
        Me.ProductControl1.Picture = Global.Vending_machine.My.Resources.Resources.Doritos
        Me.ProductControl1.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl1.ProductID = Nothing
        Me.ProductControl1.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 450)
        Me.Controls.Add(Me.ProductControl1)
        Me.Controls.Add(Me.Dimes)
        Me.Controls.Add(Me.Dollars)
        Me.Controls.Add(Me.Nickles)
        Me.Controls.Add(Me.Quarter)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.Dimes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dollars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nickles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quarter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Quarter As PictureBox
    Friend WithEvents Nickles As PictureBox
    Friend WithEvents Dollars As PictureBox
    Friend WithEvents Dimes As PictureBox
    Friend WithEvents ProductControl1 As ProductControl
End Class
