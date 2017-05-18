'Program:       Misty River Campground Rates
'Developer:     Jason A. Frye
'Purpose:       This program will take the information for an individual campground stay, 
'               display the calculated costs, and produce a close-of-business report
'Date:          6/14/11

Option Strict On
Option Explicit On

Public Class frmMain

#Region "Modular Variables"
    'declare all modular level variables used in this form
    Dim mdblDailyTotal As Double = 0
    Dim mintTransCount As Integer = 0
    Dim mblnTender As Boolean = False
    Dim mstrSiteSelection As String
    Dim mintNumNights As Integer
    Dim msngSiteRate As Single
    Dim mstrDiscount As String
    Dim msngBill As Single
    Dim msngSubtotal As Single
    Dim msngTaxTotal As Single
    Dim msngGrand As Single
#End Region

#Region "Validating Events"
    Private Sub txtNights_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNights.Validating
        'takes content from txtNights in string form, uses a TRY-CATCH block to 
        'catch any exceptions as it is converted to intNights. 
        'If an exception occurs, a message box with the correct format request appears. 
        'If the TRY-CATCH block is passed, intNights is tested to ensure that the the 
        'value is between 1 and 14, if the value is outside of set parameters, 
        'again a message box is displayed with correct format procedures. 


        Try
            'attempt to covnert entered text to integer
            mintNumNights = Convert.ToInt32(txtNights.Text)
            'catch all exceptions, display message box, and reset/focus input field
        Catch ex As Exception
            MsgBox("Please enter the number of nights the guests plans to stay (1-14)", MsgBoxStyle.OkOnly, "Error")
            txtNights.Clear()
            txtNights.Focus()
        End Try
        'text that integer is within valid range
        If mintNumNights > 14 Or mintNumNights < 1 Then
            'display message box, and reset/focus input field
            MsgBox("Please enter the number of nights the guests plans to stay (1-14)", MsgBoxStyle.OkOnly, "Error")
            txtNights.Clear()
            txtNights.Focus()
        End If
    End Sub
    Private Sub cboSite_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboSite.Validating
        'verifies that a index 0-2 has been selected, thus negating the user's ability 
        'to enter their own site. If a valid site has not been selected, a message box 
        'will appear and re-direct user to try again

        If cboSite.SelectedIndex < 0 Or cboSite.SelectedIndex > 2 Then
            MsgBox("Please Select a Site", MsgBoxStyle.OkOnly, "Error!")
            cboSite.Focus()
        End If

    End Sub

#End Region

#Region "Button Click Events"
    Private Sub btnCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        'Initializes mblnTender as false, executes Function and Sub Procedures 
        'to calculate cost of transaction and executes the Summarize() sub procedure 
        'to send information to the summary form. Upon return, will test mblnTender 
        'to determine if transaction was tendered...if true, will add to transaction 
        'counter and daily total accumulator and finally executes the Reset() Sub procedure. 
        'If false, nothing happens and the user may resume the current transaction, 

        'Declare necessary subroutine variables
        Dim sngDiscountAmount As Single

        'initialize tender flag as false to avoid accidental accumulation
        mblnTender = False

        'find the billing total (nights * rate)
        FindBill()

        'find the Discount amount (bill * discount rate)
        sngDiscountAmount = FindDiscount()

        'find the subtotal (bill - discount)
        msngSubtotal = FindSubtotal(sngDiscountAmount)

        'find the total tax value (subtotal * tax rate)
        msngTaxTotal = FindTax()

        'find grand total (subtotal + tax)
        msngGrand = FindGrand()

        'initialize summary form. 
        Summarize()

        'test to see if transaction was actually tendered, 
        'if yes accumulate transaction data and reset form for new transaction
        If mblnTender = True Then
            mintTransCount += 1
            mdblDailyTotal += msngGrand
            Reset()
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Executes the Reset() Sub procedure

        Reset()

    End Sub

    Private Sub btnCOB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCOB.Click
        'Displays confirmation dialouge. If yes, Executes the COB() Sub procedure. 
        'If no, executes the Reset() Sub Procedure

        If MsgBox("You cannot return from this point", MsgBoxStyle.YesNo, "Are You Sure?") = MsgBoxResult.Yes Then
            COB()
        End If
        Reset()

    End Sub
#End Region

