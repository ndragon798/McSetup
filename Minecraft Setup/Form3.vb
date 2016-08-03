Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Output.TxtBoxHealth.AppendText("scoreboard objectives add Healthside health Health" & Environment.NewLine)
        Output.TxtBoxHealth.AppendText("scoreboard objectives setdisplay sidebar Healthside" & Environment.NewLine)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Output.TxtBoxHealth.AppendText("scoreboard objectives add Healthside health Health" & Environment.NewLine)
        Output.TxtBoxHealth.AppendText("scoreboard objectives setdisplay list Healthside" & Environment.NewLine)
    End Sub
End Class