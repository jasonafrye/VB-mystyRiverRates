'Program:       Misty River Campground Rates
'Developer:     Jason A. Frye
'Purpose:       This program will take the information for an individual campground stay, 
'               display the calculated costs, and produce a close-of-business report
'Date:          6/14/11

Option Strict On
Option Explicit On

Public Class frmCOB

    Private Sub frmCOB_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Declares output variables and assigns them the appropriate values called from frmMain, 
        'then outputs them in the appropriate label. Also outputs the system's date to a label. 

        'declare output variables
        Dim intTrans As Integer
        Dim dblDaily As Double

        'assign values with called properties from main form
        intTrans = frmMain.TransCount
        dblDaily = frmMain.DailyTotal

        'output to form
        lblDate.Text = Today.ToString
        lblTrans.Text = intTrans.ToString
        lblDaily.Text = dblDaily.ToString("C")
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'terminates the program
        End

    End Sub
End Class