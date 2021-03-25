Imports MySql.Data.MySqlClient
Public Class frmRepRedempt
    Private Sub frmRepRedempt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksio()
        Dim da1 As New MySqlDataAdapter("SELECT * FROM redemptions", sqlConnect)
        Me.DataSet1.redemptions.Clear()
        da1.Fill(DataSet1.redemptions)
        Me.ReportViewer1.RefreshReport()
        sqlConnect.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMain.Enabled = True
        Me.Dispose()

    End Sub
End Class