<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CouponView
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
        Me.PanelCatchPhrase = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelNbCoupons = New System.Windows.Forms.Label()
        Me.LabelMult = New System.Windows.Forms.Label()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelCoupon.SuspendLayout()
        Me.PanelCatchPhrase.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelCoupon
        '
        Me.LabelCoupon.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelCoupon.Location = New System.Drawing.Point(0, 0)
        Me.LabelCoupon.Name = "LabelCoupon"
        Me.LabelCoupon.Size = New System.Drawing.Size(114, 26)
        Me.LabelCoupon.TabIndex = 0
        Me.LabelCoupon.Text = "Label1"
        '
        'LabelBlink
        '
        Me.LabelBlink.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelBlink.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBlink.Location = New System.Drawing.Point(0, 0)
        Me.LabelBlink.Name = "LabelBlink"
        Me.LabelBlink.Size = New System.Drawing.Size(114, 41)
        Me.LabelBlink.TabIndex = 1
        Me.LabelBlink.Text = "Label2"
        '
        'PanelCoupon
        '
        Me.PanelCoupon.BackColor = System.Drawing.Color.White
        Me.PanelCoupon.Controls.Add(Me.LabelCoupon)
        Me.PanelCoupon.Location = New System.Drawing.Point(3, 3)
        Me.PanelCoupon.Name = "PanelCoupon"
        Me.PanelCoupon.Size = New System.Drawing.Size(114, 26)
        Me.PanelCoupon.TabIndex = 2
        '
        'Timer1
        '
        '
        'PanelCatchPhrase
        '
        Me.PanelCatchPhrase.Controls.Add(Me.LabelBlink)
        Me.PanelCatchPhrase.Location = New System.Drawing.Point(3, 32)
        Me.PanelCatchPhrase.Name = "PanelCatchPhrase"
        Me.PanelCatchPhrase.Size = New System.Drawing.Size(114, 54)
        Me.PanelCatchPhrase.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LabelMult)
        Me.Panel2.Controls.Add(Me.LabelNbCoupons)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(118, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(35, 83)
        Me.Panel2.TabIndex = 2
        '
        'LabelNbCoupons
        '
        Me.LabelNbCoupons.AutoSize = True
        Me.LabelNbCoupons.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNbCoupons.Location = New System.Drawing.Point(19, 29)
        Me.LabelNbCoupons.Name = "LabelNbCoupons"
        Me.LabelNbCoupons.Size = New System.Drawing.Size(16, 17)
        Me.LabelNbCoupons.TabIndex = 0
        Me.LabelNbCoupons.Text = "0"
        '
        'LabelMult
        '
        Me.LabelMult.AutoSize = True
        Me.LabelMult.Location = New System.Drawing.Point(3, 31)
        Me.LabelMult.Name = "LabelMult"
        Me.LabelMult.Size = New System.Drawing.Size(14, 13)
        Me.LabelMult.TabIndex = 1
        Me.LabelMult.Text = "X"
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(-3, 0)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(123, 17)
        Me.LabelTitre.TabIndex = 3
        Me.LabelTitre.Text = "Bons de réduction"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PanelCoupon)
        Me.Panel1.Controls.Add(Me.PanelCatchPhrase)
        Me.Panel1.Location = New System.Drawing.Point(0, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(155, 85)
        Me.Panel1.TabIndex = 4
        '
        'CouponView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "CouponView"
        Me.Size = New System.Drawing.Size(159, 113)
        Me.PanelCoupon.ResumeLayout(False)
        Me.PanelCatchPhrase.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCoupon As System.Windows.Forms.Label
    Friend WithEvents LabelBlink As System.Windows.Forms.Label
    Friend WithEvents PanelCoupon As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PanelCatchPhrase As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelNbCoupons As System.Windows.Forms.Label
    Friend WithEvents LabelMult As System.Windows.Forms.Label
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
