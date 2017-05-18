'Program:       Misty River Campground Rates
'Developer:     Jason A. Frye
'Purpose:       This program will take the information for an individual campground stay, 
'               display the calculated costs, and produce a close-of-business report
'Date:          6/14/11

Option Strict On
Option Explicit On

Public Class frmSummary



    Private Sub frmSummary_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'initializes all output vairables and assigns them the appropriate values 
        'called from frmMain properties, then outputs them in the appropriate label, 
        'converting ToString where necessary


        'declares output variables
        Dim strSiteOut As String
        Dim strNightsOut As String
        Dim strDiscOut As String
        Dim sngBillOut As Single
        Dim sngSubtotalOut As Single
        Dim sngTaxOut As Single
        Dim sngGrandOut As Single

        'calls public properties and assigns value to output variables
        strSiteOut = frmMain.SiteOut
        strNightsOut = frmMain.NumNightsOut.ToString
        strDiscOut = frmMain.DiscountOut
        sngBillOut = frmMain.BillOut
        sngSubtotalOut = frmMain.SubtotalOut
        sngTaxOut = frmMain.TaxTotalOut
        sngGrandOut = frmMain.GrandOut

        'outputs variables to form
        lblSiteOut.Text = strSiteOut
        lblNightsOut.Text = strNightsOut
        lblDiscOut.Text = strDiscOut
        lblBillOut.Text = sngBillOut.ToString("C")
        lblSubtotalOut.Text = sngSubtotalOut.ToString("C")
        lblTaxOut.Text = sngTaxOut.ToString("C")
        lblGrandOut.Text = sngGrandOut.ToString("C")





    End Sub

    Private Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        'hides current form and displays frmMain…no other changes occur

        Me.Hide()
        frmMain.Show()

    End Sub

    Private Sub btnTender_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTender.Click
        'Calls the public Tender() property setting the boolean value to true, hides the current form, and returns to frmMain

        frmMain.Tender() = True
        Me.Hide()
        frmMain.Show()


    End Sub
End Class