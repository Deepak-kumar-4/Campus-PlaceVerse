Imports System.Data.SqlClient

Public Class report
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT COUNT(*) FROM company"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim cmd1 As New SqlCommand(query, connection)
            Dim count As Integer = Convert.ToInt32(cmd1.ExecuteScalar())
            Label2.Text = "Number of Students Applied: " & count
            Label2.AutoSize = True
            Me.Controls.Add(Label2)

        End Using

        con.Open()
        Dim query1 = "Select * from company"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query1, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet()
        adapter.Fill(ds)
        Guna2DataGridView2.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs)

    End Sub

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
        Dim Obj As New test_report()
        Obj.Show()
        Me.Hide()
    End Sub
End Class