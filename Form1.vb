Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim centena As Integer
        Dim j As Integer
        Dim unidad As Integer
        For j = 100 To 999
            centena = Math.Truncate(j / 100)
            unidad = j Mod 10
            If centena = unidad Then
                Lbl1.Text = "Los capicua son"
                ListB1.Items.Add(j)
            End If
        Next j

    End Sub
End Class
