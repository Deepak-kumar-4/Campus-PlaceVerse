Imports System.Data.SqlClient

Public Class test
    Public Property sid As String
    Dim questions As New List(Of Tuple(Of String, List(Of String), Integer))
    Dim currentQuestion As Integer = 0
    Dim score As Integer = 0

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
    Dim student As String
    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = sid
        student = sid
        con.Open()
        Dim command As New SqlCommand("Select *from test where student_id='" + student + "'")
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet()
        command.Connection = con
        da.SelectCommand = command
        da.Fill(ds, "test")
        If (ds.Tables("test").Rows.Count > 0) Then
            Dim result = MessageBox.Show("You have Already Taken TEST! ..", "TEST!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If result = DialogResult.OK Then
                Dim Obj As New Home()
                Obj.sid = username.Text
                Obj.Show()
                Me.Close()
                Exit Sub

            End If
        Else

            Getdetails()

            questions.Add(Tuple.Create("1.A train running at the speed of 60 km/hr crosses a pole in 9 seconds. What is the length of the train?", New List(Of String) From {"120 metres", "180 metres", "324 metres", "150 metres"}, 3))
            questions.Add(Tuple.Create("2.Find the greatest number that will divide 43, 91 and 183 so as to leave the same remainder in each case", New List(Of String) From {"4", "7", "9", "13"}, 2))
            questions.Add(Tuple.Create("3.Synonym of word - CANNY", New List(Of String) From {"Obstinate", "Handsome", "Clever", "Stout"}, 2))
            questions.Add(Tuple.Create("4.Antonym of word - QUIESCENT ", New List(Of String) From {"Active", "Dormant", "Weak", "Unconcerned"}, 0))
            questions.Add(Tuple.Create("5.Find the missing pattern in the series SCD, TEF, UGH, ____, WKL", New List(Of String) From {"CMN", "UJI", "VIJ", "IJI"}, 2))
            questions.Add(Tuple.Create("6.Look at this series: 7, 10, 8, 11, 9, 12, ... What number should come next?", New List(Of String) From {"7", "10", "12", "4"}, 1))
            questions.Add(Tuple.Create("7.Which word does NOT belong with the others?", New List(Of String) From {"Tyre", "Steering Wheel", "Engine", "Car"}, 3))
            questions.Add(Tuple.Create("8.8, 27, 64, 100, 125, 216, 343", New List(Of String) From {"27", "100", "125", "343"}, 1))
            questions.Add(Tuple.Create("9.I haven't eaten an apple ...... a long while", New List(Of String) From {"from", "since", "for", "untill"}, 0))
            questions.Add(Tuple.Create("10.Which one of the following is not a prime number?", New List(Of String) From {"31", "61", "71", "91"}, 3))
            DisplayQuestion()
        End If
        con.Close()

    End Sub

    Private Sub DisplayQuestion()
        TextBox1.Text = questions(currentQuestion).Item1
        RadioButton1.Text = questions(currentQuestion).Item2(0)
        RadioButton2.Text = questions(currentQuestion).Item2(1)
        RadioButton3.Text = questions(currentQuestion).Item2(2)
        RadioButton4.Text = questions(currentQuestion).Item2(3)
    End Sub


    Private Sub Getdetails()


        Dim cmd As New SqlCommand("Select * from reg where student_id=@student_id", con)
        cmd.Parameters.AddWithValue("student_id", student)
        Dim myreader As SqlDataReader = cmd.ExecuteReader()
        If (myreader.Read()) Then
            image_path.Text = myreader("image_path")
            Guna2CirclePictureBox1.Image = Image.FromFile(image_path.Text)
        End If

    End Sub

    Private Sub nxtbut_Click(sender As Object, e As EventArgs) Handles nxtbut.Click
        If RadioButton1.Checked Then
            score += If(questions(currentQuestion).Item3 = 0, 1, 0)
        ElseIf RadioButton2.Checked Then
            score += If(questions(currentQuestion).Item3 = 1, 1, 0)
        ElseIf RadioButton3.Checked Then
            score += If(questions(currentQuestion).Item3 = 2, 1, 0)
        ElseIf RadioButton4.Checked Then
            score += If(questions(currentQuestion).Item3 = 3, 1, 0)
        End If

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False

        currentQuestion += 1
        If currentQuestion >= questions.Count Then
            Label7.Text = " Your score is: " & score & " out of " & questions.Count
            Label8.Text = Label7.Text
            Label7.Visible = True
            nxtbut.Enabled = False
            StoreResult()
            Dim obj As New mock_result
            obj.sid = username.Text
            obj.lb = Label8.Text
            obj.sc = score
            obj.Show()
            Me.Hide()
        Else
            DisplayQuestion()
        End If
    End Sub

    Private Sub StoreResult()
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30"
        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim query As String = "INSERT INTO test (student_id, score, date) VALUES (@student_id, @Score, @date)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@student_id", student)
                cmd.Parameters.AddWithValue("@Score", score)
                cmd.Parameters.AddWithValue("@date", DateTime.Now)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class