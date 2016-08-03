Public Class FormColor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim asdf As Integer = Form2.tsa - 1
        Output.TxtBoxColor.AppendText("scoreboard teams option Team" & asdf & " color " & ComboBox1.SelectedItem & Environment.NewLine)
        Me.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class