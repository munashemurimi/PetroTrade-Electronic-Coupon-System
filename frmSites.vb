Imports MySql.Data.MySqlClient
Public Class frmSites

    Private Sub frmSites_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = 125
        TimerSet.Enabled = True
    End Sub

    Private Sub TimerSet_Tick(sender As Object, e As EventArgs) Handles TimerSet.Tick
        'Clear codes here
        txtAd.Text = ""
        txtAlias.Text = ""
        txtRegDat.Text = ""
        txtPhone.Text = ""
        cmbState.Text = ""
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        'Clear ends
        koneksio()
        Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM tblone", sqlConnect)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 1 Then
            siteID = dt.Rows(0).Item("SiteID") & ""
            txtSiteID.Text = siteID
        End If
        sqlConnect.Close()
        txtRegDat.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtAd.Focus()
        TimerSet.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPhone.Text = "" Or cmbState.Text = "" Or txtAlias.Text = "" Or txtAd.Text = "" Then
            MsgBox("Some fields are still empty. Station details saving failed.", vbExclamation, "")
            Exit Sub
        End If
        Dim mycmd As New MySqlCommand
        Dim zer As String = "0"
        Call koneksio()
        With mycmd
            'Save new station details
            .Connection = sqlConnect
            .CommandText = "INSERT INTO fuelstations VALUES ('" & txtSiteID.Text & "','" & txtRegDat.Text & "','" & txtAd.Text & "','" & txtAlias.Text & "','" & txtPhone.Text & "','" & cmbState.Text & "','" & zer & "','" & zer & "')"
            .ExecuteNonQuery()
            'Increment site id
            .CommandText = "UPDATE tblone SET SiteID = '" & Val(txtSiteID.Text) + 1 & "'"
            .ExecuteNonQuery()
        End With
        sqlConnect.Close()

        MsgBox("The new station details are successfully saved in system database.", vbInformation, "")
        btnClear.PerformClick()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtPhone.Text = "" Or cmbState.Text = "" Or txtAlias.Text = "" Or txtAd.Text = "" Then
            MsgBox("Some fields are still empty. Station details updating failed.", vbExclamation, "")
            Exit Sub
        End If
        Dim mycmd As New MySqlCommand

        Call koneksio()
        With mycmd
            'Update station details
            .Connection = sqlConnect
            .CommandText = "UPDATE fuelstations SET Address='" & txtAd.Text & "',Boss='" & txtAlias.Text & "',BossPhone='" & txtPhone.Text & "',Working='" & cmbState.Text & "' WHERE ID='" & txtSiteID.Text & "'"
            .ExecuteNonQuery()
        End With
        sqlConnect.Close()

        MsgBox("The station details are successfully updated in system database.", vbInformation, "")
        btnClear.PerformClick()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim mycmd As New MySqlCommand

        Call koneksio()
        With mycmd
            'Update station details
            .Connection = sqlConnect
            .CommandText = "DELETE FROM fuelstations WHERE ID='" & txtSiteID.Text & "'"
            .ExecuteNonQuery()
        End With
        sqlConnect.Close()
        MsgBox("The station details are successfully removed from system database.", vbInformation, "")
        btnClear.PerformClick()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim st As String = InputBox("Type in the sale receipt number below...", "    Record Search Input")
        If st = "" Then
            Exit Sub
        End If
        Call koneksio()
        Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM fuelstations WHERE ID='" & st & "'", sqlConnect)
        Dim dt As New DataTable

        da.Fill(dt)
        If dt.Rows.Count = 1 Then
            txtRegDat.Text = dt.Rows(0).Item("Dat") & ""
            txtAd.Text = dt.Rows(0).Item("Address") & ""
            txtPhone.Text = dt.Rows(0).Item("BossPhone") & ""
            cmbState.Text = dt.Rows(0).Item("Working") & ""
            txtAlias.Text = dt.Rows(0).Item("Boss") & ""
            txtSiteID.Text = st
            txtPhone.Enabled = False
            btnSave.Enabled = False
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        Else

            MsgBox("The station you are trying to look for is not found in system.", vbInformation, "")

        End If

        sqlConnect.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TimerSet.Enabled = True

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMain.Enabled = True
        frmMain.lblForm.Hide()
        frmMain.lblMain.Show()
        Me.Dispose()
    End Sub

    Private Sub txtAd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAd.KeyPress
        Select Case AscW(e.KeyChar)
            Case 13
                e.Handled = True
                txtAlias.Focus()
                Exit Sub
            Case 65 To 90, 8, 39
            Case 97 To 122
            Case 48 To 57
            Case 32
            Case Else
                e.Handled = True
                MsgBox("The character you typed is not allowed in address field.", vbExclamation, "")
        End Select
    End Sub

    Private Sub txtAd_TextChanged(sender As Object, e As EventArgs) Handles txtAd.TextChanged

    End Sub

    Private Sub txtAlias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlias.KeyPress
        e.KeyChar = ChrW(Asc(LCase(Chr(AscW(e.KeyChar)))))
        Select Case AscW(e.KeyChar)
            Case 13
                e.Handled = True
                txtPhone.Focus()
                Exit Sub
            Case 65 To 90, 8, 39
            Case 97 To 122
            Case 48 To 57
                e.Handled = True
                MsgBox("You can not type numbers on site supervisor name field.", vbExclamation, "")
            Case 32
            Case Else
                e.Handled = True
                MsgBox("The character you typed is not allowed in name field.", vbExclamation, "")
        End Select
    End Sub

    Private Sub txtAlias_LostFocus(sender As Object, e As EventArgs) Handles txtAlias.LostFocus
        txtAlias.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAlias.Text)
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        Select Case AscW(e.KeyChar)
            ' let these key codes pass through
            Case 48 To 57 '0-9
            Case 97 To 122, 65 To 90 'A-Z,a-z
                e.Handled = True
                MsgBox("Letters are not allowed on cellphone number input.", vbExclamation, "")
            Case 8 'Backspace
                Exit Sub
            Case 13
                'search code o be placed here
                e.Handled = True
                cmbState.Focus()
            Case 32 ' spacing not allowed
                e.Handled = True
                MsgBox("Spacing is not allowed on cellphone number input.", vbExclamation, "")
            Case Else
                'all others get trapped
                e.Handled = True 'set ascii=0 to trap other inputs
                MsgBox("Cellphone number field accept numbers only.", vbExclamation, "")
        End Select
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub cmbState_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbState.KeyPress
        Select Case AscW(e.KeyChar)
            Case 8
            Case 13
                e.Handled = True
            Case Else
                e.Handled = True
                MsgBox("Please do not type on this field, select input from the items provided.", vbExclamation, "")
        End Select
    End Sub

    Private Sub cmbState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbState.SelectedIndexChanged

    End Sub
End Class