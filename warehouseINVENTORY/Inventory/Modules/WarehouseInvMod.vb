Imports System.Data.SqlClient

Module WarehouseInvMod

    Public Sub Warehouse_Inv_STP(ByVal StoredProcedureName As String,
                                 ByVal dsTbl_Command As String,
                                 Optional SearchString As String = "",
                                 Optional cols As String = "",
                                 Optional supplier As String = "",
                                 Optional costhead As String = "",
                                 Optional typecolor As String = "",
                                 Optional articleno As String = "",
                                 Optional desc As String = "",
                                 Optional unit As String = "",
                                 Optional monetary As String = "",
                                 Optional location_inv As String = "",
                                 Optional header As String = "",
                                 Optional qty As Integer = 0,
                                 Optional min As Integer = 0,
                                 Optional ufactor As Decimal = 0.0D,
                                 Optional unitprice As Decimal = 0.0D,
                                 Optional stockno As Integer = 0)
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
                sqlCommand.Parameters.Add("@Cols", SqlDbType.VarChar).Value = cols
                sqlCommand.Parameters.Add("@SearchString", SqlDbType.VarChar).Value = SearchString

                sqlCommand.Parameters.Add("@supplier", SqlDbType.VarChar).Value = supplier
                sqlCommand.Parameters.Add("@costhead", SqlDbType.VarChar).Value = costhead
                sqlCommand.Parameters.Add("@typecolor", SqlDbType.VarChar).Value = typecolor
                sqlCommand.Parameters.Add("@articleno", SqlDbType.VarChar).Value = articleno
                sqlCommand.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc
                sqlCommand.Parameters.Add("@unit", SqlDbType.VarChar).Value = unit
                sqlCommand.Parameters.Add("@monetary", SqlDbType.VarChar).Value = monetary
                sqlCommand.Parameters.Add("@location_inv", SqlDbType.VarChar).Value = location_inv
                sqlCommand.Parameters.Add("@header", SqlDbType.VarChar).Value = header
                sqlCommand.Parameters.Add("@inputted", SqlDbType.VarChar).Value = user_fullname

                sqlCommand.Parameters.Add("@qty", SqlDbType.Int).Value = qty
                sqlCommand.Parameters.Add("@min", SqlDbType.Int).Value = min
                sqlCommand.Parameters.Add("@ufactor", SqlDbType.Decimal).Value = ufactor
                sqlCommand.Parameters.Add("@unitprice", SqlDbType.Decimal).Value = unitprice

                sqlCommand.Parameters.Add("@stockno", SqlDbType.Int).Value = stockno

                sqlCommand.ExecuteNonQuery()
                transaction.Commit()

                sql_Transaction_result = "Committed"

                If dsTbl_Command.Contains("Trans") = False And
                    dsTbl_Command.Contains("Print") = False Then

                    sqlDataAdapter.SelectCommand = sqlCommand
                    sqlDataAdapter.Fill(sqlDataSet, dsTbl_Command)
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
