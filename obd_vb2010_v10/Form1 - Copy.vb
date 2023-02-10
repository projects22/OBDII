Public Class Form1
    Dim inPort, buf As String    ', pid, a, b 
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If sp1.IsOpen Then sp1.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        sp1.BaudRate = 38400    '38400
        sp1.DataBits = 8
        sp1.PortName = "COM" + Text2.Text
        If Not sp1.IsOpen Then sp1.Open()
    End Sub
    Private Sub ButtonSet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonSet.Click
        If sp1.IsOpen Then
            sp1.Close()
            sp1.PortName = "COM" + Text2.Text
            sp1.Open()
        Else
            sp1.PortName = "COM" + Text2.Text
            sp1.Open()
        End If
    End Sub
    Private Sub rb1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb1.CheckedChanged
        sp1.Close()
        If rb1.Checked Then sp1.BaudRate = 9600
        If rb2.Checked Then sp1.BaudRate = 38400
        sp1.Open()
    End Sub
    Private Sub rtb()
        buf = 0
        buf = rtb1.Text + inPort
        rtb1.Text = buf
    End Sub
    'Private Sub inPort = sp1.ReadTo(">")
    'Dim i As Integer

    ' For i = 0 To 30
    'inPort = sp1.ReadExisting
    '   inPort = sp1.ReadTo(">")
    'Label1.Text = inPort
    'If Mid(inPort, 3, 1) = Mid(pid, 3, 2) Then Exit Sub
    'If Mid(inPort, 1, 3) = "ELM" Then Exit Sub
    'If Mid(inPort, 1, 3) = "7E8" Then Exit Sub
    'Sleep(10)
    ' Next
    'End Sub

    Private Sub reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.Click
        'pid = "ATZ"
        sp1.Write("ATZ" & vbCr)    '"atx"
        'sp1.Write(Text1.Text & vbCr)    '"atx"
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        ' Label1.Text = inPort
        rtb()
    End Sub
    Private Sub Button01_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button01.Click
        On Error Resume Next
        'pid = "0101"
        sp1.Write("0101" & vbCr)
        'sp1.Write("0101" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        Text01.Text = Mid(inPort, 12, 11)
        rtb()
    End Sub
    Private Sub Button04_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button04.Click
        On Error Resume Next
        'pid = "0104"
        sp1.Write("0104" & vbCr)
        inPort = sp1.ReadTo(">")
        ' If inPort = "" Then Exit Sub
        'a = "&H" & Mid(inPort, 12, 2)       'convert text to hexadecimal    7E8 02 41 04 78  ,0104 NL 41 05 78 
        ' Label1.Text = a
        Text04.Text = Convert.ToInt16(Mid(inPort, 12, 2), 16) * 100 / 255 & " %"    'Convert.ToInt32
        'Text04.Text = CInt((a * 100) / 255) & " %"      'calculating
        rtb()
    End Sub
    Private Sub Button05_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button05.Click
        On Error Resume Next
        sp1.Write("0105" & vbCr)
        inPort = sp1.ReadTo(">")
        'If inPort = "" Then Exit Sub
        'a = "&H" & Mid(inPort, 12, 2)
        'Text05.Text = (a * 1) - 40 & " °C"
        Text05.Text = Convert.ToInt16(Mid(inPort, 12, 2), 16) - 40 & " °C"
        rtb()
    End Sub
    Private Sub Button06_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button06.Click
        On Error Resume Next
        sp1.Write("0106" & vbCr)
        inPort = sp1.ReadTo(">")
        'If inPort = "" Then Exit Sub
        'a = "&H" & Mid(inPort, 12, 2)
        'Text06.Text = CInt((a 
        Text06.Text = Convert.ToInt16(Mid(inPort, 12, 2), 16) * 100 / 128 - 100 & " %"
        rtb()
    End Sub


    Private Sub Button07_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button07.Click
        On Error Resume Next
        sp1.Write("0107" & vbCr)
        inPort = sp1.ReadTo(">")
        'If inPort = "" Then Exit Sub
        'a = "&H" & Mid(inPort, 12, 2)
        'Text07.Text = CInt((a * 100) / 128) - 100 & " %"
        Text07.Text = Convert.ToInt16(Mid(inPort, 12, 2), 16) * 100 / 128 - 100 & " %"
        rtb()
    End Sub

    Private Sub Button0B_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0B.Click
        On Error Resume Next
        sp1.Write("010B" & vbCr)
        inPort = sp1.ReadTo(">")
        'If inPort = "" Then Exit Sub
        'a = "&H" & Mid(inPort, 12, 2)
        'Text0B.Text = a * 1 & " kPa"
        Text0B.Text = Convert.ToInt16(Mid(inPort, 12, 2), 16) & " kPa"
        rtb()
    End Sub

    Private Sub Button0C_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0C.Click
        On Error Resume Next
        sp1.Write("010C" & vbCr)
        inPort = sp1.ReadTo(">")
        'If inPort = "" Then Exit Sub
        'a = "&H" & Mid(inPort, 12, 2)
        ' b = "&H" & Mid(inPort, 15, 2)
        'Text0C.Text = (a * 256 + b) / 4 & " RPM"
        Text0C.Text = ((Convert.ToInt16(Mid(inPort, 12, 2), 16) * 256) + (Convert.ToInt16(Mid(inPort, 15, 2), 16))) / 4 & " RPM"
        rtb()
    End Sub

    Private Sub Button0D_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0D.Click
        On Error Resume Next
        sp1.Write("010D" & vbCr)
        inPort = sp1.ReadTo(">")
        'If inPort = "" Then Exit Sub
        'a = "&H" & Mid(inPort, 12, 2)
        'Text0D.Text = a * 1 & " km/h"
        Text0D.Text = Convert.ToInt16(Mid(inPort, 12, 2), 16) & " km/h"
        rtb()
    End Sub
    Private Sub Button0E_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0E.Click
        On Error Resume Next
        sp1.Write("010E" & vbCr)
        inPort = sp1.ReadTo(">")
        'If inPort = "" Then Exit Sub
        'a = "&H" & Mid(inPort, 12, 2)
        'Text0E.Text = (a / 2) - 64 & " °"
        Text0E.Text = Convert.ToInt16(Mid(inPort, 12, 2), 16) / 2 - 64 & " °"
        rtb()
    End Sub

    Private Sub Button0F_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0F.Click
        On Error Resume Next
        sp1.Write("010F" & vbCr)
        inPort = sp1.ReadTo(">")
        'If inPort = "" Then Exit Sub
        'a = "&H" & Mid(inPort, 12, 2)
        'Text0F.Text = (a * 1) - 40 & " °C"
        Text0F.Text = Convert.ToInt16(Mid(inPort, 12, 2), 16) - 40 & " °C"
        rtb()
    End Sub

    Private Sub Button11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.Click
        On Error Resume Next
        sp1.Write("0111" & vbCr)
        inPort = sp1.ReadTo(">")
        'If inPort = "" Then Exit Sub
        'a = "&H" & Mid(inPort, 12, 2)
        ' Text11.Text = CInt((a * 100) / 255) & " %"
        Text11.Text = Convert.ToInt16(Mid(inPort, 12, 2), 16) * 100 / 255 & " %"
        rtb()
    End Sub

    Private Sub Button13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.Click
        On Error Resume Next
        sp1.Write("0113" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        Text13.Text = Mid(inPort, 12, 2)
        'a = "&H" & Mid(inPort, 12, 2)
        'b = "&H" & Mid(inPort, 15, 2)
        'Text13.Text = a / 200 & " V,  " & CInt(((b * 100) / 128) - 100) & " %"
        rtb()
    End Sub

    Private Sub Button14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.Click
        On Error Resume Next
        sp1.Write("0114" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        'a = "&H" & Mid(inPort, 12, 2)
        'b = "&H" & Mid(inPort, 17, 2)
        'Text14.Text = a / 200 & " V,  " & CInt(((b * 100) / 128) - 100) & " %"
        Text14.Text = Convert.ToInt16(Mid(inPort, 12, 2), 16) / 200 & " V,  " & Convert.ToInt16(Mid(inPort, 15, 2), 16) * 100 / 128 - 100 & " %"
        rtb()
    End Sub

    Private Sub Button15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.Click
        On Error Resume Next
        sp1.Write("0115" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        ' a = "&H" & Mid(inPort, 12, 2)
        ' b = "&H" & Mid(inPort, 17, 2)
        'Text15.Text = a / 200 & " V,  " & CInt(((b * 100) / 128) - 100) & " %"
        Text15.Text = Convert.ToInt16(Mid(inPort, 12, 2), 16) / 200 & " V,  " & Convert.ToInt16(Mid(inPort, 15, 2), 16) * 100 / 128 - 100 & " %"
        rtb()
    End Sub

    Private Sub Button1C_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1C.Click
        On Error Resume Next
        sp1.Write("011C" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        Text1C.Text = Mid(inPort, 12, 2)
        rtb()
    End Sub

    Private Sub Button20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button20.Click
        On Error Resume Next
        sp1.Write("0120" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        Text20.Text = Mid(inPort, 12, 11)
        rtb()
    End Sub

    Private Sub Button21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button21.Click
        On Error Resume Next
        sp1.Write("0121" & vbCr)
        inPort = sp1.ReadTo(">")
        If inPort = "" Then Exit Sub
        'a = "&H" & Mid(inPort, 12, 2)
        'b = "&H" & Mid(inPort, 17, 2)
        'Text21.Text = (a * 256) + b & " km"
        Text21.Text = (Convert.ToInt16(Mid(inPort, 12, 2), 16) * 256) + (Convert.ToInt16(Mid(inPort, 15, 2), 16)) & " km"
        rtb()
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        rtb1.Text = ""
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        rtb1.SaveFile("obd2.txt")
    End Sub



End Class
