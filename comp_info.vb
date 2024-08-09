Imports System.Data.SqlClient

Public Class comp_info
    Public Property sid As String
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim Obj As New profile()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        Dim Obj As New wipro()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim Obj As New Home()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Dim result = MessageBox.Show("Are you sure you want to Log out", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim Obj As New login()
            Obj.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles infosysbtn.Click
        Dim Obj As New infosys()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        Dim Obj As New deloitte()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton4.Click
        Dim Obj As New sap()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton5.Click
        Dim Obj As New tech()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ImageButton6_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton6.Click
        Dim Obj As New accenture()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ImageButton7_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton7.Click
        Dim Obj As New hcl()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ImageButton8_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton8.Click
        Dim Obj As New hexaware()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ImageButton9_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton9.Click
        Dim Obj As New tcs()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub
    Dim student As String
    Private Sub comp_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = sid
        student = sid
        Getdetails()
    End Sub
    Private Sub Getdetails()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("Select * from reg where student_id=@student_id", con)
        cmd.Parameters.AddWithValue("student_id", username.Text)
        Dim myreader As SqlDataReader = cmd.ExecuteReader
        con.Close()
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Dim Obj As New Faq()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Dim Obj As New applied_comp()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Dim Obj As New test()
        Obj.sid = username.Text
        Me.Hide()
        Obj.Show()
    End Sub
End Class