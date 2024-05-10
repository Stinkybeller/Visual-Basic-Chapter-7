'Program Name: Uber, Subway, or Bus commute
'Developer: Izabella Fortunata'
'Date: 3/22/2024'
'Purpose: Computes the cost of a yearly commute price, f the user is taking an uber, subway or bus.'

Public Class frmTypeOfCommute
    Private Sub frmTypeOfCommute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Pause splash screen for 2 seconds'
        Threading.Thread.Sleep(2000)
    End Sub

    Private Sub cboSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTypeOfCommute.SelectedIndexChanged
        'Allows the user to select the type of commute'
        Dim intTypeOfCommute

        intTypeOfCommute = cboTypeOfCommute.SelectedIndex

        Select Case intTypeOfCommute
            Case 0
                'Makes Objects Visible, when selected certain cbo item'
                lblHeading.Visible = True
                lblWorkDaysPerMonth.Visible = True
                lblCostPerMonth.Visible = True
                txtWorkDaysPerMonth.Visible = True
                txtRoundCost.Visible = True
                btnCalculate.Visible = True
                btnClear.Visible = True
                lblDisplay.Text = ""
            Case 1
                'Makes Objects Visible, when selected certain cbo item'
                lblHeading.Visible = True
                lblWorkDaysPerMonth.Visible = True
                lblCostPerMonth.Visible = True
                txtWorkDaysPerMonth.Visible = True
                txtRoundCost.Visible = True
                btnCalculate.Visible = True
                btnClear.Visible = True
                lblDisplay.Text = ""
            Case 2
                'Makes Objects Visible, when selected certain cbo item'
                lblHeading.Visible = True
                lblWorkDaysPerMonth.Visible = True
                lblCostPerMonth.Visible = True
                txtWorkDaysPerMonth.Visible = True
                txtRoundCost.Visible = True
                btnCalculate.Visible = True
                btnClear.Visible = True
                lblDisplay.Text = ""
        End Select
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intDaysWorked As Integer
        Dim intRoundCost As Integer
        Dim blnDaysWorkedValid As Boolean = False
        Dim blnRoundCostValid As Boolean = False
        Dim intTypeOfCommute As Integer
        Dim decFinalCalc As Decimal

        'Validates input for days worked textbox'
        blnDaysWorkedValid = prcValidateDaysWorked()

        'Validates input for the round cost textbox'
        blnRoundCostValid = prcValidateRoundCost()

        If (blnDaysWorkedValid And blnRoundCostValid) Then
            intTypeOfCommute = cboTypeOfCommute.SelectedIndex
            intDaysWorked = Convert.ToInt32(txtWorkDaysPerMonth.Text)
            intRoundCost = Convert.ToDecimal(txtRoundCost.Text)

            Select Case intTypeOfCommute
                Case 0
                    decFinalCalc = prcUber(intDaysWorked, intRoundCost)
                Case 1
                    decFinalCalc = prcSubway(intDaysWorked, intRoundCost)
                Case 2
                    decFinalCalc = prcBus(intDaysWorked, intRoundCost)
            End Select
            'Display final cost'
            lblDisplay.Visible = True
            lblDisplay.Text = "Your total cost for one year of commuting is " + decFinalCalc.ToString("C")
        End If
    End Sub

    Private Function prcValidateDaysWorked() As Boolean
        'Validates values in days worked per month'
        Dim intDaysWorked As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strDaysWorkedMessage As String = "Please enter a number for the number of days worked."
        Dim strMsgBoxTitle As String = "Error!"

        Try
            intDaysWorked = Convert.ToInt32(txtWorkDaysPerMonth.Text)
            If (intDaysWorked > 0) Then
                blnValidityCheck = True
            Else
                MsgBox(strDaysWorkedMessage,, strMsgBoxTitle)
                txtWorkDaysPerMonth.Focus()
                txtWorkDaysPerMonth.Clear()
            End If

        Catch ex As Exception
            MsgBox(strDaysWorkedMessage,, strMsgBoxTitle)
            txtWorkDaysPerMonth.Focus()
            txtWorkDaysPerMonth.Clear()
        End Try
        Return blnValidityCheck
    End Function

    Private Function prcValidateRoundCost() As Boolean
        'Validates values in days worked per month'
        Dim intRoundCost
        Dim blnValidityCheck As Boolean = False
        Dim strDaysWorkedMessage As String = "Please enter a number for the number of days worked."
        Dim strMsgBoxTitle As String = "Error!"

        Try
            intRoundCost = Convert.ToInt32(txtWorkDaysPerMonth.Text)
            If (intRoundCost > 0) Then
                blnValidityCheck = True
            Else
                MsgBox(strDaysWorkedMessage,, strMsgBoxTitle)
                txtWorkDaysPerMonth.Focus()
                txtWorkDaysPerMonth.Clear()
            End If

        Catch ex As Exception
            MsgBox(strDaysWorkedMessage,, strMsgBoxTitle)
            txtWorkDaysPerMonth.Focus()
            txtWorkDaysPerMonth.Clear()
        End Try
        Return blnValidityCheck
    End Function

    Private Function prcUber(ByVal intDaysWorked As Integer, ByVal intRouteCost As Decimal)
        'Calculates based the ubers cost'
        Dim decFinalCalc As Decimal
        Dim decDaysCalc As Integer

        decDaysCalc = intDaysWorked * 12
        decFinalCalc = 1.2 * (intRouteCost * decDaysCalc)

        Return decFinalCalc
    End Function

    Private Function prcSubway(ByVal intDaysWorked As Decimal, ByVal intRouteCost As Decimal)
        'Calculates based the subway cost'
        Dim decFinalCalc
        Dim decDaysCalc

        decDaysCalc = intDaysWorked * 12
        decFinalCalc = decDaysCalc * intRouteCost

        Return decFinalCalc
    End Function

    Private Function prcBus(ByVal intDaysWorked As Decimal, ByVal intRouteCost As Decimal)
        'Calculates based the bus cost'
        Dim decFinalCalc
        Dim decDaysCalc

        decDaysCalc = intDaysWorked * 12
        decFinalCalc = decDaysCalc * intRouteCost

        Return decFinalCalc
    End Function
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the form'
        lblWorkDaysPerMonth.Visible = False
        lblCostPerMonth.Visible = False
        txtWorkDaysPerMonth.Visible = False
        txtRoundCost.Visible = False
        btnCalculate.Visible = False
        btnClear.Visible = False
        lblDisplay.Text = ""
    End Sub
End Class
