<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartElem
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pizzaQteLabel = New System.Windows.Forms.Label()
        Me.pizzaPriceLabel = New System.Windows.Forms.Label()
        Me.pizzaNameLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.pizzaQteLabel)
        Me.Panel2.Controls.Add(Me.pizzaPriceLabel)
        Me.Panel2.Controls.Add(Me.pizzaNameLabel)
        Me.Panel2.Location = New System.Drawing.Point(3, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(144, 35)
        Me.Panel2.TabIndex = 2
        '
        'pizzaQteLabel
        '
        Me.pizzaQteLabel.AutoSize = True
        Me.pizzaQteLabel.Location = New System.Drawing.Point(60, 9)
        Me.pizzaQteLabel.Name = "pizzaQteLabel"
        Me.pizzaQteLabel.Size = New System.Drawing.Size(24, 13)
        Me.pizzaQteLabel.TabIndex = 2
        Me.pizzaQteLabel.Text = "Qte"
        '
        'pizzaPriceLabel
        '
        Me.pizzaPriceLabel.AutoSize = True
        Me.pizzaPriceLabel.Location = New System.Drawing.Point(105, 9)
        Me.pizzaPriceLabel.Name = "pizzaPriceLabel"
        Me.pizzaPriceLabel.Size = New System.Drawing.Size(24, 13)
        Me.pizzaPriceLabel.TabIndex = 1
        Me.pizzaPriceLabel.Text = "Prix"
        '
        'pizzaNameLabel
        '
        Me.pizzaNameLabel.AutoSize = True
        Me.pizzaNameLabel.Location = New System.Drawing.Point(3, 9)
        Me.pizzaNameLabel.Name = "pizzaNameLabel"
        Me.pizzaNameLabel.Size = New System.Drawing.Size(32, 13)
        Me.pizzaNameLabel.TabIndex = 0
        Me.pizzaNameLabel.Text = "Pizza"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.deleteBtn)
        Me.Panel1.Location = New System.Drawing.Point(3, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 31)
        Me.Panel1.TabIndex = 3
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(3, 3)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.deleteBtn.TabIndex = 0
        Me.deleteBtn.Text = "Supprimer"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'CartElem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "CartElem"
        Me.Size = New System.Drawing.Size(150, 82)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pizzaNameLabel As System.Windows.Forms.Label
    Friend WithEvents pizzaQteLabel As System.Windows.Forms.Label
    Friend WithEvents pizzaPriceLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents deleteBtn As System.Windows.Forms.Button

End Class
