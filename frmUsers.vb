Imports MySql.Data.MySqlClient
Public Class frmUsers

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Dispose()
        frmMain.Show()
    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If String.IsNullOrEmpty(Me.cmbAccLevel.Text) Or String.IsNullOrEmpty(Me.txtEmpCode.Text) Or _
       String.IsNullOrEmpty(Me.txtNam.Text) Or String.IsNullOrEmpty(Me.txtUsrnm.Text) Or _
       String.IsNullOrEmpty(Me.txtPswd.Text) Or String.IsNullOrEmpty(Me.txtCnPswd.Text) Then
            MsgBox("Some fields are still empty. Saving failed.", MsgBoxStyle.Exclamation, "Empty Fields Error")
            Exit Sub
        End If

        If Len(txtPswd.Text) < 6 Then
            txtPswd.Select()
            MsgBox("Password length is too short, it must be at least six characters and above.", MsgBoxStyle.Exclamation, "Password Error")
            Exit Sub
        End If

        If txtPswd.Text <> txtCnPswd.Text Then
            MsgBox("Password is not correctly confirmed record cannot be saved.", MsgBoxStyle.Exclamation, "Password Error")
            Exit Sub
        End If


        Call koneksio()

        Dim myCmd As MySqlCommand
        myCmd = New MySqlCommand("SELECT * FROM users WHERE ID='" & txtEmpCode.Text & "'", sqlConnect)

        Try
            Dim read As MySqlDataReader
            read = myCmd.ExecuteReader()
            If read.HasRows Then
                read.Read()
                MsgBox("The staff EC number you provided is already saved in system for staff name: " & read.Item("Alias") & ". Record saving failed.", vbCritical, "")
                sqlConnect.Close()
                read.Dispose()
                Exit Sub
            End If
            read.Dispose()
        Catch ex As Exception
        End Try
        With myCmd
            .Connection = sqlConnect
            .CommandText = "INSERT INTO users(ID,Alias,AccLevel,Usrnm,Pswd) VALUES ('" & txtEmpCode.Text & "','" & txtNam.Text & "','" & cmbAccLevel.Text & "','" & txtUsrnm.Text & "','" & txtPswd.Text & "')"
            .ExecuteNonQuery()
        End With
        sqlConnect.Close()
        MsgBox("User login details are successfully saved in system.", vbInformation, "")
        btnClear.PerformClick()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtEmpCode.Text = "" Then
            MsgBox("User deletion failed, ec field is empty.", vbExclamation, "")
            Exit Sub
        End If
        Dim myCmd As New MySqlCommand
        Call koneksio()
        Dim da As New MySqlDataAdapter("SELECT * FROM users WHERE ID='" & txtEmpCode.Text & "'", sqlConnect)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MsgBox("The user you want to delete is not found in system.", vbCritical, "")
            Exit Sub
        End If

        With myCmd
            .Connection = sqlConnect
            .CommandText = "DELETE FROM users WHERE ID='" & txtEmpCode.Text & "'"
            .ExecuteNonQuery()
        End With
        sqlConnect.Close()
        MsgBox("User login details are successfully removed from system.", vbInformation, "")
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmpCode.Text = ""
        txtNam.Text = ""
        cmbAccLevel.Text = ""
        txtUsrnm.Text = ""
        txtPswd.Text = ""
        txtCnPswd.Text = ""
    End Sub

    Private Sub txtEmpCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpCode.KeyPress
        Select Case AscW(e.KeyChar)
            ' let these key codes pass through
            Case 48 To 57 '0-9
            Case 97 To 122, 65 To 90 'A-Z,a-z
            Case 8 'Backspace
                Exit Sub
            Case 13
                'search code o be placed here
                e.Handled = True
            Case 32 ' spacing not allowed
                e.Handled = True
                MsgBox("Spacing is not allowed on Staff EC input.", vbExclamation, "")
            Case Else
                'all others get trapped
                e.Handled = True 'set ascii=0 to trap other inputs
                MsgBox("Staff EC field accept numbers and alphabetical letters only.", vbExclamation, "")
        End Select
    End Sub

    Private Sub txtEmpCode_TextChanged(sender As Object, e As EventArgs) Handles txtEmpCode.TextChanged

    End Sub

    Private Sub txtNam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNam.KeyPress
        e.KeyChar = ChrW(Asc(LCase(Chr(AscW(e.KeyChar)))))
        Select Case AscW(e.KeyChar)
            ' let these key codes pass through
            Case 13
                e.Handled = True
            Case 65 To 90, 8, 39  'A-Z,Backspace and lastly Apostrophe for spellings like Run'anga
            Case 97 To 122 'a-z 
            Case 48 To 57 'numbers in surname field
                e.Handled = True
                MsgBox("Numbers are not allowed on staff name input.", vbExclamation, "System Input Error Info:")
            Case 32 'space
            Case Else
                'all others get trapped
                e.Handled = True
                MsgBox("Staff name input accept alphabetical letters only.", vbExclamation, "System Input Error Info:")
        End Select
    End Sub

    Private Sub txtNam_LostFocus(sender As Object, e As EventArgs) Handles txtNam.LostFocus
        txtNam.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNam.Text)
    End Sub

    Private Sub cmbAccLevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbAccLevel.KeyPress
        Select Case AscW(e.KeyChar)
            Case 8 ' backspace to be allowed
            Case 13 ' enter to be allowed
                e.Handled = True ' to cancel that sound we hear when enter key is pressed
            Case Else ' other keys not mentioned will be disallowed
                e.Handled = True
                MsgBox("Typing is not allowed on user access level input, select input from the provided list.", vbExclamation, "System Input Error Info:")
        End Select
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(Me.cmbAccLevel.Text) Or String.IsNullOrEmpty(Me.txtEmpCode.Text) Or _
   String.IsNullOrEmpty(Me.txtNam.Text) Or String.IsNullOrEmpty(Me.txtUsrnm.Text) Or _
   String.IsNullOrEmpty(Me.txtPswd.Text) Or String.IsNullOrEmpty(Me.txtCnPswd.Text) Then
            MsgBox("Some fields are still empty. Saving failed.", MsgBoxStyle.Exclamation, "Empty Fields Error")
            Exit Sub
        End If

        If Len(txtPswd.Text) < 6 Then
            txtPswd.Select()
            MsgBox("Password length is too short, it must be at least six characters and above.", MsgBoxStyle.Exclamation, "Password Error")
            Exit Sub
        End If

        If txtPswd.Text <> txtCnPswd.Text Then
            MsgBox("Password is not correctly confirmed record cannot be saved.", MsgBoxStyle.Exclamation, "Password Error")
            Exit Sub
        End If


        Call koneksio()
        Dim da As New MySqlDataAdapter("SELECT * FROM users WHERE ID='" & txtEmpCode.Text & "'", sqlConnect)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MsgBox("The user you want to update is not found in system.", vbCritical, "")
            Exit Sub
        End If
        Dim myCmd As New MySqlCommand
        Call koneksio()
        With myCmd
            .Connection = sqlConnect
            .CommandText = "UPDATE users SET Alias='" & txtNam.Text & "',AccLevel='" & cmbAccLevel.Text & "',Usrnm='" & txtUsrnm.Text & "',Pswd='" & txtPswd.Text & "' WHERE ID='" & txtEmpCode.Text & "'"
            .ExecuteNonQuery()
        End With
        sqlConnect.Close()
        MsgBox("User login details are successfully updated in system.", vbInformation, "")
        btnClear.PerformClick()
    End Sub

    Private Sub txtNam_TextChanged(sender As Object, e As EventArgs) Handles txtNam.TextChanged

    End Sub
End Class