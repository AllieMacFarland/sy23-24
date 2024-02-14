<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.IDTB = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Dimes = New System.Windows.Forms.PictureBox()
        Me.Dollars = New System.Windows.Forms.PictureBox()
        Me.Nickles = New System.Windows.Forms.PictureBox()
        Me.Quarter = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProductControl4 = New Vending_machine.ProductControl()
        Me.ProductControl3 = New Vending_machine.ProductControl()
        Me.ProductControl2 = New Vending_machine.ProductControl()
        Me.ProductControl1 = New Vending_machine.ProductControl()
        Me.ProductPB = New System.Windows.Forms.PictureBox()
        CType(Me.Dimes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dollars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nickles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quarter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDTB
        '
        Me.IDTB.Location = New System.Drawing.Point(757, 69)
        Me.IDTB.Multiline = True
        Me.IDTB.Name = "IDTB"
        Me.IDTB.Size = New System.Drawing.Size(48, 32)
        Me.IDTB.TabIndex = 31
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(714, 303)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 48)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "Buy"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Dimes
        '
        Me.Dimes.Image = Global.Vending_machine.My.Resources.Resources.dime
        Me.Dimes.Location = New System.Drawing.Point(687, 389)
        Me.Dimes.Name = "Dimes"
        Me.Dimes.Size = New System.Drawing.Size(118, 91)
        Me.Dimes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Dimes.TabIndex = 25
        Me.Dimes.TabStop = False
        Me.Dimes.Visible = False
        '
        'Dollars
        '
        Me.Dollars.Image = Global.Vending_machine.My.Resources.Resources.Dollar
        Me.Dollars.Location = New System.Drawing.Point(811, 389)
        Me.Dollars.Name = "Dollars"
        Me.Dollars.Size = New System.Drawing.Size(126, 91)
        Me.Dollars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Dollars.TabIndex = 24
        Me.Dollars.TabStop = False
        Me.Dollars.Visible = False
        '
        'Nickles
        '
        Me.Nickles.Image = Global.Vending_machine.My.Resources.Resources.nickles
        Me.Nickles.Location = New System.Drawing.Point(563, 389)
        Me.Nickles.Name = "Nickles"
        Me.Nickles.Size = New System.Drawing.Size(118, 91)
        Me.Nickles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Nickles.TabIndex = 23
        Me.Nickles.TabStop = False
        Me.Nickles.Visible = False
        '
        'Quarter
        '
        Me.Quarter.Image = Global.Vending_machine.My.Resources.Resources.Quart
        Me.Quarter.Location = New System.Drawing.Point(421, 389)
        Me.Quarter.Name = "Quarter"
        Me.Quarter.Size = New System.Drawing.Size(136, 91)
        Me.Quarter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Quarter.TabIndex = 22
        Me.Quarter.TabStop = False
        Me.Quarter.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(792, 303)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 48)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Coin Return"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(768, 104)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(48, 16)
        Me.TotalLabel.TabIndex = 20
        Me.TotalLabel.Text = "Label1"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Vending_machine.My.Resources.Resources.Dollar
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(860, 228)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 69)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Dollar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Vending_machine.My.Resources.Resources.dime
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(860, 153)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 69)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Dimes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Vending_machine.My.Resources.Resources.nickles
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(860, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 69)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Nickles"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Vending_machine.My.Resources.Resources.Quart
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(860, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 69)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Quarter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProductControl4
        '
        Me.ProductControl4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl4.Location = New System.Drawing.Point(12, 12)
        Me.ProductControl4.Name = "ProductControl4"
        Me.ProductControl4.Picture = Global.Vending_machine.My.Resources.Resources.Lays
        Me.ProductControl4.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl4.ProductCount = 5
        Me.ProductControl4.ProductID = "A1"
        Me.ProductControl4.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl4.TabIndex = 29
        '
        'ProductControl3
        '
        Me.ProductControl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl3.Location = New System.Drawing.Point(181, 12)
        Me.ProductControl3.Name = "ProductControl3"
        Me.ProductControl3.Picture = Global.Vending_machine.My.Resources.Resources.Barb
        Me.ProductControl3.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl3.ProductCount = 0
        Me.ProductControl3.ProductID = "A2"
        Me.ProductControl3.Size = New System.Drawing.Size(155, 150)
        Me.ProductControl3.TabIndex = 28
        '
        'ProductControl2
        '
        Me.ProductControl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl2.Location = New System.Drawing.Point(498, 12)
        Me.ProductControl2.Name = "ProductControl2"
        Me.ProductControl2.Picture = Global.Vending_machine.My.Resources.Resources.sour
        Me.ProductControl2.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl2.ProductCount = 0
        Me.ProductControl2.ProductID = Nothing
        Me.ProductControl2.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl2.TabIndex = 27
        '
        'ProductControl1
        '
        Me.ProductControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductControl1.Location = New System.Drawing.Point(342, 12)
        Me.ProductControl1.Name = "ProductControl1"
        Me.ProductControl1.Picture = Global.Vending_machine.My.Resources.Resources.Doritos
        Me.ProductControl1.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl1.ProductCount = 5
        Me.ProductControl1.ProductID = "A3"
        Me.ProductControl1.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl1.TabIndex = 26
        '
        'ProductPB
        '
        Me.ProductPB.Location = New System.Drawing.Point(115, 256)
        Me.ProductPB.Name = "ProductPB"
        Me.ProductPB.Size = New System.Drawing.Size(100, 50)
        Me.ProductPB.TabIndex = 32
        Me.ProductPB.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 493)
        Me.Controls.Add(Me.ProductPB)
        Me.Controls.Add(Me.IDTB)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ProductControl4)
        Me.Controls.Add(Me.ProductControl3)
        Me.Controls.Add(Me.ProductControl2)
        Me.Controls.Add(Me.ProductControl1)
        Me.Controls.Add(Me.Dimes)
        Me.Controls.Add(Me.Dollars)
        Me.Controls.Add(Me.Nickles)
        Me.Controls.Add(Me.Quarter)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Dimes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dollars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nickles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quarter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDTB As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents ProductControl4 As ProductControl
    Friend WithEvents ProductControl3 As ProductControl
    Friend WithEvents ProductControl2 As ProductControl
    Friend WithEvents ProductControl1 As ProductControl
    Friend WithEvents Dimes As PictureBox
    Friend WithEvents Dollars As PictureBox
    Friend WithEvents Nickles As PictureBox
    Friend WithEvents Quarter As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ProductPB As PictureBox
End Class
