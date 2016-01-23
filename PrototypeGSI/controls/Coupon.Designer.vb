<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Coupon
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelCoupon = New System.Windows.Forms.Label()
        Me.LabelBlink = New System.Windows.Forms.Label()
        Me.PanelCoupon = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelCoupon.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelCoupon
        '
        Me.LabelCoupon.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelCoupon.Location = New System.Drawing.Point(0, 0)
        Me.LabelCoupon.Name = "LabelCoupon"
        Me.LabelCoupon.Size = New System.Drawing.Size(147, 36)
        Me.LabelCoupon.TabIndex = 0
        Me.LabelCoupon.Text = "Label1"
        '
        'LabelBlink
        '
        Me.LabelBlink.Location = New System.Drawing.Point(0, 36)
        Me.LabelBlink.Name = "LabelBlink"
        Me.LabelBlink.Size = New System.Drawing.Size(144, 29)
        Me.LabelBlink.TabIndex = 1
        Me.LabelBlink.Text = "Label2"
        '
        'PanelCoupon
        '
        Me.PanelCoupon.BackColor = System.Drawing.Color.White
        Me.PanelCoupon.Controls.Add(Me.LabelCoupon)
        Me.PanelCoupon.Controls.Add(Me.LabelBlink)
        Me.PanelCoupon.Location = New System.Drawing.Point(3, 3)
        Me.PanelCoupon.Name = "PanelCoupon"
        Me.PanelCoupon.Size = New System.Drawing.Size(147, 66)
        Me.PanelCoupon.TabIndex = 2
        '
        'Timer1
        '
        '
        'Coupon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelCoupon)
        Me.Name = "Coupon"
        Me.Size = New System.Drawing.Size(150, 77)
        Me.PanelCoupon.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelCoupon As System.Windows.Forms.Label
    Friend WithEvents LabelBlink As System.Windows.Forms.Label
    Friend WithEvents PanelCoupon As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
