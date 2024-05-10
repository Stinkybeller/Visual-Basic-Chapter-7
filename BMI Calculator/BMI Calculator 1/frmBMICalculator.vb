'Program Name: BMI Calculator'
'Developer: Izabella Fortunata'
'Date: 3/11/2024'
'Purpose: Computes the users BMI'
Public Class frmBMICalculator
    'Declare variables'
    Private decImperial As Decimal
    Private decMetric As Decimal
    Private intTypeOfMeasurement As Integer
    Private Sub frmBMICalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Pause splash screen for 2 seconds'
        Threading.Thread.Sleep(2000)
    End Sub
    Private Sub lstSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSelection.SelectedIndexChanged
        'User to select type of measurement and shows the rest of the form'

        Dim intSystemChoice As Integer

        intSystemChoice = lstSelection.SelectedIndex

        If (intSystemChoice = 0) Then

            lblWeight.Text = "Weight (kg): "
            lblHeight.Text = "Height (m): "
            txtHeight.Clear()
            txtWeight.Clear()
            txtWeight.Focus()
        ElseIf (intSystemChoice = 1) Then

            lblWeight.Text = "Weight (lbs): "
            lblHeight.Text = "Height (in): "
            txtHeight.Clear()
            txtWeight.Clear()
            txtWeight.Focus()
        End If

        'Objects visible'
        lblHeight.Visible = True
        lblWeight.Visible = True
        txtHeight.Visible = True
        txtWeight.Visible = True
        btnCalculate.Visible = True
        btnClear.Visible = True
        txtWeight.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Calculates the bmi of the user in desired system'
        Dim decWeight As Decimal
        Dim decHeight As Decimal
        Dim blnWeightValid As Boolean = False
        Dim blnHeightValid As Boolean = False
        Dim blnSystemChoiceValid As Boolean = False
        Dim intSystemChoice As Integer
        Dim strSystemChoice As String = ""
        Dim decFinalCalc As Decimal
        Dim strResult As String

        'Validates input for weight textbox'
        blnWeightValid = prcValidateWeight()

        'Validates input for height textbox'
        blnHeightValid = prcValidateHeight()

        If (blnWeightValid And blnHeightValid) Then

            decWeight = Convert.ToDecimal(txtWeight.Text)
            decHeight = Convert.ToDecimal(txtHeight.Text)
            intSystemChoice = lstSelection.SelectedIndex

            Select Case intSystemChoice
                Case 0
                    decFinalCalc = prcMetric(decWeight, decHeight)
                Case 1
                    decFinalCalc = prcImperial(decWeight, decHeight)
            End Select
            'Display BMI'
            lblCalcBMI.Visible = True
            strResult = prcFinalResult(decFinalCalc)
            lblCalcBMI.Text = "Your BMI score is " + decFinalCalc.ToString("F2") + ", You are " + strResult.ToString + "."
        End If
    End Sub
    Private Function prcValidateWeight() As Boolean
        'Validates value entered for weight'
        Dim decWeight As Decimal
        Dim blnValidityCheck As Boolean = False
        Dim strWeightMessage As String = "Enter a positive number for weight."
        Dim strMsgBoxTitle As String = "Error"

        Try
            decWeight = Convert.ToDecimal(txtWeight.Text)
            If (decWeight >= 0) Then
                blnValidityCheck = True
            Else
                MsgBox(strWeightMessage,, strMsgBoxTitle)
                txtWeight.Focus()
                txtWeight.Clear()
            End If

        Catch Exception As FormatException
            MsgBox(strWeightMessage,, strMsgBoxTitle)
            txtWeight.Focus()
            txtWeight.Clear()

        Catch Exception As OverflowException
            MsgBox(strWeightMessage,, strMsgBoxTitle)
            txtWeight.Focus()
            txtWeight.Clear()

        Catch Exception As SystemException
            MsgBox(strWeightMessage,, strMsgBoxTitle)
            txtWeight.Focus()
            txtWeight.Clear()

        End Try
        Return blnValidityCheck
    End Function
    Private Function prcValidateHeight() As Boolean
        'Validates value entered for height'
        Dim decHeight As Decimal
        Dim blnValidityCheck1 As Boolean = False
        Dim strHeightMessage As String = "Enter a positive number for height."
        Dim strMsgBoxTitle As String = "Error"

        Try
            decHeight = Convert.ToDecimal(txtHeight.Text)

            If (decHeight >= 0) Then
                blnValidityCheck1 = True
            Else
                MsgBox(strHeightMessage,, strMsgBoxTitle)
                txtHeight.Clear()
            End If

        Catch Exception As FormatException
            MsgBox(strHeightMessage,, strMsgBoxTitle)
            txtHeight.Clear()
        Catch Exception As OverflowException
            MsgBox(strHeightMessage,, strMsgBoxTitle)
            txtHeight.Clear()
        Catch Exception As SystemException
            MsgBox(strHeightMessage,, strMsgBoxTitle)
            txtHeight.Clear()

        End Try
        Return blnValidityCheck1
    End Function

    Private Function prcMetric(ByVal decWeight As Decimal, ByVal decHeight As Decimal)
        'Calculates on based on metric measurement'
        Dim decFinalCalc As Decimal

        decFinalCalc = decWeight / (decHeight * decHeight)

        Return decFinalCalc
    End Function

    Private Function prcImperial(ByVal decWeight As Decimal, ByVal decHeight As Decimal)
        'Calculates based on imperial measurement'
        Dim decFinalCalc As Decimal
        decFinalCalc = (decWeight / (decHeight * decHeight)) * 703
        Return decFinalCalc

    End Function
    Private Function prcFinalResult(ByVal decFinalCalculation As Decimal) As String

        Dim strResult As String = ""
        Select Case decFinalCalculation
            Case 1 To 18.5
                strResult = "Underweight"
                'MsgBox("underweight")

            Case 18.5 To 24.99
                strResult = "a Healthy weight"
                'MsgBox("healthy weight")

            Case 25 To 29.99
                strResult = "Overweight"
                'MsgBox("overweight")

            Case 30 To 50000
                strResult = "Obese"
                'MsgBox("obese")
        End Select
        Return strResult
    End Function
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears everything and hides form'
        txtWeight.Clear()
        txtHeight.Clear()
        lblCalcBMI.Text = ""
        lblWeight.Visible = False
        lblHeight.Visible = False
        txtWeight.Visible = False
        txtHeight.Visible = False
        lblCalcBMI.Visible = False

        btnCalculate.Visible = False
        btnClear.Visible = False

    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes program'
        Close()
    End Sub
End Class
