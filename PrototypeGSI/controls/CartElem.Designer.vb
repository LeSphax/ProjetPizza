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
        Me.LabelPizzaPrice = New System.Windows.Forms.Label()
        Me.pizzaNameLabel = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.PizzaQte = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PizzaQte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelPizzaPrice
        '
        Me.LabelPizzaPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelPizzaPrice.AutoSize = True
        Me.LabelPizzaPrice.Location = New System.Drawing.Point(99, 22)
        Me.LabelPizzaPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPizzaPrice.Name = "LabelPizzaPrice"
        Me.LabelPizzaPrice.Size = New System.Drawing.Size(31, 17)
        Me.LabelPizzaPrice.TabIndex = 1
        Me.LabelPizzaPrice.Text = "Prix"
        Me.LabelPizzaPrice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pizzaNameLabel
        '
        Me.pizzaNameLabel.AutoSize = True
        Me.pizzaNameLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pizzaNameLabel.Location = New System.Drawing.Point(0, 0)
        Me.pizzaNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pizzaNameLabel.Name = "pizzaNameLabel"
        Me.pizzaNameLabel.Size = New System.Drawing.Size(42, 17)
        Me.pizzaNameLabel.TabIndex = 0
        Me.pizzaNameLabel.Text = "Pizza"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(25, 4)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(100, 28)
        Me.DeleteBtn.TabIndex = 0
        Me.DeleteBtn.Text = "Supprimer"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'PizzaQte
        '
        Me.PizzaQte.Location = New System.Drawing.Point(4, 20)
        Me.PizzaQte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PizzaQte.Name = "PizzaQte"
        Me.PizzaQte.ReadOnly = True
        Me.PizzaQte.Size = New System.Drawing.Size(64, 22)
        Me.PizzaQte.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DeleteBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 38)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PizzaQte)
        Me.Panel2.Controls.Add(Me.LabelPizzaPrice)
        Me.Panel2.Controls.Add(Me.pizzaNameLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(165, 68)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "€"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CartElem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CartElem"
        Me.Size = New System.Drawing.Size(165, 87)
        CType(Me.PizzaQte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pizzaNameLabel As System.Windows.Forms.Label
    Friend WithEvents LabelPizzaPrice As System.Windows.Forms.Label
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents PizzaQte As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
