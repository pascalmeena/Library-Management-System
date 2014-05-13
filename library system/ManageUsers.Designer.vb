<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUsers))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.deleteUserButton = New System.Windows.Forms.Button()
        Me.updateUserButton = New System.Windows.Forms.Button()
        Me.addUserButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.userNameTextBox = New System.Windows.Forms.TextBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.feesDueTextBox = New System.Windows.Forms.TextBox()
        Me.roleComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.clearGridButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(174, 227)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(733, 178)
        Me.DataGridView1.TabIndex = 11
        '
        'deleteUserButton
        '
        Me.deleteUserButton.Location = New System.Drawing.Point(54, 326)
        Me.deleteUserButton.Name = "deleteUserButton"
        Me.deleteUserButton.Size = New System.Drawing.Size(98, 30)
        Me.deleteUserButton.TabIndex = 10
        Me.deleteUserButton.Text = "Delete User"
        Me.deleteUserButton.UseVisualStyleBackColor = True
        '
        'updateUserButton
        '
        Me.updateUserButton.Location = New System.Drawing.Point(54, 277)
        Me.updateUserButton.Name = "updateUserButton"
        Me.updateUserButton.Size = New System.Drawing.Size(98, 32)
        Me.updateUserButton.TabIndex = 9
        Me.updateUserButton.Text = "Update User"
        Me.updateUserButton.UseVisualStyleBackColor = True
        '
        'addUserButton
        '
        Me.addUserButton.Location = New System.Drawing.Point(54, 227)
        Me.addUserButton.Name = "addUserButton"
        Me.addUserButton.Size = New System.Drawing.Size(98, 31)
        Me.addUserButton.TabIndex = 8
        Me.addUserButton.Text = "Add User"
        Me.addUserButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(443, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Role"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(443, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Fees Due"
        '
        'userNameTextBox
        '
        Me.userNameTextBox.Location = New System.Drawing.Point(197, 86)
        Me.userNameTextBox.Name = "userNameTextBox"
        Me.userNameTextBox.Size = New System.Drawing.Size(148, 20)
        Me.userNameTextBox.TabIndex = 18
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Location = New System.Drawing.Point(197, 116)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(148, 20)
        Me.firstNameTextBox.TabIndex = 19
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Location = New System.Drawing.Point(197, 146)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(148, 20)
        Me.lastNameTextBox.TabIndex = 20
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(547, 86)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(154, 20)
        Me.passwordTextBox.TabIndex = 21
        '
        'feesDueTextBox
        '
        Me.feesDueTextBox.Location = New System.Drawing.Point(547, 149)
        Me.feesDueTextBox.Name = "feesDueTextBox"
        Me.feesDueTextBox.Size = New System.Drawing.Size(154, 20)
        Me.feesDueTextBox.TabIndex = 22
        '
        'roleComboBox
        '
        Me.roleComboBox.FormattingEnabled = True
        Me.roleComboBox.Items.AddRange(New Object() {"Admin", "Student"})
        Me.roleComboBox.Location = New System.Drawing.Point(547, 122)
        Me.roleComboBox.Name = "roleComboBox"
        Me.roleComboBox.Size = New System.Drawing.Size(121, 21)
        Me.roleComboBox.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(329, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(278, 46)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Manage Users"
        '
        'clearGridButton
        '
        Me.clearGridButton.Location = New System.Drawing.Point(54, 375)
        Me.clearGridButton.Name = "clearGridButton"
        Me.clearGridButton.Size = New System.Drawing.Size(98, 30)
        Me.clearGridButton.TabIndex = 26
        Me.clearGridButton.Text = "Clear All"
        Me.clearGridButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(54, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 50)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'ManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(938, 417)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.clearGridButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.roleComboBox)
        Me.Controls.Add(Me.feesDueTextBox)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.userNameTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.deleteUserButton)
        Me.Controls.Add(Me.updateUserButton)
        Me.Controls.Add(Me.addUserButton)
        Me.Name = "ManageUsers"
        Me.Text = "ManageUsers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents deleteUserButton As System.Windows.Forms.Button
    Friend WithEvents updateUserButton As System.Windows.Forms.Button
    Friend WithEvents addUserButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents userNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents firstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents feesDueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents roleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents clearGridButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
