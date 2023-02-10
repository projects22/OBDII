Public Class Form1
    Dim inPort, buf As String    ', pid, a, b 
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Dim si As Integer

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If sp1.IsOpen Then sp1.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'cmb1.Enabled = False
        cmbBaud.SelectedText = "38400"
        GetPorts()
    End Sub
    Sub GetPorts()
        For Each sp As String In My.Computer.Ports.SerialPortNames ' Show all available COM ports.
            cmb1.Items.Add(sp)
        Next
    End Sub
    Private Sub cmb1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb1.SelectedIndexChanged
        On Error Resume Next
        sp1.PortName = cmb1.SelectedItem
        sp1.BaudRate = cmbBaud.SelectedItem
        sp1.DataBits = 8
        sp1.Open()
        Label2.Text = "Port Open"
    End Sub
    Private Sub cmbBaud_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBaud.SelectedIndexChanged
        sp1.BaudRate = cmbBaud.SelectedItem
        cmb1.Enabled = True
        Label2.Visible = True
        'GetPorts()
    End Sub

    Private Sub rtb()
        buf = 0
        buf = rtb1.Text + inPort
        rtb1.Text = buf
    End Sub


    '01 service
    Private Sub reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.Click
        On Error Resume Next
        sp1.Write("ATZ" & vbCr)    '"atx"
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        rtb()
    End Sub
    Private Sub Button01_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button01.Click
        On Error Resume Next
        sp1.Write("0101" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        si = inPort.IndexOf("41")
        Text01.Text = Mid(inPort, si + 7, 11)
        rtb()
    End Sub
    Private Sub Button04_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button04.Click
        On Error Resume Next
        sp1.Write("0104" & vbCr)
        inPort = sp1.ReadTo(">")
        si = inPort.IndexOf("41")
        Text04.Text = CInt(Convert.ToInt16(Mid(inPort, si + 7, 2), 16) * 100 / 255) & " %"    'Convert.ToInt32
        rtb()
    End Sub
    Private Sub Button05_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button05.Click
        On Error Resume Next
        sp1.Write("0105" & vbCr)
        inPort = sp1.ReadTo(">")
        si = inPort.IndexOf("41")   '41 05 5A

        Text05.Text = Convert.ToInt16(Mid(inPort, si + 7, 2), 16) - 40 & " °C"
        rtb()
    End Sub
    Private Sub Button06_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button06.Click
        On Error Resume Next
        sp1.Write("0106" & vbCr)
        inPort = sp1.ReadTo(">")
        si = inPort.IndexOf("41")
        Text06.Text = CInt(Convert.ToInt16(Mid(inPort, si + 7, 2), 16) * 100 / 128) - 100 & " %"
        rtb()
    End Sub

    Private Sub Button07_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button07.Click
        On Error Resume Next
        sp1.Write("0107" & vbCr)
        inPort = sp1.ReadTo(">")
        si = inPort.IndexOf("41")
        Text07.Text = CInt(Convert.ToInt16(Mid(inPort, si + 7, 2), 16) * 100 / 128) - 100 & " %"
        rtb()
    End Sub

    Private Sub Button0B_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0B.Click
        On Error Resume Next
        sp1.Write("010B" & vbCr)
        inPort = sp1.ReadTo(">")
        si = inPort.IndexOf("41")
        Text0B.Text = Convert.ToInt16(Mid(inPort, si + 7, 2), 16) & " kPa"
        rtb()
    End Sub

    Private Sub Button0C_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0C.Click
        On Error Resume Next
        sp1.Write("010C" & vbCr)
        inPort = sp1.ReadTo(">")
        si = inPort.IndexOf("41")
        Text0C.Text = CInt(((Convert.ToInt16(Mid(inPort, si + 7, 2), 16) * 256) + (Convert.ToInt16(Mid(inPort, si + 10, 2), 16))) / 4) & " RPM"
        rtb()
    End Sub

    Private Sub Button0D_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0D.Click
        On Error Resume Next
        sp1.Write("010D" & vbCr)
        inPort = sp1.ReadTo(">")
        si = inPort.IndexOf("41")
        Text0D.Text = Convert.ToInt16(Mid(inPort, si + 7, 2), 16) & " km/h"
        rtb()
    End Sub
    Private Sub Button0E_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0E.Click
        On Error Resume Next
        sp1.Write("010E" & vbCr)
        inPort = sp1.ReadTo(">")
        si = inPort.IndexOf("41")
        Text0E.Text = Convert.ToInt16(Mid(inPort, si + 7, 2), 16) / 2 - 64 & " °"
        rtb()
    End Sub

    Private Sub Button0F_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0F.Click
        On Error Resume Next
        sp1.Write("010F" & vbCr)
        inPort = sp1.ReadTo(">")
        si = inPort.IndexOf("41")
        Text0F.Text = Convert.ToInt16(Mid(inPort, si + 7, 2), 16) - 40 & " °C"
        rtb()
    End Sub

    Private Sub Button11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.Click
        On Error Resume Next
        sp1.Write("0111" & vbCr)
        inPort = sp1.ReadTo(">")
        si = inPort.IndexOf("41")
        Text11.Text = CInt(Convert.ToInt16(Mid(inPort, si + 7, 2), 16) * 100 / 255) & " %"
        rtb()
    End Sub

    Private Sub Button13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.Click
        On Error Resume Next
        sp1.Write("0113" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        si = inPort.IndexOf("41")
        Text13.Text = Mid(inPort, si + 7, 2)
        rtb()
    End Sub

    Private Sub Button14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.Click
        On Error Resume Next
        sp1.Write("0114" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        si = inPort.IndexOf("41")
        Text14.Text = Format(Convert.ToInt16(Mid(inPort, si + 7, 2), 16) / 200, "00.000") & " V,  " & CInt(Convert.ToInt16(Mid(inPort, si + 10, 2), 16) * 100 / 128) - 100 & " %"
        rtb()
    End Sub

    Private Sub Button15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.Click
        On Error Resume Next
        sp1.Write("0115" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        si = inPort.IndexOf("41")
        Text15.Text = Format(Convert.ToInt16(Mid(inPort, si + 7, 2), 16) / 200, "00.000") & " V,  " & CInt(Convert.ToInt16(Mid(inPort, si + 10, 2), 16) * 100 / 128) - 100 & " %"
        rtb()
    End Sub

    Private Sub Button1C_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1C.Click
        On Error Resume Next
        sp1.Write("011C" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        si = inPort.IndexOf("41")
        Text1C.Text = Mid(inPort, si + 7, 2)
        rtb()
    End Sub

    Private Sub Button20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button20.Click
        On Error Resume Next
        sp1.Write("0120" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        si = inPort.IndexOf("41")
        Text20.Text = Mid(inPort, si + 7, 11)
        rtb()
    End Sub

    Private Sub Button21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button21.Click
        On Error Resume Next
        sp1.Write("0121" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        si = inPort.IndexOf("41")
        Text21.Text = (Convert.ToInt16(Mid(inPort, si + 7, 2), 16) * 256) + (Convert.ToInt16(Mid(inPort, si + 10, 2), 16)) & " km"
        rtb()
    End Sub
    Private Sub ButtonDTC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonDTC.Click
        On Error Resume Next
        Dim txt As String = ""
        sp1.Write("0301" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        For i = 0 To 3
            txt = txt & Mid(inPort, 19 + i * 3, 2)
            txt = txt & " "
        Next
        For i = 0 To 7
            txt = txt & Mid(inPort, 36 + i * 3, 2)
            txt = txt & " "
        Next
        TextDTC.Text = txt
        rtb()
    End Sub
    Private Sub ButtonVID_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonVID.Click
        On Error Resume Next
        Dim txt As String = ""
        sp1.Write("0902" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        For i = 0 To 3
            txt = txt & ChrW(Convert.ToInt16(Mid(inPort, 19 + i * 3, 2), 16))
        Next
        For i = 0 To 6
            txt = txt & ChrW(Convert.ToInt16(Mid(inPort, 36 + i * 3, 2), 16))
        Next
        For i = 0 To 6
            txt = txt & ChrW(Convert.ToInt16(Mid(inPort, 59 + i * 3, 2), 16))
        Next
        TextVID.Text = txt  'ChrW(Convert.ToInt16(Mid(inPort, 25, 2), 16))
        'TextVID.Text = Convert.
        rtb()
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        rtb1.Text = ""
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        rtb1.SaveFile("obd2.txt")
    End Sub

End Class
