<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIMAXTheatre
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFinalTicketPrice = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.txtNumberOfTickets = New System.Windows.Forms.TextBox()
        Me.lblNumberOfTickets = New System.Windows.Forms.Label()
        Me.cboTypeOfTickets = New System.Windows.Forms.ComboBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picIMAXTheatre = New System.Windows.Forms.PictureBox()
        CType(Me.picIMAXTheatre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFinalTicketPrice
        '
        Me.lblFinalTicketPrice.AutoSize = True
        Me.lblFinalTicketPrice.BackColor = System.Drawing.SystemColors.Window
        Me.lblFinalTicketPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalTicketPrice.Location = New System.Drawing.Point(374, 352)
        Me.lblFinalTicketPrice.Name = "lblFinalTicketPrice"
        Me.lblFinalTicketPrice.Size = New System.Drawing.Size(272, 16)
        Me.lblFinalTicketPrice.TabIndex = 23
        Me.lblFinalTicketPrice.Text = "The total cost of the tickets are $XX.XX"
        Me.lblFinalTicketPrice.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(429, 278)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(145, 40)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCost.Location = New System.Drawing.Point(429, 233)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(145, 42)
        Me.btnCost.TabIndex = 21
        Me.btnCost.Text = "Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        Me.btnCost.Visible = False
        '
        'txtNumberOfTickets
        '
        Me.txtNumberOfTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfTickets.Location = New System.Drawing.Point(480, 177)
        Me.txtNumberOfTickets.Name = "txtNumberOfTickets"
        Me.txtNumberOfTickets.Size = New System.Drawing.Size(35, 29)
        Me.txtNumberOfTickets.TabIndex = 20
        Me.txtNumberOfTickets.Visible = False
        '
        'lblNumberOfTickets
        '
        Me.lblNumberOfTickets.AutoSize = True
        Me.lblNumberOfTickets.BackColor = System.Drawing.SystemColors.Window
        Me.lblNumberOfTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfTickets.Location = New System.Drawing.Point(411, 121)
        Me.lblNumberOfTickets.Name = "lblNumberOfTickets"
        Me.lblNumberOfTickets.Size = New System.Drawing.Size(186, 24)
        Me.lblNumberOfTickets.TabIndex = 19
        Me.lblNumberOfTickets.Text = "Number of Tickets:"
        Me.lblNumberOfTickets.Visible = False
        '
        'cboTypeOfTickets
        '
        Me.cboTypeOfTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTypeOfTickets.FormattingEnabled = True
        Me.cboTypeOfTickets.Items.AddRange(New Object() {"Matinee ($16)", "Evening ($17)"})
        Me.cboTypeOfTickets.Location = New System.Drawing.Point(442, 75)
        Me.cboTypeOfTickets.Name = "cboTypeOfTickets"
        Me.cboTypeOfTickets.Size = New System.Drawing.Size(121, 23)
        Me.cboTypeOfTickets.TabIndex = 18
        Me.cboTypeOfTickets.Text = "Select"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHeading.Location = New System.Drawing.Point(372, 25)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(265, 29)
        Me.lblHeading.TabIndex = 17
        Me.lblHeading.Text = "IMAX Theatre Tickets"
        '
        'picIMAXTheatre
        '
        Me.picIMAXTheatre.Image = Global.IMAX_Theatre.My.Resources.Resources.imax
        Me.picIMAXTheatre.Location = New System.Drawing.Point(-4, -3)
        Me.picIMAXTheatre.Name = "picIMAXTheatre"
        Me.picIMAXTheatre.Size = New System.Drawing.Size(680, 407)
        Me.picIMAXTheatre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIMAXTheatre.TabIndex = 16
        Me.picIMAXTheatre.TabStop = False
        '
        'frmIMAXTheatre
        '
        Me.AcceptButton = Me.btnCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 400)
        Me.Controls.Add(Me.lblFinalTicketPrice)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.txtNumberOfTickets)
        Me.Controls.Add(Me.lblNumberOfTickets)
        Me.Controls.Add(Me.cboTypeOfTickets)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picIMAXTheatre)
        Me.Name = "frmIMAXTheatre"
        Me.Text = "IMAX Theatre"
        CType(Me.picIMAXTheatre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFinalTicketPrice As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCost As Button
    Friend WithEvents txtNumberOfTickets As TextBox
    Friend WithEvents lblNumberOfTickets As Label
    Friend WithEvents cboTypeOfTickets As ComboBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents picIMAXTheatre As PictureBox
End Class
