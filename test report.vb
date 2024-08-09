Imports System.Data.SqlClient
Public Class test_report
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim Obj As New admin_home()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim Obj As New admin_edit()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Dim Obj As New report()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub test_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT COUNT(*) FROM test"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim cmd1 As New SqlCommand(query, connection)
            Dim count As Integer = Convert.ToInt32(cmd1.ExecuteScalar())
            Label4.Text = "Number of Students Taken Test: " & count
            Label4.AutoSize = True
            Me.Controls.Add(Label4)

        End Using

        con.Open()
        Dim query1 = "Select * from test"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query1, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet()
        adapter.Fill(ds)
        Guna2DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub
End Class