#Region "Sub procedures"
    Private Sub FindBill()
        'Initializes constants for site rates, tests the selected index of cboSite 
        'in a Case Select block and loads the modular level variables (Site Selection and Rate) 
        'with the appropriate information. 
        'After, determines the value of the Bill (Site Rate * number of Nights)

        'declare contstants
        Const cintTentRate As Integer = 20
        Const cintRVRate As Integer = 35
        Const cintCabinRate As Integer = 55

        'determine selections and assign variables 
        Select Case cboSite.SelectedIndex
            Case Is = 0
                mstrSiteSelection = "Tent Site $20/night"
                msngSiteRate = cintTentRate
            Case Is = 1
                mstrSiteSelection = "RV Site $35/nite"
                msngSiteRate = cintRVRate
            Case Is = 2
                mstrSiteSelection = "Cabin Rental $55/night"
                msngSiteRate = cintCabinRate
        End Select

        'find total bill amount
        msngBill = msngSiteRate * mintNumNights
    End Sub

    Private Sub Reset()
        'resets all modular level strings to null, resets all modular level numeric variables 
        '(except transaction counter and daily total accumulator) to 0, 
        'clears all text boxes, selects radNone, resets selected index of cboSite 
        'and set focus to cboSite for user to begin new transaction

        'reset modular level strings
        mstrSiteSelection = ""
        mstrDiscount = ""

        'reset transaction numeric variables
        mintNumNights = 0
        msngSiteRate = 0
        msngBill = 0
        msngSubtotal = 0
        msngTaxTotal = 0
        msngGrand = 0

        'reset user input fields
        cboSite.Text = "Please Select a Site"
        txtNights.Clear()
        radNone.Checked = True
        cboSite.Focus()

    End Sub

    Private Sub Summarize()
        'Hides frmMain and loads frmSummary as dialogue

        Me.Hide()
        FormLibrary.NewfrmSummary.ShowDialog()
    End Sub

    Private Sub COB()
        'Hides frmMain and loads frmCOB as dialogue

        Me.Hide()
        FormLibrary.NewfrmCOB.ShowDialog()

    End Sub
#End Region

#Region "Function procedures"
    Private Function FindDiscount() As Single
        'Declares discount variables, tests if radio button is selected and sets 
        'mstrDiscount with appropriate discount information (None, AAA, or Military) 
        'then determines and returns the amount to be subtracted from the Bill to 
        'find the subtotal

        'declare local variables
        Dim sngDiscountRate As Single
        Dim sngDiscountAmount As Single


        'determine radio button selection and apply correct discount information
        If radNone.Checked Then
            sngDiscountRate = 0
            mstrDiscount = "None"
        Else
            If radAAA.Checked Then
                sngDiscountRate = 0.1
                mstrDiscount = "AAA - 10%"
            Else
                sngDiscountRate = 0.12
                mstrDiscount = "Military - 12%"
            End If
        End If

        'determine discount amoutn to remove from bill
        sngDiscountAmount = (msngBill * sngDiscountRate)
        Return sngDiscountAmount

    End Function

    Private Function FindSubtotal(ByVal sngDiscountAmount As Single) As Single

        'Receives the Discount Amount the determines and returns the subtotal amount (Bill - Discount)
        Dim sngSubTotal As Single
        sngSubTotal = msngBill - sngDiscountAmount
        Return sngSubTotal

    End Function

    Private Function FindTax() As Single
        'Declares csngTaxRate constant, then determines and returns the tax rate 
        'to be added to the subtotal to find the grand total

        ' declare contsant
        Const csngTaxRate As Single = 0.075

        'determine and return tax amount
        Dim sngTax As Single
        sngTax = msngSubtotal * csngTaxRate
        Return sngTax
    End Function

    Private Function FindGrand() As Single
        'determines and returns Grand Total (subtotal + taxtotal)
        Dim sngGrand As Single
        sngGrand = (msngSubtotal + msngTaxTotal)
        Return sngGrand

    End Function
#End Region

#Region "Properties"
    Public ReadOnly Property SiteOut() As String
        'Returns type of site selected (called from Summary)

        Get
            Return mstrSiteSelection
        End Get
    End Property

    Public ReadOnly Property DiscountOut() As String
        'Returns the Discount Type and Value (called from Summary)
        Get
            Return mstrDiscount
        End Get
    End Property

    Public ReadOnly Property NumNightsOut() As Integer
        ' Returns number of nights selected (called from Summary)

        Get
            Return mintNumNights
        End Get
    End Property

    Public ReadOnly Property BillOut() As Single
        ' Returns total billed amount (called from Summary)

        Get
            Return msngBill
        End Get
    End Property

    Public ReadOnly Property SubtotalOut() As Single
        'Returns Subtotal amount (called from Summary)

        Get
            Return msngSubtotal
        End Get

    End Property

    Public ReadOnly Property TaxTotalOut() As Single
        '   Returns total tax amount (called from Summary)

        Get
            Return msngTaxTotal
        End Get
    End Property

    Public ReadOnly Property GrandOut() As Single
        'Returns Grand Total Amount (called from Summary)

        Get
            Return msngGrand
        End Get
    End Property

    Public ReadOnly Property TransCount() As Integer
        'returns transaction count for the day (called from COB)

        Get
            Return mintTransCount
        End Get
    End Property

    Public ReadOnly Property DailyTotal() As Double
        'Returns the daily accumulated total for all tendered transactions (called from COB)
        Get
            Return mdblDailyTotal
        End Get
    End Property
    Public Property Tender() As Boolean
        'Sets the value of mblnTender as True (called from Summary)
        Get
            Return mblnTender
        End Get
        Set(ByVal value As Boolean)
            mblnTender = True
        End Set
    End Property
#End Region

End Class
