'Program Name: IMAX Theatre Tickets'
'Developer: Izabella Fortunata'
'Date: 3/7/2024'
'Purpose: Computes the cost of Matinee and Evening showings with the number of tickets.'

Public Class frmIMAXTheatre
    'Declare variables'
    Private intMantineePrice As Integer = 16
    Private intEveningPrice As Integer = 17
    Private decTotalCost As Decimal
    Private intTicketCost As Integer
    Private intNumberOfTickets As Integer

    Private Sub IMAXTheatre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Pause splash screen for 4 seconds'
        Threading.Thread.Sleep(4000)
    End Sub

    Private Sub cboTypeOfTickets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTypeOfTickets.SelectedIndexChanged
        'Allows the user to select type of showing'
        Dim intTypeOfTickets As Integer

        intTypeOfTickets = cboTypeOfTickets.SelectedIndex

        Select Case intTypeOfTickets
            Case 0
                'Makes the objects visible'
                lblNumberOfTickets.Visible = True
                txtNumberOfTickets.Visible = True
                btnCost.Visible = True
                btnClear.Visible = True

                lblFinalTicketPrice.Text = ""
            Case 1
                'Makes the objects visible'
                lblNumberOfTickets.Visible = True
                txtNumberOfTickets.Visible = True
                btnCost.Visible = True
                btnClear.Visible = True

                'Clears label'
                lblFinalTicketPrice.Text = ""
        End Select
    End Sub
    Private Function fncValidateNumberOfTickets() As Boolean
        'Validate the amount entered'
        Dim blnValidatyCheck As Boolean = False
        Dim strNumberOfTicketsMessage As String = "Enter a ticket amount between 1 - 99"
        Dim strMessageBoxTitle As String = "Error!"

        'If there is an invalid input, it will display the message box'
        Try
            intNumberOfTickets = Convert.ToInt32(txtNumberOfTickets.Text)
            If intNumberOfTickets > 0 And intNumberOfTickets < 100 Then
                blnValidatyCheck = True
            Else
                MsgBox(strNumberOfTicketsMessage,, strMessageBoxTitle)
                txtNumberOfTickets.Focus()
                txtNumberOfTickets.Clear()
                lblFinalTicketPrice.Visible = False
            End If
        Catch ex As FormatException
            MsgBox(strNumberOfTicketsMessage,, strMessageBoxTitle)
            txtNumberOfTickets.Focus()
            txtNumberOfTickets.Clear()
            lblFinalTicketPrice.Visible = False

        Catch ex As OverflowException
            MsgBox(strNumberOfTicketsMessage,, strMessageBoxTitle)
            txtNumberOfTickets.Focus()
            txtNumberOfTickets.Clear()
            lblFinalTicketPrice.Visible = False

        Catch ex As SystemException
            MsgBox(strNumberOfTicketsMessage,, strMessageBoxTitle)
            txtNumberOfTickets.Focus()
            txtNumberOfTickets.Clear()
            lblFinalTicketPrice.Visible = False
        End Try

        Return blnValidatyCheck
    End Function

    Private Function fncMatineeTicketPrice(ByVal intTypeOfTickets As Integer)
        'Calculates the cost for the Matinee movie, returns the value'
        Dim decCost As Decimal
        Dim decTotalCost As Decimal

        intTypeOfTickets = cboTypeOfTickets.SelectedIndex
        Select Case intTypeOfTickets
            Case 0
                decCost = intMantineePrice
            Case 1
                decCost = intEveningPrice
        End Select
        decTotalCost = decCost * intNumberOfTickets

        Return decTotalCost
    End Function
    Private Function fncEveningTicketPrice(ByVal intTypesOfTickets As Integer)
        'Calculates the cost for the Evening movie, returns the value'
        'Declare variables'
        Dim decCost As Decimal
        Dim decTotalCost As Decimal

        intTypesOfTickets = cboTypeOfTickets.SelectedIndex

        Select Case intTypesOfTickets
            Case 0
                decCost = intMantineePrice
            Case 1
                decCost = intEveningPrice
        End Select
        decTotalCost = decCost * intNumberOfTickets

        Return decTotalCost
    End Function
    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        'Calculate the cost of the tickets and display the final price'
        Dim intTypeOfTickets As Integer
        Dim blnNumberOfTicketsIsValid As Boolean = False
        Dim decTotalCost As Decimal

        'Call the function to validate the number of tickets that the user inputed'
        blnNumberOfTicketsIsValid = fncValidateNumberOfTickets()
        If blnNumberOfTicketsIsValid Then
            intNumberOfTickets = Convert.ToInt32(txtNumberOfTickets.Text)
            intTypeOfTickets = cboTypeOfTickets.SelectedIndex

            Select Case intTypeOfTickets
                Case 0
                    decTotalCost = fncMatineeTicketPrice(decTotalCost)
                Case 1
                    decTotalCost = fncEveningTicketPrice(decTotalCost)
            End Select
            'Displaying the final price'
            lblFinalTicketPrice.Visible = True
            lblFinalTicketPrice.Text = "The total cost of the tickets are " & decTotalCost.ToString("C")
        End If

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears out the form'
        txtNumberOfTickets.Clear()
        lblFinalTicketPrice.Text = ""

        lblFinalTicketPrice.Visible = False
        lblNumberOfTickets.Visible = False
        btnClear.Visible = False
        btnCost.Visible = False
        txtNumberOfTickets.Visible = False
    End Sub
End Class
