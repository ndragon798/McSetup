Public Class Form2
    Dim Tamount As Integer
    Dim Pteam As Integer
    Dim i As Integer

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        i = NumericUpDown1.Value

    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged

        If NumericUpDown2.Value > NumericUpDown1.Value Then
            NumericUpDown2.Value = 1
        End If
        Tamount = NumericUpDown2.Value


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.Items.Count < NumericUpDown1.Value Then
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Clear()
        Else
            NumericUpDown1.Value = NumericUpDown1.Value + 1
            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Clear()
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)

        Button2.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()



    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox1.Items.Count = 0 Then
            MsgBox("Please Enter In Some Players")
        Else
            Label5.Text = 1
            Dim tmount As Integer = 1
            Do Until ListBox1.Items.Count = 0
                Dim myRandom As New Random
                Dim gen As String
                Dim i As Integer = ListBox1.Items.Count
                Dim loopcount As Integer


                gen = ListBox1.Items.Item(myRandom.Next(i)).ToString()
                ListBox1.Items.Remove(gen)
                TextBox2.AppendText(gen)
                'Form1.TextBox1.AppendText("scoreboard teams join Team" & Label5.Text & " " & gen & Environment.NewLine)
                Output.TxtBoxPlayers.AppendText("scoreboard teams join Team" & Label5.Text & " " & gen & Environment.NewLine)
                TextBox2.AppendText(Environment.NewLine)
                loopcount += 1
                If NumericUpDown2.Value = loopcount Then
                    loopcount = 0
                    tmount = tmount + 1

                    TextBox2.AppendText(Environment.NewLine)
                    Label5.Text() = tmount
                End If
            Loop
        End If
        Button5.Enabled = True
    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        TextBox2.Clear()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Public tsa As Integer = 1
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim re As Integer
        'Form1.TextBox1.AppendText("scoreboard teams add Team" & tsa & Environment.NewLine)
        Output.TxtBoxTeams.AppendText("scoreboard teams add Team" & tsa & Environment.NewLine)

        tsa = tsa + 1
        Button4.Enabled = True
        re = MsgBox(Prompt:="Would you like to add a color to Team" & tsa - 1 & "?", Buttons:=vbYesNo)
        If re = vbYes Then
            FormColor.Show()
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs)

    End Sub
    Dim ta As Integer = 1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Do Until ta = tsa
            Output.TxtBoxTeams.AppendText("scoreboard teams option Team" & ta & " friendlyfire false " & Environment.NewLine)
            ta = ta + 1
        Loop

    End Sub
End Class