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
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Les Meilleures")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Végétariennes")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hallal")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Type", New System.Windows.Forms.TreeNode() {TreeNode43, TreeNode44, TreeNode45})
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tomate")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Crème Fraiche")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sauce Blanche")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sauce", New System.Windows.Forms.TreeNode() {TreeNode47, TreeNode48, TreeNode49})
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jambon")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Boeuf")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kebab")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Viande", New System.Windows.Forms.TreeNode() {TreeNode51, TreeNode52, TreeNode53})
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mozzarella")
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Roquefort")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reblochon")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chèvre")
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fromage", New System.Windows.Forms.TreeNode() {TreeNode55, TreeNode56, TreeNode57, TreeNode58})
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ail")
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Oignons")
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Champignons")
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autres", New System.Windows.Forms.TreeNode() {TreeNode60, TreeNode61, TreeNode62})
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.CartPanelForm = New System.Windows.Forms.Panel()
        Me.viderBtn = New System.Windows.Forms.Button()
        Me.CartLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
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
        Me.Label1.Location = New System.Drawing.Point(71, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pizzas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1264, 67)
        Me.Panel1.TabIndex = 2
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 39)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TreeView1.Name = "TreeView1"
        TreeNode43.Name = "Type1"
        TreeNode43.Text = "Les Meilleures"
        TreeNode44.Name = "Type2"
        TreeNode44.Text = "Végétariennes"
        TreeNode45.Name = "Type3"
        TreeNode45.Text = "Hallal"
        TreeNode46.Name = "TypeNode"
        TreeNode46.Text = "Type"
        TreeNode47.Name = "Sauce1"
        TreeNode47.Text = "Tomate"
        TreeNode48.Name = "Sauce2"
        TreeNode48.Text = "Crème Fraiche"
        TreeNode49.Name = "Sauce3"
        TreeNode49.Text = "Sauce Blanche"
        TreeNode50.Name = "SauceNode"
        TreeNode50.Text = "Sauce"
        TreeNode51.Name = "JambonNode"
        TreeNode51.Text = "Jambon"
        TreeNode52.Name = "BoeufNode"
        TreeNode52.Text = "Boeuf"
        TreeNode53.Name = "KebabNode"
        TreeNode53.Text = "Kebab"
        TreeNode54.Name = "ViandeNode"
        TreeNode54.Text = "Viande"
        TreeNode55.Name = "MozzarellaNode"
        TreeNode55.Text = "Mozzarella"
        TreeNode56.Name = "RoquefortNode"
        TreeNode56.Text = "Roquefort"
        TreeNode57.Name = "ReblochonNode"
        TreeNode57.Text = "Reblochon"
        TreeNode58.Name = "ChèvreNode"
        TreeNode58.Text = "Chèvre"
        TreeNode59.Name = "FromageNode"
        TreeNode59.Text = "Fromage"
        TreeNode60.Name = "AilNode"
        TreeNode60.Text = "Ail"
        TreeNode61.Name = "OignonsNode"
        TreeNode61.Text = "Oignons"
        TreeNode62.Name = "ChampignonsNode"
        TreeNode62.Text = "Champignons"
        TreeNode63.Name = "AutresNode"
        TreeNode63.Text = "Autres"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode46, TreeNode50, TreeNode54, TreeNode59, TreeNode63})
        Me.TreeView1.Size = New System.Drawing.Size(200, 667)
        Me.TreeView1.TabIndex = 5
        '
        'CartPanelForm
        '
        Me.CartPanelForm.BackColor = System.Drawing.SystemColors.Control
        Me.CartPanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CartPanelForm.Controls.Add(Me.viderBtn)
        Me.CartPanelForm.Controls.Add(Me.CartLayoutPanel)
        Me.CartPanelForm.Controls.Add(Me.sumLabel)
        Me.CartPanelForm.Controls.Add(Me.Label3)
        Me.CartPanelForm.Controls.Add(Me.validerBtn)
        Me.CartPanelForm.Controls.Add(Me.Label2)
        Me.CartPanelForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.CartPanelForm.Location = New System.Drawing.Point(837, 0)
        Me.CartPanelForm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CartPanelForm.Name = "CartPanelForm"
        Me.CartPanelForm.Size = New System.Drawing.Size(227, 706)
        Me.CartPanelForm.TabIndex = 5
        '
        'viderBtn
        '
        Me.viderBtn.Location = New System.Drawing.Point(4, 661)
        Me.viderBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.viderBtn.Name = "viderBtn"
        Me.viderBtn.Size = New System.Drawing.Size(100, 28)
        Me.viderBtn.TabIndex = 5
        Me.viderBtn.Text = "Vider"
        Me.viderBtn.UseVisualStyleBackColor = True
        '
        'CartLayoutPanel
        '
        Me.CartLayoutPanel.Location = New System.Drawing.Point(24, 38)
        Me.CartLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CartLayoutPanel.Name = "CartLayoutPanel"
        Me.CartLayoutPanel.Size = New System.Drawing.Size(188, 570)
        Me.CartLayoutPanel.TabIndex = 4
        '
        'sumLabel
        '
        Me.sumLabel.AutoSize = True
        Me.sumLabel.Location = New System.Drawing.Point(99, 626)
        Me.sumLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sumLabel.Name = "sumLabel"
        Me.sumLabel.Size = New System.Drawing.Size(28, 17)
        Me.sumLabel.TabIndex = 3
        Me.sumLabel.Text = "0,0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 626)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total"
        '
        'validerBtn
        '
        Me.validerBtn.Location = New System.Drawing.Point(112, 661)
        Me.validerBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.validerBtn.Name = "validerBtn"
        Me.validerBtn.Size = New System.Drawing.Size(100, 28)
        Me.validerBtn.TabIndex = 1
        Me.validerBtn.Text = "Valider"
        Me.validerBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 1)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
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
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(837, 100)
        Me.Panel4.TabIndex = 4
        '
        'FilterPanel
        '
        Me.FilterPanel.AutoScroll = True
        Me.FilterPanel.AutoSize = True
        Me.FilterPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilterPanel.Location = New System.Drawing.Point(0, 0)
        Me.FilterPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(635, 98)
        Me.FilterPanel.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ListButton)
        Me.Panel5.Controls.Add(Me.GridButton)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(635, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 98)
        Me.Panel5.TabIndex = 0
        '
        'ListButton
        '
        Me.ListButton.BackgroundImage = Global.PrototypeGSI.My.Resources.Resources.ListIcon
        Me.ListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ListButton.Location = New System.Drawing.Point(110, 24)
        Me.ListButton.Name = "ListButton"
        Me.ListButton.Size = New System.Drawing.Size(50, 50)
        Me.ListButton.TabIndex = 1
        Me.ListButton.UseVisualStyleBackColor = True
        '
        'GridButton
        '
        Me.GridButton.BackgroundImage = Global.PrototypeGSI.My.Resources.Resources.GridIcon
        Me.GridButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GridButton.Location = New System.Drawing.Point(32, 24)
        Me.GridButton.Name = "GridButton"
        Me.GridButton.Size = New System.Drawing.Size(50, 50)
        Me.GridButton.TabIndex = 0
        Me.GridButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TreeView1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 67)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 706)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 39)
        Me.Panel3.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.CartPanelForm)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(200, 67)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1064, 706)
        Me.Panel6.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 773)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents CartLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents viderBtn As System.Windows.Forms.Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GridButton As Button
    Friend WithEvents ListButton As Button
End Class
