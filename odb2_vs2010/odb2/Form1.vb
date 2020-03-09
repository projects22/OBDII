Public Class Form1
    Dim inPort, buf, a, b As String
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If sp1.IsOpen Then sp1.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        sp1.BaudRate = 38400
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
    Private Sub checkIn()
        Dim i As Integer

        For i = 0 To 30
            inPort = sp1.ReadExisting
            If Mid(inPort, 1, 3) = "ELM" Then Exit Sub
            If Mid(inPort, 1, 3) = "7E8" Then Exit Sub
            Sleep(100)
        Next
    End Sub
   
    Private Sub reset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles reset.Click
        sp1.Write(Text1.Text & vbCr)    '"atx"
        checkIn()
        If inPort = "" Then Exit Sub
        ' Label1.Text = inPort
        rtb()
    End Sub
    Private Sub Button01_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button01.Click
        sp1.Write("0101" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        Text01.Text = Mid(inPort, 14, 11)
        rtb()
    End Sub
    Private Sub Button04_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button04.Click
        sp1.Write("0104" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        a = "&H" & Mid(inPort, 14, 2)       'convert text to hexadecimal
        Text04.Text = CInt((a * 100) / 255) & " %"      'calculating
        rtb()
    End Sub
    Private Sub Button05_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button05.Click
        sp1.Write("0105" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        a = "&H" & Mid(inPort, 14, 2)
        Text05.Text = (a * 1) - 40 & " °C"
        rtb()
    End Sub
    Private Sub Button06_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button06.Click
        sp1.Write("0106" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        a = "&H" & Mid(inPort, 14, 2)
        Text06.Text = CInt((a * 100) / 128) - 100 & " %"
        rtb()
    End Sub


    Private Sub Button07_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button07.Click
        sp1.Write("0107" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        a = "&H" & Mid(inPort, 14, 2)
        Text07.Text = CInt((a * 100) / 128) - 100 & " %"
        rtb()
    End Sub

    Private Sub Button0B_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0B.Click
        sp1.Write("010B" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        a = "&H" & Mid(inPort, 14, 2)
        Text0B.Text = a * 1 & " kPa"
        rtb()
    End Sub

    Private Sub Button0C_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0C.Click
        sp1.Write("010C" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        a = "&H" & Mid(inPort, 14, 2)
        b = "&H" & Mid(inPort, 17, 2)
        Text0C.Text = (a * 256 + b) / 4 & " RPM"
        rtb()
    End Sub

    Private Sub Button0D_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0D.Click
        sp1.Write("010D" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        a = "&H" & Mid(inPort, 14, 2)
        Text0D.Text = a * 1 & " km/h"
        rtb()
    End Sub
    Private Sub Button0E_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0E.Click
        sp1.Write("010E" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        a = "&H" & Mid(inPort, 14, 2)
        Text0E.Text = (a / 2) - 64 & " °"
        rtb()
    End Sub

    Private Sub Button0F_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button0F.Click
        sp1.Write("010F" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        a = "&H" & Mid(inPort, 14, 2)
        Text0F.Text = (a * 1) - 40 & " °C"
        rtb()
    End Sub

    Private Sub Button11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.Click
        sp1.Write("0111" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        a = "&H" & Mid(inPort, 14, 2)
        Text11.Text = CInt((a * 100) / 255) & " %"
        rtb()
    End Sub

    Private Sub Button13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.Click
        sp1.Write("0113" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        Text13.Text = Mid(inPort, 14, 2)
        rtb()
    End Sub

    Private Sub Button14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.Click
        sp1.Write("0114" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        a = "&H" & Mid(inPort, 14, 2)
        b = "&H" & Mid(inPort, 17, 2)
        Text14.Text = a / 200 & " V,  " & CInt(((b * 100) / 128) - 100) & " %"
        rtb()
    End Sub

    Private Sub Button15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.Click
        sp1.Write("0115" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        a = "&H" & Mid(inPort, 14, 2)
        b = "&H" & Mid(inPort, 17, 2)
        Text15.Text = a / 200 & " V,  " & CInt(((b * 100) / 128) - 100) & " %"
        rtb()
    End Sub

    Private Sub Button1C_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1C.Click
        sp1.Write("011C" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        Text1C.Text = Mid(inPort, 14, 2)
        rtb()
    End Sub

    Private Sub Button20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button20.Click
        sp1.Write("0120" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        Text20.Text = Mid(inPort, 14, 11)
        rtb()
    End Sub

    Private Sub Button21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button21.Click
        sp1.Write("0121" & vbCr)
        checkIn()
        If inPort = "" Then Exit Sub
        a = "&H" & Mid(inPort, 14, 2)
        b = "&H" & Mid(inPort, 17, 2)
        Text21.Text = (a * 256) + b & " km"
        rtb()
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        rtb1.Text = ""
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        rtb1.SaveFile("obd2.txt")
    End Sub

    
    
End Class
