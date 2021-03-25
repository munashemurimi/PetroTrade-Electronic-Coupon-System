Imports MySql.Data.MySqlClient
Public Class frmFuelCosting


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtPetOne.Text = ""
        txtDieOne.Text = ""
        txtPetTwo.Text = ""
        txtDieTwo.Text = ""
        Call koneksio()
        Dim da As New MySqlDataAdapter("SELECT * FROM tblone", sqlConnect)
        Dim dt As New DataTable
        da.Fill(dt)
        txtPetTwo.Text = dt.Rows(0).Item("PetCost")
        txtDieTwo.Text = dt.Rows(0).Item("DieCost")
        sqlConnect.Close()

        Timer1.Enabled = False

    End Sub

    Private Sub frmFuelCosting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Dispose()
        frmMain.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDieOne.Text = ""
        txtPetOne.Text = ""
        Timer1.Enabled = True
    End Sub

    Private Sub btnUpdt_Click(sender As Object, e As EventArgs) Handles btnUpdt.Click
        If txtPetOne.Text = "" Then
            MsgBox("Fill in the new cost value for petrol. Saving failed.", vbInformation, "")
            Exit Sub
        End If
        koneksio()
        Dim myCmd As New MySqlCommand("UPDATE tblone SET PetCost='" & txtPetOne.Text & "'", sqlConnect)
        myCmd.ExecuteNonQuery()
        sqlConnect.Close()
        MsgBox("The petrol cost have been successfully updated.", vbInformation, "")
        Timer1.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtDieOne.Text = "" Then
            MsgBox("Fill in the new cost value for diessel. Saving failed.", vbInformation, "")
            Exit Sub
        End If
        koneksio()
        Dim myCmd As New MySqlCommand("UPDATE tblone SET DieCost='" & txtDieOne.Text & "'", sqlConnect)
        myCmd.ExecuteNonQuery()
        sqlConnect.Close()
        MsgBox("The diessel cost have been successfully updated.", vbInformation, "")
        Timer1.Enabled = True
    End Sub
End Class