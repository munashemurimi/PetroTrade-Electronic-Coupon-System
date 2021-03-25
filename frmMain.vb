Imports MySql.Data.MySqlClient
Imports System.Management
Imports System.Threading
Imports System.IO.Ports
Public Class frmMain
    Dim rcvdata As String = ""
    Public Function ModemsConnected() As String
        Dim modems As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_POTSModem")
            For Each queryobj As ManagementObject In searcher.Get()
                If queryobj("status") = "OK" Then
                    modems = modems & (queryobj("AttachedTo") & " , " & queryobj("Description") & "***")

                End If
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
            Return ""

        End Try
        Return modems
    End Function

    Private Sub btnReports_MouseMove(sender As Object, e As MouseEventArgs) Handles btnReports.MouseMove
        btnRep1.Visible = True
        btnRep2.Visible = True
        btnRep3.Visible = True
        btnRep4.Visible = True
        btnRep5.Visible = True

        btnCosting.Visible = False
        btnUsers.Visible = False
    End Sub

    Private Sub btnAdmin_MouseMove(sender As Object, e As MouseEventArgs) Handles btnAdmin.MouseMove
        btnRep1.Visible = False
        btnRep2.Visible = False
        btnRep3.Visible = False
        btnRep4.Visible = False
        btnRep5.Visible = False

        btnCosting.Visible = True
        btnUsers.Visible = True
    End Sub
    Private Sub btnHelp_MouseMove(sender As Object, e As MouseEventArgs) Handles btnHelp.MouseMove
        btnRep1.Visible = False
        btnRep2.Visible = False
        btnRep3.Visible = False
        btnRep4.Visible = False
        btnRep5.Visible = False

        btnCosting.Visible = False
        btnUsers.Visible = False
    End Sub

    Private Sub btnCustCare_MouseMove(sender As Object, e As MouseEventArgs)
        btnRep1.Visible = False
        btnRep2.Visible = False
        btnRep3.Visible = False
        btnRep5.Visible = False

        btnRep4.Visible = False
        btnRep5.Visible = False
        btnCosting.Visible = False
        btnUsers.Visible = False
    End Sub

    Private Sub btnAllocation_MouseMove(sender As Object, e As MouseEventArgs) Handles btnAllocation.MouseMove
        btnRep1.Visible = False
        btnRep2.Visible = False
        btnRep3.Visible = False
        btnRep4.Visible = False
        btnRep5.Visible = False

        btnCosting.Visible = False
        btnUsers.Visible = False
    End Sub

    Private Sub btnSites_MouseMove(sender As Object, e As MouseEventArgs) Handles btnSites.MouseMove
        btnRep1.Visible = False
        btnRep2.Visible = False
        btnRep3.Visible = False
        btnRep5.Visible = False

        btnRep4.Visible = False
        btnCosting.Visible = False
        btnUsers.Visible = False
    End Sub

    Private Sub btnSales_MouseMove(sender As Object, e As MouseEventArgs) Handles btnSales.MouseMove
        btnRep1.Visible = False
        btnRep2.Visible = False
        btnRep3.Visible = False
        btnRep4.Visible = False
        btnRep5.Visible = False

        btnCosting.Visible = False
        btnUsers.Visible = False
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        frmSales.Show()
        lblForm.Text = "Sales Department - Fuel Sales"
        lblForm.Show()
        lblMain.Hide()
        Me.Enabled = False
    End Sub

    Private Sub btnSites_Click(sender As Object, e As EventArgs) Handles btnSites.Click
        frmSites.Show()
        lblForm.Text = "Stocks Department - Fuel Sites"
        lblForm.Show()
        lblMain.Hide()
        Me.Enabled = False
    End Sub

    Private Sub btnAllocation_Click(sender As Object, e As EventArgs) Handles btnAllocation.Click
        frmFuelStocks.Show()
        lblForm.Text = "Stocks Department - Station Fuel Additions"
        lblForm.Show()
        lblMain.Hide()
        Me.Enabled = False
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Dispose()
        frmLogin.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Me.Enabled = False
        frmBout.Show()
    End Sub

    Private Sub btnCosting_Click(sender As Object, e As EventArgs) Handles btnCosting.Click
        Me.Hide()
        frmFuelCosting.Show()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Me.Hide()
        frmUsers.Show()
    End Sub

    Private Sub btnRep2_Click(sender As Object, e As EventArgs) Handles btnRep2.Click
        Me.Enabled = False
        frmRepRedempt.Show()
    End Sub

    Private Sub btnRep4_Click(sender As Object, e As EventArgs) Handles btnRep4.Click
        Me.Enabled = False
        frmRepSites.Show()
    End Sub

    Private Sub btnRep3_Click(sender As Object, e As EventArgs) Handles btnRep3.Click
        Me.Enabled = False
        frmRepTran.Show()
    End Sub

    Private Sub btnRep1_Click(sender As Object, e As EventArgs) Handles btnRep1.Click
        Me.Enabled = False
        frmRepSales.Show()
    End Sub

    Private Sub btnRep5_Click(sender As Object, e As EventArgs) Handles btnRep5.Click
        Me.Enabled = False
        frmfUELaLLO.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbModerm.Text = "There is no Dongle Connected"
        ''TimerLoad.Enabled = True
        Dim ports() As String
        ports = Split(ModemsConnected(), "***")
        For i As Integer = 0 To ports.Length - 2
            cmbModerm.Items.Add(ports(i))
        Next
        'Check to see if the combobox is populated
        If cmbModerm.Items.Count = 0 Then
            lblState.ForeColor = Color.Red
            lblState.Text = "Dongle Not Detected"
        Else
            lblState.ForeColor = Color.Blue
            lblState.Text = "Dongle Detected"
            cmbModerm.SelectedIndex = cmbModerm.SelectionStart ' to autofill the combobox
            ''''''''''''''Spare Codes''''''''''''''''
            ''ComboBox1.SelectedIndex = 0
            ''ComboBox1.Text = ComboBox1.Items(0).ToString
        End If

        If cmbModerm.Text <> "" And cmbModerm.Text <> "There is no Dongle Connected" Then
            btnConnect.PerformClick() 'to connect to the detected moderm
            MsgBox("Dongle detected and connected.", vbInformation, "")
        Else
            lblState.ForeColor = Color.Red
            lblState.Text = "Dongle Not Detected"
        End If
        Timer1.Enabled = True
    End Sub
    Private Sub cmbModerm_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbModerm.SelectedValueChanged
        lblStatus.Text = Trim(Mid(cmbModerm.Text, 1, 5))
    End Sub
    Private Sub serialport1_datareceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim datain As String = ""
        Dim numbytes As Integer = SerialPort1.BytesToRead
        For i As Integer = 1 To numbytes
            datain &= Chr(SerialPort1.ReadChar)
        Next
        test(datain)
    End Sub
    Private Sub test(ByVal indata As String)
        rcvdata &= indata
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Ryts = "Sales" Then
            btnAllocation.Enabled = False
            btnReports.Enabled = False
            btnAdmin.Enabled = False
            btnSites.Enabled = False
        End If
        Timer1.Enabled = False
    End Sub

    Private Sub TimerSend_Tick(sender As Object, e As EventArgs) Handles TimerSend.Tick

        'Code to send an sms here
        Try
            With SerialPort1
                'sending AT commands
                .Write("at" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("at+cmgf=1" & vbCrLf) 'set command message format to text mode(1)
                Threading.Thread.Sleep(1000)
                .Write("at+cmgs=" & Chr(34) & txtPhone2.Text & Chr(34) & vbCrLf) ' enter the mobile number whom you want to send the SMS
                .Write(txtSms.Text & Chr(26)) 'SMS sending
                Threading.Thread.Sleep(1000)
                'MsgBox(rcvdata.ToString)
            End With
        Catch ex As Exception

        End Try
        If rcvdata.ToString.Contains(">") Then

        Else
            Try
                With SerialPort1
                    'sending AT commands
                    .Write("at" & vbCrLf)
                    Threading.Thread.Sleep(1000)
                    .Write("at+cmgf=1" & vbCrLf) 'set command message format to text mode(1)
                    Threading.Thread.Sleep(1000)
                    .Write("at+cmgs=" & Chr(34) & txtPhone2.Text & Chr(34) & vbCrLf) ' enter the mobile number whom you want to send the SMS
                    .Write(txtSms.Text & Chr(26)) 'SMS sending
                    MessageBox.Show("Message successfully sent to recepient")
                    Threading.Thread.Sleep(1000)
                    'MsgBox(rcvdata.ToString)
                End With
            Catch ex As Exception

            End Try
        End If
        TimerSend.Enabled = False
    End Sub

    Private Sub Labl78_Click(sender As Object, e As EventArgs) Handles Labl78.Click

    End Sub
End Class
