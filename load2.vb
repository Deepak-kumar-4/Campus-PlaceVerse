Public Class load2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2ProgressBar1.Increment(1)
        Dim Per As String
        Per = Convert.ToString(Guna2ProgressBar1.Value)
        Label2.Text = Per + "%"
        If Guna2ProgressBar1.Value = 100 Then
            Me.Hide()
            Dim Obj = New login
            Obj.Show()
            Timer1.Enabled = False
        ElseIf Guna2ProgressBar1.Value < 25 Then
            Label1.Text = "Loading Forms.."
        ElseIf Guna2ProgressBar1.Value < 50 Then
            Label1.Text = "Preparing Database.."
        ElseIf Guna2ProgressBar1.Value < 75 Then
            Label1.Text = "Almost Ready.."
        Else
            Label1.Text = "Launching a Campus Placeverse.."
        End If
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub
End Class