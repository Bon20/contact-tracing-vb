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
        Me.txtbxFname = New System.Windows.Forms.TextBox()
        Me.txtbxLname = New System.Windows.Forms.TextBox()
        Me.txtbxCnumber = New System.Windows.Forms.TextBox()
        Me.txtbxAge = New System.Windows.Forms.TextBox()
        Me.cbxGender = New System.Windows.Forms.ComboBox()
        Me.txtbxAddress = New System.Windows.Forms.TextBox()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblCnumber = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.gbxQuestion1 = New System.Windows.Forms.GroupBox()
        Me.radbuttonNo = New System.Windows.Forms.RadioButton()
        Me.radbuttonYes = New System.Windows.Forms.RadioButton()
        Me.lblQuestion2 = New System.Windows.Forms.Label()
        Me.cboxFever = New System.Windows.Forms.ComboBox()
        Me.cboxCough = New System.Windows.Forms.ComboBox()
        Me.cboxColds = New System.Windows.Forms.ComboBox()
        Me.cboxSorethroat = New System.Windows.Forms.ComboBox()
        Me.cboxDiffInBreath = New System.Windows.Forms.ComboBox()
        Me.cBoxDiarrhea = New System.Windows.Forms.ComboBox()
        Me.lblFever = New System.Windows.Forms.Label()
        Me.lblCough = New System.Windows.Forms.Label()
        Me.lblColds = New System.Windows.Forms.Label()
        Me.lblSorethroat = New System.Windows.Forms.Label()
        Me.lblDiffInBreath = New System.Windows.Forms.Label()
        Me.lbldiarrhea = New System.Windows.Forms.Label()
        Me.lblAppname = New System.Windows.Forms.Label()
        Me.lblSubhead = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.gbxQuestion1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtbxFname
        '
        Me.txtbxFname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtbxFname.Location = New System.Drawing.Point(162, 58)
        Me.txtbxFname.Name = "txtbxFname"
        Me.txtbxFname.Size = New System.Drawing.Size(164, 27)
        Me.txtbxFname.TabIndex = 0
        '
        'txtbxLname
        '
        Me.txtbxLname.Location = New System.Drawing.Point(162, 91)
        Me.txtbxLname.Name = "txtbxLname"
        Me.txtbxLname.Size = New System.Drawing.Size(164, 27)
        Me.txtbxLname.TabIndex = 0
        '
        'txtbxCnumber
        '
        Me.txtbxCnumber.Location = New System.Drawing.Point(162, 124)
        Me.txtbxCnumber.Name = "txtbxCnumber"
        Me.txtbxCnumber.Size = New System.Drawing.Size(164, 27)
        Me.txtbxCnumber.TabIndex = 0
        '
        'txtbxAge
        '
        Me.txtbxAge.Location = New System.Drawing.Point(162, 157)
        Me.txtbxAge.Name = "txtbxAge"
        Me.txtbxAge.Size = New System.Drawing.Size(48, 27)
        Me.txtbxAge.TabIndex = 0
        '
        'cbxGender
        '
        Me.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGender.FormattingEnabled = True
        Me.cbxGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cbxGender.Location = New System.Drawing.Point(161, 190)
        Me.cbxGender.Name = "cbxGender"
        Me.cbxGender.Size = New System.Drawing.Size(164, 28)
        Me.cbxGender.TabIndex = 1
        '
        'txtbxAddress
        '
        Me.txtbxAddress.Location = New System.Drawing.Point(161, 227)
        Me.txtbxAddress.Multiline = True
        Me.txtbxAddress.Name = "txtbxAddress"
        Me.txtbxAddress.Size = New System.Drawing.Size(159, 82)
        Me.txtbxAddress.TabIndex = 2
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblFname.Location = New System.Drawing.Point(59, 61)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(94, 20)
        Me.lblFname.TabIndex = 3
        Me.lblFname.Text = "FIRST NAME:"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblLname.Location = New System.Drawing.Point(62, 94)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(91, 20)
        Me.lblLname.TabIndex = 3
        Me.lblLname.Text = "LAST NAME:"
        '
        'lblCnumber
        '
        Me.lblCnumber.AutoSize = True
        Me.lblCnumber.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblCnumber.Location = New System.Drawing.Point(12, 124)
        Me.lblCnumber.Name = "lblCnumber"
        Me.lblCnumber.Size = New System.Drawing.Size(141, 20)
        Me.lblCnumber.TabIndex = 3
        Me.lblCnumber.Text = "CONTACT NUMBER:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblAge.Location = New System.Drawing.Point(109, 160)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(40, 20)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "AGE:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblGender.Location = New System.Drawing.Point(80, 190)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(69, 20)
        Me.lblGender.TabIndex = 3
        Me.lblGender.Text = "GENDER:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblAddress.Location = New System.Drawing.Point(72, 227)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(77, 20)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "ADDRESS:"
        '
        'gbxQuestion1
        '
        Me.gbxQuestion1.Controls.Add(Me.radbuttonNo)
        Me.gbxQuestion1.Controls.Add(Me.radbuttonYes)
        Me.gbxQuestion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gbxQuestion1.Location = New System.Drawing.Point(47, 331)
        Me.gbxQuestion1.Name = "gbxQuestion1"
        Me.gbxQuestion1.Size = New System.Drawing.Size(279, 89)
        Me.gbxQuestion1.TabIndex = 4
        Me.gbxQuestion1.TabStop = False
        Me.gbxQuestion1.Text = "Have you had encounter with COVID-19 positive? :"
        '
        'radbuttonNo
        '
        Me.radbuttonNo.AutoSize = True
        Me.radbuttonNo.Location = New System.Drawing.Point(147, 42)
        Me.radbuttonNo.Name = "radbuttonNo"
        Me.radbuttonNo.Size = New System.Drawing.Size(50, 24)
        Me.radbuttonNo.TabIndex = 0
        Me.radbuttonNo.TabStop = True
        Me.radbuttonNo.Text = "No"
        Me.radbuttonNo.UseVisualStyleBackColor = True
        '
        'radbuttonYes
        '
        Me.radbuttonYes.AutoSize = True
        Me.radbuttonYes.Location = New System.Drawing.Point(62, 42)
        Me.radbuttonYes.Name = "radbuttonYes"
        Me.radbuttonYes.Size = New System.Drawing.Size(51, 24)
        Me.radbuttonYes.TabIndex = 0
        Me.radbuttonYes.TabStop = True
        Me.radbuttonYes.Text = "Yes"
        Me.radbuttonYes.UseVisualStyleBackColor = True
        '
        'lblQuestion2
        '
        Me.lblQuestion2.AutoSize = True
        Me.lblQuestion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblQuestion2.Location = New System.Drawing.Point(360, 56)
        Me.lblQuestion2.Name = "lblQuestion2"
        Me.lblQuestion2.Size = New System.Drawing.Size(416, 20)
        Me.lblQuestion2.TabIndex = 5
        Me.lblQuestion2.Text = "Have you been sick of any of the following in the last 14 days:"
        '
        'cboxFever
        '
        Me.cboxFever.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxFever.FormattingEnabled = True
        Me.cboxFever.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboxFever.Location = New System.Drawing.Point(567, 103)
        Me.cboxFever.Name = "cboxFever"
        Me.cboxFever.Size = New System.Drawing.Size(130, 28)
        Me.cboxFever.TabIndex = 6
        '
        'cboxCough
        '
        Me.cboxCough.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCough.FormattingEnabled = True
        Me.cboxCough.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboxCough.Location = New System.Drawing.Point(567, 137)
        Me.cboxCough.Name = "cboxCough"
        Me.cboxCough.Size = New System.Drawing.Size(130, 28)
        Me.cboxCough.TabIndex = 6
        '
        'cboxColds
        '
        Me.cboxColds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxColds.FormattingEnabled = True
        Me.cboxColds.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboxColds.Location = New System.Drawing.Point(567, 171)
        Me.cboxColds.Name = "cboxColds"
        Me.cboxColds.Size = New System.Drawing.Size(130, 28)
        Me.cboxColds.TabIndex = 6
        '
        'cboxSorethroat
        '
        Me.cboxSorethroat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSorethroat.FormattingEnabled = True
        Me.cboxSorethroat.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboxSorethroat.Location = New System.Drawing.Point(567, 205)
        Me.cboxSorethroat.Name = "cboxSorethroat"
        Me.cboxSorethroat.Size = New System.Drawing.Size(130, 28)
        Me.cboxSorethroat.TabIndex = 6
        '
        'cboxDiffInBreath
        '
        Me.cboxDiffInBreath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxDiffInBreath.FormattingEnabled = True
        Me.cboxDiffInBreath.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboxDiffInBreath.Location = New System.Drawing.Point(567, 239)
        Me.cboxDiffInBreath.Name = "cboxDiffInBreath"
        Me.cboxDiffInBreath.Size = New System.Drawing.Size(130, 28)
        Me.cboxDiffInBreath.TabIndex = 6
        '
        'cBoxDiarrhea
        '
        Me.cBoxDiarrhea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxDiarrhea.FormattingEnabled = True
        Me.cBoxDiarrhea.Items.AddRange(New Object() {"YES", "NO"})
        Me.cBoxDiarrhea.Location = New System.Drawing.Point(567, 273)
        Me.cBoxDiarrhea.Name = "cBoxDiarrhea"
        Me.cBoxDiarrhea.Size = New System.Drawing.Size(130, 28)
        Me.cBoxDiarrhea.TabIndex = 6
        '
        'lblFever
        '
        Me.lblFever.AutoSize = True
        Me.lblFever.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblFever.Location = New System.Drawing.Point(500, 106)
        Me.lblFever.Name = "lblFever"
        Me.lblFever.Size = New System.Drawing.Size(53, 20)
        Me.lblFever.TabIndex = 7
        Me.lblFever.Text = "FEVER:"
        '
        'lblCough
        '
        Me.lblCough.AutoSize = True
        Me.lblCough.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblCough.Location = New System.Drawing.Point(490, 140)
        Me.lblCough.Name = "lblCough"
        Me.lblCough.Size = New System.Drawing.Size(63, 20)
        Me.lblCough.TabIndex = 7
        Me.lblCough.Text = "COUGH:"
        '
        'lblColds
        '
        Me.lblColds.AutoSize = True
        Me.lblColds.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblColds.Location = New System.Drawing.Point(495, 179)
        Me.lblColds.Name = "lblColds"
        Me.lblColds.Size = New System.Drawing.Size(58, 20)
        Me.lblColds.TabIndex = 7
        Me.lblColds.Text = "COLDS:"
        '
        'lblSorethroat
        '
        Me.lblSorethroat.AutoSize = True
        Me.lblSorethroat.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblSorethroat.Location = New System.Drawing.Point(445, 213)
        Me.lblSorethroat.Name = "lblSorethroat"
        Me.lblSorethroat.Size = New System.Drawing.Size(108, 20)
        Me.lblSorethroat.TabIndex = 7
        Me.lblSorethroat.Text = "SORE THROAT:"
        '
        'lblDiffInBreath
        '
        Me.lblDiffInBreath.AutoSize = True
        Me.lblDiffInBreath.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDiffInBreath.Location = New System.Drawing.Point(365, 242)
        Me.lblDiffInBreath.Name = "lblDiffInBreath"
        Me.lblDiffInBreath.Size = New System.Drawing.Size(188, 20)
        Me.lblDiffInBreath.TabIndex = 7
        Me.lblDiffInBreath.Text = "DIFFICULTY IN BREATHING:"
        '
        'lbldiarrhea
        '
        Me.lbldiarrhea.AutoSize = True
        Me.lbldiarrhea.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbldiarrhea.Location = New System.Drawing.Point(469, 276)
        Me.lbldiarrhea.Name = "lbldiarrhea"
        Me.lbldiarrhea.Size = New System.Drawing.Size(84, 20)
        Me.lbldiarrhea.TabIndex = 7
        Me.lbldiarrhea.Text = "DIARRHEA:"
        '
        'lblAppname
        '
        Me.lblAppname.AutoSize = True
        Me.lblAppname.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAppname.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblAppname.Location = New System.Drawing.Point(47, 9)
        Me.lblAppname.Name = "lblAppname"
        Me.lblAppname.Size = New System.Drawing.Size(300, 41)
        Me.lblAppname.TabIndex = 8
        Me.lblAppname.Text = "PARADISO GARDEN"
        '
        'lblSubhead
        '
        Me.lblSubhead.AutoSize = True
        Me.lblSubhead.Font = New System.Drawing.Font("Matura MT Script Capitals", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblSubhead.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblSubhead.Location = New System.Drawing.Point(338, 19)
        Me.lblSubhead.Name = "lblSubhead"
        Me.lblSubhead.Size = New System.Drawing.Size(215, 26)
        Me.lblSubhead.TabIndex = 9
        Me.lblSubhead.Text = "Contact Tracing App"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Navy
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSubmit.Location = New System.Drawing.Point(567, 349)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(125, 55)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblSubhead)
        Me.Controls.Add(Me.lblAppname)
        Me.Controls.Add(Me.lbldiarrhea)
        Me.Controls.Add(Me.lblDiffInBreath)
        Me.Controls.Add(Me.lblSorethroat)
        Me.Controls.Add(Me.lblColds)
        Me.Controls.Add(Me.lblCough)
        Me.Controls.Add(Me.lblFever)
        Me.Controls.Add(Me.cBoxDiarrhea)
        Me.Controls.Add(Me.cboxDiffInBreath)
        Me.Controls.Add(Me.cboxSorethroat)
        Me.Controls.Add(Me.cboxColds)
        Me.Controls.Add(Me.cboxCough)
        Me.Controls.Add(Me.cboxFever)
        Me.Controls.Add(Me.lblQuestion2)
        Me.Controls.Add(Me.gbxQuestion1)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblCnumber)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.txtbxAddress)
        Me.Controls.Add(Me.cbxGender)
        Me.Controls.Add(Me.txtbxAge)
        Me.Controls.Add(Me.txtbxCnumber)
        Me.Controls.Add(Me.txtbxLname)
        Me.Controls.Add(Me.txtbxFname)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbxQuestion1.ResumeLayout(False)
        Me.gbxQuestion1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbxFname As TextBox
    Friend WithEvents txtbxLname As TextBox
    Friend WithEvents txtbxCnumber As TextBox
    Friend WithEvents txtbxAge As TextBox
    Friend WithEvents cbxGender As ComboBox
    Friend WithEvents txtbxAddress As TextBox
    Friend WithEvents lblFname As Label
    Friend WithEvents lblLname As Label
    Friend WithEvents lblCnumber As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents gbxQuestion1 As GroupBox
    Friend WithEvents radbuttonYes As RadioButton
    Friend WithEvents radbuttonNo As RadioButton
    Friend WithEvents lblQuestion2 As Label
    Friend WithEvents cboxFever As ComboBox
    Friend WithEvents cboxCough As ComboBox
    Friend WithEvents cboxColds As ComboBox
    Friend WithEvents cboxSorethroat As ComboBox
    Friend WithEvents cboxDiffInBreath As ComboBox
    Friend WithEvents cBoxDiarrhea As ComboBox
    Friend WithEvents lblFever As Label
    Friend WithEvents lblCough As Label
    Friend WithEvents lblColds As Label
    Friend WithEvents lblSorethroat As Label
    Friend WithEvents lblDiffInBreath As Label
    Friend WithEvents lbldiarrhea As Label
    Friend WithEvents lblAppname As Label
    Friend WithEvents lblSubhead As Label
    Friend WithEvents btnSubmit As Button
End Class
