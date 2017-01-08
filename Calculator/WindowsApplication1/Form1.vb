Option Explicit On
Public Class Form1
    Dim firstnumber As Single
    Dim secondnumber As Single
    Dim answernumber As Single
    Dim arithmeticprocess As String

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        txtdisplay.Text = txtdisplay.Text & "1"
    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        txtdisplay.Text = txtdisplay.Text & "2"
    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        txtdisplay.Text = txtdisplay.Text & "3"
    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        txtdisplay.Text = txtdisplay.Text & "4"
    End Sub

    Private Sub cmd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5.Click
        txtdisplay.Text = txtdisplay.Text & "5"
    End Sub

    Private Sub cmd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd6.Click
        txtdisplay.Text = txtdisplay.Text & "6"
    End Sub

    Private Sub cmd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd7.Click
        txtdisplay.Text = txtdisplay.Text & "7"
    End Sub

    Private Sub cmd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd8.Click
        txtdisplay.Text = txtdisplay.Text & "8"
    End Sub

    Private Sub cmd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd9.Click
        txtdisplay.Text = txtdisplay.Text & "9"
    End Sub

    Private Sub cmd0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd0.Click
        txtdisplay.Text = txtdisplay.Text & "0"
    End Sub

    Private Sub cmddecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddecimal.Click
        txtdisplay.Text = txtdisplay.Text & "."
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtdisplay.Text = 0
    End Sub

    Private Sub cmdplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdplus.Click
        firstnumber = Val(txtdisplay.Text)
        txtdisplay.Text = "0"
        arithmeticprocess = "+"
    End Sub

    Private Sub cmdmultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmultiply.Click
        firstnumber = Val(txtdisplay.Text)
        txtdisplay.Text = "0"
        arithmeticprocess = "*"
    End Sub

    Private Sub cmdsubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsubtract.Click
        firstnumber = Val(txtdisplay.Text)
        txtdisplay.Text = "0"
        arithmeticprocess = "-"
    End Sub

    Private Sub cmddivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddivide.Click
        firstnumber = Val(txtdisplay.Text)
        txtdisplay.Text = "0"
        arithmeticprocess = "/"
    End Sub

    Private Sub cmdequals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdequals.Click
        secondnumber = Val(txtdisplay.Text)
        If arithmeticprocess = "+" Then
            answernumber = firstnumber + secondnumber
        End If
        If arithmeticprocess = "-" Then
            answernumber = firstnumber - secondnumber
        End If
        If arithmeticprocess = "/" Then
            answernumber = firstnumber / secondnumber
        End If
        If arithmeticprocess = "*" Then
            answernumber = firstnumber * secondnumber
        End If
        txtdisplay.Text = answernumber
    End Sub
End Class
