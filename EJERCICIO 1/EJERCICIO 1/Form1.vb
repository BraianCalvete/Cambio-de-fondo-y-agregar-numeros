Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.BackColor = Color.White

        Select Case txtColor.Text
            Case "1"
                Me.BackColor = Color.Black
            Case "2"
                Me.BackColor = Color.Yellow
            Case "3"
                Me.BackColor = Color.Blue
            Case "4"
                Me.BackColor = Color.Red
            Case "5"
                Me.BackColor = Color.Green
            Case Else
                Me.BackColor = Color.White

        End Select

    End Sub
End Class
