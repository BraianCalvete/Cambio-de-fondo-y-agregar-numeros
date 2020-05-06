Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (txtAgregarNumero.Text >= 1) And (txtAgregarNumero.Text <= 100) Then

            ListBox1.Items.Add(txtAgregarNumero.Text)
            txtAgregarNumero.Clear()
        Else

            MsgBox("El número que ingreso esta fuera del rango permitido, intente denuevo")
            txtAgregarNumero.Clear()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim cantidad As Integer
        Dim promedio
        Dim total As Double

        total = CDbl(ListBox1.Text)
        cantidad = ListBox1.Items.Count
        promedio = total / 100 * cantidad
        MsgBox("El promedio es" & promedio & "  " & cantidad & "  " & total)


    End Sub
End Class
