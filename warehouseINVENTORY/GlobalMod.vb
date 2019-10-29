Imports System.Data.SqlClient
Imports System.IO
Imports ComponentFactory.Krypton.Toolkit
Imports MetroFramework

Module GlobalMod
    Public Log_File As StreamWriter
    Public QuestionPromptAnswer As Integer

    Public sqlDataAdapter As SqlDataAdapter
    Public sqlDataSet As New DataSet
    Public sqlBindingSource As BindingSource

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
    Public Sub rowpostpaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs)
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        e.PaintHeader(DataGridViewPaintParts.Background)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New Font("Microsoft Sans Serif", 10.0!,
            FontStyle.Regular,
            GraphicsUnit.Point, CType(0, Byte))

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)

        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub
    Public Sub DGV_Properties(ByVal DGV As KryptonDataGridView,
                              ByVal dgvName As String)
        With DGV
            .Name = dgvName
            .Dock = DockStyle.Fill
            .Select()
            .DefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AllowUserToOrderColumns = True
            .AllowUserToResizeColumns = True
            .AllowUserToResizeRows = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            '.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            .CausesValidation = True
            .ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText
            .PaletteMode = PaletteMode.Office2010Silver
            .ColumnHeadersHeight = 30
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            With .GridStyles
                .Style = DataGridViewStyle.List
                .StyleColumn = DataGridViewStyle.List
                .StyleDataCells = DataGridViewStyle.List
                .StyleRow = DataGridViewStyle.List
            End With
            .HideOuterBorders = True
            .ReadOnly = True
            .ScrollBars = ScrollBars.Both
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ShowCellErrors = True
            .ShowCellToolTips = True
            .ShowRowErrors = True
            .StandardTab = False
            .MultiSelect = True
            With .StateCommon
                .Background.Color1 = Color.White
                .Background.Color2 = Color.Transparent
                .DataCell.Content.Color1 = Color.Black
                .DataCell.Content.Color2 = Color.Transparent
                .DataCell.Content.ColorAngle = -1
                .DataCell.Content.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                .HeaderColumn.Back.Color1 = Color.FromArgb(11, 19, 36)
                .HeaderColumn.Back.Color2 = Color.FromArgb(11, 19, 36)
                .HeaderColumn.Back.ColorAngle = -1
                .HeaderColumn.Back.ColorStyle = PaletteColorStyle.Dashed
                .HeaderColumn.Border.Width = 0
                .HeaderColumn.Content.Color1 = Color.White
                .HeaderColumn.Content.Color2 = Color.Transparent
                .HeaderColumn.Content.Font = New Font("Segoe UI", 11.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                .HeaderColumn.Content.Hint = PaletteTextHint.AntiAlias
            End With
        End With
    End Sub

End Module
