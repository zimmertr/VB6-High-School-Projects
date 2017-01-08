Public Class Form1
    Dim grade1, grade2, grade3, grade4, grade5, grade6, grade7, grade8, Gradefinal, Gradeaverage As Integer


    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) = False Then
            MsgBox("This is a NUMBER grade averager. Not A Letter Grade Averager.")
            Exit Sub
        End If
        grade1 = Val(TextBox1.Text)
        grade2 = Val(TextBox2.Text)
        grade3 = Val(TextBox3.Text)
        grade4 = Val(TextBox4.Text)
        grade5 = Val(TextBox5.Text)
        grade6 = Val(TextBox6.Text)
        grade7 = Val(TextBox7.Text)
        grade8 = Val(TextBox8.Text)
        gradefinal = (grade1 + grade2 + grade3 + grade4 + grade5 + grade6 + grade7 + grade8) / 8
        If Gradefinal < 70 Then
            MsgBox("NP", 0, "Grade Calculator")
        ElseIf Gradefinal >= 70 And Gradefinal <= 73 Then
            MsgBox("C-", 0, "Grade Calculator")
        ElseIf Gradefinal >= 74 And Gradefinal <= 76 Then
            MsgBox("C", 0, "Grade Calculator")
        ElseIf Gradefinal >= 77 And Gradefinal <= 79 Then
            MsgBox("C+", 0, "Grade Calculator")
        ElseIf Gradefinal >= 80 And Gradefinal <= 83 Then
            MsgBox("B-", 0, "Grade Calculator")
        ElseIf Gradefinal >= 84 And Gradefinal <= 86 Then
            MsgBox("B", 0, "Grade Calculator")
        ElseIf Gradefinal >= 87 And Gradefinal <= 89 Then
            MsgBox("B+", 0, "Grade Calculator")
        ElseIf Gradefinal >= 90 And Gradefinal <= 93 Then
            MsgBox("A-", 0, "Grade Calculator")
        ElseIf Gradefinal >= 94 And Gradefinal <= 96 Then
            MsgBox("A", 0, "Grade Calculator")
        ElseIf Gradefinal >= 97 And Gradefinal <= 100 Then
            MsgBox("A+", 0, "Grade Calculator")
        ElseIf Gradefinal >= 101 And Gradefinal <= 150 Then
            MsgBox("A++", 0, "Grade Calculator")
        ElseIf Gradefinal >= 151 Then
            MsgBox("Your Either Giving Too Much Extra Credit Or Entered A Number In Incorrectly.", 0, "Grade Calculator")
        End If


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Textbox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) _
Handles TextBox1.MouseHover, TextBox2.MouseHover, _
TextBox3.MouseHover, TextBox4.MouseHover, _
TextBox5.MouseHover, TextBox6.MouseHover, _
TextBox7.MouseHover, TextBox8.MouseHover
        If sender Is TextBox1 Then
            ToolTip1.Show("Enter Grade 1 Here", sender)
        ElseIf sender Is TextBox2 Then
            ToolTip1.Show("Enter Grade 2 Here", sender)
        ElseIf sender Is TextBox3 Then
            ToolTip1.Show("Enter Grade 3 Here", sender)
        ElseIf sender Is TextBox4 Then
            ToolTip1.Show("Enter Grade 4 Here", sender)
        ElseIf sender Is TextBox5 Then
            ToolTip1.Show("Enter Grade 5 Here", sender)
        ElseIf sender Is TextBox6 Then
            ToolTip1.Show("Enter Grade 6 Here", sender)
        ElseIf sender Is TextBox7 Then
            ToolTip1.Show("Enter Grade 7 Here", sender)
        ElseIf sender Is TextBox8 Then
            ToolTip1.Show("Enter Grade 8 Here", sender)
        End If
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        ToolTip1.Show("Click This Button To Calculate Average Letter Grade", sender)
    End Sub

    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        ToolTip1.Show("Click This Button To Reset All The Fields To Blank", sender)
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        ToolTip1.Show("Click This Button To Quit And Exit The Program", sender)
    End Sub




End Class


