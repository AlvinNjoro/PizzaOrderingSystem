<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSummary
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
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.lblNumOrders = New System.Windows.Forms.Label()
        Me.txtNumOrders = New System.Windows.Forms.TextBox()
        Me.lblSubtotals = New System.Windows.Forms.Label()
        Me.txtSubtotals = New System.Windows.Forms.TextBox()
        Me.lblTotalVAT = New System.Windows.Forms.Label()
        Me.txtTotalVAT = New System.Windows.Forms.TextBox()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSummary
        '
        Me.grpSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grpSummary.Controls.Add(Me.lblNumOrders)
        Me.grpSummary.Controls.Add(Me.txtNumOrders)
        Me.grpSummary.Controls.Add(Me.lblSubtotals)
        Me.grpSummary.Controls.Add(Me.txtSubtotals)
        Me.grpSummary.Controls.Add(Me.lblTotalVAT)
        Me.grpSummary.Controls.Add(Me.txtTotalVAT)
        Me.grpSummary.Controls.Add(Me.lblGrandTotal)
        Me.grpSummary.Controls.Add(Me.txtGrandTotal)
        Me.grpSummary.Location = New System.Drawing.Point(30, 20)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Size = New System.Drawing.Size(360, 230)
        Me.grpSummary.TabIndex = 0
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Orders Summary"
        '
        'lblNumOrders
        '
        Me.lblNumOrders.AutoSize = True
        Me.lblNumOrders.Location = New System.Drawing.Point(20, 43)
        Me.lblNumOrders.Name = "lblNumOrders"
        Me.lblNumOrders.Size = New System.Drawing.Size(101, 15)
        Me.lblNumOrders.TabIndex = 0
        Me.lblNumOrders.Text = "Number of Orders:"
        '
        'txtNumOrders
        '
        Me.txtNumOrders.BackColor = System.Drawing.Color.White
        Me.txtNumOrders.Location = New System.Drawing.Point(200, 40)
        Me.txtNumOrders.Name = "txtNumOrders"
        Me.txtNumOrders.ReadOnly = True
        Me.txtNumOrders.Size = New System.Drawing.Size(130, 23)
        Me.txtNumOrders.TabIndex = 1
        Me.txtNumOrders.TabStop = False
        '
        'lblSubtotals
        '
        Me.lblSubtotals.AutoSize = True
        Me.lblSubtotals.Location = New System.Drawing.Point(20, 88)
        Me.lblSubtotals.Name = "lblSubtotals"
        Me.lblSubtotals.Size = New System.Drawing.Size(92, 15)
        Me.lblSubtotals.TabIndex = 2
        Me.lblSubtotals.Text = "Order Subtotals:"
        '
        'txtSubtotals
        '
        Me.txtSubtotals.BackColor = System.Drawing.Color.White
        Me.txtSubtotals.Location = New System.Drawing.Point(200, 85)
        Me.txtSubtotals.Name = "txtSubtotals"
        Me.txtSubtotals.ReadOnly = True
        Me.txtSubtotals.Size = New System.Drawing.Size(130, 23)
        Me.txtSubtotals.TabIndex = 3
        Me.txtSubtotals.TabStop = False
        '
        'lblTotalVAT
        '
        Me.lblTotalVAT.AutoSize = True
        Me.lblTotalVAT.Location = New System.Drawing.Point(20, 133)
        Me.lblTotalVAT.Name = "lblTotalVAT"
        Me.lblTotalVAT.Size = New System.Drawing.Size(134, 15)
        Me.lblTotalVAT.TabIndex = 4
        Me.lblTotalVAT.Text = "Total Value Added Tax:"
        '
        'txtTotalVAT
        '
        Me.txtTotalVAT.BackColor = System.Drawing.Color.White
        Me.txtTotalVAT.Location = New System.Drawing.Point(200, 130)
        Me.txtTotalVAT.Name = "txtTotalVAT"
        Me.txtTotalVAT.ReadOnly = True
        Me.txtTotalVAT.Size = New System.Drawing.Size(130, 23)
        Me.txtTotalVAT.TabIndex = 5
        Me.txtTotalVAT.TabStop = False
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Location = New System.Drawing.Point(20, 178)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(115, 15)
        Me.lblGrandTotal.TabIndex = 6
        Me.lblGrandTotal.Text = "Orders Grand Total:"
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.BackColor = System.Drawing.Color.White
        Me.txtGrandTotal.Location = New System.Drawing.Point(200, 175)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Size = New System.Drawing.Size(130, 23)
        Me.txtGrandTotal.TabIndex = 7
        Me.txtGrandTotal.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(30, 270)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(360, 35)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSummary
        '
        Me.AcceptButton = Me.btnClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(420, 325)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Orders Summary"
        Me.grpSummary.ResumeLayout(False)
        Me.grpSummary.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpSummary As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumOrders As System.Windows.Forms.Label
    Friend WithEvents txtNumOrders As System.Windows.Forms.TextBox
    Friend WithEvents lblSubtotals As System.Windows.Forms.Label
    Friend WithEvents txtSubtotals As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalVAT As System.Windows.Forms.Label
    Friend WithEvents txtTotalVAT As System.Windows.Forms.TextBox
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
