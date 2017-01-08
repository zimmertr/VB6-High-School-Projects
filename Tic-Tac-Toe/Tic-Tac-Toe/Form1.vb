Public Class Form1
    Dim token As Char
    Dim player As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        restartgame()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Text = token
        Button1.Enabled = False
        checkwinner()
        nextplayer()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Text = token
        Button2.Enabled = False
        checkwinner()
        nextplayer()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Text = token
        Button3.Enabled = False
        checkwinner()
        nextplayer()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Text = token
        Button4.Enabled = False
        checkwinner()
        nextplayer()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Text = token
        Button5.Enabled = False
        checkwinner()
        nextplayer()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Text = token
        Button6.Enabled = False
        checkwinner()
        nextplayer()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Text = token
        Button7.Enabled = False
        checkwinner()
        nextplayer()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button8.Text = token
        Button8.Enabled = False
        checkwinner()
        nextplayer()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button9.Text = token
        Button9.Enabled = False
        checkwinner()
        nextplayer()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        End
    End Sub

    Private Sub nextplayer()
        If player = 1 Then
            token = "X"
            player = 2
        ElseIf player = 2 Then
            token = "O"
            player = 1
        End If
        Label2.Text = "player " & player & " : '" & token & "'"
    End Sub

    Private Sub DisplayWinner()
        'display winner message
        Label2.Text = "player '" & token & "' is the winner!"

        'disable all the buttons
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub

    Private Sub checkwinner()
        'check rows
        If Len(Button1.Text & Button2.Text & Button3.Text) > 0 And _
        Button1.Text = Button2.Text And Button2.Text = Button3.Text Then
            Button1.BackColor = Color.Yellow
            Button2.BackColor = Color.Yellow
            Button3.BackColor = Color.Yellow
            DisplayWinner()
        ElseIf Len(Button4.Text & Button5.Text & Button6.Text) > 0 And _
            Button4.Text = Button5.Text And Button6.Text = Button3.Text Then
            Button1.BackColor = Color.Yellow
            Button2.BackColor = Color.Yellow
            Button3.BackColor = Color.Yellow
            DisplayWinner()
        ElseIf Len(Button7.Text & Button8.Text & Button9.Text) > 0 And _
            Button7.Text = Button8.Text And Button8.Text = Button9.Text Then
            Button7.BackColor = Color.Yellow
            Button8.BackColor = Color.Yellow
            Button9.BackColor = Color.Yellow
            DisplayWinner()
        ElseIf Len(Button1.Text & Button4.Text & Button7.Text) > 0 And _
            Button1.Text = Button4.Text And Button7.Text = Button4.Text Then
            Button1.BackColor = Color.Yellow
            Button4.BackColor = Color.Yellow
            Button7.BackColor = Color.Yellow
            DisplayWinner()
        ElseIf Len(Button2.Text & Button5.Text & Button8.Text) > 0 And _
            Button2.Text = Button5.Text And Button8.Text = Button3.Text Then
            Button2.BackColor = Color.Yellow
            Button5.BackColor = Color.Yellow
            Button8.BackColor = Color.Yellow
            DisplayWinner()
        ElseIf Len(Button3.Text & Button6.Text & Button9.Text) > 0 And _
            Button3.Text = Button6.Text And Button9.Text = Button3.Text Then
            Button3.BackColor = Color.Yellow
            Button6.BackColor = Color.Yellow
            Button9.BackColor = Color.Yellow
            DisplayWinner()

            'check diagonals
        ElseIf Len(Button1.Text & Button5.Text & Button9.Text) > 0 And _
        Button4.Text = Button5.Text And Button6.Text = Button3.Text Then
            Button1.BackColor = Color.Yellow
            Button5.BackColor = Color.Yellow
            Button9.BackColor = Color.Yellow
            DisplayWinner()
        ElseIf Len(Button3.Text & Button5.Text & Button7.Text) > 0 And _
        Button4.Text = Button5.Text And Button6.Text = Button3.Text Then
            Button3.BackColor = Color.Yellow
            Button5.BackColor = Color.Yellow
            Button7.BackColor = Color.Yellow
            DisplayWinner()
        Else
            nextplayer()
        End If
    End Sub
    Private Sub restartgame()
        're-enable the buttons
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        'clear the button labels
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        'set the button background colors
        Button1.BackColor = Color.Lime
        Button2.BackColor = Color.Lime
        Button3.BackColor = Color.Lime
        Button4.BackColor = Color.Lime
        Button5.BackColor = Color.Lime
        Button6.BackColor = Color.Lime
        Button7.BackColor = Color.Lime
        Button8.BackColor = Color.Lime
        Button9.BackColor = Color.Lime

        'set up the new game
        player = 2
        token = "O"
        nextplayer()

    End Sub
End Class
