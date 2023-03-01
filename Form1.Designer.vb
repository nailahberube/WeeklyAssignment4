<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirBnBReservations
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
        Me.lblOrlandoAirBnB = New System.Windows.Forms.TextBox()
        Me.lblNumberofNights = New System.Windows.Forms.TextBox()
        Me.lblCostofStay = New System.Windows.Forms.TextBox()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.TextBox()
        Me.txtNumberofNights = New System.Windows.Forms.TextBox()
        Me.picAirBnB = New System.Windows.Forms.PictureBox()
        CType(Me.picAirBnB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOrlandoAirBnB
        '
        Me.lblOrlandoAirBnB.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblOrlandoAirBnB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblOrlandoAirBnB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblOrlandoAirBnB.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrlandoAirBnB.Location = New System.Drawing.Point(418, 30)
        Me.lblOrlandoAirBnB.Multiline = True
        Me.lblOrlandoAirBnB.Name = "lblOrlandoAirBnB"
        Me.lblOrlandoAirBnB.Size = New System.Drawing.Size(308, 73)
        Me.lblOrlandoAirBnB.TabIndex = 1
        Me.lblOrlandoAirBnB.Text = " Orlando AirBnB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Only $79.00 per night" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblOrlandoAirBnB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumberofNights
        '
        Me.lblNumberofNights.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblNumberofNights.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblNumberofNights.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberofNights.Location = New System.Drawing.Point(396, 147)
        Me.lblNumberofNights.Name = "lblNumberofNights"
        Me.lblNumberofNights.Size = New System.Drawing.Size(182, 25)
        Me.lblNumberofNights.TabIndex = 2
        Me.lblNumberofNights.Text = "Number of Nights:"
        '
        'lblCostofStay
        '
        Me.lblCostofStay.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblCostofStay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCostofStay.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostofStay.Location = New System.Drawing.Point(396, 231)
        Me.lblCostofStay.Name = "lblCostofStay"
        Me.lblCostofStay.Size = New System.Drawing.Size(133, 25)
        Me.lblCostofStay.TabIndex = 3
        Me.lblCostofStay.Text = "Cost of Stay:"
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.Location = New System.Drawing.Point(377, 338)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(131, 36)
        Me.btnDisplayCost.TabIndex = 4
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDisplayCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(529, 338)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 36)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(670, 338)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 36)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(615, 231)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(79, 25)
        Me.lblTotalCost.TabIndex = 9
        Me.lblTotalCost.Text = "$888.88"
        Me.lblTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumberofNights
        '
        Me.txtNumberofNights.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberofNights.Location = New System.Drawing.Point(615, 147)
        Me.txtNumberofNights.Name = "txtNumberofNights"
        Me.txtNumberofNights.Size = New System.Drawing.Size(42, 32)
        Me.txtNumberofNights.TabIndex = 10
        Me.txtNumberofNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picAirBnB
        '
        Me.picAirBnB.Image = Global.WeeklyAssignment4.My.Resources.Resources.airbnb
        Me.picAirBnB.Location = New System.Drawing.Point(0, 2)
        Me.picAirBnB.Name = "picAirBnB"
        Me.picAirBnB.Size = New System.Drawing.Size(371, 449)
        Me.picAirBnB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAirBnB.TabIndex = 11
        Me.picAirBnB.TabStop = False
        '
        'frmAirBnBReservations
        '
        Me.AcceptButton = Me.btnDisplayCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picAirBnB)
        Me.Controls.Add(Me.txtNumberofNights)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.lblCostofStay)
        Me.Controls.Add(Me.lblNumberofNights)
        Me.Controls.Add(Me.lblOrlandoAirBnB)
        Me.Name = "frmAirBnBReservations"
        Me.Text = "AirBnBReservations"
        CType(Me.picAirBnB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOrlandoAirBnB As TextBox
    Friend WithEvents lblNumberofNights As TextBox
    Friend WithEvents lblCostofStay As TextBox
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotalCost As TextBox
    Friend WithEvents txtNumberofNights As TextBox
    Friend WithEvents picAirBnB As PictureBox
End Class
