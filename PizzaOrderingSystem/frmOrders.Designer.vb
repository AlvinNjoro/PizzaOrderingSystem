<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrders
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
        grpPizzas = New GroupBox()
        chkSmall = New CheckBox()
        chkMedium = New CheckBox()
        chkLarge = New CheckBox()
        chkParty = New CheckBox()
        grpExtras = New GroupBox()
        chkDrinks = New CheckBox()
        chkSalad = New CheckBox()
        chkPasta = New CheckBox()
        chkDessert = New CheckBox()
        pnlTotals = New Panel()
        lblSubtotal = New Label()
        txtSubtotal = New TextBox()
        lblVAT = New Label()
        txtVAT = New TextBox()
        lblTotal = New Label()
        txtTotal = New TextBox()
        pnlButtons = New Panel()
        btnAddOrder = New Button()
        btnClearOrder = New Button()
        btnOrdersSummary = New Button()
        btnClose = New Button()
        grpPizzas.SuspendLayout()
        grpExtras.SuspendLayout()
        pnlTotals.SuspendLayout()
        pnlButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpPizzas
        ' 
        grpPizzas.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        grpPizzas.Controls.Add(chkSmall)
        grpPizzas.Controls.Add(chkMedium)
        grpPizzas.Controls.Add(chkLarge)
        grpPizzas.Controls.Add(chkParty)
        grpPizzas.Location = New Point(40, 20)
        grpPizzas.Name = "grpPizzas"
        grpPizzas.Size = New Size(220, 190)
        grpPizzas.TabIndex = 0
        grpPizzas.TabStop = False
        grpPizzas.Text = "Pizzas"
        ' 
        ' chkSmall
        ' 
        chkSmall.AutoSize = True
        chkSmall.Location = New Point(20, 30)
        chkSmall.Name = "chkSmall"
        chkSmall.Size = New Size(119, 19)
        chkSmall.TabIndex = 0
        chkSmall.Text = "Small size (30aed)"
        chkSmall.UseVisualStyleBackColor = True
        ' 
        ' chkMedium
        ' 
        chkMedium.AutoSize = True
        chkMedium.Location = New Point(20, 70)
        chkMedium.Name = "chkMedium"
        chkMedium.Size = New Size(135, 19)
        chkMedium.TabIndex = 1
        chkMedium.Text = "Medium size (35aed)"
        chkMedium.UseVisualStyleBackColor = True
        ' 
        ' chkLarge
        ' 
        chkLarge.AutoSize = True
        chkLarge.Location = New Point(20, 110)
        chkLarge.Name = "chkLarge"
        chkLarge.Size = New Size(119, 19)
        chkLarge.TabIndex = 2
        chkLarge.Text = "Large size (40aed)"
        chkLarge.UseVisualStyleBackColor = True
        ' 
        ' chkParty
        ' 
        chkParty.AutoSize = True
        chkParty.Location = New Point(20, 150)
        chkParty.Name = "chkParty"
        chkParty.Size = New Size(95, 19)
        chkParty.TabIndex = 3
        chkParty.Text = "Party (50aed)"
        chkParty.UseVisualStyleBackColor = True
        ' 
        ' grpExtras
        ' 
        grpExtras.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        grpExtras.Controls.Add(chkDrinks)
        grpExtras.Controls.Add(chkSalad)
        grpExtras.Controls.Add(chkPasta)
        grpExtras.Controls.Add(chkDessert)
        grpExtras.Location = New Point(300, 20)
        grpExtras.Name = "grpExtras"
        grpExtras.Size = New Size(220, 190)
        grpExtras.TabIndex = 1
        grpExtras.TabStop = False
        grpExtras.Text = "Extras"
        ' 
        ' chkDrinks
        ' 
        chkDrinks.AutoSize = True
        chkDrinks.Location = New Point(20, 30)
        chkDrinks.Name = "chkDrinks"
        chkDrinks.Size = New Size(112, 19)
        chkDrinks.TabIndex = 0
        chkDrinks.Text = "Drinks (1@5aed)"
        chkDrinks.UseVisualStyleBackColor = True
        ' 
        ' chkSalad
        ' 
        chkSalad.AutoSize = True
        chkSalad.Location = New Point(20, 70)
        chkSalad.Name = "chkSalad"
        chkSalad.Size = New Size(121, 19)
        chkSalad.TabIndex = 1
        chkSalad.Text = "Salad dish (10aed)"
        chkSalad.UseVisualStyleBackColor = True
        ' 
        ' chkPasta
        ' 
        chkPasta.AutoSize = True
        chkPasta.Location = New Point(20, 110)
        chkPasta.Name = "chkPasta"
        chkPasta.Size = New Size(121, 19)
        chkPasta.TabIndex = 2
        chkPasta.Text = "Pasta dish (10aed)"
        chkPasta.UseVisualStyleBackColor = True
        ' 
        ' chkDessert
        ' 
        chkDessert.AutoSize = True
        chkDessert.Location = New Point(20, 150)
        chkDessert.Name = "chkDessert"
        chkDessert.Size = New Size(106, 19)
        chkDessert.TabIndex = 3
        chkDessert.Text = "Dessert (15aed)"
        chkDessert.UseVisualStyleBackColor = True
        ' 
        ' pnlTotals
        ' 
        pnlTotals.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        pnlTotals.Controls.Add(lblSubtotal)
        pnlTotals.Controls.Add(txtSubtotal)
        pnlTotals.Controls.Add(lblVAT)
        pnlTotals.Controls.Add(txtVAT)
        pnlTotals.Controls.Add(lblTotal)
        pnlTotals.Controls.Add(txtTotal)
        pnlTotals.Location = New Point(20, 225)
        pnlTotals.Name = "pnlTotals"
        pnlTotals.Size = New Size(520, 60)
        pnlTotals.TabIndex = 2
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(10, 22)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(87, 15)
        lblSubtotal.TabIndex = 0
        lblSubtotal.Text = "Order Subtotal:"
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.BackColor = Color.White
        txtSubtotal.Location = New Point(103, 19)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.ReadOnly = True
        txtSubtotal.Size = New Size(80, 23)
        txtSubtotal.TabIndex = 1
        txtSubtotal.TabStop = False
        ' 
        ' lblVAT
        ' 
        lblVAT.AutoSize = True
        lblVAT.Location = New Point(200, 22)
        lblVAT.Name = "lblVAT"
        lblVAT.Size = New Size(29, 15)
        lblVAT.TabIndex = 2
        lblVAT.Text = "VAT:"
        ' 
        ' txtVAT
        ' 
        txtVAT.BackColor = Color.White
        txtVAT.Location = New Point(235, 19)
        txtVAT.Name = "txtVAT"
        txtVAT.ReadOnly = True
        txtVAT.Size = New Size(80, 23)
        txtVAT.TabIndex = 3
        txtVAT.TabStop = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(330, 22)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(68, 15)
        lblTotal.TabIndex = 4
        lblTotal.Text = "Order Total:"
        ' 
        ' txtTotal
        ' 
        txtTotal.BackColor = Color.White
        txtTotal.Location = New Point(405, 19)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(95, 23)
        txtTotal.TabIndex = 5
        txtTotal.TabStop = False
        ' 
        ' pnlButtons
        ' 
        pnlButtons.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        pnlButtons.Controls.Add(btnAddOrder)
        pnlButtons.Controls.Add(btnClearOrder)
        pnlButtons.Controls.Add(btnOrdersSummary)
        pnlButtons.Controls.Add(btnClose)
        pnlButtons.Location = New Point(20, 300)
        pnlButtons.Name = "pnlButtons"
        pnlButtons.Size = New Size(520, 70)
        pnlButtons.TabIndex = 3
        ' 
        ' btnAddOrder
        ' 
        btnAddOrder.BackColor = Color.Gold
        btnAddOrder.Location = New Point(10, 15)
        btnAddOrder.Name = "btnAddOrder"
        btnAddOrder.Size = New Size(110, 40)
        btnAddOrder.TabIndex = 0
        btnAddOrder.Text = "Add Order"
        btnAddOrder.UseVisualStyleBackColor = False
        ' 
        ' btnClearOrder
        ' 
        btnClearOrder.BackColor = Color.Gold
        btnClearOrder.Location = New Point(140, 15)
        btnClearOrder.Name = "btnClearOrder"
        btnClearOrder.Size = New Size(110, 40)
        btnClearOrder.TabIndex = 1
        btnClearOrder.Text = "Clear Order"
        btnClearOrder.UseVisualStyleBackColor = False
        ' 
        ' btnOrdersSummary
        ' 
        btnOrdersSummary.BackColor = Color.Gold
        btnOrdersSummary.Location = New Point(270, 15)
        btnOrdersSummary.Name = "btnOrdersSummary"
        btnOrdersSummary.Size = New Size(110, 40)
        btnOrdersSummary.TabIndex = 2
        btnOrdersSummary.Text = "Orders Summary"
        btnOrdersSummary.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.BlanchedAlmond
        btnClose.Location = New Point(400, 15)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(110, 40)
        btnClose.TabIndex = 3
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' frmOrders
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 390)
        Controls.Add(grpPizzas)
        Controls.Add(grpExtras)
        Controls.Add(pnlTotals)
        Controls.Add(pnlButtons)
        Name = "frmOrders"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pizza Ordering System"
        grpPizzas.ResumeLayout(False)
        grpPizzas.PerformLayout()
        grpExtras.ResumeLayout(False)
        grpExtras.PerformLayout()
        pnlTotals.ResumeLayout(False)
        pnlTotals.PerformLayout()
        pnlButtons.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents grpPizzas As System.Windows.Forms.GroupBox
    Friend WithEvents chkSmall As System.Windows.Forms.CheckBox
    Friend WithEvents chkMedium As System.Windows.Forms.CheckBox
    Friend WithEvents chkLarge As System.Windows.Forms.CheckBox
    Friend WithEvents chkParty As System.Windows.Forms.CheckBox
    Friend WithEvents grpExtras As System.Windows.Forms.GroupBox
    Friend WithEvents chkDrinks As System.Windows.Forms.CheckBox
    Friend WithEvents chkSalad As System.Windows.Forms.CheckBox
    Friend WithEvents chkPasta As System.Windows.Forms.CheckBox
    Friend WithEvents chkDessert As System.Windows.Forms.CheckBox
    Friend WithEvents pnlTotals As System.Windows.Forms.Panel
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents lblVAT As System.Windows.Forms.Label
    Friend WithEvents txtVAT As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnAddOrder As System.Windows.Forms.Button
    Friend WithEvents btnClearOrder As System.Windows.Forms.Button
    Friend WithEvents btnOrdersSummary As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
