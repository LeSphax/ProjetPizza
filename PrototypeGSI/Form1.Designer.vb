<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TreeNode85 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Les Meilleures")
        Dim TreeNode86 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Végétariennes")
        Dim TreeNode87 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hallal")
        Dim TreeNode88 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Type", New System.Windows.Forms.TreeNode() {TreeNode85, TreeNode86, TreeNode87})
        Dim TreeNode89 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tomate")
        Dim TreeNode90 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Crème Fraiche")
        Dim TreeNode91 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sauce Blanche")
        Dim TreeNode92 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sauce", New System.Windows.Forms.TreeNode() {TreeNode89, TreeNode90, TreeNode91})
        Dim TreeNode93 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jambon")
        Dim TreeNode94 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Boeuf")
        Dim TreeNode95 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kebab")
        Dim TreeNode96 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Viande", New System.Windows.Forms.TreeNode() {TreeNode93, TreeNode94, TreeNode95})
        Dim TreeNode97 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mozzarella")
        Dim TreeNode98 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Roquefort")
        Dim TreeNode99 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reblochon")
        Dim TreeNode100 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chèvre")
        Dim TreeNode101 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fromage", New System.Windows.Forms.TreeNode() {TreeNode97, TreeNode98, TreeNode99, TreeNode100})
        Dim TreeNode102 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ail")
        Dim TreeNode103 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Oignons")
        Dim TreeNode104 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Champignons")
        Dim TreeNode105 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autres", New System.Windows.Forms.TreeNode() {TreeNode102, TreeNode103, TreeNode104})
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.CartPanelForm = New System.Windows.Forms.Panel()
        Me.viderBtn = New System.Windows.Forms.Button()
        Me.sumLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.validerBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FilterPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ListButton = New System.Windows.Forms.Button()
        Me.GridButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CartLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CartPanelForm.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pizzas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(948, 55)
        Me.Panel1.TabIndex = 2
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 32)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(2)
        Me.TreeView1.Name = "TreeView1"
        TreeNode85.Name = "Type1"
        TreeNode85.Text = "Les Meilleures"
        TreeNode86.Name = "Type2"
        TreeNode86.Text = "Végétariennes"
        TreeNode87.Name = "Type3"
        TreeNode87.Text = "Hallal"
        TreeNode88.Name = "TypeNode"
        TreeNode88.Text = "Type"
        TreeNode89.Name = "Sauce1"
        TreeNode89.Text = "Tomate"
        TreeNode90.Name = "Sauce2"
        TreeNode90.Text = "Crème Fraiche"
        TreeNode91.Name = "Sauce3"
        TreeNode91.Text = "Sauce Blanche"
        TreeNode92.Name = "SauceNode"
        TreeNode92.Text = "Sauce"
        TreeNode93.Name = "JambonNode"
        TreeNode93.Text = "Jambon"
        TreeNode94.Name = "BoeufNode"
        TreeNode94.Text = "Boeuf"
        TreeNode95.Name = "KebabNode"
        TreeNode95.Text = "Kebab"
        TreeNode96.Name = "ViandeNode"
        TreeNode96.Text = "Viande"
        TreeNode97.Name = "MozzarellaNode"
        TreeNode97.Text = "Mozzarella"
        TreeNode98.Name = "RoquefortNode"
        TreeNode98.Text = "Roquefort"
        TreeNode99.Name = "ReblochonNode"
        TreeNode99.Text = "Reblochon"
        TreeNode100.Name = "ChèvreNode"
        TreeNode100.Text = "Chèvre"
        TreeNode101.Name = "FromageNode"
        TreeNode101.Text = "Fromage"
        TreeNode102.Name = "AilNode"
        TreeNode102.Text = "Ail"
        TreeNode103.Name = "OignonsNode"
        TreeNode103.Text = "Oignons"
        TreeNode104.Name = "ChampignonsNode"
        TreeNode104.Text = "Champignons"
        TreeNode105.Name = "AutresNode"
        TreeNode105.Text = "Autres"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode88, TreeNode92, TreeNode96, TreeNode101, TreeNode105})
        Me.TreeView1.Size = New System.Drawing.Size(150, 535)
        Me.TreeView1.TabIndex = 5
        '
        'CartPanelForm
        '
        Me.CartPanelForm.BackColor = System.Drawing.SystemColors.Control
        Me.CartPanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CartPanelForm.Controls.Add(Me.CartLayoutPanel)
        Me.CartPanelForm.Controls.Add(Me.viderBtn)
        Me.CartPanelForm.Controls.Add(Me.sumLabel)
        Me.CartPanelForm.Controls.Add(Me.Label3)
        Me.CartPanelForm.Controls.Add(Me.validerBtn)
        Me.CartPanelForm.Controls.Add(Me.Label2)
        Me.CartPanelForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.CartPanelForm.Location = New System.Drawing.Point(627, 0)
        Me.CartPanelForm.Margin = New System.Windows.Forms.Padding(2)
        Me.CartPanelForm.Name = "CartPanelForm"
        Me.CartPanelForm.Size = New System.Drawing.Size(171, 567)
        Me.CartPanelForm.TabIndex = 5
        '
        'viderBtn
        '
        Me.viderBtn.Location = New System.Drawing.Point(3, 537)
        Me.viderBtn.Name = "viderBtn"
        Me.viderBtn.Size = New System.Drawing.Size(75, 23)
        Me.viderBtn.TabIndex = 5
        Me.viderBtn.Text = "Vider"
        Me.viderBtn.UseVisualStyleBackColor = True
        '
        'sumLabel
        '
        Me.sumLabel.AutoSize = True
        Me.sumLabel.Location = New System.Drawing.Point(74, 509)
        Me.sumLabel.Name = "sumLabel"
        Me.sumLabel.Size = New System.Drawing.Size(22, 13)
        Me.sumLabel.TabIndex = 3
        Me.sumLabel.Text = "0,0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 509)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total"
        '
        'validerBtn
        '
        Me.validerBtn.Location = New System.Drawing.Point(84, 537)
        Me.validerBtn.Name = "validerBtn"
        Me.validerBtn.Size = New System.Drawing.Size(75, 23)
        Me.validerBtn.TabIndex = 1
        Me.validerBtn.Text = "Valider"
        Me.validerBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ma commande"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.FilterPanel)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(627, 82)
        Me.Panel4.TabIndex = 4
        '
        'FilterPanel
        '
        Me.FilterPanel.AutoScroll = True
        Me.FilterPanel.AutoSize = True
        Me.FilterPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilterPanel.Location = New System.Drawing.Point(0, 0)
        Me.FilterPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(475, 80)
        Me.FilterPanel.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ListButton)
        Me.Panel5.Controls.Add(Me.GridButton)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(475, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(150, 80)
        Me.Panel5.TabIndex = 0
        '
        'ListButton
        '
        Me.ListButton.BackgroundImage = Global.PrototypeGSI.My.Resources.Resources.ListIcon
        Me.ListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ListButton.Location = New System.Drawing.Point(82, 20)
        Me.ListButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ListButton.Name = "ListButton"
        Me.ListButton.Size = New System.Drawing.Size(38, 41)
        Me.ListButton.TabIndex = 1
        Me.ListButton.UseVisualStyleBackColor = True
        '
        'GridButton
        '
        Me.GridButton.BackgroundImage = Global.PrototypeGSI.My.Resources.Resources.GridIcon
        Me.GridButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GridButton.Location = New System.Drawing.Point(24, 20)
        Me.GridButton.Margin = New System.Windows.Forms.Padding(2)
        Me.GridButton.Name = "GridButton"
        Me.GridButton.Size = New System.Drawing.Size(38, 41)
        Me.GridButton.TabIndex = 0
        Me.GridButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TreeView1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 55)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(150, 567)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(150, 32)
        Me.Panel3.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.CartPanelForm)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(150, 55)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(798, 567)
        Me.Panel6.TabIndex = 7
        '
        'CartLayoutPanel
        '
        Me.CartLayoutPanel.AutoScroll = True
        Me.CartLayoutPanel.Location = New System.Drawing.Point(8, 20)
        Me.CartLayoutPanel.Name = "CartLayoutPanel"
        Me.CartLayoutPanel.Size = New System.Drawing.Size(151, 463)
        Me.CartLayoutPanel.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 622)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.CartPanelForm.ResumeLayout(False)
        Me.CartPanelForm.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents CartPanelForm As Panel
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents FilterPanel As FlowLayoutPanel
    Friend WithEvents sumLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents validerBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents viderBtn As System.Windows.Forms.Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GridButton As Button
    Friend WithEvents ListButton As Button
    Friend WithEvents CartLayoutPanel As System.Windows.Forms.FlowLayoutPanel
End Class
