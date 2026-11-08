Public Class frmSummary

    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumOrders.Text = OrderCount.ToString()
        txtSubtotals.Text = CURRENCY_SYMBOL & AllSubtotals.ToString("N2")
        txtTotalVAT.Text = CURRENCY_SYMBOL & AllVATs.ToString("N2")
        txtGrandTotal.Text = CURRENCY_SYMBOL & AllGrandTotals.ToString("N2")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
