<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScuba
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
        Me.pnlScuba = New System.Windows.Forms.Panel()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.cboComboBox = New System.Windows.Forms.ComboBox()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.txtTeam = New System.Windows.Forms.TextBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.pnlScuba.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlScuba
        '
        Me.pnlScuba.BackColor = System.Drawing.Color.Transparent
        Me.pnlScuba.Controls.Add(Me.lblSelect)
        Me.pnlScuba.Controls.Add(Me.txtTeam)
        Me.pnlScuba.Controls.Add(Me.lblTeam)
        Me.pnlScuba.Controls.Add(Me.cboComboBox)
        Me.pnlScuba.Controls.Add(Me.lblHeading)
        Me.pnlScuba.Location = New System.Drawing.Point(443, 0)
        Me.pnlScuba.Name = "pnlScuba"
        Me.pnlScuba.Size = New System.Drawing.Size(432, 480)
        Me.pnlScuba.TabIndex = 0
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(16, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(395, 32)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Oceanic Scuba Expeditions"
        '
        'cboComboBox
        '
        Me.cboComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComboBox.FormattingEnabled = True
        Me.cboComboBox.Location = New System.Drawing.Point(127, 53)
        Me.cboComboBox.Name = "cboComboBox"
        Me.cboComboBox.Size = New System.Drawing.Size(175, 32)
        Me.cboComboBox.TabIndex = 1
        Me.cboComboBox.Text = "Select Location:"
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.Location = New System.Drawing.Point(53, 106)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(200, 24)
        Me.lblTeam.TabIndex = 2
        Me.lblTeam.Text = "Number in Dive Team:"
        '
        'txtTeam
        '
        Me.txtTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeam.Location = New System.Drawing.Point(259, 104)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(79, 29)
        Me.txtTeam.TabIndex = 3
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(75, 161)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(163, 24)
        Me.lblSelect.TabIndex = 4
        Me.lblSelect.Text = "Select Scuba Dive"
        '
        'frmScuba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Scuba_Diving_Expeditions.My.Resources.Resources.scuba
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(876, 479)
        Me.Controls.Add(Me.pnlScuba)
        Me.Name = "frmScuba"
        Me.Text = "Scuba Diving Expeditions"
        Me.pnlScuba.ResumeLayout(False)
        Me.pnlScuba.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlScuba As Panel
    Friend WithEvents txtTeam As TextBox
    Friend WithEvents lblTeam As Label
    Friend WithEvents cboComboBox As ComboBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSelect As Label
End Class
