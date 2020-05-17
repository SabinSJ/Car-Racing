Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQL_Control
    Public SQLCon As New SqlConnection With {.ConnectionString = "Server=SabinSJ;Database=master;User=sa;Pwd=racingcar;"}
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataSet As DataSet

    Public Function HasConnection() As Boolean
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub RunQuery(Query As String)

        Try
            SQLCon.Open()

            SQLCmd = New SqlCommand(Query, SQLCon)
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDataSet = New DataSet
            SQLDA.Fill(SQLDataSet)

            SQLCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If

        End Try
    End Sub


    Public Sub AddName(Name As String, Score As Integer)
        Try
            Dim strInsert As String = "Insert INTO rank (name,score)" &
                                      " VALUES (" &
                                      "'" & Name & "'," & Score & ")"

            SQLCon.Open()

            SQLCmd = New SqlCommand(strInsert, SQLCon)
            SQLCmd.ExecuteNonQuery()

            SQLCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
