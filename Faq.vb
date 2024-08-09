Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Faq
    Public Property sid As String
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Guna2ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            TextBox1.Text = "1.What is CAMPUS PLACEVERSE? How it is useful for the students?"
            Label4.Text = "CAMPUS PLACEVERSE is basically a placement management system 
designed and developed which aimed at providing placement 
opportunities for the students. It covers the details about 
the specific companies and provides the mock assessment for 
the registered students to prepare for their placements."
        ElseIf ComboBox1.SelectedIndex = 1 Then
            TextBox1.Text = "2.How important is Pre-Placement talk?"
            Label4.Text = "-->Pre-placement talks or we call it as the discussion 
about the company. Here we came to know about various aspects of 
a company and it tells us that if we are suitable enough to work
for a company.
-->Pre-placement talks serve as a means to clarify details such as 
salary break-up, job profile, place of work, bond details etc. 
with the companies. Students are required to be well- versed
with all these details by clarifying them during the pre-placement talk."
        ElseIf ComboBox1.SelectedIndex = 2 Then
            TextBox1.Text = "3.How to prepare for the Aptitude round?"
            Label4.Text = "*Practice the test daily. Practice makes perfect.
*Make sure you know the test format.
*Read the instructions carefully.
*Be sure that you practice tests specific to your niche, market or
industry.
*Manage your time well."
        ElseIf ComboBox1.SelectedIndex = 3 Then
            TextBox1.Text = "4.What is Group discussion?"
            Label4.Text = "A vital component in any screening process, GD involves the
participation of a group of people who are asked to debate and 
discuss different aspects of a topic given by the interviewers.
GD assesses the overall personality – thoughts, feelings and 
behaviour - of an individual in a group."
        ElseIf ComboBox1.SelectedIndex = 4 Then
            TextBox1.Text = "5.How one should prepare for the technical round?"
            Label4.Text = "*Consider the tools and skills necessary for the role.
*Study helpful books and digital publications.
*Practice for the interview.
*Use the Interview to Show Your Passion for Tech. 
*Be Prepared for a Lengthy Interview Process. 
*Take the time you need."
        ElseIf ComboBox1.SelectedIndex = 5 Then
            TextBox1.Text = "6.Which type of questions will be asked during HR round?"
            Label4.Text = "During an HR round, you can expect high-level, 
general questions about you, your past work experience, and 
your motivefor looking for a new position.Expect to receive
questions that allude to your aptitudes and competencies, but 
that don't go too in depth about role-specific responsibilities."

        End If
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Dim result = MessageBox.Show("Are you sure you want to Log out", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim Obj As New login()
            Obj.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Dim Obj As New Home()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Faq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = sid

    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        Dim Obj As New profile()
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