<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateUserForm
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
        Me.addUserBackButton = New System.Windows.Forms.Button()
        Me.updateUserButton = New System.Windows.Forms.Button()
        Me.updateUserRoleComboBox = New System.Windows.Forms.ComboBox()
        Me.lastName = New System.Windows.Forms.TextBox()
        Me.firstName = New System.Windows.Forms.TextBox()
        Me.userID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.userCreditReport = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'addUserBackButton
        '
        Me.addUserBackButton.Location = New System.Drawing.Point(168, 309)
        Me.addUserBackButton.Name = "addUserBackButton"
        Me.addUserBackButton.Size = New System.Drawing.Size(108, 23)
        Me.addUserBackButton.TabIndex = 22
        Me.addUserBackButton.Text = "Back"
        Me.addUserBackButton.UseVisualStyleBackColor = True
        '
        'updateUserButton
        '
        Me.updateUserButton.Location = New System.Drawing.Point(29, 309)
        Me.updateUserButton.Name = "updateUserButton"
        Me.updateUserButton.Size = New System.Drawing.Size(108, 23)
        Me.updateUserButton.TabIndex = 21
        Me.updateUserButton.Text = "Update User"
        Me.updateUserButton.UseVisualStyleBackColor = True
        '
        'updateUserRoleComboBox
        '
        Me.updateUserRoleComboBox.FormattingEnabled = True
        Me.updateUserRoleComboBox.Items.AddRange(New Object() {"Admin", "Student"})
        Me.updateUserRoleComboBox.Location = New System.Drawing.Point(112, 185)
        Me.updateUserRoleComboBox.Name = "updateUserRoleComboBox"
        Me.updateUserRoleComboBox.Size = New System.Drawing.Size(173, 21)
        Me.updateUserRoleComboBox.TabIndex = 20
        '
        'lastName
        '
        Me.lastName.Location = New System.Drawing.Point(112, 140)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(196, 20)
        Me.lastName.TabIndex = 19
        '
        'firstName
        '
        Me.firstName.Location = New System.Drawing.Point(112, 106)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(196, 20)
        Me.firstName.TabIndex = 18
        '
        'userID
        '
        Me.userID.Location = New System.Drawing.Point(112, 64)
        Me.userID.Name = "userID"
        Me.userID.Size = New System.Drawing.Size(196, 20)
        Me.userID.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Role"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "User ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 46)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Update User Info"
        '
        'userCreditReport
        '
        Me.userCreditReport.Location = New System.Drawing.Point(112, 219)
        Me.userCreditReport.Name = "userCreditReport"
        Me.userCreditReport.Size = New System.Drawing.Size(196, 20)
        Me.userCreditReport.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Credit Report"
        '
        'UpdateUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 414)
        Me.Controls.Add(Me.userCreditReport)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.addUserBackButton)
        Me.Controls.Add(Me.updateUserButton)
        Me.Controls.Add(Me.updateUserRoleComboBox)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.userID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateUserForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addUserBackButton As System.Windows.Forms.Button
    Friend WithEvents updateUserButton As System.Windows.Forms.Button
    Friend WithEvents updateUserRoleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents lastName As System.Windows.Forms.TextBox
    Friend WithEvents firstName As System.Windows.Forms.TextBox
    Friend WithEvents userID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents userCreditReport As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
