Imports System.Data.SqlClient

Public Class report

    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")

        con.Open()
        Dim query = "Select * from company"
        Dim query1 = "Select student_id, student_name, department, phno, cgpa from reg"
        Dim cmd As SqlCommand
        Dim cmd1 As SqlCommand
        cmd = New SqlCommand(query, con)
        cmd1 = New SqlCommand(query1, con)
        Dim adapter As SqlDataAdapter
        Dim adapter1 As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        adapter1 = New SqlDataAdapter(cmd1)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim builder1 As New SqlCommandBuilder(adapter1)
        Dim ds As DataSet
        Dim ds1 As DataSet
        ds = New DataSet()
        ds1 = New DataSet()
        adapter.Fill(ds)
        adapter1.Fill(ds1)
        Guna2DataGridView2.DataSource = ds.Tables(0)
        Guna2DataGridView1.DataSource = ds1.Tables(0)
        con.Close()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Dim Obj As New admin_home()
        Obj.Show()
        Me.Hide()
    End Sub
End Class