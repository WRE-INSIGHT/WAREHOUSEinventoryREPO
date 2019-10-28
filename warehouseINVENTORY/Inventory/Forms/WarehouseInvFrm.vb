Imports System.ComponentModel
Imports System.Data.SqlClient
Imports ComponentFactory.Krypton.Toolkit
Imports MetroFramework

Public Class WarehouseInvFrm
    Private BGW As BackgroundWorker = New BackgroundWorker
    Public DGV_Warehouse_Inventory As New KryptonDataGridView
    Dim dgv_bs As New BindingSource

    Dim todo, searchstring As String
    Private Sub Reset_here()
        Frm_Pnl.Enabled = True
        Loading_PB.SendToBack()
    End Sub
    Private Sub Start_BGW()
        Try
            If BGW.IsBusy <> True Then
                Frm_Pnl.Enabled = False
                Loading_PB.BringToFront()
                BGW.RunWorkerAsync()
            Else
                MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WarehouseInvFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BGW.WorkerSupportsCancellation = True
        BGW.WorkerReportsProgress = True
        AddHandler BGW.DoWork, AddressOf BGW_DoWork
        AddHandler BGW.ProgressChanged, AddressOf BGW_ProgressChanged
        AddHandler BGW.RunWorkerCompleted, AddressOf BGW_RunWorkerCompleted

        DGV_Warehouse_Inventory.DataSource = dgv_bs

        searchstring = ""
        todo = "Load_Warehouse"
        Start_BGW()
    End Sub

    Private Sub BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case todo
                Case "Load_Warehouse"
                    Warehouse_Inv_STP("warehouse_inv_stp", todo, searchstring)
                    BGW.ReportProgress(0)
            End Select
        Catch ex As SqlException
            BGW.CancelAsync()
            KMDIPrompts(Me, "SqlError", ex.Message, ex.StackTrace, ex.Number, True)
            Try
                transaction.Rollback()
                sql_Transaction_result = "Rollback"
            Catch ex2 As Exception
                KMDIPrompts(Me, "DotNetError", ex2.Message, ex2.StackTrace)
                BGW.CancelAsync()
                Exit Sub
            End Try
        Catch ex As Exception
            BGW.CancelAsync()
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            Exit Sub
        End Try
    End Sub

    Private Sub BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try
            Select Case todo
                Case "Load_Warehouse"
                    If Not Frm_Pnl.Controls.Contains(DGV_Warehouse_Inventory) Then
                        DGV_Properties(DGV_Warehouse_Inventory, "DGV_Warehouse_Inventory")
                        AddHandler DGV_Warehouse_Inventory.RowPostPaint, AddressOf dgv_rowpostpaint
                        Frm_Pnl.Controls.Add(DGV_Warehouse_Inventory)
                    End If
            End Select
        Catch ex As Exception
            Reset_here()
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            Exit Sub
        End Try
    End Sub

    Private Sub BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                'If BackgroundWorker Then terminated due To Error
            Else
                If sql_Transaction_result = "Committed" Then
                    Select Case todo
                        Case "Load_Warehouse"
                            dgv_bs.DataSource = sqlDataSet
                            dgv_bs.DataMember = todo
                            With DGV_Warehouse_Inventory
                                .AllowUserToResizeColumns = False
                                .AllowUserToResizeRows = False
                                .AllowUserToOrderColumns = False
                                .Select()
                                .Columns("Row_Status").Visible = False
                                'For i = 0 To .Columns.Count - 1
                                '    If .Columns(i).HeaderText.Contains("_") Then
                                '        .Columns(i).Visible = False
                                '    End If
                                '    .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                                'Next
                                '.Columns("BRAND").Frozen = True
                                '.Columns("DATE PURCHASED").DefaultCellStyle.Format = "MMM. dd, yyyy"
                                '.Columns("MARKET PRICE").DefaultCellStyle.Format = "N2"
                                '.Columns("PURCHASED PRICE").DefaultCellStyle.Format = "N2"
                                '.Columns("DISCOUNT").DefaultCellStyle.Format = "N2"
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                                .MultiSelect = True
                                .ClearSelection()
                            End With
                            Reset_here()
                    End Select
                End If
            End If
        Catch ex As Exception
            Reset_here()
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_rowpostpaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        rowpostpaint(sender, e)
    End Sub

    Private Sub WarehouseInvFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainFrm.InventoryToolStripMenuItem.Checked = False
    End Sub

    Private Sub WarehouseInvFrm_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Loading_PB.Location = New Point((Width - Loading_PB.Width) / 2, (Height - Loading_PB.Height) / 2)
    End Sub

End Class