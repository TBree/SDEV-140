<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalExam
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRadioButon = New System.Windows.Forms.Label()
        Me.Radio_Btn_Add = New System.Windows.Forms.RadioButton()
        Me.Radio_btn_Subtract = New System.Windows.Forms.RadioButton()
        Me.Radio_btn_Dob = New System.Windows.Forms.RadioButton()
        Me.Radio_btn_Half = New System.Windows.Forms.RadioButton()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(127, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(312, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Number Calculations:"
        '
        'lblRadioButon
        '
        Me.lblRadioButon.AutoSize = True
        Me.lblRadioButon.Font = New System.Drawing.Font("Ravie", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRadioButon.Location = New System.Drawing.Point(62, 104)
        Me.lblRadioButon.Name = "lblRadioButon"
        Me.lblRadioButon.Size = New System.Drawing.Size(160, 21)
        Me.lblRadioButon.TabIndex = 9
        Me.lblRadioButon.Text = "Select a Task: "
        '
        'Radio_Btn_Add
        '
        Me.Radio_Btn_Add.AutoSize = True
        Me.Radio_Btn_Add.Checked = True
        Me.Radio_Btn_Add.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Radio_Btn_Add.Location = New System.Drawing.Point(62, 140)
        Me.Radio_Btn_Add.Name = "Radio_Btn_Add"
        Me.Radio_Btn_Add.Size = New System.Drawing.Size(64, 23)
        Me.Radio_Btn_Add.TabIndex = 2
        Me.Radio_Btn_Add.TabStop = True
        Me.Radio_Btn_Add.Text = "ADD"
        Me.Radio_Btn_Add.UseVisualStyleBackColor = True
        '
        'Radio_btn_Subtract
        '
        Me.Radio_btn_Subtract.AutoSize = True
        Me.Radio_btn_Subtract.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Radio_btn_Subtract.Location = New System.Drawing.Point(62, 169)
        Me.Radio_btn_Subtract.Name = "Radio_btn_Subtract"
        Me.Radio_btn_Subtract.Size = New System.Drawing.Size(116, 23)
        Me.Radio_btn_Subtract.TabIndex = 3
        Me.Radio_btn_Subtract.Text = "SUBTRACT"
        Me.Radio_btn_Subtract.UseVisualStyleBackColor = True
        '
        'Radio_btn_Dob
        '
        Me.Radio_btn_Dob.AutoSize = True
        Me.Radio_btn_Dob.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Radio_btn_Dob.Location = New System.Drawing.Point(62, 198)
        Me.Radio_btn_Dob.Name = "Radio_btn_Dob"
        Me.Radio_btn_Dob.Size = New System.Drawing.Size(97, 23)
        Me.Radio_btn_Dob.TabIndex = 4
        Me.Radio_btn_Dob.Text = "DOUBLE"
        Me.Radio_btn_Dob.UseVisualStyleBackColor = True
        '
        'Radio_btn_Half
        '
        Me.Radio_btn_Half.AutoSize = True
        Me.Radio_btn_Half.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Radio_btn_Half.Location = New System.Drawing.Point(62, 227)
        Me.Radio_btn_Half.Name = "Radio_btn_Half"
        Me.Radio_btn_Half.Size = New System.Drawing.Size(70, 23)
        Me.Radio_btn_Half.TabIndex = 5
        Me.Radio_btn_Half.Text = "HALF"
        Me.Radio_btn_Half.UseVisualStyleBackColor = True
        '
        'lblNumbers
        '
        Me.lblNumbers.AutoSize = True
        Me.lblNumbers.Font = New System.Drawing.Font("Ravie", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNumbers.Location = New System.Drawing.Point(320, 104)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(184, 21)
        Me.lblNumbers.TabIndex = 10
        Me.lblNumbers.Text = "Type In Numbers:"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(380, 142)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 23)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(380, 198)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 23)
        Me.txtNum2.TabIndex = 1
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum1.Location = New System.Drawing.Point(320, 146)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(29, 19)
        Me.lblNum1.TabIndex = 11
        Me.lblNum1.Text = "#1"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum2.Location = New System.Drawing.Point(320, 202)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(29, 19)
        Me.lblNum2.TabIndex = 12
        Me.lblNum2.Text = "#2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(62, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 35)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(290, 276)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(171, 35)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'FinalExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(595, 346)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.lblNumbers)
        Me.Controls.Add(Me.Radio_btn_Half)
        Me.Controls.Add(Me.Radio_btn_Dob)
        Me.Controls.Add(Me.Radio_btn_Subtract)
        Me.Controls.Add(Me.Radio_Btn_Add)
        Me.Controls.Add(Me.lblRadioButon)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "FinalExam"
        Me.Text = "Number Calculations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRadioButon As Label
    Friend WithEvents Radio_Btn_Add As RadioButton
    Friend WithEvents Radio_btn_Subtract As RadioButton
    Friend WithEvents Radio_btn_Dob As RadioButton
    Friend WithEvents Radio_btn_Half As RadioButton
    Friend WithEvents lblNumbers As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExit As Button
End Class
