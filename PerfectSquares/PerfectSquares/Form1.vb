Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        Dim numSq As Integer

        numSq = 1
        Do While (numSq <= 10)
            numSq = numSq + 1

            lstResult.Items.Add("Number is " & numSq ^ 2)

        Loop
       

    End Sub
End Class
