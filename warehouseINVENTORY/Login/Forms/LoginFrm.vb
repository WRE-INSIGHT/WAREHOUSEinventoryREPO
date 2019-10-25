Imports MetroFramework
Public Class LoginFrm
    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tbox_Enter(sender As Object, e As EventArgs) Handles UserNameTbox.Enter, PasswordTbox.Enter
        If sender Is PasswordTbox Then
            PasswordLbl.FontWeight = MetroLabelWeight.Bold
        ElseIf sender Is UserNameTbox Then
            UserNameLbl.FontWeight = MetroLabelWeight.Bold
        End If
    End Sub

    Private Sub Tbox_Leave(sender As Object, e As EventArgs) Handles UserNameTbox.Leave, PasswordTbox.Leave
        If sender Is PasswordTbox Then
            PasswordLbl.FontWeight = MetroLabelWeight.Light
        ElseIf sender Is UserNameTbox Then
            UserNameLbl.FontWeight = MetroLabelWeight.Light
        End If
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        LoginBtn.SendToBack()
    End Sub
End Class
