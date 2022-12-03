

Module Module1
    Public puzzleButtons() As Button = {Form1.Button1, Form1.Button2, Form1.Button3, Form1.Button4,
                                        Form1.Button5, Form1.Button6, Form1.Button7, Form1.Button8, Form1.Button9}

    Public numberOfMoves As Integer = 0

    Sub MovePiece(ByRef btn1 As Button, ByRef btn2 As Button)
        If btn2.Text = " " Then
            btn2.Text = btn1.Text
            btn1.Text = " "
            numberOfMoves += 1
        End If
    End Sub

    Sub SolutionChecker()
        If Form1.Button1.Text = "1" And Form1.Button2.Text = "2" And
                Form1.Button3.Text = "3" And Form1.Button4.Text = "4" And
                Form1.Button5.Text = "5" And Form1.Button5.Text = "5" And
                Form1.Button6.Text = "6" And Form1.Button7.Text = "7" And
                Form1.Button8.Text = "8" Then
            MsgBox("You solved it in " + CStr(numberOfMoves) + " moves")
            For i = 0 To 8
                puzzleButtons(i).Enabled = False
            Next

            Form1.Button9.Enabled = False
            Form1.Button11.Enabled = True
        End If

        If Form1.Button1.Text = "1" And Form1.Button2.Text = "2" And
        Form1.Button3.Text = "3" And Form1.Button4.Text = "4" And
        Form1.Button5.Text = "5" And Form1.Button5.Text = "5" And
        Form1.Button6.Text = "6" And Form1.Button7.Text = "8" And
        Form1.Button8.Text = "7" Then
            Form1.Button7.Text = "7"
            Form1.Button8.Text = "8"

            MsgBox("You solved it in " + CStr(numberOfMoves) + " moves")
            For i = 0 To 8
                puzzleButtons(i).Enabled = False
            Next

            Form1.Button9.Enabled = False
            Form1.Button11.Enabled = True
        End If
    End Sub

End Module
