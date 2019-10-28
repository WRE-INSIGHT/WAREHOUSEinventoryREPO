Imports System.ComponentModel
Imports System.Data.SqlClient
Imports MetroFramework
Public Class LoginFrm
    Private BGW As BackgroundWorker = New BackgroundWorker
    Dim user, pass As String
    Private Sub Reset_here()
        LoginBtn.Enabled = True
        UserNameTbox.Enabled = True
        PasswordTbox.Enabled = True
        Loading_PB.SendToBack()
    End Sub
    Private Sub Start_BGW()
        Try
            If BGW.IsBusy <> True Then
                LoginBtn.Enabled = False
                UserNameTbox.Enabled = False
                PasswordTbox.Enabled = False
                Loading_PB.BringToFront()
                BGW.RunWorkerAsync()
            Else
                MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BGW.WorkerSupportsCancellation = True
        BGW.WorkerReportsProgress = True
        AddHandler BGW.DoWork, AddressOf BGW_DoWork
        AddHandler BGW.RunWorkerCompleted, AddressOf BGW_RunWorkerCompleted
    End Sub

    Private Sub BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            If user = Nothing Then
                MetroMessageBox.Show(Me, "Please enter username", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                BGW.CancelAsync()
            ElseIf pass = Nothing Then
                MetroMessageBox.Show(Me, "Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                BGW.CancelAsync()
            Else
                WarehouseSystems_Login(user, pass)
            End If

        Catch ex As SqlException
            If ex.Number = -2 Then
                MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf ex.Number = 1232 Then
                MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BGW.CancelAsync()
            ElseIf ex.Number = 19 Then
                MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BGW.CancelAsync()
            ElseIf ex.Number <> -2 And ex.Number <> 1232 And ex.Number <> 19 Then
                MetroMessageBox.Show(Me, ex.ToString)
                BGW.CancelAsync()
            End If
            BGW.CancelAsync()
            'KMDIPrompts(Me, "SqlError", ex.Message, ex.StackTrace, ex.Number, True)
            'Try
            '    transaction.Rollback()
            '    sql_Transaction_result = "Rollback"
            'Catch ex2 As Exception
            '    KMDIPrompts(Me, "DotNetError", ex2.Message, ex2.StackTrace)
            '    BGW.CancelAsync()
            '    Exit Sub
            'End Try
        Catch ex As Exception
            BGW.CancelAsync()
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
        If BGW.CancellationPending = True Then
            e.Cancel = True
        End If
    End Sub
    Private Sub BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                'If BackgroundWorker Then terminated due To Error
                Reset_here()
            Else
                If sql_Transaction_result = "Committed" Then
                    If user_id <> Nothing Then
                        Me.Hide()
                        MainFrm.Show()
                    Else
                        MetroMessageBox.Show(Me, "Login failed! Please Try again", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                    Reset_here()
                End If
            End If

        Catch ex As Exception
            Reset_here()
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            Exit Sub
        End Try
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
        Try
            user = Trim(UserNameTbox.Text)
            pass = Trim(PasswordTbox.Text)
            Start_BGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
End Class
