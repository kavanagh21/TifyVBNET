Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        outputbox.Items.Clear()
        outputbox.Items.Add("Image count: " & imgCount)
        If imgCount = 0 Then
            outputbox.Items.Add("No statistics in memory.")
            Exit Sub
        End If
        outputbox.Items.Add("Included: " & imgIncluded.Count(Function(f) f = True))
        outputbox.Items.Add("Min user score: " & imgScore.Min)
        outputbox.Items.Add("Max user score: " & imgScore.Max)
        outputbox.Items.Add("Min calc score: " & calcScore.Min)
        outputbox.Items.Add("Max calc score: " & calcScore.Max)

    End Sub
End Class