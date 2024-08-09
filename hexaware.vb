
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class hexaware
    Public Property sid As String
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\placeverse.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub loginbutton_Click(sender As Object, e As EventArgs) Handles loginbutton.Click
        If ComboBox1.SelectedIndex <> -1 Then
            username.Text = sid
            Try

                con.Open()
                Dim c1, c2, dat As String
                c1 = "HEXAWARE"
                c2 = "108"
                dat = DateTime.Now
                Dim query = "insert into company values('" & c2 & "','" & c1 & "','" & username.Text & "','" & dat & "')"
                Dim cmd1 As SqlCommand
                cmd1 = New SqlCommand(query, con)
                cmd1.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("Applied Successfully..", "Applied!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("You have already applied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("please choose a Role ", "Role", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        con.Close()



    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Dim Obj As New comp_info()
        Obj.sid = username.Text
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub hexaware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = sid
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("Select * from reg where student_id=@student_id", con)
        cmd.Parameters.AddWithValue("student_id", username.Text)
        Dim myreader As SqlDataReader = cmd.ExecuteReader
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Label2.Text = "     Roles and Responsibilities
       •Design, development, implementation, and maintenance 
        of an enterprise level, multi-user, big data aggregation,
        analysis, and reporting system
       •Full-stack development (Java /Spring, JavaScript, 
        React/Angular, REST/APIs, HTML5, CSS, Hibernate, etc.)
       •Support all phases of the Software/Systems
        Development Lifecycle (SDLC)
       •Working closely with multiple DoD customers 
        providing technical guidance, documentation, 
        and presentation support as needed for all supported 
        efforts
       •Providing direct technical guidance and support to both 
        the development and sustainment teams as necessary"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Label2.Text = "      Roles and Responsibilities
       •Work with clients and technical resources to identify 
        their business problems and develop the right approach
        and analytical solution.
       •Good knowledge and understanding of digital
        application workflows.
       •Planning and managing business diagnosis and planning
        activities.
       •Understand and analyze functional impacts on 
        front-to-back applications.
       •Performing/interpreting requirement analysis to
        identify value creation opportunities for clients.
       •Design and document new process and system changes."
        End If
    End Sub
End Class