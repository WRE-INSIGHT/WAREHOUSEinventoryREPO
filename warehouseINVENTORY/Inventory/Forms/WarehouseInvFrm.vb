Imports System.ComponentModel
Imports System.Data.SqlClient
Imports ComponentFactory.Krypton.Toolkit
Imports MetroFramework

Public Class WarehouseInvFrm
    Private BGW As BackgroundWorker = New BackgroundWorker
    Public DGV_Warehouse_Inventory As New KryptonDataGridView
    Dim dgv_bs As New BindingSource
    Dim supplier_bs As New BindingSource
    Dim costhead_bs As New BindingSource
    Dim typecolor_bs As New BindingSource
    Dim articleno_bs As New BindingSource
    Dim header_bs As New BindingSource

    Dim cbox_bs As New BindingSource

    Dim todo, todo_mode, searchstring, stock_cols,
        supplier, costhead, typecolor, articleno, desc, unit, monetary, location_inv, header As String
    Dim ufactor, unitprice As Decimal
    Dim cbox_obj As Object
    Dim ctr_todo, stockno, qty, min, CboxselIndex As Integer
    Private Sub Reset_here()
        DGV_Warehouse_Inventory.Enabled = True
        Loading_PB.Visible = False
        todo_mode = ""
        ctr_todo = 0
    End Sub
    Private Sub Start_BGW()
        Try
            If BGW.IsBusy <> True Then
                DGV_Warehouse_Inventory.Enabled = False
                Loading_PB.Visible = True
                BGW.RunWorkerAsync()
            Else
                MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub save()
        supplier = Trim(Supplier_Cbox.Text)
        costhead = Trim(Costhead_Cbox.Text)
        typecolor = Trim(TypeColor_Cbox.Text)
        articleno = Trim(ArticleNo_Cbox.Text)
        desc = Trim(Desc_Tbox.Text)
        unit = Trim(Unit_Tbox.Text)
        monetary = Trim(Monetary_Tbox.Text)
        location_inv = Trim(Location_Tbox.Text)
        header = Trim(Header_Cbox.Text)
        ufactor = CDec(UFactor_Tbox.Text)
        unitprice = CDec(UnitPrice_Tbox.Text)
        qty = CInt(Qty_Tbox.Text)
        min = CInt(Min_Tbox.Text)

        If stockno = 0 Then
            todo_mode = "CheckExists"
            todo = "GetExisting"
        Else
            todo_mode = ""
            todo = "TransUpdInv"
        End If
        Start_BGW()
    End Sub
    Private Sub WarehouseInvFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BGW.WorkerSupportsCancellation = True
        BGW.WorkerReportsProgress = True
        AddHandler BGW.DoWork, AddressOf BGW_DoWork
        AddHandler BGW.ProgressChanged, AddressOf BGW_ProgressChanged
        AddHandler BGW.RunWorkerCompleted, AddressOf BGW_RunWorkerCompleted

        DGV_Warehouse_Inventory.DataSource = dgv_bs

        searchstring = ""
        'todo_mode = "onload"
        todo = "Load_Warehouse"
        Start_BGW()
    End Sub

    Private Sub BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case todo
                Case "Load_Warehouse"
                    Warehouse_Inv_STP("warehouse_inv_stp", todo, "%" & searchstring & "%")
                    BGW.ReportProgress(0)

                Case "Load_ComboBoxData"
                    Warehouse_Inv_STP("warehouse_inv_stp", todo,, stock_cols)
                    BGW.ReportProgress(0)

                Case "GetExisting"
                    Warehouse_Inv_STP("warehouse_inv_stp", todo,,,, costhead, typecolor, articleno)

                Case "TransAddInv"
                    Warehouse_Inv_STP("warehouse_inv_stp", todo,,, supplier, costhead, typecolor, articleno, desc,
                                      unit, monetary, location_inv, header, qty, min, ufactor, unitprice)

                Case "TransUpdInv"
                    Warehouse_Inv_STP("warehouse_inv_stp", todo,,, supplier, costhead, typecolor, articleno, desc,
                                      unit, monetary, location_inv, header, qty, min, ufactor, unitprice, stockno)

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
            End Try
        Catch ex As Exception
            BGW.CancelAsync()
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
        If BGW.CancellationPending = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try
            Select Case todo
                Case "Load_Warehouse"
                    If Not Frm_Split.Panel1.Controls.Contains(DGV_Warehouse_Inventory) Then
                        DGV_Properties(DGV_Warehouse_Inventory, "DGV_Warehouse_Inventory")
                        AddHandler DGV_Warehouse_Inventory.RowPostPaint, AddressOf dgv_rowpostpaint
                        AddHandler DGV_Warehouse_Inventory.DataError, AddressOf dgv_dataerror
                        'AddHandler DGV_Warehouse_Inventory.CellMouseClick, AddressOf dgv_cellmouseclick

                        Frm_Split.Panel1.Controls.Add(DGV_Warehouse_Inventory)
                    End If

                Case "Load_ComboBoxData"
                    cbox_bs = New BindingSource
                    cbox_bs.DataSource = sqlDataSet
                    cbox_bs.DataMember = todo
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
                Reset_here()
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
                                .Columns("STOCKNO").Visible = False
                                '.Columns("QTY").DefaultCellStyle.Format = "N2"
                                '.Columns("MINIMUM").DefaultCellStyle.Format = "N2"
                                .Columns("UNITPRICE").DefaultCellStyle.Format = "N2"
                                .Columns("NETAMOUNT").DefaultCellStyle.Format = "N2"
                                .Columns("UFACTOR").DefaultCellStyle.Format = "N2"
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                                .MultiSelect = True
                                .ClearSelection()
                            End With
                            If todo_mode <> "" Then
                                ctr_todo += 1
                            Else
                                Reset_here()
                            End If

                        Case "Load_ComboBoxData"
                            cbox_obj.DataSource = cbox_bs
                            cbox_obj.DisplayMember = stock_cols


                            If CboxselIndex > cbox_obj.Items.Count - 1 Then
                                cbox_obj.SelectedIndex = -1
                            Else
                                cbox_obj.SelectedIndex = CboxselIndex
                            End If

                            If todo_mode <> "" Then
                                ctr_todo += 1
                            Else
                                Reset_here()
                            End If

                        Case "TransAddInv"
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            Search_Tbox.CustomButton.PerformClick()

                            If todo_mode <> "" Then
                                ctr_todo += 1
                            Else
                                Reset_here()
                            End If

                        Case "TransUpdInv"
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            Search_Tbox.CustomButton.PerformClick()
                            stockno = Nothing
                            Mode_Lbl.Text = "New"
                            Mode_Lbl.ForeColor = Color.DarkSlateBlue
                            Qty_Tbox.BackColor = SystemColors.Window
                            Qty_Tbox.Enabled = True

                        Case "GetExisting"
                            If todo_mode <> "" Then
                                If sqlDataSet.Tables(todo).Rows(0).Item(0) <> 0 Then
                                    KMDIPrompts(Me, "UserWarning",,,, True, True, "Exisiting Item", False)
                                    Reset_here()
                                Else
                                    ctr_todo += 1
                                End If
                            Else
                                Reset_here()
                            End If
                    End Select

                    Select Case todo_mode
                        Case "CheckExists"
                            Select Case ctr_todo
                                Case 1
                                    todo = "TransAddInv"
                                    Start_BGW()
                                Case 2
                                    Reset_here()

                            End Select
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

    Private Sub dgv_dataerror(sender As Object, e As DataGridViewDataErrorEventArgs)

    End Sub

    'Private Sub dgv_cellmouseclick(sender As Object, e As DataGridViewCellMouseEventArgs)
    '    Try
    '        If e.Button = MouseButtons.Right AndAlso BGW.IsBusy <> True Then
    '            sender.Rows(e.RowIndex).Selected = True
    '            If DGV_Warehouse_Inventory.SelectedRows.Count > 1 Then
    '                UpdateToolStripMenuItem.Visible = False
    '            Else
    '                UpdateToolStripMenuItem.Visible = True
    '            End If
    '            Inv_Cmenu.Show()
    '            Inv_Cmenu.Location = New Point(MousePosition.X, MousePosition.Y)
    '        End If
    '    Catch ex As Exception
    '        KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
    '    End Try
    'End Sub

    Private Sub WarehouseInvFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainFrm.InventoryToolStripMenuItem.Checked = False
    End Sub

    Private Sub TransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click, UpdateToolStripMenuItem.Click
        'Dim invItem As Form = WarehouseItemFrm
        'invItem.MdiParent = MainFrm
        'invItem.Show()
        WarehouseItemFrm.ShowDialog()
    End Sub

    Private Sub Tbox_Leave(sender As Object, e As EventArgs) Handles UnitPrice_Tbox.Leave, UFactor_Tbox.Leave, Qty_Tbox.Leave, Min_Tbox.Leave
        If Not IsNumeric(sender.text) Then
            KMDIPrompts(Me, "UserWarning",,,, True, True, sender.Tag & " must be a valid number", False)
            sender.Focus()
        End If
    End Sub

    Private Sub WarehouseInvFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                stockno = Nothing
                Supplier_Cbox.Focus()
                Mode_Lbl.Text = "New"
                Mode_Lbl.ForeColor = Color.DarkSlateBlue
                Qty_Tbox.BackColor = SystemColors.Window
                Qty_Tbox.Enabled = True

            ElseIf e.KeyCode = Keys.F2 Then
                If DGV_Warehouse_Inventory.SelectedRows.Count = 1 Then
                    Dim items As DataGridViewSelectedRowCollection = DGV_Warehouse_Inventory.SelectedRows
                    stockno = items(0).Cells("STOCKNO").Value
                    Supplier_Cbox.Text = items(0).Cells("SUPPLIER").Value.ToString
                    Costhead_Cbox.Text = items(0).Cells("COSTHEAD").Value.ToString
                    TypeColor_Cbox.Text = items(0).Cells("TYPECOLOR").Value.ToString
                    ArticleNo_Cbox.Text = items(0).Cells("ARTICLENO").Value.ToString
                    Desc_Tbox.Text = items(0).Cells("DESCRIPTION").Value.ToString
                    Qty_Tbox.Text = items(0).Cells("QTY").Value.ToString
                    Min_Tbox.Text = items(0).Cells("MINIMUM").Value.ToString
                    Unit_Tbox.Text = items(0).Cells("UNIT").Value.ToString
                    UFactor_Tbox.Text = items(0).Cells("UFACTOR").Value.ToString
                    Monetary_Tbox.Text = items(0).Cells("MONETARY").Value.ToString
                    UnitPrice_Tbox.Text = items(0).Cells("UNITPRICE").Value.ToString
                    Location_Tbox.Text = items(0).Cells("LOCATION").Value.ToString
                    Header_Cbox.Text = items(0).Cells("HEADER").Value.ToString

                    Supplier_Cbox.Focus()
                    Mode_Lbl.Text = "Edit " & Desc_Tbox.Text
                    Mode_Lbl.ForeColor = Color.Maroon
                    Qty_Tbox.BackColor = Color.Silver
                    Qty_Tbox.Enabled = False
                Else
                    KMDIPrompts(Me, "UserWarning",,,, True, True, "Select one(1) item only.", False)
                End If

            ElseIf e.KeyCode = Keys.F3 Then

            ElseIf e.KeyCode = Keys.F4 Then
                For Each ctrl In Frm_Split.Panel2.Controls
                    If ctrl.GetType Is GetType(ComboBox) Then
                        ctrl.Text = ""
                    ElseIf ctrl.GetType Is GetType(TextBox) Then
                        If ctrl.Tag <> "" Then
                            ctrl.Text = "0"
                        Else
                            ctrl.Clear()
                        End If
                    End If
                Next
                stockno = Nothing
                Supplier_Cbox.Focus()
                Mode_Lbl.Text = "New"
                Mode_Lbl.ForeColor = Color.DarkSlateBlue
                Qty_Tbox.BackColor = SystemColors.Window
                Qty_Tbox.Enabled = True

            ElseIf e.KeyCode = Keys.F5 Then
                Search_Tbox.Clear()
                searchstring = ""
                todo = "Load_Warehouse"
                Start_BGW()

            ElseIf e.Control And e.KeyCode = Keys.S Then
                save()

            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub Search_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles Search_Tbox.ButtonClick
        'DGV_Warehouse_Inventory.Rows.Clear()
        searchstring = Trim(Search_Tbox.Text)
        todo = "Load_Warehouse"
        Start_BGW()
    End Sub

    'Private Sub Cbox_Enter(sender As Object, e As EventArgs) Handles TypeColor_Cbox.Enter,
    '                                                                 Supplier_Cbox.Enter,
    '                                                                 Header_Cbox.Enter,
    '                                                                 Costhead_Cbox.Enter,
    '                                                                 ArticleNo_Cbox.Enter
    '    'If sender.DataSource Is Nothing Then
    '    cbox_obj = sender
    '    stock_cols = sender.Tag
    '    todo = "Load_ComboBoxData"
    '    Start_BGW()
    '    'End If
    'End Sub

    Private Sub Cbox_MouseDown(sender As Object, e As MouseEventArgs) Handles TypeColor_Cbox.MouseDown,
                                                                              Supplier_Cbox.MouseDown,
                                                                              Header_Cbox.MouseDown,
                                                                              Costhead_Cbox.MouseDown,
                                                                              ArticleNo_Cbox.MouseDown
        CboxselIndex = sender.SelectedIndex
        cbox_obj = sender
        stock_cols = sender.Tag
        todo = "Load_ComboBoxData"
        Start_BGW()

    End Sub
    Private Sub Search_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Search_Tbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search_Tbox.CustomButton.PerformClick()
        End If
    End Sub
    Private Sub Frm_Split_Panel1_SizeChanged(sender As Object, e As EventArgs) Handles Frm_Split.Panel1.SizeChanged
        Loading_PB.Location = New Point((sender.Width - Loading_PB.Width) / 2, (sender.Height - Loading_PB.Height) / 2)
    End Sub

End Class