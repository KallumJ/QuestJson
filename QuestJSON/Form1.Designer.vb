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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtIcon = New System.Windows.Forms.TextBox()
        Me.txtDisplayName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDisplayRecipe = New System.Windows.Forms.TextBox()
        Me.txtDisplayText = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtConditionAmount = New System.Windows.Forms.TextBox()
        Me.txtConditionItem = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRewardAmount = New System.Windows.Forms.TextBox()
        Me.txtRewardItem = New System.Windows.Forms.TextBox()
        Me.btnConditions = New System.Windows.Forms.Button()
        Me.btnRewards = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(10, 415)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(85, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(326, 20)
        Me.txtName.TabIndex = 1
        '
        'txtIcon
        '
        Me.txtIcon.Location = New System.Drawing.Point(85, 38)
        Me.txtIcon.Name = "txtIcon"
        Me.txtIcon.Size = New System.Drawing.Size(326, 20)
        Me.txtIcon.TabIndex = 2
        '
        'txtDisplayName
        '
        Me.txtDisplayName.Location = New System.Drawing.Point(85, 65)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(326, 20)
        Me.txtDisplayName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Icon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Display Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDisplayRecipe)
        Me.GroupBox1.Controls.Add(Me.txtDisplayText)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 87)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Recipe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Text"
        '
        'txtDisplayRecipe
        '
        Me.txtDisplayRecipe.Location = New System.Drawing.Point(72, 45)
        Me.txtDisplayRecipe.Name = "txtDisplayRecipe"
        Me.txtDisplayRecipe.Size = New System.Drawing.Size(326, 20)
        Me.txtDisplayRecipe.TabIndex = 10
        '
        'txtDisplayText
        '
        Me.txtDisplayText.Location = New System.Drawing.Point(72, 19)
        Me.txtDisplayText.Name = "txtDisplayText"
        Me.txtDisplayText.Size = New System.Drawing.Size(326, 20)
        Me.txtDisplayText.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtConditionAmount)
        Me.GroupBox2.Controls.Add(Me.txtConditionItem)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 87)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Conditions"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Item"
        '
        'txtConditionAmount
        '
        Me.txtConditionAmount.Location = New System.Drawing.Point(72, 45)
        Me.txtConditionAmount.Name = "txtConditionAmount"
        Me.txtConditionAmount.Size = New System.Drawing.Size(326, 20)
        Me.txtConditionAmount.TabIndex = 10
        '
        'txtConditionItem
        '
        Me.txtConditionItem.Location = New System.Drawing.Point(72, 19)
        Me.txtConditionItem.Name = "txtConditionItem"
        Me.txtConditionItem.Size = New System.Drawing.Size(326, 20)
        Me.txtConditionItem.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtRewardAmount)
        Me.GroupBox3.Controls.Add(Me.txtRewardItem)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 286)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(411, 87)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rewards"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Item"
        '
        'txtRewardAmount
        '
        Me.txtRewardAmount.Location = New System.Drawing.Point(72, 45)
        Me.txtRewardAmount.Name = "txtRewardAmount"
        Me.txtRewardAmount.Size = New System.Drawing.Size(326, 20)
        Me.txtRewardAmount.TabIndex = 10
        '
        'txtRewardItem
        '
        Me.txtRewardItem.Location = New System.Drawing.Point(72, 19)
        Me.txtRewardItem.Name = "txtRewardItem"
        Me.txtRewardItem.Size = New System.Drawing.Size(326, 20)
        Me.txtRewardItem.TabIndex = 8
        '
        'btnConditions
        '
        Me.btnConditions.Location = New System.Drawing.Point(430, 231)
        Me.btnConditions.Name = "btnConditions"
        Me.btnConditions.Size = New System.Drawing.Size(94, 23)
        Me.btnConditions.TabIndex = 10
        Me.btnConditions.Text = "Add Condition"
        Me.btnConditions.UseVisualStyleBackColor = True
        '
        'btnRewards
        '
        Me.btnRewards.Location = New System.Drawing.Point(430, 324)
        Me.btnRewards.Name = "btnRewards"
        Me.btnRewards.Size = New System.Drawing.Size(94, 23)
        Me.btnRewards.TabIndex = 11
        Me.btnRewards.Text = "Add Reward"
        Me.btnRewards.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 450)
        Me.Controls.Add(Me.btnRewards)
        Me.Controls.Add(Me.btnConditions)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDisplayName)
        Me.Controls.Add(Me.txtIcon)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtIcon As TextBox
    Friend WithEvents txtDisplayName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDisplayText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDisplayRecipe As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtConditionAmount As TextBox
    Friend WithEvents txtConditionItem As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRewardAmount As TextBox
    Friend WithEvents txtRewardItem As TextBox
    Friend WithEvents btnConditions As Button
    Friend WithEvents btnRewards As Button
End Class
