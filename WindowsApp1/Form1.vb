Public Class Form1
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ViewSubmissions()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            CreateNewSubmission()
        End If
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ViewSubmissions()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        CreateNewSubmission()
    End Sub

    Private Sub ViewSubmissions()
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.ShowDialog()
    End Sub

    Private Sub CreateNewSubmission()
        Dim createForm As New CreateSubmissionForm()
        createForm.ShowDialog()
    End Sub
End Class
