Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch

    Public Sub New()
        InitializeComponent()
        stopwatch = New Stopwatch()
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission = New Submission(txtName.Text, txtEmail.Text, txtPhone.Text, txtGithub.Text, lblStopwatchTime.Text)
        ' Call the API to submit the form
        ' This is a placeholder; replace with actual API call
        MessageBox.Show("Form submitted successfully!")
    End Sub

    Private Sub UpdateStopwatchLabel()
        lblStopwatchTime.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub
End Class
