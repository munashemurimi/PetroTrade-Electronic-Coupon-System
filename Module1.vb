Imports MySql.Data.MySqlClient
Module Module1
    Public serverString As String = "Server=localhost; User Id=root; Password=; Database=petrodbase"
    Public sqlConnect As MySqlConnection = New MySqlConnection
    Public itm As Integer = 0
    Public cnt As Integer = 0
    Public EcNum As String = "0000"
    Public Ryts As String = ""
    Public saleRec As String = ""
    Public petCost As String = ""
    Public dieCost As String = ""
    Public siteID As String = ""
    Public stkID As String = ""
    Public Sub koneksio()

        If sqlConnect.State = ConnectionState.Open Then
            sqlConnect.Close()
        End If
        sqlConnect.ConnectionString = serverString
        Try
            If sqlConnect.State = ConnectionState.Closed Then
                sqlConnect.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module


