Public Class Form1
    Dim pid As Integer
    Public Declare Function IsWindowVisible Lib "user32" (ByVal hwnd As IntPtr) As Boolean
    Private Declare Function BringWindowToTop Lib "user32" (ByVal hwnd As IntPtr) As Boolean
    Dim buttone As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AppActivate(pid)
        My.Computer.Keyboard.SendKeys(TextBox1.Text, True)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Label1.Text = ListBox1.SelectedItem.ToString()
        pid = Convert.ToInt32(Label1.Text)
        buttone = buttone + 1
        If buttone > 2 Then
            Button1.Enabled = True
        End If

    End Sub


    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        MsgBox("Selecting Minecraft Setup Could Cause Crashes", MsgBoxStyle.Exclamation)
        buttone = buttone + 1
        For Each p As Process In Process.GetProcesses
            If Not IsWindowVisible(p.MainWindowHandle) Then Continue For
            ListBox1.Items.Add(p.Id.ToString())
            ListBox2.Items.Add(p.ProcessName) ' Just an example - You would want to add this to your program's window list.
            BringWindowToTop(p.MainWindowHandle) ' This will bring the process's window to the top.
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Output.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox1.AppendText(Output.TxtBoxHealth.Text)
        TextBox1.AppendText(Output.TxtBoxTeams.Text)
        TextBox1.AppendText(Output.TxtBoxColor.Text)
        TextBox1.AppendText(Output.TxtBoxPlayers.Text)
        buttone = buttone + 1
        If buttone > 2 Then
            Button1.Enabled = True
        End If
        CheckBox1.Enabled = False
        CheckBox1.Visible = False
        Button6.Visible = True
        Button6.Enabled = True

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Clear()

        TextBox1.AppendText(Output.TxtBoxHealth.Text)
        TextBox1.AppendText(Output.TxtBoxTeams.Text)
        TextBox1.AppendText(Output.TxtBoxColor.Text)
        TextBox1.AppendText(Output.TxtBoxPlayers.Text)
    End Sub

End Class
