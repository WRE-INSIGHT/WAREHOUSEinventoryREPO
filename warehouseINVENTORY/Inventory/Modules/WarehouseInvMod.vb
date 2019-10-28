﻿Imports System.Data.SqlClient

Module WarehouseInvMod

    Public Sub Warehouse_Inv_STP(ByVal StoredProcedureName As String,
                                 ByVal dsTbl_Command As String,
                                 Optional SearchString As String = "")
        sqlDataAdapter = New SqlDataAdapter
        sqlBindingSource = New BindingSource
        sqlDataSet = New DataSet
        If sqlDataSet.Tables.Contains(dsTbl_Command) Then
            sqlDataSet.Tables(dsTbl_Command).Clear()
        End If
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure
                sqlCommand.Parameters.Add("@todo", SqlDbType.VarChar).Value = dsTbl_Command
                sqlCommand.Parameters.Add("@SearchString", SqlDbType.VarChar).Value = SearchString
                sqlCommand.ExecuteNonQuery()
                transaction.Commit()

                sql_Transaction_result = "Committed"

                If dsTbl_Command.Contains("Trans") = False And dsTbl_Command.Contains("Print") = False Then
                    SqlDataAdapter.SelectCommand = sqlCommand
                    SqlDataAdapter.Fill(sqlDataSet, dsTbl_Command)
                    sqlBindingSource.DataSource = sqlDataSet
                    sqlBindingSource.DataMember = dsTbl_Command
                    'ElseIf dsTbl_Command.Contains("Print") = True Then
                    '    If dsTbl_Command = "PrintER_Items" Then
                    '        SqlDataAdapter.SelectCommand = sqlCommand
                    '        SqlDataAdapter.Fill(mi_ds.ER_Items)
                    '        RR_Transmittal.ER_ItemsBindingSource.DataSource = mi_ds.ER_Items.DefaultView
                    '    ElseIf dsTbl_Command = "PrintER_GiftSummary" Then
                    '        SqlDataAdapter.SelectCommand = sqlCommand
                    '        SqlDataAdapter.Fill(mi_ds.GiftSummaryBody)
                    '        RR_GiftSummary.GiftSummaryBodyBindingSource.DataSource = mi_ds.GiftSummaryBody.DefaultView
                    '    ElseIf dsTbl_Command = "PrintWithoutGifts" Then
                    '        SqlDataAdapter.SelectCommand = sqlCommand
                    '        SqlDataAdapter.Fill(mi_ds.WithoutGifts)
                    '        RR_WithoutGifts.WithoutGiftsBindingSource.DataSource = mi_ds.WithoutGifts.DefaultView
                    '    ElseIf dsTbl_Command = "PrintCreditPoints" Then
                    '        SqlDataAdapter.SelectCommand = sqlCommand
                    '        SqlDataAdapter.Fill(mi_ds.ExportCP)
                    '        RR_ExportCP.ExportCPBindingSource.DataSource = mi_ds.ExportCP.DefaultView
                    '    End If
                End If
            End Using
        End Using
    End Sub

End Module
