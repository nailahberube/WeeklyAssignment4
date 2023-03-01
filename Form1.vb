Public Class frmAirBnBReservations
    Const cdecCostPerNight = 79D

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click

        Dim strNumNights As String
        Dim intNumNights As Integer
        Dim decTotalCost As Decimal

        strNumNights = txtNumberofNights.Text
        intNumNights = Convert.ToInt32(strNumNights)

        decTotalCost = intNumNights * cdecCostPerNight

        lblTotalCost.Text = decTotalCost.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumberofNights.Clear()
        lblTotalCost.Text = ""
        txtNumberofNights.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
