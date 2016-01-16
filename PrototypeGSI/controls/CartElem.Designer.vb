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
        Me.pizzaPriceLabel = New System.Windows.Forms.Label()
        Me.pizzaNameLabel = New System.Windows.Forms.Label()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.pizzaQte = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pizzaQte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pizzaPriceLabel
        '
        Me.pizzaPriceLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pizzaPriceLabel.AutoSize = True
        Me.pizzaPriceLabel.Location = New System.Drawing.Point(66, 29)
        Me.pizzaPriceLabel.Name = "pizzaPriceLabel"
        Me.pizzaPriceLabel.Size = New System.Drawing.Size(24, 13)
        Me.pizzaPriceLabel.TabIndex = 1
        Me.pizzaPriceLabel.Text = "Prix"
        Me.pizzaPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pizzaNameLabel
        '
        Me.pizzaNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pizzaNameLabel.AutoSize = True
        Me.pizzaNameLabel.Location = New System.Drawing.Point(7, 6)
        Me.pizzaNameLabel.Name = "pizzaNameLabel"
        Me.pizzaNameLabel.Size = New System.Drawing.Size(32, 13)
        Me.pizzaNameLabel.TabIndex = 0
        Me.pizzaNameLabel.Text = "Pizza"
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(19, 3)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.deleteBtn.TabIndex = 0
        Me.deleteBtn.Text = "Supprimer"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'pizzaQte
        '
        Me.pizzaQte.Location = New System.Drawing.Point(3, 27)
        Me.pizzaQte.Name = "pizzaQte"
        Me.pizzaQte.Size = New System.Drawing.Size(48, 20)
        Me.pizzaQte.TabIndex = 3
        Me.pizzaQte.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.deleteBtn)
        Me.Panel1.Location = New System.Drawing.Point(3, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(114, 31)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.pizzaQte)
        Me.Panel2.Controls.Add(Me.pizzaPriceLabel)
        Me.Panel2.Controls.Add(Me.pizzaNameLabel)
        Me.Panel2.Location = New System.Drawing.Point(3, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(114, 55)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "€"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CartElem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "CartElem"
        Me.Size = New System.Drawing.Size(124, 98)
        CType(Me.pizzaQte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pizzaNameLabel As System.Windows.Forms.Label
    Friend WithEvents pizzaPriceLabel As System.Windows.Forms.Label
    Friend WithEvents deleteBtn As System.Windows.Forms.Button
    Friend WithEvents pizzaQte As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
