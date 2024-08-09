Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports Guna.UI2.WinForms

Public Class Home
    Public Property sid As String
    Dim images As New List(Of Image)
    Dim currentImage As Integer = 0
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Guna2GradientButton5_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Dim Obj As New Faq()
        Obj.sid = username.Text
        Me.Hide()
        Obj.Show()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Dim result = MessageBox.Show("Are you sure you want to Log out", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim Obj As New login()
            Obj.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim Obj As New comp_info()
        Obj.sid = username.Text
        Me.Hide()
        Obj.Show()
    End Sub
    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Dim Obj As New applied_comp()
        Obj.sid = username.Text
        Me.Hide()
        Obj.Show()

    End Sub
    Private Sub Getdetails()
        con.Open()

        Dim cmd As New SqlCommand("Select * from reg where student_id=@student_id", con)
        cmd.Parameters.AddWithValue("student_id", student)
        Dim myreader As SqlDataReader = cmd.ExecuteReader()
        If (myreader.Read()) Then
            student = myreader("student_name")
            label6.Text = "Hey  " & student & "  Welcome to Campus PlaceVerse"
            label6.AutoSize = True
            Me.Controls.Add(label6)

            image_path.Text = myreader("image_path")
            Guna2CirclePictureBox1.Image = Image.FromFile(image_path.Text)
        End If
        con.Close()
    End Sub
    Dim student As String
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = sid
        student = sid
        Getdetails()
        images.Add(Image.FromFile("G:\Project work\CAMPUS PlaceVerse\images\1.jpg"))
        images.Add(Image.FromFile("G:\Project work\CAMPUS PlaceVerse\images\2.jpg"))
        images.Add(Image.FromFile("G:\Project work\CAMPUS PlaceVerse\images\3.jpg"))
        images.Add(Image.FromFile("G:\Project work\CAMPUS PlaceVerse\images\4.jpg"))
        Guna2PictureBox2.Image = images(0)
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim Obj As New profile()
        Obj.sid = username.Text
        Me.Hide()
        Obj.Show()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Dim Obj As New test()
        Obj.sid = username.Text
        Me.Hide()
        Obj.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentImage += 1
        If currentImage >= images.Count Then
            currentImage = 0
        End If
        Guna2PictureBox2.Image = images(currentImage)

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click

    End Sub
End Class

