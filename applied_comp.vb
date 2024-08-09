Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions


Public Class applied_comp
    Public Property sid As String
    Dim student As String
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub applied_comp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = sid
        student = sid
        con.Open()
        Dim command As New SqlCommand("Select *from company where student_id='" + username.Text + "' ")
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet()
        command.Connection = con
        da.SelectCommand = command
        da.Fill(ds, "company")
        If (ds.Tables("company").Rows.Count > 0) Then
            Getdetails()

        Else
            Dim result = MessageBox.Show("Please Apply for any Company ..", "APPLY NOW!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If result = DialogResult.OK Then
                Dim Obj As New comp_info()
                Obj.sid = username.Text
                Obj.Show()
                Me.Close()
                Exit Sub

            End If
        End If
        con.Close()

    End Sub
    Private Sub Getdetails()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("Select * from company where student_id=@student_id", con)
        cmd.Parameters.AddWithValue("student_id", student)
        Dim myreader As SqlDataReader = cmd.ExecuteReader
        If (myreader.Read()) Then
            company_id.Text = myreader("company_id")
            company_name.Text = myreader("company_name")
            con.Close()
        End If
        If company_id.Text = "101" Then
            Me.Guna2PictureBox2.Image = infosys.Guna2PictureBox1.Image
            Me.salary.Text = infosys.salary.Text
        ElseIf company_id.Text = "102" Then
            Me.Guna2PictureBox2.Image = wipro.Guna2PictureBox1.Image
            Me.salary.Text = wipro.salary.Text
        ElseIf company_id.Text = "103" Then
            Me.Guna2PictureBox2.Image = deloitte.Guna2PictureBox1.Image
            Me.salary.Text = deloitte.salary.Text
        ElseIf company_id.Text = "104" Then
            Me.Guna2PictureBox2.Image = sap.Guna2PictureBox1.Image
            Me.salary.Text = sap.salary.Text
        ElseIf company_id.Text = "105" Then
            Me.Guna2PictureBox2.Image = tech.Guna2PictureBox1.Image
            Me.salary.Text = tech.salary.Text
        ElseIf company_id.Text = "106" Then
            Me.Guna2PictureBox2.Image = accenture.Guna2PictureBox1.Image
            Me.salary.Text = accenture.salary.Text
        ElseIf company_id.Text = "107" Then
            Me.Guna2PictureBox2.Image = hcl.Guna2PictureBox1.Image
            Me.salary.Text = hcl.salary.Text
        ElseIf company_id.Text = "108" Then
            Me.Guna2PictureBox2.Image = hexaware.Guna2PictureBox1.Image
            Me.salary.Text = hexaware.salary.Text
        Else
            Me.Guna2PictureBox2.Image = tcs.Guna2PictureBox1.Image
            Me.salary.Text = tcs.salary.Text
            con.Close()
        End If
    End Sub

    Private Sub applybutton_Click(sender As Object, e As EventArgs) Handles applybutton.Click
        student = sid
        con.Open()
        Try

            Dim withdraw = MessageBox.Show("Do you really want to withdraw?", "Withdraw", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If withdraw = DialogResult.Yes Then
                Dim cmd1 As New SqlCommand
                cmd1.Connection = con
                cmd1.CommandText = "Delete From company where student_id= @student_id"
                cmd1.Parameters.Add(New SqlParameter("@student_id", student))
                MessageBox.Show("Withdrawed successfully", "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd1.ExecuteNonQuery()
                con.Close()
                Dim Obj As New comp_info()
                Obj.sid = username.Text
                Obj.Show()
                Me.Hide()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Error while withdrawal..." & ex.Message, "error!!")
            'MsgBox(ex.Message)

        Finally

            con.Close()
        End Try
        con.Close()
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
        Dim Obj As New comp_info()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim Obj As New Home()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim Obj As New profile()
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

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Dim Obj As New test()
        Obj.sid = username.Text
        Me.Hide()
        Obj.Show()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click

    End Sub
End Class