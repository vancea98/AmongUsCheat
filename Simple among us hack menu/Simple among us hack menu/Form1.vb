Public Class Form1
    Private Sub ImpoButton_Click(sender As Object, e As EventArgs) Handles ImpoButton.Click
        Dim imposter As New ProcessStartInfo("Source.exe")
        imposter.WindowStyle = ProcessWindowStyle.Hidden

        Process.Start(imposter)
    End Sub

    Private Sub CrewButton_Click(sender As Object, e As EventArgs) Handles CrewButton.Click
        Dim imposter As New ProcessStartInfo("Force CrewMate.exe")
        imposter.WindowStyle = ProcessWindowStyle.Hidden

        Process.Start(imposter)
    End Sub
End Class
