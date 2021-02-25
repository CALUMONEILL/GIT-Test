Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'button
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnAidansButton_Click(sender As Object, e As EventArgs) Handles btnAidansButton.Click
        MessageBox.Show("it is this working???")
    End Sub

    Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
        MessageBox.Show("Another message")
    End Sub
End Class
