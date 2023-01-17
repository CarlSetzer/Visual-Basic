<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblGrossPayEarned = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.TxtPayRate = New System.Windows.Forms.TextBox()
        Me.btnCalcGrossPay = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Hours"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hourly Pay Rate"
        '
        'lblGrossPayEarned
        '
        Me.lblGrossPayEarned.AutoSize = True
        Me.lblGrossPayEarned.Location = New System.Drawing.Point(80, 187)
        Me.lblGrossPayEarned.Name = "lblGrossPayEarned"
        Me.lblGrossPayEarned.Size = New System.Drawing.Size(92, 13)
        Me.lblGrossPayEarned.TabIndex = 2
        Me.lblGrossPayEarned.Text = "Gross Pay Earned"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Location = New System.Drawing.Point(203, 187)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(34, 13)
        Me.lblGrossPay.TabIndex = 3
        Me.lblGrossPay.Text = "$0.00"
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(206, 111)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursWorked.TabIndex = 4
        '
        'TxtPayRate
        '
        Me.TxtPayRate.Location = New System.Drawing.Point(206, 156)
        Me.TxtPayRate.Name = "TxtPayRate"
        Me.TxtPayRate.Size = New System.Drawing.Size(100, 20)
        Me.TxtPayRate.TabIndex = 5
        '
        'btnCalcGrossPay
        '
        Me.btnCalcGrossPay.Location = New System.Drawing.Point(83, 242)
        Me.btnCalcGrossPay.Name = "btnCalcGrossPay"
        Me.btnCalcGrossPay.Size = New System.Drawing.Size(75, 37)
        Me.btnCalcGrossPay.TabIndex = 6
        Me.btnCalcGrossPay.Text = "Calculate Gross Pay"
        Me.btnCalcGrossPay.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(206, 242)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 37)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 396)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalcGrossPay)
        Me.Controls.Add(Me.TxtPayRate)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblGrossPayEarned)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Wage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblGrossPayEarned As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents txtHoursWorked As TextBox
    Friend WithEvents TxtPayRate As TextBox
    Friend WithEvents btnCalcGrossPay As Button
    Friend WithEvents btnClose As Button
End Class
