Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class admin_login
    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand("Select *from admin where id='" + idbox.Text + "' and password='" + passbox.Text + "'")
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet()
        con.Open()
        cmd.Connection = con
        da.SelectCommand = cmd

        da.Fill(ds, "admin")
        If idbox.Text = "" Or passbox.Text = "" Then
            MessageBox.Show("Please enter Admin ID and Password")
            Return
        End If
        If (ds.Tables("admin").Rows.Count > 0) Then
            MessageBox.Show("Login successfull...!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            admin_home.ShowDialog()
            Me.Hide()


        Else
            MessageBox.Show("Please Check Admin ID and Password ..", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Guna2ControlBox4_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox4.Click
        Dim Obj = New login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel1.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        idbox.Text = ""
        passbox.Text = ""
    End Sub

    Private Sub admin_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class