Imports MySql.Data.MySqlClient
Public Class frmLogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label17.Click
        txtUsernam.Visible = True
        Label1.Visible = False
        txtUsernam.Focus()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        txtPassword.Visible = True
        Label2.Visible = False
        txtPassword.Focus()
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        Label2.Visible = False
    End Sub

    Private Sub txtPswd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If AscW(e.KeyChar) = 13 Then
            e.Handled = True
            btnLog.PerformClick()
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            Label2.Visible = True
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles txtUsernam.GotFocus
        If txtUsernam.Text = "" Then
            Label1.Visible = False
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsernam.KeyPress
        If AscW(e.KeyChar) = 13 Then
            e.Handled = True
            txtPassword.Focus()
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles txtUsernam.LostFocus
        If txtUsernam.Text = "" Then
            Label1.Visible = True
        Else
            Label1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub
    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

        txtUsernam.Visible = True
        Label1.Visible = False
        txtUsernam.Focus()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        If txtUsernam.Text = "" Or txtPassword.Text = "" Then
            MsgBox("The login process can not be initiated while some fields are still empty.", vbExclamation, "")
            Exit Sub
        End If

        Call koneksio()
        Dim myCmd As MySqlCommand
        myCmd = New MySqlCommand("select * from users where Usrnm=@usrnm AND Pswd=@pswd", sqlConnect)
        'Parameters are wanted here to avoid false login
        myCmd.Parameters.AddWithValue("@usrnm", txtUsernam.Text)
        myCmd.Parameters.AddWithValue("@pswd", txtPassword.Text)

        Try
            Dim read As MySqlDataReader
            read = myCmd.ExecuteReader()
            If read.HasRows Then
                read.Read()
                Dim one As String = read.Item("Usrnm")
                Dim two As String = read.Item("Pswd")
                Dim four As String = read.Item("ID")
                Dim five As String = read.Item("AccLevel")
                Dim six As String = read.Item("Alias")

                If txtUsernam.Text = one And txtPassword.Text = two Then
                    EcNum = four
                    Ryts = five
                    frmMain.Show()
                    cnt = 0
                    Me.Dispose()
                Else
                    cnt = cnt + 1
                    If cnt = 1 Then
                        MsgBox("Login failed. Try login in again for second time", MsgBoxStyle.Exclamation, "")
                    ElseIf cnt = 2 Then
                        MsgBox("Login failed. Try login in again for third time", MsgBoxStyle.Exclamation, "")
                    ElseIf cnt = 3 Then
                        MsgBox("You failed to login, system is now closing", MsgBoxStyle.Exclamation, "")
                        End
                    End If

                End If
            Else
                cnt = cnt + 1
                If cnt = 1 Then
                    MsgBox("Login failed. Try login in again for second time", MsgBoxStyle.Exclamation, "")
                ElseIf cnt = 2 Then
                    MsgBox("Login failed. Try login in again for third time", MsgBoxStyle.Exclamation, "")
                ElseIf cnt = 3 Then
                    MsgBox("Login failed. You failed to login, system is now closing", MsgBoxStyle.Exclamation, "")
                    End
                End If

            End If

            read.Dispose()

        Catch ex As Exception

        End Try
        sqlConnect.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
