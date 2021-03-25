Imports MySql.Data.MySqlClient
Public Class frmFuelAllo
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMain.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub frmFuelAllo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksio()
        Dim da1 As New MySqlDataAdapter("SELECT * FROM stocks", sqlConnect)
        Me.DataSet1.stocks.Clear()
        da1.Fill(DataSet1.stocks)
        Me.ReportViewer1.RefreshReport()
        sqlConnect.Close()
    End Sub
End Class