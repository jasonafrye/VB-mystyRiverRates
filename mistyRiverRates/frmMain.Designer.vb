<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.picCamp = New System.Windows.Forms.PictureBox()
        Me.cboSite = New System.Windows.Forms.ComboBox()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMil = New System.Windows.Forms.RadioButton()
        Me.radAAA = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCOB = New System.Windows.Forms.Button()
        CType(Me.picCamp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCamp
        '
        Me.picCamp.Image = Global.mistyRiverRates.My.Resources.Resources.campground
        Me.picCamp.Location = New System.Drawing.Point(353, 12)
        Me.picCamp.Name = "picCamp"
        Me.picCamp.Size = New System.Drawing.Size(338, 284)
        Me.picCamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCamp.TabIndex = 0
        Me.picCamp.TabStop = False
        '
        'cboSite
        '
        Me.cboSite.FormattingEnabled = True
        Me.cboSite.Items.AddRange(New Object() {"Tent Site - $20/night", "RV Site - $35/night", "Cabin Rental - $55/night"})
        Me.cboSite.Location = New System.Drawing.Point(177, 38)
        Me.cboSite.Name = "cboSite"
        Me.cboSite.Size = New System.Drawing.Size(121, 21)
        Me.cboSite.TabIndex = 1
        Me.cboSite.Text = "Please Select a Site"
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(177, 89)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(100, 20)
        Me.txtNights.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMil)
        Me.GroupBox1.Controls.Add(Me.radAAA)
        Me.GroupBox1.Controls.Add(Me.radNone)
        Me.GroupBox1.Location = New System.Drawing.Point(177, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 106)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'radMil
        '
        Me.radMil.AutoSize = True
        Me.radMil.Location = New System.Drawing.Point(7, 66)
        Me.radMil.Name = "radMil"
        Me.radMil.Size = New System.Drawing.Size(86, 17)
        Me.radMil.TabIndex = 2
        Me.radMil.Text = "Military - 12%"
        Me.radMil.UseVisualStyleBackColor = True
        '
        'radAAA
        '
        Me.radAAA.AutoSize = True
        Me.radAAA.Location = New System.Drawing.Point(7, 43)
        Me.radAAA.Name = "radAAA"
        Me.radAAA.Size = New System.Drawing.Size(75, 17)
        Me.radAAA.TabIndex = 1
        Me.radAAA.Text = "AAA - 10%"
        Me.radAAA.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Checked = True
        Me.radNone.Location = New System.Drawing.Point(7, 20)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(51, 17)
        Me.radNone.TabIndex = 0
        Me.radNone.TabStop = True
        Me.radNone.Text = "None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select a Site"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Length of Stay (1-14)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Select Discount"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(30, 273)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(177, 273)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCOB
        '
        Me.btnCOB.Location = New System.Drawing.Point(552, 321)
        Me.btnCOB.Name = "btnCOB"
        Me.btnCOB.Size = New System.Drawing.Size(139, 23)
        Me.btnCOB.TabIndex = 9
        Me.btnCOB.Text = "Close of Business"
        Me.btnCOB.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 356)
        Me.Controls.Add(Me.btnCOB)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNights)
        Me.Controls.Add(Me.cboSite)
        Me.Controls.Add(Me.picCamp)
        Me.Name = "frmMain"
        Me.Text = "Misty River Campground Rates"
        CType(Me.picCamp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCamp As System.Windows.Forms.PictureBox
    Friend WithEvents cboSite As System.Windows.Forms.ComboBox
    Friend WithEvents txtNights As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radMil As System.Windows.Forms.RadioButton
    Friend WithEvents radAAA As System.Windows.Forms.RadioButton
    Friend WithEvents radNone As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCOB As System.Windows.Forms.Button

End Class
