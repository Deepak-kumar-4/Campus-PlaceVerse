Imports Guna.UI2.WinForms
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class admin_edit
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")


    Private Sub applybutton_Click(sender As Object, e As EventArgs) Handles removebutton.Click
        If student_id.Text = "" Then
            MessageBox.Show("Please Enter Student ID", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim command As New SqlCommand("Select *from reg where student_id='" + student_id.Text + "'")
            Dim da As New SqlDataAdapter()
            Dim ds As New DataSet()
            command.Connection = con
            da.SelectCommand = command
            da.Fill(ds, "reg")
            If (ds.Tables("reg").Rows.Count > 0) Then
                'MessageBox.Show("EEEE")
            Else
                MessageBox.Show("Student ID doesn't exist!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
            con.Open()
        Dim i As String
        i = student_id.Text
        Dim cmd As New SqlCommand("Select * from reg where student_id=@student_id", con)
        Try

            Dim withdraw = MessageBox.Show("Do you really want to Remove this user?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If withdraw = DialogResult.Yes Then
                Dim cmd1 As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim cmd3 As New SqlCommand
                cmd1.Connection = con
                cmd2.Connection = con
                cmd3.Connection = con
                cmd1.CommandText = "Delete From reg where student_id= @student_id"
                cmd2.CommandText = "Delete From company where student_id= @student_id"
                cmd3.CommandText = "Delete From test where student_id= @student_id"
                cmd1.Parameters.Add(New SqlParameter("@student_id", i))
                cmd2.Parameters.Add(New SqlParameter("@student_id", i))
                cmd3.Parameters.Add(New SqlParameter("@student_id", i))
                MessageBox.Show("Removed successfully", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information)
                image_path.Text = ""
                Guna2CirclePictureBox1.Image = Nothing
                Label2.Text = ""
                student_id.Text = ""
                cmd1.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()
                cmd3.ExecuteNonQuery()
                con.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Try with Valid User ID" & ex.Message, "error!!")
            'MsgBox(ex.Message)

        Finally

            con.Close()
        End Try
        con.Close()

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles search.Click
        If student_id.Text = "" Then
            MessageBox.Show("Please Enter Student ID", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        con.Open()
        Dim i As String
        i = student_id.Text
        Dim command As New SqlCommand("Select *from reg where student_id='" + student_id.Text + "'")
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet()
        command.Connection = con
        da.SelectCommand = command
        da.Fill(ds, "reg")
        If (ds.Tables("reg").Rows.Count > 0) Then
            Dim cmd As New SqlCommand("Select * from reg where student_id=@student_id", con)
            cmd.Parameters.AddWithValue("student_id", i)
            Dim myreader As SqlDataReader = cmd.ExecuteReader
            If (myreader.Read()) Then
                Label2.Text = myreader("student_name")
                image_path.Text = myreader("image_path")
                Guna2CirclePictureBox1.Image = Image.FromFile(image_path.Text)

            End If
        Else
            MessageBox.Show("Please Check Student ID ..", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        con.Close()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs)
        Dim Obj As New admin_home()
        Obj.Show()
        Me.Hide()
    End Sub


    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim Obj As New admin_home()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton1_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim Obj As New test_report()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Dim Obj As New report()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub student_id_TextChanged(sender As Object, e As EventArgs) Handles student_id.TextChanged

    End Sub

    Private Sub admin_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class