Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class Mocktest

    Public Property sid As String
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Dim result = MessageBox.Show("Are you sure you want to Log out", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim Obj As New login()
            Obj.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        Dim Obj As New profile()
        Obj.sid = username.Text
        Me.Hide()
        Obj.Show()
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Dim Obj As New Home()
        Obj.sid = username.Text
        Me.Hide()
        Obj.Show()
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

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Dim Obj As New Faq()
        Obj.sid = username.Text
        Me.Hide()
        Obj.Show()
    End Sub
    Dim t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, total As Integer

    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click

        If ComboBox1.SelectedIndex = 0 And RadioButton4.Checked = True Then
            t1 = 10
            total = t1
        End If
        If ComboBox1.SelectedIndex = 1 And RadioButton3.Checked = True Then
            t2 = 10
            total = total + t2
        End If
        If ComboBox1.SelectedIndex = 2 And RadioButton3.Checked = True Then
            t3 = 10
            total = total + t3
        End If
        If ComboBox1.SelectedIndex = 3 And RadioButton1.Checked = True Then
            t4 = 10
            total = total + t4
        End If
        If ComboBox1.SelectedIndex = 4 And RadioButton3.Checked = True Then
            t5 = 10
            total = total + t5
        End If
        If ComboBox1.SelectedIndex = 5 And RadioButton2.Checked = True Then
            t6 = 10
            total = total + t6
        End If
        If ComboBox1.SelectedIndex = 6 And RadioButton4.Checked = True Then
            t7 = 10
            total = total + t7
        End If
        If ComboBox1.SelectedIndex = 7 And RadioButton2.Checked = True Then
            t8 = 10
            total = total + t8
        End If
        If ComboBox1.SelectedIndex = 8 And RadioButton1.Checked = True Then
            t9 = 10
            total = total + t9

        End If
        If ComboBox1.SelectedIndex = 9 And RadioButton4.Checked = True Then
            t10 = 10
            total = total + t10
        End If

        Dim remarks As String
        If (total > 70) Then
            remarks = "Excellent"
            Label7.Text = remarks


        End If

        'Dim command As New SqlCommand("Select *from test where student_id='" + username.Text + "' ")
        'Dim da As New SqlDataAdapter()
        'Dim ds As New DataSet()
        'command.Connection = con
        'da.SelectCommand = command
        'da.Fill(ds, "test")
        'If (ds.Tables("test").Rows.Count > 0) Then
        '    Try
        '        con.Open()
        '        Dim query = "Update test set result = " & total & " and remarks = " & remarks & " where student_id=" & student & " "
        '        Dim cmd As SqlCommand
        '        cmd = New SqlCommand(query, con)
        '        cmd.ExecuteNonQuery()
        '        con.Close()
        '        Exit Try

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        'Else
        '    Try
        '        con.Open()
        '        Dim query = "insert into test values(" & username.Text & "," & total & ",'" & remarks & "','" & System.DateTime.Today.Date & "')"
        '        Dim cmd1 As SqlCommand
        '        cmd1 = New SqlCommand(query, con)
        '        cmd1.ExecuteNonQuery()
        '        con.Close()

        '        'Dim query = "insert into test values(" & student & ",'" & total & "'," & remarks & ",'" & System.DateTime.Today.Date & "')"
        '        'Dim cmd As SqlCommand
        '        'cmd = New SqlCommand(query, con)
        '        'cmd.ExecuteNonQuery()

        '        'con.Close()
        '        Exit Try

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End If
        'con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            TextBox1.Text = "1.A train running at the speed of 60 km/hr crosses a pole in 9 seconds. What is the length of the train?"
            RadioButton1.Text = "120 metres"
            RadioButton2.Text = "180 metres"
            RadioButton3.Text = "324 metres"
            RadioButton4.Text = "150 metres"

        ElseIf ComboBox1.SelectedIndex = 1 Then
            TextBox1.Text = "2.Find the greatest number that will divide 43, 91 and 183 so as to leave the same remainder in each case."
            RadioButton1.Text = "4"
            RadioButton2.Text = "7"
            RadioButton3.Text = "9"
            RadioButton4.Text = "13"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            TextBox1.Text = "3.Synonym of word - CANNY"
            RadioButton1.Text = "Obstinate"
            RadioButton2.Text = "Handsome"
            RadioButton3.Text = "Clever"
            RadioButton4.Text = "Stout"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            TextBox1.Text = "4.Antonym of word - QUIESCENT"
            RadioButton1.Text = "Active"
            RadioButton2.Text = "Dormant"
            RadioButton3.Text = "Weak"
            RadioButton4.Text = "Unconcerned"
        ElseIf ComboBox1.SelectedIndex = 4 Then
            TextBox1.Text = "5.Find the missing pattern in the series SCD, TEF, UGH, ____, WKL"
            RadioButton1.Text = "CMN"
            RadioButton2.Text = "UJI"
            RadioButton3.Text = "VIJ"
            RadioButton4.Text = "IJT"
        ElseIf ComboBox1.SelectedIndex = 5 Then
            TextBox1.Text = "6.Look at this series: 7, 10, 8, 11, 9, 12, ... What number should come next?"
            RadioButton1.Text = "7"
            RadioButton2.Text = "10"
            RadioButton3.Text = "12"
            RadioButton4.Text = "4"
        ElseIf ComboBox1.SelectedIndex = 6 Then
            TextBox1.Text = "7.Which word does NOT belong with the others?"
            RadioButton1.Text = "Tyre"
            RadioButton2.Text = "Steering wheel"
            RadioButton3.Text = "Engine"
            RadioButton4.Text = "Car"
        ElseIf ComboBox1.SelectedIndex = 7 Then
            TextBox1.Text = "8.8, 27, 64, 100, 125, 216, 343"
            RadioButton1.Text = "27"
            RadioButton2.Text = "100"
            RadioButton3.Text = "125"
            RadioButton4.Text = "343"
        ElseIf ComboBox1.SelectedIndex = 8 Then
            TextBox1.Text = "9.I haven't eaten an apple ...... a long while."
            RadioButton1.Text = "from"
            RadioButton2.Text = "since"
            RadioButton3.Text = "for"
            RadioButton4.Text = "until"
        ElseIf ComboBox1.SelectedIndex = 9 Then
            TextBox1.Text = "10.Which one of the following is not a prime number?"
            RadioButton1.Text = "31"
            RadioButton2.Text = "61"
            RadioButton3.Text = "71"
            RadioButton4.Text = "91"
        End If
    End Sub
    Dim student As String
    Private Sub Mocktest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = sid
        student = sid
        Getdetails()
    End Sub
    Private Sub Getdetails()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("Select * from reg where student_id=@student_id", con)
        cmd.Parameters.AddWithValue("student_id", username.Text)
        Dim myreader As SqlDataReader = cmd.ExecuteReader
        con.Close()
    End Sub
End Class