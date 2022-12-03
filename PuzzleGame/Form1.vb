Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.MovePiece(Button1, Button2)
        Module1.MovePiece(Button1, Button4)
        Module1.SolutionChecker()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Module1.MovePiece(Button2, Button1)
        Module1.MovePiece(Button2, Button3)
        Module1.MovePiece(Button2, Button5)
        Module1.SolutionChecker()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Module1.MovePiece(Button3, Button2)
        Module1.MovePiece(Button3, Button6)
        Module1.SolutionChecker()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Module1.MovePiece(Button4, Button1)
        Module1.MovePiece(Button4, Button5)
        Module1.MovePiece(Button4, Button7)
        Module1.SolutionChecker()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Module1.MovePiece(Button5, Button2)
        Module1.MovePiece(Button5, Button4)
        Module1.MovePiece(Button5, Button6)
        Module1.MovePiece(Button5, Button8)
        Module1.SolutionChecker()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Module1.MovePiece(Button6, Button3)
        Module1.MovePiece(Button6, Button5)
        Module1.MovePiece(Button6, Button9)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Module1.MovePiece(Button7, Button4)
        Module1.MovePiece(Button7, Button8)
        Module1.SolutionChecker()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Module1.MovePiece(Button8, Button5)
        Module1.MovePiece(Button8, Button7)
        Module1.MovePiece(Button8, Button9)
        Module1.SolutionChecker()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Module1.MovePiece(Button9, Button6)
        Module1.MovePiece(Button9, Button8)
        Module1.SolutionChecker()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim tempArr() As String = {"1", "2", "3", "4", "5", "6", "7", "8", " "}
        Randomize()
        Module1.numberOfMoves = 0

        For i As Integer = 0 To tempArr.Length - 1
            Dim j As Integer
            Dim temp As String
            j = Math.Floor(Rnd() * (i + 1))
            temp = tempArr(i)
            tempArr(i) = tempArr(j)
            tempArr(j) = temp
        Next

        For i = 0 To 8
            Module1.puzzleButtons(i).Text = tempArr(i)
            Module1.puzzleButtons(i).Enabled = True
        Next

        Button9.Enabled = True
        Button11.Enabled = False



    End Sub
End Class
