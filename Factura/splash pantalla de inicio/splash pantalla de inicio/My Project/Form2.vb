Public Class Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static contar As Integer
        If contar < 100 Then
            contar = contar + 10
            ProgressBar1.Value = contar


        Else
            Timer1.Stop()
            contar = 0
            principal.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class