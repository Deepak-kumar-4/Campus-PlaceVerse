Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class profile
    Public Property sid As String
    Dim student As String
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = sid
        student = sid
        Getdetails()
    End Sub
    Private Sub Getdetails()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("Select * from reg where student_id=@student_id", con)
        cmd.Parameters.AddWithValue("student_id", student)
        Dim myreader As SqlDataReader = cmd.ExecuteReader
        If (myreader.Read()) Then
            student_name.Text = myreader("student_name")
            student_id.Text = myreader("student_id")

            cgpa.Text = myreader("cgpa")
            department.Text = myreader("department")
            phno.Text = myreader("phno")
            email.Text = myreader("email")
            image_path.Text = myreader("image_path")
            Guna2CirclePictureBox1.Image = Image.FromFile(image_path.Text)
            Guna2PictureBox2.Image = Image.FromFile(image_path.Text)
            con.Close()

        End If
        con.Close()

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim Obj As New Home()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim Obj As New comp_info()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Dim Obj As New Faq()
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

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Dim Obj As New applied_comp()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Dim Obj As New test()
        Obj.sid = username.Text
        Me.Hide()
        Obj.Show()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click

    End Sub
End Class