Imports MySql.Data.MySqlClient
Public Class frmRepSites
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMain.Enabled = True
        Me.Dispose()

    End Sub

    Private Sub frmRepSites_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksio()
        Dim da1 As New MySqlDataAdapter("SELECT * FROM fuelstations", sqlConnect)
        Me.DataSet1.fuelstations.Clear()
        da1.Fill(DataSet1.fuelstations)
        Me.ReportViewer1.RefreshReport()
        sqlConnect.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class