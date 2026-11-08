Public Class frmOrders


    Private Function CalculateVAT(subtotal As Decimal) As Decimal
        Return Math.Round(subtotal * VAT_RATE, 2)
    End Function


    Private Sub ClearOrderFields()
        chkSmall.Checked = False
        chkMedium.Checked = False
        chkLarge.Checked = False
        chkParty.Checked = False
        chkDrinks.Checked = False
        chkSalad.Checked = False
        chkPasta.Checked = False
        chkDessert.Checked = False

        txtSubtotal.Clear()
        txtVAT.Clear()
        txtTotal.Clear()

        btnAddOrder.Enabled = True
        btnAddOrder.Focus()
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Dim subtotal As Decimal = 0D

        If chkSmall.Checked Then subtotal += 30D
        If chkMedium.Checked Then subtotal += 35D
        If chkLarge.Checked Then subtotal += 40D
        If chkParty.Checked Then subtotal += 50D
        If chkDrinks.Checked Then subtotal += 5D
        If chkSalad.Checked Then subtotal += 10D
        If chkPasta.Checked Then subtotal += 10D
        If chkDessert.Checked Then subtotal += 15D

        If subtotal = 0D Then
            MessageBox.Show("Please select at least one item.", "Pizza Ordering System",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim vat As Decimal = CalculateVAT(subtotal)
        Dim orderTotal As Decimal = subtotal + vat

        txtSubtotal.Text = CURRENCY_SYMBOL & subtotal.ToString("N2")
        txtVAT.Text = CURRENCY_SYMBOL & vat.ToString("N2")
        txtTotal.Text = CURRENCY_SYMBOL & orderTotal.ToString("N2")


        OrderCount += 1
        AllSubtotals += subtotal
        AllVATs += vat
        AllGrandTotals += orderTotal


        btnAddOrder.Enabled = False
    End Sub

    Private Sub btnClearOrder_Click(sender As Object, e As EventArgs) Handles btnClearOrder.Click
        ClearOrderFields()
    End Sub

    Private Sub btnOrdersSummary_Click(sender As Object, e As EventArgs) Handles btnOrdersSummary.Click
        Using frm As New frmSummary()
            frm.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
