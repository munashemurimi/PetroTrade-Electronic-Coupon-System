Imports MySql.Data.MySqlClient
Public Class frmSales
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = 125
        TimerSet.Enabled = True
    End Sub

    Private Sub TimerSet_Tick(sender As Object, e As EventArgs) Handles TimerSet.Tick
        txtPin.Text = ""
        ' Initialize the random-number generator.
        Randomize()
        For i = 0 To 3

            ' Generate random value between 1 and 6. 
            Dim num1 As Integer = CInt(Int((9 * Rnd()) + 1))

            ' Generate string chosen num
            Dim num2 As String = num1.ToString
            txtPin.Text = txtPin.Text + num2
        Next i
        'Clear codes here
        txtLitres.Text = ""
        txtSaleID.Text = ""
        txtRegDat.Text = ""
        txtPhone.Text = ""
        cmbProduct.Text = ""
        txtAlias.Text = ""
        txtAmount.Text = ""
        txtStatus.Text = ""
        txtBal.Text = "0"
        txtHidLitres.Text = ""
        txtHidProduct.Text = ""

        txtPhone.Enabled = True
        txtAlias.Enabled = True
        txtPhone.BackColor = Color.DodgerBlue
        txtStatus.Text = "New / Exist / Exist But New To Product /  Blocked"
        btnTransect.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        'Clear ends
        koneksio()
        Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM tblone", sqlConnect)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 1 Then
            saleRec = dt.Rows(0).Item("RecNum") & ""
            txtSaleID.Text = saleRec
            petCost = dt.Rows(0).Item("PetCost") & ""
            dieCost = dt.Rows(0).Item("DieCost") & ""
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

    Private Sub txtPhone_GotFocus(sender As Object, e As EventArgs) Handles txtPhone.GotFocus
        If cmbProduct.Text = "" Then
            cmbProduct.Focus()
        End If
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        Select Case AscW(e.KeyChar)
            Case 48 To 57
            Case 97 To 122, 65 To 90
                e.Handled = True
                MsgBox("Type in numbers only on customer phone number.", vbExclamation, "")
            Case 8
                Exit Sub
            Case 13
                e.Handled = True
                If txtPhone.Text = "" Then
                    Exit Sub
                End If
                If Len(txtPhone.Text) >= 2 Then
                    If txtPhone.Text.Substring(0, 2) <> "07" Then
                        MsgBox("Mobile number is Invalid. Type in a valid mobile number that starts with 07.", vbExclamation, "")
                        Exit Sub
                    End If
                End If


                If Len(txtPhone.Text) <> 10 Then
                    MsgBox("Mobile number is Invalid. Type in a valid mobile number.", vbExclamation, "")
                    Exit Sub
                End If
                Call koneksio()

                Dim dt As New DataTable
                Dim daa As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM Accounts WHERE Account='" & txtPhone.Text & "'", sqlConnect)
                daa.Fill(dt)
                If dt.Rows.Count = 1 Then
                    txtPin.Text = dt.Rows(0).Item("Pin") & ""
                    If dt.Rows(0).Item("Product") & "" = cmbProduct.Text Then
                        txtBal.Text = dt.Rows(0).Item("Balance") & ""
                        txtStatus.Text = "Customer Exist"
                    Else
                        txtBal.Text = "0"
                        txtStatus.Text = "Customer Exist But New To Selected Product"
                    End If
                    If dt.Rows(0).Item("Alias") & "" <> "Emp" Then
                        txtAlias.Text = dt.Rows(0).Item("Alias") & ""
                        txtAlias.Enabled = False
                    End If
                    If dt.Rows(0).Item("Status") & "" = "Blocked" Then
                        MsgBox("This client is blocked and not allowed to buy fuel.", , "")
                        sqlConnect.Close()
                        btnClear.PerformClick()
                        Exit Sub
                    End If
                ElseIf dt.Rows.Count = 2 Then
                    txtPin.Text = dt.Rows(0).Item("Pin") & ""
                    If dt.Rows(0).Item("Product") & "" = cmbProduct.Text Then
                        txtBal.Text = dt.Rows(0).Item("Balance") & ""
                        txtStatus.Text = "Customer Exist"
                    ElseIf dt.Rows(1).Item("Product") & "" = cmbProduct.Text Then
                        txtBal.Text = dt.Rows(1).Item("Balance") & ""
                        txtStatus.Text = "Customer Exist"
                    Else
                        'Rare case cz customer must at least find one product out of selected two
                        txtBal.Text = "0"
                        txtStatus.Text = "Old Customer New To Product"
                    End If
                    If dt.Rows(0).Item("Alias") & "" <> "Emp" Then
                        txtAlias.Text = dt.Rows(0).Item("Alias") & ""
                        txtAlias.Enabled = False
                    End If
                    If dt.Rows(1).Item("Alias") & "" <> "Emp" Then
                        txtAlias.Text = dt.Rows(0).Item("Alias") & ""
                        txtAlias.Enabled = False
                    End If
                    If dt.Rows(0).Item("Status") & "" = "Blocked" Then
                        MsgBox("This client is blocked and can not buy any fuel now.", , "")
                        sqlConnect.Close()
                        btnClear.PerformClick()
                        Exit Sub
                    End If
                    If dt.Rows(1).Item("Status") & "" = "Blocked" Then
                        MsgBox("This client is blocked and can not buy any fuel now.", , "")
                        sqlConnect.Close()
                        btnClear.PerformClick()
                        Exit Sub
                    End If
                Else
                    txtStatus.Text = "New Customer"
                    txtBal.Text = "0"
                End If

                txtPhone.Enabled = False
                txtPhone.BackColor = Color.Beige
                If txtAlias.Text = "" Then
                    txtAlias.Focus()
                Else
                    txtLitres.Focus()
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

    Private Sub txtPhone_LostFocus(sender As Object, e As EventArgs) Handles txtPhone.LostFocus
        If txtValid.Text = "0" Then
            Exit Sub
        End If
        If Len(txtPhone.Text) >= 2 Then
            If txtPhone.Text.Substring(0, 2) <> "07" Then
                MsgBox("Mobile number is validated as invalid. Type in a valid mobile number.", vbExclamation, "")
                txtPhone.Focus()
                Exit Sub
            End If
        End If
        If Len(txtPhone.Text) <> 10 Then
            MsgBox("Mobile number is validated as invalid. Type in a valid mobile number.", vbExclamation, "")
            txtPhone.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub cmbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduct.SelectedIndexChanged
        If txtLitres.Text <> "" Then
            If cmbProduct.Text = "Petrol" Then
                txtAmount.Text = Val(txtLitres.Text) * Val(petCost)
            ElseIf cmbProduct.Text = "Diesel" Then
                txtAmount.Text = Val(txtLitres.Text) * Val(dieCost)
            End If
        End If
        If txtPhone.Text = "" Then
            Exit Sub
        End If
        If Len(txtPhone.Text) >= 2 Then
            If txtPhone.Text.Substring(0, 2) <> "07" Then
                MsgBox("Mobile number is validated as invalid. Type in a valid mobile number.", vbExclamation, "")
                txtPhone.Focus()
                Exit Sub
            End If
        End If
        If Len(txtPhone.Text) <> 10 Then
            MsgBox("Mobile number is validated as invalid. Type in a valid mobile number.", vbExclamation, "")
            Exit Sub
        End If
        Call koneksio()

        Dim dt As New DataTable
        Dim daa As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM Accounts WHERE Account='" & txtPhone.Text & "'", sqlConnect)
        daa.Fill(dt)
        If dt.Rows.Count = 1 Then
            txtPin.Text = dt.Rows(0).Item("Pin") & ""
            If dt.Rows(0).Item("Product") & "" = cmbProduct.Text Then
                txtBal.Text = dt.Rows(0).Item("Balance") & ""
                txtStatus.Text = "Customer Exist"
            Else
                txtBal.Text = "0"
                txtStatus.Text = "Customer Exist But New To Selected Product"
            End If
            If dt.Rows(0).Item("Alias") & "" <> "Emp" Then
                txtAlias.Text = dt.Rows(0).Item("Alias") & ""
                txtAlias.Enabled = False
            End If
            If dt.Rows(0).Item("Status") & "" = "Blocked" Then
                MsgBox("This client is blocked and not allowed to buy fuel.", , "")
                sqlConnect.Close()
                btnClear.PerformClick()
                Exit Sub
            End If
        ElseIf dt.Rows.Count = 2 Then
            txtPin.Text = dt.Rows(0).Item("Pin") & ""
            If dt.Rows(0).Item("Product") & "" = cmbProduct.Text Then
                txtBal.Text = dt.Rows(0).Item("Balance") & ""
                txtStatus.Text = "Customer Exist"
            ElseIf dt.Rows(1).Item("Product") & "" = cmbProduct.Text Then
                txtBal.Text = dt.Rows(1).Item("Balance") & ""
                txtStatus.Text = "Customer Exist"
            Else
                'Rare case cz customer must at least find one product out of selected two
                txtBal.Text = "0"
                txtStatus.Text = "Old Customer New To Product"
            End If
            If dt.Rows(0).Item("Alias") & "" <> "Emp" Then
                txtAlias.Text = dt.Rows(0).Item("Alias") & ""
                txtAlias.Enabled = False
            End If
            If dt.Rows(1).Item("Alias") & "" <> "Emp" Then
                txtAlias.Text = dt.Rows(0).Item("Alias") & ""
                txtAlias.Enabled = False
            End If
            If dt.Rows(0).Item("Status") & "" = "Blocked" Then
                MsgBox("This client is blocked and can not buy any fuel now.", , "")
                sqlConnect.Close()
                btnClear.PerformClick()
                Exit Sub
            End If
            If dt.Rows(1).Item("Status") & "" = "Blocked" Then
                MsgBox("This client is blocked and can not buy any fuel now.", , "")
                sqlConnect.Close()
                btnClear.PerformClick()
                Exit Sub
            End If
        Else
            txtStatus.Text = "New Customer"
            txtBal.Text = "0"
        End If

        txtPhone.Enabled = False
        txtPhone.BackColor = Color.Beige
        If txtAlias.Text = "" Then
            txtAlias.Focus()
        Else
            txtLitres.Focus()
        End If
        'Code to recalculate is wanted
        sqlConnect.Close()
    End Sub

    Private Sub txtLitres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLitres.KeyPress
        Select Case AscW(e.KeyChar)
            Case 48 To 57
            Case 97 To 122, 65 To 90, 46
                e.Handled = True
                MsgBox("Litres to be purchased field accept numbers only as it's input.", vbExclamation, "")
            Case 8
                Exit Sub
            Case 13
                e.Handled = True
            Case 32
                e.Handled = True
                MsgBox("Spacing is not allowed on litres to be purchased field.", vbExclamation, "")
            Case Else
                e.Handled = True
                MsgBox("Litres to be purchased input accept numbers only.", vbExclamation, "")
        End Select
    End Sub

    Private Sub txtLitres_TextChanged(sender As Object, e As EventArgs) Handles txtLitres.TextChanged
        If cmbProduct.Text = "" Then
            MsgBox("Select product or fuel type first for system to calculate fuel price.", vbExclamation, "Error In Procedure")
            Exit Sub
        ElseIf cmbProduct.Text = "Petrol" Then
            txtAmount.Text = Val(txtLitres.Text) * Val(petCost)
        ElseIf cmbProduct.Text = "Diesel" Then
            txtAmount.Text = Val(txtLitres.Text) * Val(dieCost)
        End If
    End Sub

    Private Sub txtAlias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlias.KeyPress
        e.KeyChar = ChrW(Asc(LCase(Chr(AscW(e.KeyChar)))))
        Select Case AscW(e.KeyChar)
            ' let these key codes pass through
            Case 13
                e.Handled = True
                txtLitres.Focus()
                Exit Sub
            Case 65 To 90, 8, 39  'A-Z,Backspace and lastly Apostrophe for spellings like Run'anga
            Case 97 To 122 'a-z 
            Case 48 To 57 'numbers in surname field
                e.Handled = True
                MsgBox("Numbers are not allowed in user full name field.", vbExclamation, "Error on Field Input")
            Case 32 'space
            Case Else
                'all others get trapped
                e.Handled = True
                MsgBox("User full name field accept alphabetical letters only.", vbExclamation, "Error on Field Input")
        End Select
    End Sub
    Private Sub txtAlias_LostFocus(sender As Object, e As EventArgs) Handles txtAlias.LostFocus
        txtAlias.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAlias.Text)
    End Sub

    Private Sub btnTransect_Click(sender As Object, e As EventArgs) Handles btnTransect.Click
        If txtPhone.Text = "" Or cmbProduct.Text = "" Or txtAlias.Text = "" Or txtLitres.Text = "" Or txtAmount.Text = "" Then
            MsgBox("Some fields are still empty. Transction saving failed.", vbExclamation, "")
            Exit Sub
        End If

        Dim mont As String = Now.Month.ToString
        Dim yea As String = Now.Year.ToString
        Dim emp As String = "Emp", zer As String = "0"
        Dim vld As String = "Active"
        Dim myCmd As MySqlCommand = New MySqlCommand, cmdText As String = "INSERT INTO Accounts VALUES ('" & txtRegDat.Text & "', '" & txtPhone.Text & "', '" & txtAlias.Text & "','" & cmbProduct.Text & "','" & txtLitres.Text & "', '" & txtPin.Text & "','" & vld & "','" & mont & "', '" & yea & "','" & zer & "', '" & zer & "', '" & zer & "', '" & zer & "')"
        Call koneksio()
        If txtStatus.Text = "New Customer" Or txtStatus.Text = "Customer Exist But New To Selected Product" Then
            With myCmd
                'Save new customer details
                .Connection = sqlConnect
                .CommandText = cmdText
                .ExecuteNonQuery()
                'Save new sale details
                cmdText = "INSERT INTO fuelsales VALUES ('" & txtRegDat.Text & "', '" & txtPhone.Text & "', '" & txtSaleID.Text & "', '" & _
                cmbProduct.Text & "', '" & txtLitres.Text & "', '" & txtAmount.Text & "','" & mont & "', '" & yea & "')"
                .CommandText = cmdText
                .ExecuteNonQuery()
                'Increment sale receipt number by one
                cmdText = "UPDATE tblone SET RecNum = '" & Val(txtSaleID.Text) + 1 & "'"
                .CommandText = cmdText
                .ExecuteNonQuery()
            End With
        End If
        If txtStatus.Text = "Customer Exist" Then
            With myCmd
                'Add bought litres to existing customer account balance
                cmdText = "UPDATE Accounts SET Balance=Balance + '" & Val(txtLitres.Text) & "' WHERE Account='" & txtPhone.Text & "' AND Product='" & cmbProduct.Text & "'"
                .Connection = sqlConnect
                .CommandText = cmdText
                .ExecuteNonQuery()
                'Save new sale details
                cmdText = "INSERT INTO fuelsales VALUES ('" & txtRegDat.Text & "', '" & txtPhone.Text & "', '" & txtSaleID.Text & "', '" & _
                cmbProduct.Text & "', '" & txtLitres.Text & "', '" & txtAmount.Text & "','" & mont & "', '" & yea & "')"
                .CommandText = cmdText
                .ExecuteNonQuery()
                'Increment sale receipt number by one
                cmdText = "UPDATE tblone SET RecNum = '" & Val(txtSaleID.Text) + 1 & "'"
                .CommandText = cmdText
                .ExecuteNonQuery()
            End With
        End If

        If txtAlias.Enabled = True Then
            cmdText = "UPDATE Accounts SET Alias = '" & txtAlias.Text & "' WHERE Account = '" & txtPhone.Text & "'"
            myCmd.Connection = sqlConnect
            myCmd.CommandText = cmdText
            myCmd.ExecuteNonQuery()
        End If
        Dim uuh As String = "No"
        'insert into sms
        myCmd.Connection = sqlConnect
        myCmd.CommandText = "INSERT INTO sms(RegDat,Account,MsgBody,Litres,StatTraAcc,Sent) VALUES ('" & DateTime.Now.ToString("dd/MM/yyyy") & "','" & txtPhone.Text & "','" & txtPin.Text & "','" & txtLitres.Text & "','" & cmbProduct.Text & "','" & uuh & "')"
        If txtStatus.Text = "Old Customer New To Product"  Then
            Dim msgbdy As String = "nwtopro"
            myCmd.CommandText = "INSERT INTO sms(RegDat,Account,MsgBody,Litres,StatTraAcc,Sent) VALUES ('" & DateTime.Now.ToString("dd/MM/yyyy") & "','" & txtPhone.Text & "','" & msgbdy & "','" & txtLitres.Text & "','" & cmbProduct.Text & "','" & uuh & "')"
        ElseIf txtStatus.Text = "Old Customer" And cmbProduct.Text = "Petrol" Then
            Dim msgbdy As String = "oltoPet"
            Dim nebal As String = Val(txtBal.Text) + Val(txtLitres.Text)
            myCmd.CommandText = "INSERT INTO sms(RegDat,Account,MsgBody,Litres,StatTraAcc,Sent) VALUES ('" & DateTime.Now.ToString("dd/MM/yyyy") & "','" & txtPhone.Text & "','" & msgbdy & "','" & txtLitres.Text & "','" & nebal & "','" & uuh & "')"
        ElseIf txtStatus.Text = "Old Customer" And cmbProduct.Text = "Diesel" Then
            Dim msgbdy As String = "oltoDie"
            Dim nebal As String = Val(txtBal.Text) + Val(txtLitres.Text)
            myCmd.CommandText = "INSERT INTO sms(RegDat,Account,MsgBody,Litres,StatTraAcc,Sent) VALUES ('" & DateTime.Now.ToString("dd/MM/yyyy") & "','" & txtPhone.Text & "','" & msgbdy & "','" & txtLitres.Text & "','" & nebal & "','" & uuh & "')"

        End If
        myCmd.ExecuteNonQuery()

        sqlConnect.Close()
        
        MsgBox("Transection details are successfully saved in system.", vbInformation, "")
        btnClear.PerformClick()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim st As String = InputBox("Type in the sale receipt number below...", "    Record Search Input")
        If st = "" Then
            Exit Sub
        End If
        Call koneksio()
        Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM fuelsales WHERE RecNum='" & st & "'", sqlConnect)
        Dim dt As New DataTable

        da.Fill(dt)
        If dt.Rows.Count = 1 Then
            txtRegDat.Text = dt.Rows(0).Item("Dat") & ""
            txtSaleID.Text = dt.Rows(0).Item("RecNum") & ""
            txtPhone.Text = dt.Rows(0).Item("Account") & ""
            cmbProduct.Text = dt.Rows(0).Item("Fuel") & ""
            txtLitres.Text = dt.Rows(0).Item("Litres") & ""
            'Hiddens
            txtHidProduct.Text = dt.Rows(0).Item("Fuel") & ""
            txtHidLitres.Text = dt.Rows(0).Item("Litres") & ""
            'Hiddens Over
            txtAmount.Text = dt.Rows(0).Item("Cost") & ""
            txtPhone.Enabled = False
            btnTransect.Enabled = False
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        Else
            sqlConnect.Close()
            MsgBox("The sale you are trying to look for is not found in system.", vbInformation, "")
            Exit Sub
        End If

        Dim daa As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM accounts WHERE Account='" & txtPhone.Text & "'", sqlConnect)
        Dim dtt As New DataTable
        daa.Fill(dtt)

        If dtt.Rows.Count > 0 Then
            txtAlias.Text = dtt.Rows(0).Item("Alias") & ""
            txtStatus.Text = "Customer Exist"
        Else
            txtStatus.Text = "Customer Record Deleted"
            MsgBox("Customer record no longer exist in system, name not found.", vbInformation, "")
        End If

        sqlConnect.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtPhone.Text = "" Or cmbProduct.Text = "" Or txtAlias.Text = "" Or txtLitres.Text = "" Or txtAmount.Text = "" Then
            MsgBox("Some fields are still empty. Transection updating failed.", vbExclamation, "")
            Exit Sub
        End If
        Dim sql As String = ""
        Dim sql2 As String = ""
        Dim sql3 As String = ""
        Dim fig As String = ""
        Dim myCmd As New MySqlCommand
        Call koneksio()
        If cmbProduct.Text <> txtHidProduct.Text Then
            ' Deduct and add to right side or product
            sql = "UPDATE accounts SET Balance = Balance-'" & Val(txtHidLitres.Text) & "' WHERE Account='" & txtPhone.Text & "' AND Product='" & txtHidProduct.Text & "'"
            sql2 = "UPDATE accounts SET Balance = Balance+'" & Val(txtLitres.Text) & "' WHERE Account='" & txtPhone.Text & "' AND Product='" & cmbProduct.Text & "'"
            sql3 = "UPDATE fuelsales SET Fuel='" & cmbProduct.Text & "',Litres='" & txtLitres.Text & "',Cost='" & txtAmount.Text & "' WHERE RecNum='" & txtSaleID.Text & "'"
            With myCmd
                .Connection = sqlConnect
                .CommandText = sql
                .ExecuteNonQuery()
                .CommandText = sql2
                .ExecuteNonQuery()
                .CommandText = sql3
                .ExecuteNonQuery()
            End With
        End If
        If cmbProduct.Text = txtHidProduct.Text And Val(txtLitres.Text) <> Val(txtHidLitres.Text) Then
            ' Play with diffrencies
            If Val(txtHidLitres.Text) > Val(txtLitres.Text) Then
                fig = Val(txtHidLitres.Text) - Val(txtLitres.Text)
                sql = "UPDATE accounts SET Balance = Balance-'" & Val(fig) & "' WHERE Account='" & txtPhone.Text & "' AND Product='" & txtHidProduct.Text & "'"
            Else
                fig = Val(txtLitres.Text) - Val(txtHidLitres.Text)
                sql = "UPDATE accounts SET Balance = Balance+'" & Val(fig) & "' WHERE Account='" & txtPhone.Text & "' AND Product='" & txtHidProduct.Text & "'"
            End If
            sql3 = "UPDATE fuelsales SET Litres='" & txtLitres.Text & "',Cost='" & txtAmount.Text & "' WHERE RecNum='" & txtSaleID.Text & "'"
            With myCmd
                .Connection = sqlConnect
                .CommandText = sql
                .ExecuteNonQuery()
                .CommandText = sql3
                .ExecuteNonQuery()
            End With
        End If
        sqlConnect.Close()
        MsgBox("Customer fuel sale details are successfully updated in system.", vbInformation, "")
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TimerSet.Enabled = True

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim sql As String = ""
        Dim sql2 As String = ""
        Dim sql3 As String = ""
        Dim fig As String = ""
        Dim myCmd As New MySqlCommand
        Call koneksio()
        ' Deduct and add to right side or product
        sql = "UPDATE accounts SET Balance = Balance-'" & Val(txtHidLitres.Text) & "' WHERE Account='" & txtPhone.Text & "' AND Product='" & txtHidProduct.Text & "'"
        sql3 = "DELETE FROM fuelsales WHERE RecNum='" & txtSaleID.Text & "'"
        With myCmd
            .Connection = sqlConnect
            .CommandText = sql
            .ExecuteNonQuery()
            .CommandText = sql3
            .ExecuteNonQuery()
        End With
        sqlConnect.Close()
        MsgBox("Customer fuel sale details are successfully removed from system.", vbInformation, "")
        btnClear.PerformClick()
    End Sub

    Private Sub frmSales_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        txtValid.Text = "1"
    End Sub

    Private Sub btnClear_MouseMove(sender As Object, e As MouseEventArgs) Handles btnClear.MouseMove
        txtValid.Text = "0"
    End Sub
    Private Sub btnHome_MouseMove(sender As Object, e As MouseEventArgs) Handles btnHome.MouseMove
        txtValid.Text = "0"
    End Sub

    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        txtValid.Text = "0"
    End Sub
End Class