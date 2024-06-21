Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)

    Public Sub New()
        InitializeComponent()
        LoadSubmissions()
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub LoadSubmissions()
        ' API call to backend to load submissions
        ' This is a placeholder; replace with actual API call
        submissions = New List(Of Submission)()
        ' Example data
        submissions.Add(New Submission("John Doe", "johndoe@gmail.com", "9876543210", "https://github.com/johndoe/my_slidely_task", "00:01:19"))
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(index)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGithub.Text = submission.GithubLink
            txtStopwatch.Text = submission.StopwatchTime
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String

    Public Sub New(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String)
        Me.Name = name
        Me.Email = email
        Me.Phone = phone
        Me.GithubLink = githubLink
        Me.StopwatchTime = stopwatchTime
    End Sub
End Class
