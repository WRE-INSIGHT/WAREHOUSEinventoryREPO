Imports System.Data.SqlClient
Module LoginMod
    Public sqlConnection As New SqlConnection
    Public sqlCommand As SqlCommand
    Public sqlReader As SqlDataReader
    Public transaction As SqlTransaction

    Public KMDISystemsConnectionType As String = Nothing
    Public sqlconnString As String = "Data Source='192.168.1.21,49107';Network Library=DBMSSOCN;Initial Catalog='warehousedb';User ID='kmdiadmin';Password='kmdiadmin';"

    Public user_id As Integer
    Public sql_Transaction_result, user_fullname, user_nick, user_accttype As String

    Public Sub WarehouseSystems_Login(ByVal UserName As String,
                                      ByVal Password As String)

        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, "warehouse_login")
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = "warehouse_login"
                sqlCommand.CommandType = CommandType.StoredProcedure
                sqlCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = UserName
                sqlCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = Password

                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    While read.Read
                        user_id = read.Item("user_id")
                        user_accttype = read.Item("user_accttype").ToString
                        user_nick = read.Item("user_nickname").ToString
                        user_fullname = read.Item("user_fullname").ToString
                    End While
                End Using
                transaction.Commit()

                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub

End Module
