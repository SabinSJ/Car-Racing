Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQL_Control
    Public SQLCon As New SqlConnection With {.ConnectionString = "Server=SABINSJ;Database=master;User=sa;Pwd=racingcar;"}
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
