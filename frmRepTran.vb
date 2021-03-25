Imports MySql.Data.MySqlClient
Public Class frmRepTran
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMain.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub frmRepTran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksio()
        Dim da1 As New MySqlDataAdapter("SELECT * FROM transfers", sqlConnect)
        Me.DataSet1.transfers.Clear()
        da1.Fill(DataSet1.transfers)
        Me.ReportViewer1.RefreshReport()
        sqlConnect.Close()
    End Sub
End Class