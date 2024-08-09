Imports System.Data.SqlClient

Public Class mock_result

    Public Property sid As String
    Public Property lb As String
    Public Property sc As String
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub mock_result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = lb
        If sc < 3 Then
            Label7.Text = "       Not Upto the Mark..  " & vbCrLf & vbCrLf & lb
        ElseIf sc < 7 Then
            Label7.Text = "        Prepare More.. " & vbCrLf & vbCrLf & lb
        Else
            Label7.Text = "         Congratsss :)" & vbCrLf & vbCrLf & lb
        End If
        username.Text = sid
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("Select * from reg where student_id=@student_id", con)
        cmd.Parameters.AddWithValue("student_id", username.Text)
        Dim myreader As SqlDataReader = cmd.ExecuteReader
        con.Close()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Dim Obj As New profile()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub
End Class