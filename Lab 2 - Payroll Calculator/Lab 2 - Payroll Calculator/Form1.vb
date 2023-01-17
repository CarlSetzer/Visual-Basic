Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcGrossPay.Click
        Dim dblHoursWorked, dblPayRate, dblGrossPay As Double 'Refer to Section 3.2


        dblHoursWorked = CDbl(txtHoursWorked.Text) 'CDbl() is a function which converts a string to double (numberic value). Please refer to section 3.4

        dblPayRate = CDbl(txtPayRate.Text)
        dblGrossPay = dblHoursWorked * dblPayRate 'Only number values can be used for calculation. Strings cannot be used for calculations. 

        lblGrossPay.Text = dblGrossPay.ToString("c") 'Converts a number value to a string and displays it by using a lable control




    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() 'Closes the current form
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtHoursWorked.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtPayRate.TextChanged

    End Sub
End Class
