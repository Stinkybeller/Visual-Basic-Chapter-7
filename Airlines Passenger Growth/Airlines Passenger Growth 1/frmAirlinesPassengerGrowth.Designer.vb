<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirlinesPassengerGrowth
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.cboAirlines = New System.Windows.Forms.ComboBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblFinalCalc = New System.Windows.Forms.Label()
        Me.lstAirlines = New System.Windows.Forms.ListBox()
        Me.mnuAirlines = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAirlines.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("PMingLiU-ExtB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(101, 45)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(396, 35)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Airlines Passenger Growth"
        '
        'cboAirlines
        '
        Me.cboAirlines.Font = New System.Drawing.Font("PMingLiU-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAirlines.FormattingEnabled = True
        Me.cboAirlines.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027"})
        Me.cboAirlines.Location = New System.Drawing.Point(69, 117)
        Me.cboAirlines.Name = "cboAirlines"
        Me.cboAirlines.Size = New System.Drawing.Size(125, 29)
        Me.cboAirlines.TabIndex = 1
        Me.cboAirlines.Text = "Select Year"
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("PMingLiU-ExtB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(251, 117)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(88, 29)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lblFinalCalc
        '
        Me.lblFinalCalc.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblFinalCalc.Font = New System.Drawing.Font("PMingLiU-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCalc.ForeColor = System.Drawing.Color.Black
        Me.lblFinalCalc.Location = New System.Drawing.Point(65, 186)
        Me.lblFinalCalc.Name = "lblFinalCalc"
        Me.lblFinalCalc.Size = New System.Drawing.Size(280, 96)
        Me.lblFinalCalc.TabIndex = 6
        Me.lblFinalCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFinalCalc.Visible = False
        '
        'lstAirlines
        '
        Me.lstAirlines.Font = New System.Drawing.Font("PMingLiU-ExtB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAirlines.FormattingEnabled = True
        Me.lstAirlines.ItemHeight = 21
        Me.lstAirlines.Location = New System.Drawing.Point(381, 117)
        Me.lstAirlines.Name = "lstAirlines"
        Me.lstAirlines.Size = New System.Drawing.Size(137, 235)
        Me.lstAirlines.TabIndex = 7
        '
        'mnuAirlines
        '
        Me.mnuAirlines.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuAirlines.Location = New System.Drawing.Point(0, 0)
        Me.mnuAirlines.Name = "mnuAirlines"
        Me.mnuAirlines.Size = New System.Drawing.Size(595, 24)
        Me.mnuAirlines.TabIndex = 8
        Me.mnuAirlines.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmAirlinesPassengerGrowth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Airlines_Passenger_Growth_1.My.Resources.Resources.TAL_beond_interior_BEOND1023_a16f49a4854743ec813acce764106924
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(595, 393)
        Me.Controls.Add(Me.lstAirlines)
        Me.Controls.Add(Me.lblFinalCalc)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.cboAirlines)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.mnuAirlines)
        Me.MainMenuStrip = Me.mnuAirlines
        Me.Name = "frmAirlinesPassengerGrowth"
        Me.Text = "Airlines Passenger Growth"
        Me.mnuAirlines.ResumeLayout(False)
        Me.mnuAirlines.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents cboAirlines As ComboBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lblFinalCalc As Label
    Friend WithEvents lstAirlines As ListBox
    Friend WithEvents mnuAirlines As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
