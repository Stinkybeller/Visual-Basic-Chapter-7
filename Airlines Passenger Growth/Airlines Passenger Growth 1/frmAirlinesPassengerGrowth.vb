'Program Name: Airlines Passenger Growth'
'Developer: Izabella Fortunata'
'Date: 3/19/24'
'Purpose: Calculates and displays the next 10 years of growth of an airline'
Public Class frmAirlinesPassengerGrowth
    Private Sub frmAirlinesPassengerGrowth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Splash screen displays for 5 seconds'
        Threading.Thread.Sleep(5000)

        'Calls function for list box'
        prcListBoxProjections()
    End Sub

    Private Sub cboAirlines_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAirlines.SelectedIndexChanged
        'Allows user to select year'
        Dim intYearChoiceIndex As Integer
        intYearChoiceIndex = cboAirlines.SelectedIndex

        'Makes the display button visible'
        btnDisplay.Visible = True
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Projection for year'
        Dim decFinalCalc As Decimal
        Dim blnYearSelection As Boolean
        Dim intYearChoice As Integer
        Dim intYearChoiceIndex As Integer

        'Calls function'
        blnYearSelection = prcValidateYearChoice()

        If (blnYearSelection) Then
            intYearChoice = Convert.ToInt32(cboAirlines.Text)
            intYearChoiceIndex = cboAirlines.SelectedIndex

            'Display'
            decFinalCalc = prcCalculateProjections(intYearChoice)
            lblFinalCalc.Visible = True
            lblFinalCalc.Text = decFinalCalc.ToString("N1") + " Passengers estimated for " + intYearChoice.ToString + "."
        End If
    End Sub

    Private Function prcValidateYearChoice() As Boolean
        'Validates user selection'
        Dim intYearChoiceIndex As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strYearChoiceMessage As String = "Please choose a year."
        Dim strMsgBoxTitle As String = "Error!"

        Try
            intYearChoiceIndex = Convert.ToInt32(cboAirlines.SelectedIndex)
            If (intYearChoiceIndex >= 0) Then
                blnValidityCheck = True
            Else
                MsgBox(strYearChoiceMessage,, strMsgBoxTitle)
            End If

        Catch Exception As SystemException
            MsgBox(strYearChoiceMessage,, strMsgBoxTitle)
        End Try

        Return blnValidityCheck
    End Function

    Private Function prcCalculateProjections(ByVal intYearChoice As Integer) As Decimal
        ' function calculates the projection of airline growth based on user choice
        Const decPercentGrowth As Decimal = 0.069D
        Dim decNumber As Decimal = 3.8D
        Dim intPivotYear As Integer = 2017
        Dim intBillion As Integer = 1000000000
        Dim decFinalCalc As Decimal
        Dim intDifference As Integer
        Dim intCounter As Integer

        intDifference = Math.Abs(intPivotYear - intYearChoice)
        'For loop to calculate'
        For intCounter = 1 To intDifference
            decNumber += (decPercentGrowth * decNumber)
        Next

        'Calculation'
        decFinalCalc = decNumber * intBillion
        Return decFinalCalc
    End Function

    Private Function prcListBoxProjections() As Decimal
        'Calculates the projection of airline growth for 10 years'
        Const decPercentGrowth As Decimal = 0.069D
        Dim decNumber As Decimal = 3.8
        Dim intCounter As Integer

        For intCounter = 1 To 10
            decNumber += (decPercentGrowth * decNumber)
            lstAirlines.Items.Add(decNumber.ToString("N") + " billion.")
        Next
        Return decNumber
    End Function

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Clears and rehides'
        cboAirlines.Text = "Select Year"
        lblFinalCalc.Text = ""
        btnDisplay.Visible = False
        lblFinalCalc.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes program'
        Close()
    End Sub
End Class

