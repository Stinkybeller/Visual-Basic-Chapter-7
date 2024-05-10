<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTypeOfCommute
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
        Me.cboTypeOfCommute = New System.Windows.Forms.ComboBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.txtWorkDaysPerMonth = New System.Windows.Forms.TextBox()
        Me.txtRoundCost = New System.Windows.Forms.TextBox()
        Me.lblWorkDaysPerMonth = New System.Windows.Forms.Label()
        Me.lblCostPerMonth = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboTypeOfCommute
        '
        Me.cboTypeOfCommute.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTypeOfCommute.FormattingEnabled = True
        Me.cboTypeOfCommute.Items.AddRange(New Object() {"Uber", "Subway", "Bus"})
        Me.cboTypeOfCommute.Location = New System.Drawing.Point(255, 69)
        Me.cboTypeOfCommute.Name = "cboTypeOfCommute"
        Me.cboTypeOfCommute.Size = New System.Drawing.Size(178, 31)
        Me.cboTypeOfCommute.TabIndex = 0
        Me.cboTypeOfCommute.Text = "Select transportation type:"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(185, 19)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(309, 37)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Uber, Subway, or Bus Commute"
        '
        'txtWorkDaysPerMonth
        '
        Me.txtWorkDaysPerMonth.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkDaysPerMonth.Location = New System.Drawing.Point(383, 138)
        Me.txtWorkDaysPerMonth.Name = "txtWorkDaysPerMonth"
        Me.txtWorkDaysPerMonth.Size = New System.Drawing.Size(100, 37)
        Me.txtWorkDaysPerMonth.TabIndex = 3
        Me.txtWorkDaysPerMonth.Visible = False
        '
        'txtRoundCost
        '
        Me.txtRoundCost.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoundCost.Location = New System.Drawing.Point(382, 227)
        Me.txtRoundCost.Name = "txtRoundCost"
        Me.txtRoundCost.Size = New System.Drawing.Size(100, 37)
        Me.txtRoundCost.TabIndex = 4
        Me.txtRoundCost.Visible = False
        '
        'lblWorkDaysPerMonth
        '
        Me.lblWorkDaysPerMonth.AutoSize = True
        Me.lblWorkDaysPerMonth.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkDaysPerMonth.Location = New System.Drawing.Point(149, 141)
        Me.lblWorkDaysPerMonth.Name = "lblWorkDaysPerMonth"
        Me.lblWorkDaysPerMonth.Size = New System.Drawing.Size(200, 34)
        Me.lblWorkDaysPerMonth.TabIndex = 5
        Me.lblWorkDaysPerMonth.Text = "Work days per month:"
        Me.lblWorkDaysPerMonth.Visible = False
        '
        'lblCostPerMonth
        '
        Me.lblCostPerMonth.AutoSize = True
        Me.lblCostPerMonth.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerMonth.Location = New System.Drawing.Point(102, 227)
        Me.lblCostPerMonth.Name = "lblCostPerMonth"
        Me.lblCostPerMonth.Size = New System.Drawing.Size(247, 34)
        Me.lblCostPerMonth.TabIndex = 6
        Me.lblCostPerMonth.Text = "Rounded cost for commute:"
        Me.lblCostPerMonth.Visible = False
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(133, 299)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(22, 29)
        Me.lblDisplay.TabIndex = 7
        Me.lblDisplay.Text = "..."
        Me.lblDisplay.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(210, 357)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(85, 33)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        Me.btnCalculate.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(358, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 33)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'frmTypeOfCommute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.Uber__Subway__or_Bus_Commute.My.Resources.Resources.car
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(643, 419)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblCostPerMonth)
        Me.Controls.Add(Me.lblWorkDaysPerMonth)
        Me.Controls.Add(Me.txtRoundCost)
        Me.Controls.Add(Me.txtWorkDaysPerMonth)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.cboTypeOfCommute)
        Me.Name = "frmTypeOfCommute"
        Me.Text = "Uber, Subway, or Bus Commute"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboTypeOfCommute As ComboBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents txtWorkDaysPerMonth As TextBox
    Friend WithEvents txtRoundCost As TextBox
    Friend WithEvents lblWorkDaysPerMonth As Label
    Friend WithEvents lblCostPerMonth As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
