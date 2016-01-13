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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Les Meilleures")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Végétariennes")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hallal")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Type", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tomate")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Crème Fraiche")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sauce Blanche")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sauce", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Jambon")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Boeuf")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kebab")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Viande", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mozzarella")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Roquefort")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reblochon")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chèvre")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fromage", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ail")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Oignons")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Champignons")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autres", New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19, TreeNode20})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PizzaLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CartPanelForm.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        TreeNode1.Name = "Type1"
        TreeNode1.Text = "Les Meilleures"
        TreeNode2.Name = "Type2"
        TreeNode2.Text = "Végétariennes"
        TreeNode3.Name = "Type3"
        TreeNode3.Text = "Hallal"
        TreeNode4.Name = "TypeNode"
        TreeNode4.Text = "Type"
        TreeNode5.Name = "Sauce1"
        TreeNode5.Text = "Tomate"
        TreeNode6.Name = "Sauce2"
        TreeNode6.Text = "Crème Fraiche"
        TreeNode7.Name = "Sauce3"
        TreeNode7.Text = "Sauce Blanche"
        TreeNode8.Name = "SauceNode"
        TreeNode8.Text = "Sauce"
        TreeNode9.Name = "JambonNode"
        TreeNode9.Text = "Jambon"
        TreeNode10.Name = "BoeufNode"
        TreeNode10.Text = "Boeuf"
        TreeNode11.Name = "KebabNode"
        TreeNode11.Text = "Kebab"
        TreeNode12.Name = "ViandeNode"
        TreeNode12.Text = "Viande"
        TreeNode13.Name = "MozzarellaNode"
        TreeNode13.Text = "Mozzarella"
        TreeNode14.Name = "RoquefortNode"
        TreeNode14.Text = "Roquefort"
        TreeNode15.Name = "ReblochonNode"
        TreeNode15.Text = "Reblochon"
        TreeNode16.Name = "ChèvreNode"
        TreeNode16.Text = "Chèvre"
        TreeNode17.Name = "FromageNode"
        TreeNode17.Text = "Fromage"
        TreeNode18.Name = "AilNode"
        TreeNode18.Text = "Ail"
        TreeNode19.Name = "OignonsNode"
        TreeNode19.Text = "Oignons"
        TreeNode20.Name = "ChampignonsNode"
        TreeNode20.Text = "Champignons"
        TreeNode21.Name = "AutresNode"
        TreeNode21.Text = "Autres"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode8, TreeNode12, TreeNode17, TreeNode21})
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
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(635, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 98)
        Me.Panel5.TabIndex = 0
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
        Me.Panel6.Controls.Add(Me.PizzaLayoutPanel)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.CartPanelForm)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(200, 67)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1064, 706)
        Me.Panel6.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(35, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(122, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PizzaLayoutPanel
        '
        Me.PizzaLayoutPanel.AutoScroll = True
        Me.PizzaLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PizzaLayoutPanel.Location = New System.Drawing.Point(0, 100)
        Me.PizzaLayoutPanel.Name = "PizzaLayoutPanel"
        Me.PizzaLayoutPanel.Size = New System.Drawing.Size(837, 606)
        Me.PizzaLayoutPanel.TabIndex = 0
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
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PizzaLayoutPanel As FlowLayoutPanel
End Class
