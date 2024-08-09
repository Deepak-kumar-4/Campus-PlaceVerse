Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class admin_home
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim Obj As New report()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Dim result = MessageBox.Show("Are you sure you want to Log out", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim Obj As New admin_login()
            Obj.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim Obj As New admin_edit()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs)

    End Sub
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub admin_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT COUNT(*) FROM reg"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim cmd As New SqlCommand(query, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Label1.Text = "Number of Students Registered: " & count
            Label1.AutoSize = True
            Me.Controls.Add(Label1)

        End Using
        Dim query1 = "Select student_id, student_name, department, phno, cgpa from reg"
        Dim cmd1 As SqlCommand
        cmd1 = New SqlCommand(query1, con)
        Dim adapter1 As SqlDataAdapter
        adapter1 = New SqlDataAdapter(cmd1)
        Dim builder1 As New SqlCommandBuilder(adapter1)
        Dim ds1 As DataSet
        ds1 = New DataSet()
        adapter1.Fill(ds1)
        Guna2DataGridView1.DataSource = ds1.Tables(0)
        con.Close()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Dim Obj As New test_report()
        Obj.Show()
        Me.Hide()
    End Sub
End Class