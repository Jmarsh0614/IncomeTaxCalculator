<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncomeTaxCalc
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblAnnualSalary = New System.Windows.Forms.Label()
        Me.lblnstructions = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtAnnualIncome = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCurrencySymbol = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblFedTax = New System.Windows.Forms.Label()
        Me.lblFicaTax = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblHeading.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(58, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(270, 28)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Annual Net Pay Calculator"
        '
        'lblAnnualSalary
        '
        Me.lblAnnualSalary.AutoSize = True
        Me.lblAnnualSalary.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAnnualSalary.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualSalary.Location = New System.Drawing.Point(33, 114)
        Me.lblAnnualSalary.Name = "lblAnnualSalary"
        Me.lblAnnualSalary.Size = New System.Drawing.Size(89, 18)
        Me.lblAnnualSalary.TabIndex = 1
        Me.lblAnnualSalary.Text = "Annual Salary"
        '
        'lblnstructions
        '
        Me.lblnstructions.AutoSize = True
        Me.lblnstructions.BackColor = System.Drawing.Color.Silver
        Me.lblnstructions.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnstructions.ForeColor = System.Drawing.Color.Black
        Me.lblnstructions.Location = New System.Drawing.Point(32, 55)
        Me.lblnstructions.Name = "lblnstructions"
        Me.lblnstructions.Size = New System.Drawing.Size(344, 22)
        Me.lblnstructions.TabIndex = 2
        Me.lblnstructions.Text = "Please Enter in your Annual Salary below " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(36, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'txtAnnualIncome
        '
        Me.txtAnnualIncome.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAnnualIncome.Location = New System.Drawing.Point(36, 136)
        Me.txtAnnualIncome.Name = "txtAnnualIncome"
        Me.txtAnnualIncome.Size = New System.Drawing.Size(100, 20)
        Me.txtAnnualIncome.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Gray
        Me.btnCalculate.Location = New System.Drawing.Point(24, 317)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gray
        Me.btnClear.Location = New System.Drawing.Point(155, 317)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Location = New System.Drawing.Point(286, 317)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblCurrencySymbol
        '
        Me.lblCurrencySymbol.AutoSize = True
        Me.lblCurrencySymbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrencySymbol.Location = New System.Drawing.Point(14, 135)
        Me.lblCurrencySymbol.Name = "lblCurrencySymbol"
        Me.lblCurrencySymbol.Size = New System.Drawing.Size(16, 18)
        Me.lblCurrencySymbol.TabIndex = 7
        Me.lblCurrencySymbol.Text = "$"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblStateTax.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(187, 206)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(74, 20)
        Me.lblStateTax.TabIndex = 8
        Me.lblStateTax.Text = "State Tax: "
        '
        'lblFedTax
        '
        Me.lblFedTax.AutoSize = True
        Me.lblFedTax.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFedTax.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFedTax.Location = New System.Drawing.Point(187, 177)
        Me.lblFedTax.Name = "lblFedTax"
        Me.lblFedTax.Size = New System.Drawing.Size(149, 20)
        Me.lblFedTax.TabIndex = 8
        Me.lblFedTax.Text = "Fed Tax: $XXXXXX.XX"
        '
        'lblFicaTax
        '
        Me.lblFicaTax.AutoSize = True
        Me.lblFicaTax.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFicaTax.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicaTax.Location = New System.Drawing.Point(187, 148)
        Me.lblFicaTax.Name = "lblFicaTax"
        Me.lblFicaTax.Size = New System.Drawing.Size(152, 20)
        Me.lblFicaTax.TabIndex = 8
        Me.lblFicaTax.Text = "Fica Tax: $XXXXXX.XX"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNetPay.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(187, 119)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(156, 20)
        Me.lblNetPay.TabIndex = 8
        Me.lblNetPay.Text = "Net Pay: $XXXXXXX.XX"
        '
        'frmIncomeTaxCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.IncomeTaxCalculator.My.Resources.Resources.Money
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(387, 352)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFedTax)
        Me.Controls.Add(Me.lblFicaTax)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblCurrencySymbol)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtAnnualIncome)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblnstructions)
        Me.Controls.Add(Me.lblAnnualSalary)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmIncomeTaxCalc"
        Me.Text = "                         Annual Net Pay Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblAnnualSalary As Label
    Friend WithEvents lblnstructions As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtAnnualIncome As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCurrencySymbol As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblFedTax As Label
    Friend WithEvents lblFicaTax As Label
    Friend WithEvents lblNetPay As Label
End Class
