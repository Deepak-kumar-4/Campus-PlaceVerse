Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class login
    Public Property Student_id As String
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        idbox.Clear()
        passbox.Clear()
    End Sub
    Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub loginbutton_Click(sender As Object, e As EventArgs) Handles loginbutton.Click
        If idbox.Text = "" Or passbox.Text = "" Then
            MessageBox.Show("Enter Student ID and Password")
        Else
            conn.Open()
            Dim command As New SqlCommand("Select *from reg where student_id='" + idbox.Text + "' and password='" + passbox.Text + "'")
            Dim da As New SqlDataAdapter()
            Dim ds As New DataSet()
            command.Connection = conn
            da.SelectCommand = command
            da.Fill(ds, "reg")
            If (ds.Tables("reg").Rows.Count > 0) Then
                MessageBox.Show("Login Successful Welcome to Campus PlaceVerse..", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim Obj = New Home
                Obj.sid = idbox.Text
                Obj.Show()
                Me.Hide()
            Else
                MessageBox.Show("Check Student ID and Password..", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conn.Close()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Obj = New registration
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub admin_Click(sender As Object, e As EventArgs) Handles admin.Click
        Dim Obj = New admin_login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        idbox.Text = ""
        passbox.Text = ""
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel1.Paint

    End Sub
End Class

