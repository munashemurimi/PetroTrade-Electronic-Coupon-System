Imports MySql.Data.MySqlClient
Public Class frmFuelStocks
    Private Sub frmFuelStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = 125
        TimerSet.Enabled = True
    End Sub

    Private Sub TimerSet_Tick(sender As Object, e As EventArgs) Handles TimerSet.Tick
        'Clear codes here
        txtStatID.Text = ""
        txtBalPet.Text = ""
        txtBalDie.Text = ""
        txtAddr.Text = ""
        cmbProduct.Text = ""
        txtLitres.Text = ""
        txtNewBal.Text = ""
        txtHidLitres.Text = ""
        txtHidProduct.Text = ""

        txtStatID.Enabled = True
        txtStatID.BackColor = Color.DodgerBlue
        btnTransect.Enabled = True
        btnDelete.Enabled = False
        'Clear ends
        koneksio()
        Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM tblone", sqlConnect)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 1 Then
            stkID = dt.Rows(0).Item("StockAdd") & ""
            txtSaleID.Text = stkID
        End If
        sqlConnect.Close()
        txtRegDat.Text = DateTime.Now.ToString("dd/MM/yyyy")
        cmbProduct.Focus()
        TimerSet.Enabled = False
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMain.Enabled = True
        frmMain.lblForm.Hide()
        frmMain.lblMain.Show()
        Me.Dispose()
    End Sub

    Private Sub txtStatID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStatID.KeyPress
        Select Case AscW(e.KeyChar)
            Case 48 To 57
            Case 97 To 122, 65 To 90
                e.Handled = True
                MsgBox("Type in numbers only on service station id number.", vbExclamation, "")
            Case 8
                Exit Sub
            Case 13
                e.Handled = True
                If txtStatID.Text = "" Then
                    Exit Sub
                End If
                Call koneksio()

                Dim dt As New DataTable
                Dim daa As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM fuelstations WHERE ID='" & txtStatID.Text & "'", sqlConnect)
                daa.Fill(dt)
                If dt.Rows.Count = 1 Then
                    txtAddr.Text = dt.Rows(0).Item("Address") & ""
                    txtBalPet.Text = dt.Rows(0).Item("PetBal") & ""
                    txtBalDie.Text = dt.Rows(0).Item("DieBal") & ""
                    txtStatID.Enabled = False
                    txtStatID.BackColor = Color.Beige
                Else
                    MsgBox("The station with the provided code is not found in system.", vbInformation, "")
                End If
                sqlConnect.Close()
            Case 32
                e.Handled = True
                MsgBox("Do not leave spaces on customer phone number input.", vbExclamation, "")
            Case Else
                e.Handled = True
                MsgBox("Type in numbers only on customer phone number.", vbExclamation, "")
        End Select
    End Sub

    Private Sub txtStatID_TextChanged(sender As Object, e As EventArgs) Handles txtStatID.TextChanged

    End Sub

    Private Sub txtLitres_GotFocus(sender As Object, e As EventArgs) Handles txtLitres.GotFocus
        If cmbProduct.Text = "" Then
            cmbProduct.Text = "Petrol"
        End If
    End Sub

    Private Sub txtLitres_TextChanged(sender As Object, e As EventArgs) Handles txtLitres.TextChanged
        If cmbProduct.Text = "Petrol" Then
            txtNewBal.Text = Val(txtLitres.Text) + Val(txtBalPet.Text)
        Else
            txtNewBal.Text = Val(txtLitres.Text) + Val(txtBalDie.Text)
        End If
    End Sub

    Private Sub btnTransect_Click(sender As Object, e As EventArgs) Handles btnTransect.Click
        If txtSaleID.Text = "" Or txtAddr.Text = "" Or cmbProduct.Text = "" Or txtLitres.Text = "" Then
            MsgBox("Some fields are still empty. Stock details saving failed.", vbExclamation, "")
            Exit Sub
        End If
        Dim sql As String = ""
        If cmbProduct.Text = "Petrol" Then
            sql = "UPDATE fuelstations SET PetBal =PetBal+ '" & Val(txtLitres.Text) & "' WHERE ID='" & txtStatID.Text & "'"
        Else
            sql = "UPDATE fuelstations SET DieBal =DieBal + '" & Val(txtLitres.Text) & "' WHERE ID='" & txtStatID.Text & "'"
        End If

        Dim cmdTextStation As String = "UPDATE tblone SET StockAdd = '" & Val(txtSaleID.Text) + 1 & "'"
        Dim myCmd As MySqlCommand = New MySqlCommand, cmdText As String = "INSERT INTO stocks VALUES ('" & txtSaleID.Text & "', '" & txtRegDat.Text & "', '" & txtStatID.Text & "','" & cmbProduct.Text & "','" & txtLitres.Text & "')"
        Call koneksio()
        With myCmd
            'Save new stock details
            .Connection = sqlConnect
            .CommandText = cmdText
            .ExecuteNonQuery()
            'Update station record

            .CommandText = cmdTextStation
            .ExecuteNonQuery()
            'Increment station
            .CommandText = sql
            .ExecuteNonQuery()
        End With
        sqlConnect.Close()
        MsgBox("The fuel addition is successfully captured in system.", vbInformation, "")
        TimerSet.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim st As String = InputBox("Type in the transection id.", "")
        If st = "" Then
            Exit Sub
        End If
        koneksio()
        Dim da As New MySqlDataAdapter("SELECT * FROM stocks WHERE Transection='" & st & "'", sqlConnect)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MsgBox("The transection you are trying to search is not found.", vbInformation, "")
        Else
            txtStatID.Text = dt.Rows(0).Item("Station")
            txtSaleID.Text = dt.Rows(0).Item("Transection")
            txtRegDat.Text = dt.Rows(0).Item("TransectionDay")
            cmbProduct.Text = dt.Rows(0).Item("Product")
            txtHidProduct.Text = dt.Rows(0).Item("Product")
            txtLitres.Text = dt.Rows(0).Item("Litres")
            txtHidLitres.Text = dt.Rows(0).Item("Litres")
            btnTransect.Enabled = True
            btnDelete.Enabled = False
            da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM fuelstations WHERE ID='" & txtStatID.Text & "'", sqlConnect)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtAddr.Text = dt.Rows(0).Item("Address") & ""
                txtBalPet.Text = dt.Rows(0).Item("PetBal") & ""
                txtBalDie.Text = dt.Rows(0).Item("DieBal") & ""
            End If
            txtNewBal.Text = ""
            txtStatID.Enabled = False
            txtStatID.BackColor = Color.Beige
            btnTransect.Enabled = False
            btnDelete.Enabled = True
        End If
        sqlConnect.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TimerSet.Enabled = True

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim sql As String = ""
        If txtHidProduct.Text = "Petrol" Then
            sql = "UPDATE fuelstations SET PetBal =PetBal- '" & Val(txtHidLitres.Text) & "' WHERE ID='" & txtStatID.Text & "'"
        Else
            sql = "UPDATE fuelstations SET DieBal =DieBal - '" & Val(txtHidLitres.Text) & "' WHERE ID='" & txtStatID.Text & "'"
        End If

        Dim myCmd As MySqlCommand = New MySqlCommand, cmdText As String = "DELETE FROM stocks WHERE Transection='" & txtSaleID.Text & "'"
        Call koneksio()
        With myCmd
            'Save new stock details
            .Connection = sqlConnect
            .CommandText = cmdText
            .ExecuteNonQuery()
            'Decrement station
            .CommandText = sql
            .ExecuteNonQuery()
        End With
        sqlConnect.Close()
        MsgBox("The fuel addition is successfully removed from system.", vbInformation, "")
        TimerSet.Enabled = True
    End Sub
End Class