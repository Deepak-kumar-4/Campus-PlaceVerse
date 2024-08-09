Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports Guna.UI2.WinForms
Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class registration
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click
        If student_id.Text = "" Or password.Text = "" Or student_name.Text = "" Or phno.Text = "" Or image_path.Text = "" Or cpass.Text = "" Then
            MessageBox.Show("Please Enter all the details ..", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con.Open()
                Dim ph, len As String
                ph = phno.Text
                len = ph.Length()
                If (len <= 9) Then
                    MessageBox.Show("Provide Valid Phone Number..!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    phno.Clear()

                    Exit Try
                End If
                Dim per As String
                per = cgpa.Text
                If (per > 9.9 Or per < 5) Then
                    MessageBox.Show("Provide Correct CGPA..!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cgpa.Clear()

                    Exit Try
                End If
                Dim query = "insert into reg values('" & student_id.Text & "','" & student_name.Text & "','" & gender.Text & "','" & cgpa.Text & "','" & phno.Text & "','" & email.Text & "','" & department.Text & "','" & password.Text & "','" & image_path.Text & "')"

                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registration Successful Account Created..!!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                login.Show()
                student_id.Clear()
                student_name.Clear()
                gender.Text = " "
                phno.Clear()
                email.Clear()
                cgpa.Clear()
                department.Text = ""

                password.Clear()
                con.Close()

            Catch ex As Exception

                MessageBox.Show("Student Credentials Already Exists..!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'MsgBox(ex.Message)
            End Try
            con.Close()
        End If
        con.Close()

    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Obj = New login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        OpenFileDialog1.ShowDialog()
        image_path.Text = Path.GetDirectoryName(OpenFileDialog1.FileName) & "\" & Path.GetFileName(OpenFileDialog1.FileName)
        Guna2CirclePictureBox1.Image = Image.FromFile(image_path.Text)
    End Sub



    Private Sub Guna2Button1_Validating(sender As Object, e As CancelEventArgs) Handles Guna2Button1.Validating
        If String.IsNullOrWhiteSpace(Guna2Button1.Text) Then
            ErrorProvider1.SetError(Guna2Button1, "This field is required.")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(Guna2Button1, Nothing)
        End If
    End Sub



    Private Sub student_name_Validating(sender As Object, e As CancelEventArgs) Handles student_name.Validating
        If String.IsNullOrWhiteSpace(student_name.Text) Then
            ErrorProvider1.SetError(student_name, "This field is required.")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(student_name, Nothing)
        End If
    End Sub



    Private Sub student_id_Validating(sender As Object, e As CancelEventArgs) Handles student_id.Validating
        If String.IsNullOrWhiteSpace(student_id.Text) Then
            ErrorProvider1.SetError(student_id, "This field is required.")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(student_id, Nothing)
        End If
    End Sub



    Private Sub gender_Validating(sender As Object, e As CancelEventArgs) Handles gender.Validating
        If String.IsNullOrWhiteSpace(gender.Text) Then
            ErrorProvider1.SetError(gender, "This field is required.")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(gender, Nothing)
        End If
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged
        If password.Text.Length < 8 Then
            password.BorderColor = Color.Red

        Else
            password.BorderColor = Color.Green

        End If
    End Sub

    Private Sub password_Validating(sender As Object, e As CancelEventArgs) Handles password.Validating
        If String.IsNullOrWhiteSpace(password.Text) Then
            ErrorProvider1.SetError(password, "This field is required.")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(password, Nothing)
        End If
    End Sub



    Private Sub cgpa_Validating(sender As Object, e As CancelEventArgs) Handles cgpa.Validating
        If String.IsNullOrWhiteSpace(cgpa.Text) Then
            ErrorProvider1.SetError(cgpa, "This field is required.")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(cgpa, Nothing)
        End If
    End Sub


    Private Sub phno_Validating(sender As Object, e As CancelEventArgs) Handles phno.Validating
        If String.IsNullOrWhiteSpace(phno.Text) Then
            ErrorProvider1.SetError(phno, "This field is required.")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(phno, Nothing)
        End If
    End Sub


    Private Sub email_Validating(sender As Object, e As CancelEventArgs) Handles email.Validating
        If String.IsNullOrWhiteSpace(email.Text) Then
            ErrorProvider1.SetError(email, "This field is required.")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(email, Nothing)
        End If
        Dim email1 As String = email.Text

        If Not IsValidEmail(email1) Then
            MessageBox.Show("Provide a valid email address..", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True ' prevent focus from leaving textbox
        End If

    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        ' Regular expression pattern for validating email addresses
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        ' Create a regular expression object with the pattern
        Dim regex As New Regex(pattern)

        ' Test the email address against the regular expression
        Return regex.IsMatch(email)
    End Function


    Private Sub department_Validating(sender As Object, e As CancelEventArgs) Handles department.Validating
        If String.IsNullOrWhiteSpace(department.Text) Then
            ErrorProvider1.SetError(department, "This field is required.")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(department, Nothing)
        End If
    End Sub

    Private Sub phno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phno.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cgpa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cgpa.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub student_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles student_name.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel1.Paint

    End Sub

    Private Sub cpass_TextChanged(sender As Object, e As EventArgs) Handles cpass.TextChanged
        If cpass.Text.Length < 8 Then
            cpass.BorderColor = Color.Red

        Else
            cpass.BorderColor = Color.Green
        End If

    End Sub

    Private Sub cpass_Validating(sender As Object, e As CancelEventArgs) Handles cpass.Validating
        Dim password1 As String = password.Text
        Dim confirmPassword As String = cpass.Text

        If Not password1.Equals(confirmPassword) Then
            MessageBox.Show("Passwords does not match..Provide matching passwords.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True ' prevent focus from leaving confirm password textbox
        End If
    End Sub

    Private Sub email_TextChanged(sender As Object, e As EventArgs) Handles email.TextChanged

    End Sub

    Private Sub cgpa_TextChanged(sender As Object, e As EventArgs) Handles cgpa.TextChanged

    End Sub
End Class