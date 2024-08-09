Public Class CirProg
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Prog.Value += 1
        Prog.Text = Prog.Value.ToString
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
        If Prog.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub CirProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Prog.Value = 0
        Me.Opacity = 0
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        Me.Close()
        login.Show()
    End Sub

    Private Sub l1_Click(sender As Object, e As EventArgs)
        If Me.Prog.Value = 10 Then
            Me.Text = "Loading form"
        ElseIf Me.Prog.Value = 20 Then
            Me.Text = "Preparing database"
        ElseIf Me.Prog.Value = 50 Then
            Me.Text = "Ready"
        ElseIf Me.Prog.Value = 70 Then
            Me.Text = "Launching Placeverse"
        End If
    End Sub
End Class