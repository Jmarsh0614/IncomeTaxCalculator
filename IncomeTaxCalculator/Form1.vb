Option Strict On

Public Class frmIncomeTaxCalc
    Const _cdecFicaTaxRate = 0.0765D
    Const _cdecFedTaxRate = 0.22D
    Const _cdecStateTaxRate = 0.03D

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAnnualIncome = Convert.ToDecimal(txtAnnualIncome.Text)
        Dim decFicaTaxTaken As Decimal = decAnnualIncome * _cdecFicaTaxRate
        Dim decFedTaxTaken As Decimal = decAnnualIncome * _cdecFedTaxRate
        Dim decStateTaxTaken As Decimal = decAnnualIncome * _cdecStateTaxRate
        Dim decNetPay As Decimal = decAnnualIncome - decFedTaxTaken - decFicaTaxTaken - decStateTaxTaken

        lblNetPay.Text = "Net Pay: " & decNetPay.ToString("C")
        lblFicaTax.Text = "Fica Tax: " & decFicaTaxTaken.ToString("C")
        lblFedTax.Text = "Fed Tax: " & decFedTaxTaken.ToString("C")
        lblStateTax.Text = "State Tax: " & decStateTaxTaken.ToString("C")



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAnnualIncome.Text = ""
        lblNetPay.Text = ""
        lblFicaTax.Text = ""
        lblFedTax.Text = ""
        lblStateTax.Text = ""
    End Sub
End Class
