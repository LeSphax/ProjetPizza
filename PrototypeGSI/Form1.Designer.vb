﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.CartPanelForm = New System.Windows.Forms.Panel()
        Me.CartLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelTotal = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelReduc = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.validerBtn = New System.Windows.Forms.Button()
        Me.viderBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Coupon1 = New PrototypeGSI.CouponView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FilterPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ListButton = New System.Windows.Forms.Button()
        Me.GridButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CartPanelForm.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.PanelTotal.SuspendLayout()
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
        Me.TreeView1.Size = New System.Drawing.Size(150, 535)
        Me.TreeView1.TabIndex = 5
        '
        'CartPanelForm
        '
        Me.CartPanelForm.BackColor = System.Drawing.SystemColors.Control
        Me.CartPanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CartPanelForm.Controls.Add(Me.CartLayoutPanel)
        Me.CartPanelForm.Controls.Add(Me.Panel8)
        Me.CartPanelForm.Controls.Add(Me.PanelTotal)
        Me.CartPanelForm.Controls.Add(Me.Coupon1)
        Me.CartPanelForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.CartPanelForm.Location = New System.Drawing.Point(627, 0)
        Me.CartPanelForm.Margin = New System.Windows.Forms.Padding(2)
        Me.CartPanelForm.Name = "CartPanelForm"
        Me.CartPanelForm.Size = New System.Drawing.Size(171, 567)
        Me.CartPanelForm.TabIndex = 5
        '
        'CartLayoutPanel
        '
        Me.CartLayoutPanel.AutoScroll = True
        Me.CartLayoutPanel.BackColor = System.Drawing.SystemColors.Window
        Me.CartLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CartLayoutPanel.Location = New System.Drawing.Point(0, 25)
        Me.CartLayoutPanel.Name = "CartLayoutPanel"
        Me.CartLayoutPanel.Size = New System.Drawing.Size(169, 357)
        Me.CartLayoutPanel.TabIndex = 6
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(169, 25)
        Me.Panel8.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ma commande"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelTotal
        '
        Me.PanelTotal.Controls.Add(Me.Label7)
        Me.PanelTotal.Controls.Add(Me.LabelReduc)
        Me.PanelTotal.Controls.Add(Me.Label5)
        Me.PanelTotal.Controls.Add(Me.Label4)
        Me.PanelTotal.Controls.Add(Me.validerBtn)
        Me.PanelTotal.Controls.Add(Me.viderBtn)
        Me.PanelTotal.Controls.Add(Me.Label3)
        Me.PanelTotal.Controls.Add(Me.LabelTotal)
        Me.PanelTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelTotal.Location = New System.Drawing.Point(0, 382)
        Me.PanelTotal.Name = "PanelTotal"
        Me.PanelTotal.Size = New System.Drawing.Size(169, 70)
        Me.PanelTotal.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(136, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "€"
        '
        'LabelReduc
        '
        Me.LabelReduc.AutoSize = True
        Me.LabelReduc.Location = New System.Drawing.Point(97, 4)
        Me.LabelReduc.Name = "LabelReduc"
        Me.LabelReduc.Size = New System.Drawing.Size(13, 13)
        Me.LabelReduc.TabIndex = 9
        Me.LabelReduc.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Réduction"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(136, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "€"
        '
        'validerBtn
        '
        Me.validerBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.validerBtn.Location = New System.Drawing.Point(88, 42)
        Me.validerBtn.Name = "validerBtn"
        Me.validerBtn.Size = New System.Drawing.Size(75, 23)
        Me.validerBtn.TabIndex = 1
        Me.validerBtn.Text = "Valider"
        Me.validerBtn.UseVisualStyleBackColor = True
        '
        'viderBtn
        '
        Me.viderBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.viderBtn.Location = New System.Drawing.Point(3, 42)
        Me.viderBtn.Name = "viderBtn"
        Me.viderBtn.Size = New System.Drawing.Size(75, 23)
        Me.viderBtn.TabIndex = 5
        Me.viderBtn.Text = "Vider"
        Me.viderBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total"
        '
        'LabelTotal
        '
        Me.LabelTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(97, 17)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(13, 13)
        Me.LabelTotal.TabIndex = 3
        Me.LabelTotal.Text = "0"
        '
        'Coupon1
        '
        Me.Coupon1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Coupon1.Location = New System.Drawing.Point(0, 452)
        Me.Coupon1.Margin = New System.Windows.Forms.Padding(4)
        Me.Coupon1.Name = "Coupon1"
        Me.Coupon1.Size = New System.Drawing.Size(169, 113)
        Me.Coupon1.TabIndex = 6
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
        Me.Text = "Commande de pizzas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CartPanelForm.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.PanelTotal.ResumeLayout(False)
        Me.PanelTotal.PerformLayout()
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
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents validerBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents viderBtn As System.Windows.Forms.Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GridButton As Button
    Friend WithEvents ListButton As Button
    Friend WithEvents CartLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PanelTotal As System.Windows.Forms.Panel
    Friend WithEvents Coupon1 As CouponView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelReduc As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
End Class
