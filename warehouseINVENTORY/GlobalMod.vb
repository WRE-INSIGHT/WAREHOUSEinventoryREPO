Imports System.IO
Imports MetroFramework

Module GlobalMod
    Public Log_File As StreamWriter
    Public QuestionPromptAnswer As Integer

    Public Sub KMDIPrompts(ByVal FormName As Form,
                           ByVal PromptMode As String,
                           Optional sql_Err_msg As String = "",
                           Optional sql_Err_StackTrace As String = "",
                           Optional sql_Err_no As Integer = Nothing,
                           Optional WillPrompt As Boolean = False,
                           Optional CustomPrompt As Boolean = False,
                           Optional PromptContent As String = Nothing,
                           Optional LogToFile As Boolean = True,
                           Optional Buttons As MessageBoxButtons = MessageBoxButtons.OK)

        Dim PreErrorMsg As String = Nothing, PreErrorNo As String = Nothing

        Select Case LogToFile
            Case True
                Select Case PromptMode
                    Case "DotNetError"
                        PreErrorNo = "Error Number: "
                        PreErrorMsg = "Error Message: "
                    Case "SqlError"
                        PreErrorNo = "SQL Transaction Error Number: "
                        PreErrorMsg = "SQL Transaction Error Message: "
                    Case "UserWarning"
                        PreErrorNo = "Error Number: "
                        PreErrorMsg = "Warning message: "
                    Case "Failed"
                        PreErrorNo = "Error Number: "
                        PreErrorMsg = "Failed Message: "
                    Case "SystemMaintenance"
                        PreErrorNo = "Error Number: "
                        PreErrorMsg = "System Maintenance: "
                End Select

                Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
                Log_File.WriteLine("Logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                           PreErrorNo & sql_Err_no & vbCrLf &
                                           PreErrorMsg & sql_Err_msg & vbCrLf &
                                           "Trace: " & sql_Err_StackTrace & vbCrLf)
                Log_File.Close()

            Case False
        End Select

        Select Case WillPrompt
            Case True
                Select Case PromptMode
                    Case "DotNetError"
                        Select Case CustomPrompt
                            Case True
                                MetroMessageBox.Show(FormName, PromptContent, "Internal error",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Case False
                                MetroMessageBox.Show(FormName, "Press F5 to refresh", "Internal error",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Select

                    Case "SqlError"
                        Select Case sql_Err_no
                            Case -2
                                MetroMessageBox.Show(FormName, " ", "Request timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Case 1232 Or 121
                                MetroMessageBox.Show(FormName, "Please check internet connection", "Network disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Case 19
                                MetroMessageBox.Show(FormName, "Server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Case 1205
                                MetroMessageBox.Show(FormName, "Refresh the page", " ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Case Else
                                MetroMessageBox.Show(FormName, "Transaction failed", "Internal error",
                                                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Select
                    Case "UserWarning"
                        Select Case CustomPrompt
                            Case True
                                QuestionPromptAnswer = MetroMessageBox.Show(FormName, PromptContent, "Warning",
                                                                    Buttons, MessageBoxIcon.Warning)
                            Case False
                                MetroMessageBox.Show(FormName, "Press F5 to refresh", "Internal error",
                                                               MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Select
                    Case "Success"
                        MetroMessageBox.Show(FormName, " ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Case "Failed"
                        Select Case CustomPrompt
                            Case True
                                MetroMessageBox.Show(FormName, PromptContent, PromptMode, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Case False
                                MetroMessageBox.Show(FormName, " ", PromptMode, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End Select
                    Case "Question"
                        QuestionPromptAnswer = MetroMessageBox.Show(FormName, sql_Err_msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    Case "SystemMaintenance"
                        MetroMessageBox.Show(FormName, "Developers currently working on this. Be patient. Thank You!", "System Maintenance", MessageBoxButtons.OK, MessageBoxIcon.None)
                End Select
        End Select
    End Sub

End Module
