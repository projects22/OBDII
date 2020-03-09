<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.sp1 = New System.IO.Ports.SerialPort(Me.components)
        Me.reset = New System.Windows.Forms.Button()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.read = New System.Windows.Forms.Timer(Me.components)
        Me.Button01 = New System.Windows.Forms.Button()
        Me.Button04 = New System.Windows.Forms.Button()
        Me.Text01 = New System.Windows.Forms.TextBox()
        Me.Text04 = New System.Windows.Forms.TextBox()
        Me.Button05 = New System.Windows.Forms.Button()
        Me.Text05 = New System.Windows.Forms.TextBox()
        Me.Text0C = New System.Windows.Forms.TextBox()
        Me.Button0C = New System.Windows.Forms.Button()
        Me.Text0B = New System.Windows.Forms.TextBox()
        Me.Text07 = New System.Windows.Forms.TextBox()
        Me.Button0B = New System.Windows.Forms.Button()
        Me.Button07 = New System.Windows.Forms.Button()
        Me.Text06 = New System.Windows.Forms.TextBox()
        Me.Button06 = New System.Windows.Forms.Button()
        Me.Text1C = New System.Windows.Forms.TextBox()
        Me.Button1C = New System.Windows.Forms.Button()
        Me.Text15 = New System.Windows.Forms.TextBox()
        Me.Text14 = New System.Windows.Forms.TextBox()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Text13 = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Text11 = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Text0F = New System.Windows.Forms.TextBox()
        Me.Text0E = New System.Windows.Forms.TextBox()
        Me.Button0F = New System.Windows.Forms.Button()
        Me.Button0E = New System.Windows.Forms.Button()
        Me.Text0D = New System.Windows.Forms.TextBox()
        Me.Button0D = New System.Windows.Forms.Button()
        Me.Text21 = New System.Windows.Forms.TextBox()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Text20 = New System.Windows.Forms.TextBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonSet = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'sp1
        '
        Me.sp1.BaudRate = 38400
        Me.sp1.PortName = "COM5"
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(470, 53)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(142, 23)
        Me.reset.TabIndex = 0
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(253, 55)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(211, 20)
        Me.Text1.TabIndex = 2
        Me.Text1.Text = "ATZ"
        '
        'rtb1
        '
        Me.rtb1.Location = New System.Drawing.Point(12, 53)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(228, 469)
        Me.rtb1.TabIndex = 3
        Me.rtb1.Text = ""
        '
        'Button01
        '
        Me.Button01.Location = New System.Drawing.Point(470, 79)
        Me.Button01.Name = "Button01"
        Me.Button01.Size = New System.Drawing.Size(142, 23)
        Me.Button01.TabIndex = 4
        Me.Button01.Text = "01 - Status since DTCs"
        Me.Button01.UseVisualStyleBackColor = True
        '
        'Button04
        '
        Me.Button04.Location = New System.Drawing.Point(470, 106)
        Me.Button04.Name = "Button04"
        Me.Button04.Size = New System.Drawing.Size(142, 23)
        Me.Button04.TabIndex = 7
        Me.Button04.Text = "04 - Engine load"
        Me.Button04.UseVisualStyleBackColor = True
        '
        'Text01
        '
        Me.Text01.Location = New System.Drawing.Point(253, 81)
        Me.Text01.Name = "Text01"
        Me.Text01.Size = New System.Drawing.Size(211, 20)
        Me.Text01.TabIndex = 8
        '
        'Text04
        '
        Me.Text04.Location = New System.Drawing.Point(253, 108)
        Me.Text04.Name = "Text04"
        Me.Text04.Size = New System.Drawing.Size(211, 20)
        Me.Text04.TabIndex = 9
        '
        'Button05
        '
        Me.Button05.Location = New System.Drawing.Point(470, 132)
        Me.Button05.Name = "Button05"
        Me.Button05.Size = New System.Drawing.Size(142, 23)
        Me.Button05.TabIndex = 10
        Me.Button05.Text = "05 - Coolant temp"
        Me.Button05.UseVisualStyleBackColor = True
        '
        'Text05
        '
        Me.Text05.Location = New System.Drawing.Point(253, 134)
        Me.Text05.Name = "Text05"
        Me.Text05.Size = New System.Drawing.Size(211, 20)
        Me.Text05.TabIndex = 11
        '
        'Text0C
        '
        Me.Text0C.Location = New System.Drawing.Point(253, 238)
        Me.Text0C.Name = "Text0C"
        Me.Text0C.Size = New System.Drawing.Size(211, 20)
        Me.Text0C.TabIndex = 19
        '
        'Button0C
        '
        Me.Button0C.Location = New System.Drawing.Point(470, 236)
        Me.Button0C.Name = "Button0C"
        Me.Button0C.Size = New System.Drawing.Size(142, 23)
        Me.Button0C.TabIndex = 18
        Me.Button0C.Text = "0C - RPM"
        Me.Button0C.UseVisualStyleBackColor = True
        '
        'Text0B
        '
        Me.Text0B.Location = New System.Drawing.Point(253, 212)
        Me.Text0B.Name = "Text0B"
        Me.Text0B.Size = New System.Drawing.Size(211, 20)
        Me.Text0B.TabIndex = 17
        '
        'Text07
        '
        Me.Text07.Location = New System.Drawing.Point(253, 185)
        Me.Text07.Name = "Text07"
        Me.Text07.Size = New System.Drawing.Size(211, 20)
        Me.Text07.TabIndex = 16
        '
        'Button0B
        '
        Me.Button0B.Location = New System.Drawing.Point(470, 210)
        Me.Button0B.Name = "Button0B"
        Me.Button0B.Size = New System.Drawing.Size(142, 23)
        Me.Button0B.TabIndex = 15
        Me.Button0B.Text = "0B - Intake pressure"
        Me.Button0B.UseVisualStyleBackColor = True
        '
        'Button07
        '
        Me.Button07.Location = New System.Drawing.Point(470, 183)
        Me.Button07.Name = "Button07"
        Me.Button07.Size = New System.Drawing.Size(142, 23)
        Me.Button07.TabIndex = 14
        Me.Button07.Text = "07 - Long term fuel"
        Me.Button07.UseVisualStyleBackColor = True
        '
        'Text06
        '
        Me.Text06.Location = New System.Drawing.Point(253, 159)
        Me.Text06.Name = "Text06"
        Me.Text06.Size = New System.Drawing.Size(211, 20)
        Me.Text06.TabIndex = 13
        '
        'Button06
        '
        Me.Button06.Location = New System.Drawing.Point(470, 157)
        Me.Button06.Name = "Button06"
        Me.Button06.Size = New System.Drawing.Size(142, 23)
        Me.Button06.TabIndex = 12
        Me.Button06.Text = "06 - Short term fuel"
        Me.Button06.UseVisualStyleBackColor = True
        '
        'Text1C
        '
        Me.Text1C.Location = New System.Drawing.Point(253, 448)
        Me.Text1C.Name = "Text1C"
        Me.Text1C.Size = New System.Drawing.Size(211, 20)
        Me.Text1C.TabIndex = 35
        '
        'Button1C
        '
        Me.Button1C.Location = New System.Drawing.Point(470, 446)
        Me.Button1C.Name = "Button1C"
        Me.Button1C.Size = New System.Drawing.Size(142, 23)
        Me.Button1C.TabIndex = 34
        Me.Button1C.Text = "1C - OBD standards"
        Me.Button1C.UseVisualStyleBackColor = True
        '
        'Text15
        '
        Me.Text15.Location = New System.Drawing.Point(253, 422)
        Me.Text15.Name = "Text15"
        Me.Text15.Size = New System.Drawing.Size(211, 20)
        Me.Text15.TabIndex = 33
        '
        'Text14
        '
        Me.Text14.Location = New System.Drawing.Point(253, 395)
        Me.Text14.Name = "Text14"
        Me.Text14.Size = New System.Drawing.Size(211, 20)
        Me.Text14.TabIndex = 32
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(470, 420)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(142, 23)
        Me.Button15.TabIndex = 31
        Me.Button15.Text = "15 - Oxygen sensor 2"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(470, 393)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(142, 23)
        Me.Button14.TabIndex = 30
        Me.Button14.Text = "14 - Oxygen sensor 1"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Text13
        '
        Me.Text13.Location = New System.Drawing.Point(253, 369)
        Me.Text13.Name = "Text13"
        Me.Text13.Size = New System.Drawing.Size(211, 20)
        Me.Text13.TabIndex = 29
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(470, 367)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(142, 23)
        Me.Button13.TabIndex = 28
        Me.Button13.Text = "13 - Oxygen sensors"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Text11
        '
        Me.Text11.Location = New System.Drawing.Point(253, 344)
        Me.Text11.Name = "Text11"
        Me.Text11.Size = New System.Drawing.Size(211, 20)
        Me.Text11.TabIndex = 27
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(470, 342)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(142, 23)
        Me.Button11.TabIndex = 26
        Me.Button11.Text = "11 - Throttle position"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Text0F
        '
        Me.Text0F.Location = New System.Drawing.Point(253, 318)
        Me.Text0F.Name = "Text0F"
        Me.Text0F.Size = New System.Drawing.Size(211, 20)
        Me.Text0F.TabIndex = 25
        '
        'Text0E
        '
        Me.Text0E.Location = New System.Drawing.Point(253, 291)
        Me.Text0E.Name = "Text0E"
        Me.Text0E.Size = New System.Drawing.Size(211, 20)
        Me.Text0E.TabIndex = 24
        '
        'Button0F
        '
        Me.Button0F.Location = New System.Drawing.Point(470, 316)
        Me.Button0F.Name = "Button0F"
        Me.Button0F.Size = New System.Drawing.Size(142, 23)
        Me.Button0F.TabIndex = 23
        Me.Button0F.Text = "0F - Intake air temp"
        Me.Button0F.UseVisualStyleBackColor = True
        '
        'Button0E
        '
        Me.Button0E.Location = New System.Drawing.Point(470, 289)
        Me.Button0E.Name = "Button0E"
        Me.Button0E.Size = New System.Drawing.Size(142, 23)
        Me.Button0E.TabIndex = 22
        Me.Button0E.Text = "0E - Timing advance"
        Me.Button0E.UseVisualStyleBackColor = True
        '
        'Text0D
        '
        Me.Text0D.Location = New System.Drawing.Point(253, 265)
        Me.Text0D.Name = "Text0D"
        Me.Text0D.Size = New System.Drawing.Size(211, 20)
        Me.Text0D.TabIndex = 21
        '
        'Button0D
        '
        Me.Button0D.Location = New System.Drawing.Point(470, 263)
        Me.Button0D.Name = "Button0D"
        Me.Button0D.Size = New System.Drawing.Size(142, 23)
        Me.Button0D.TabIndex = 20
        Me.Button0D.Text = "0D - Speed"
        Me.Button0D.UseVisualStyleBackColor = True
        '
        'Text21
        '
        Me.Text21.Location = New System.Drawing.Point(253, 501)
        Me.Text21.Name = "Text21"
        Me.Text21.Size = New System.Drawing.Size(211, 20)
        Me.Text21.TabIndex = 39
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(470, 499)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(142, 23)
        Me.Button21.TabIndex = 38
        Me.Button21.Text = "21 - Distance traveled"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Text20
        '
        Me.Text20.Location = New System.Drawing.Point(253, 475)
        Me.Text20.Name = "Text20"
        Me.Text20.Size = New System.Drawing.Size(211, 20)
        Me.Text20.TabIndex = 37
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(470, 473)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(142, 23)
        Me.Button20.TabIndex = 36
        Me.Button20.Text = "20 - PIDs supported"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(40, 14)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(57, 24)
        Me.ButtonClear.TabIndex = 40
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(155, 14)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(57, 24)
        Me.ButtonSave.TabIndex = 41
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonSet
        '
        Me.ButtonSet.Location = New System.Drawing.Point(537, 12)
        Me.ButtonSet.Name = "ButtonSet"
        Me.ButtonSet.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSet.TabIndex = 42
        Me.ButtonSet.Text = "Set Port"
        Me.ButtonSet.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "COM"
        '
        'Text2
        '
        Me.Text2.Location = New System.Drawing.Point(487, 14)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(44, 20)
        Me.Text2.TabIndex = 44
        Me.Text2.Text = "6"
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(311, 15)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(49, 17)
        Me.rb1.TabIndex = 45
        Me.rb1.Text = "9600"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Checked = True
        Me.rb2.Location = New System.Drawing.Point(376, 15)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(55, 17)
        Me.rb2.TabIndex = 46
        Me.rb2.TabStop = True
        Me.rb2.Text = "38400"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 534)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb1)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonSet)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.Text21)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Text20)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Text1C)
        Me.Controls.Add(Me.Button1C)
        Me.Controls.Add(Me.Text15)
        Me.Controls.Add(Me.Text14)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Text13)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Text11)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Text0F)
        Me.Controls.Add(Me.Text0E)
        Me.Controls.Add(Me.Button0F)
        Me.Controls.Add(Me.Button0E)
        Me.Controls.Add(Me.Text0D)
        Me.Controls.Add(Me.Button0D)
        Me.Controls.Add(Me.Text0C)
        Me.Controls.Add(Me.Button0C)
        Me.Controls.Add(Me.Text0B)
        Me.Controls.Add(Me.Text07)
        Me.Controls.Add(Me.Button0B)
        Me.Controls.Add(Me.Button07)
        Me.Controls.Add(Me.Text06)
        Me.Controls.Add(Me.Button06)
        Me.Controls.Add(Me.Text05)
        Me.Controls.Add(Me.Button05)
        Me.Controls.Add(Me.Text04)
        Me.Controls.Add(Me.Text01)
        Me.Controls.Add(Me.Button04)
        Me.Controls.Add(Me.Button01)
        Me.Controls.Add(Me.rtb1)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.reset)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "OBD-II"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sp1 As System.IO.Ports.SerialPort
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents Text1 As System.Windows.Forms.TextBox
    Friend WithEvents rtb1 As System.Windows.Forms.RichTextBox
    Friend WithEvents read As System.Windows.Forms.Timer
    Friend WithEvents Button01 As System.Windows.Forms.Button
    Friend WithEvents Button04 As System.Windows.Forms.Button
    Friend WithEvents Text01 As System.Windows.Forms.TextBox
    Friend WithEvents Text04 As System.Windows.Forms.TextBox
    Friend WithEvents Button05 As System.Windows.Forms.Button
    Friend WithEvents Text05 As System.Windows.Forms.TextBox
    Friend WithEvents Text0C As System.Windows.Forms.TextBox
    Friend WithEvents Button0C As System.Windows.Forms.Button
    Friend WithEvents Text0B As System.Windows.Forms.TextBox
    Friend WithEvents Text07 As System.Windows.Forms.TextBox
    Friend WithEvents Button0B As System.Windows.Forms.Button
    Friend WithEvents Button07 As System.Windows.Forms.Button
    Friend WithEvents Text06 As System.Windows.Forms.TextBox
    Friend WithEvents Button06 As System.Windows.Forms.Button
    Friend WithEvents Text1C As System.Windows.Forms.TextBox
    Friend WithEvents Button1C As System.Windows.Forms.Button
    Friend WithEvents Text15 As System.Windows.Forms.TextBox
    Friend WithEvents Text14 As System.Windows.Forms.TextBox
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Text13 As System.Windows.Forms.TextBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Text11 As System.Windows.Forms.TextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Text0F As System.Windows.Forms.TextBox
    Friend WithEvents Text0E As System.Windows.Forms.TextBox
    Friend WithEvents Button0F As System.Windows.Forms.Button
    Friend WithEvents Button0E As System.Windows.Forms.Button
    Friend WithEvents Text0D As System.Windows.Forms.TextBox
    Friend WithEvents Button0D As System.Windows.Forms.Button
    Friend WithEvents Text21 As System.Windows.Forms.TextBox
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Text20 As System.Windows.Forms.TextBox
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonSet As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Text2 As System.Windows.Forms.TextBox
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton

End Class
