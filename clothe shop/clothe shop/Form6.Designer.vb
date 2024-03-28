<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Me.ItemInfo1 = New clothe_shop.ItemInfo()
        Me.SuspendLayout()
        '
        'ItemInfo1
        '
        Me.ItemInfo1.Location = New System.Drawing.Point(283, 41)
        Me.ItemInfo1.Name = "ItemInfo1"
        Me.ItemInfo1.picture = Nothing
        Me.ItemInfo1.Size = New System.Drawing.Size(532, 428)
        Me.ItemInfo1.TabIndex = 0
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1375, 578)
        Me.Controls.Add(Me.ItemInfo1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ItemInfo1 As ItemInfo
End Class
