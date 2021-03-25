Imports MySql.Data.MySqlClient
Public Class frmRepSales
    Private Sub btnHome_Click(sender As Object, e As EventArgs)
        frmMain.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub frmRepSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksio()
        Dim da1 As New MySqlDataAdapter("SELECT * FROM fuelsales", sqlConnect)
        Me.DataSet1.fuelsales.Clear()
        da1.Fill(DataSet1.fuelsales)
        Me.ReportViewer1.RefreshReport()
        sqlConnect.Close()
    End Sub

    Private Sub btnHome_Click_1(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMain.Enabled = True
        Me.Dispose()
    End Sub
End Class