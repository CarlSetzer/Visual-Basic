Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblScore1 As Double
        Dim dblScore2 As Double
        Dim dblScore3 As Double
        Dim dblAverage As Double
        'Constants
        Const NUM_SCORES As Integer = 3
        Const dblHIGH_SCORE As Double = 95.0

        Try
            'Copy the TextBox scores into the variables
            dblScore1 = CDbl(txtScore1.Text)
            dblScore2 = CDbl(txtScore2.Text)
            dblScore3 = CDbl(txtScore3.Text)

            'Calculate the average score
            dblAverage = (dblScore1 + dblScore2 + dblScore3) / NUM_SCORES

            'Display the average score, rounded to 2 decimal places
            lblAverage.Text = dblAverage.ToString("n2")

            'If the score is high, give the studen prais. Otherwise, give some encouragement
            If dblAverage > dblHIGH_SCORE Then
                lblMessage.Text = "Congratulations! Great Job!"

            Else
                lblMessage.Text = "Keep Trying!"
            End If

            If dblAverage < 60 Then
                lblGrade.Text = "F"
            ElseIf dblAverage < 70 Then
                lblGrade.Text = "D"
            ElseIf dblAverage < 80 Then
                lblGrade.Text = "C"
            ElseIf dblAverage < 90 Then
                lblGrade.Text = "B"
            ElseIf dblAverage <= 100 Then
                lblGrade.Text = "A"
            Else
                lblGrade.Text = "Invalid Score"
            End If


        Catch ex As Exception
            'Display an error message
            lblMessage.Text = "Scores must be numeric"

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the contents of the TextBox Controls
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()


        'Clear the Text property of the lable controls used for displaying information 
        lblAverage.Text = String.Empty
        lblMessage.Text = String.Empty
        lblGrade.Text = String.Empty


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
