<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.loginButton = New System.Windows.Forms.Button()
        Me.loginGroupBox = New System.Windows.Forms.GroupBox()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.userNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.genreComboBox = New System.Windows.Forms.ComboBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.searchByTitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.checkOutButton = New System.Windows.Forms.Button()
        Me.libraryHoursButton = New System.Windows.Forms.Button()
        Me.adminButton = New System.Windows.Forms.Button()
        Me.userPortalButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.welcomeLabel = New System.Windows.Forms.Label()
        Me.userLabel = New System.Windows.Forms.Label()
        Me.loginGroupBox.SuspendLayout()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Search.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(133, 65)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(58, 24)
        Me.loginButton.TabIndex = 0
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'loginGroupBox
        '
        Me.loginGroupBox.Controls.Add(Me.registerButton)
        Me.loginGroupBox.Controls.Add(Me.passwordTextBox)
        Me.loginGroupBox.Controls.Add(Me.userNameTextBox)
        Me.loginGroupBox.Controls.Add(Me.Label2)
        Me.loginGroupBox.Controls.Add(Me.loginButton)
        Me.loginGroupBox.Controls.Add(Me.Label1)
        Me.loginGroupBox.Location = New System.Drawing.Point(616, 62)
        Me.loginGroupBox.Name = "loginGroupBox"
        Me.loginGroupBox.Size = New System.Drawing.Size(203, 96)
        Me.loginGroupBox.TabIndex = 1
        Me.loginGroupBox.TabStop = False
        Me.loginGroupBox.Text = "Login"
        '
        'registerButton
        '
        Me.registerButton.Location = New System.Drawing.Point(43, 66)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(58, 24)
        Me.registerButton.TabIndex = 4
        Me.registerButton.Text = "Register"
        Me.registerButton.UseVisualStyleBackColor = True
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(91, 39)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.passwordTextBox.TabIndex = 3
        '
        'userNameTextBox
        '
        Me.userNameTextBox.Location = New System.Drawing.Point(91, 13)
        Me.userNameTextBox.Name = "userNameTextBox"
        Me.userNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.userNameTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(23, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(23, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name"
        '
        'dataGridView
        '
        Me.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Location = New System.Drawing.Point(235, 208)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(570, 198)
        Me.dataGridView.TabIndex = 2
        '
        'Search
        '
        Me.Search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Search.Controls.Add(Me.Label6)
        Me.Search.Controls.Add(Me.Label4)
        Me.Search.Controls.Add(Me.genreComboBox)
        Me.Search.Controls.Add(Me.searchButton)
        Me.Search.Controls.Add(Me.searchByTitleTextBox)
        Me.Search.Location = New System.Drawing.Point(261, 62)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(340, 112)
        Me.Search.TabIndex = 3
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label6.Location = New System.Drawing.Point(23, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Search By Genre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Location = New System.Drawing.Point(23, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Search By Title"
        '
        'genreComboBox
        '
        Me.genreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genreComboBox.FormattingEnabled = True
        Me.genreComboBox.Location = New System.Drawing.Point(131, 40)
        Me.genreComboBox.Name = "genreComboBox"
        Me.genreComboBox.Size = New System.Drawing.Size(199, 21)
        Me.genreComboBox.TabIndex = 5
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(182, 73)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(109, 23)
        Me.searchButton.TabIndex = 4
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'searchByTitleTextBox
        '
        Me.searchByTitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchByTitleTextBox.Location = New System.Drawing.Point(131, 13)
        Me.searchByTitleTextBox.Name = "searchByTitleTextBox"
        Me.searchByTitleTextBox.Size = New System.Drawing.Size(199, 20)
        Me.searchByTitleTextBox.TabIndex = 0
        Me.searchByTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(116, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(552, 46)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Library Management System"
        '
        'checkOutButton
        '
        Me.checkOutButton.Location = New System.Drawing.Point(12, 208)
        Me.checkOutButton.Name = "checkOutButton"
        Me.checkOutButton.Size = New System.Drawing.Size(185, 37)
        Me.checkOutButton.TabIndex = 5
        Me.checkOutButton.Text = "Check Out"
        Me.checkOutButton.UseVisualStyleBackColor = True
        '
        'libraryHoursButton
        '
        Me.libraryHoursButton.Location = New System.Drawing.Point(14, 261)
        Me.libraryHoursButton.Name = "libraryHoursButton"
        Me.libraryHoursButton.Size = New System.Drawing.Size(183, 37)
        Me.libraryHoursButton.TabIndex = 6
        Me.libraryHoursButton.Text = "Library Hours"
        Me.libraryHoursButton.UseVisualStyleBackColor = True
        '
        'adminButton
        '
        Me.adminButton.Location = New System.Drawing.Point(16, 317)
        Me.adminButton.Name = "adminButton"
        Me.adminButton.Size = New System.Drawing.Size(183, 39)
        Me.adminButton.TabIndex = 8
        Me.adminButton.Text = "Admin Portal"
        Me.adminButton.UseVisualStyleBackColor = True
        '
        'userPortalButton
        '
        Me.userPortalButton.Location = New System.Drawing.Point(14, 317)
        Me.userPortalButton.Name = "userPortalButton"
        Me.userPortalButton.Size = New System.Drawing.Size(183, 39)
        Me.userPortalButton.TabIndex = 9
        Me.userPortalButton.Text = "My Portal"
        Me.userPortalButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 47)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'logoutButton
        '
        Me.logoutButton.Location = New System.Drawing.Point(666, 100)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(120, 34)
        Me.logoutButton.TabIndex = 0
        Me.logoutButton.Text = "Logout"
        Me.logoutButton.UseVisualStyleBackColor = True
        '
        'welcomeLabel
        '
        Me.welcomeLabel.AutoSize = True
        Me.welcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomeLabel.Location = New System.Drawing.Point(631, 73)
        Me.welcomeLabel.Name = "welcomeLabel"
        Me.welcomeLabel.Size = New System.Drawing.Size(75, 20)
        Me.welcomeLabel.TabIndex = 9
        Me.welcomeLabel.Text = "Welcome"
        '
        'userLabel
        '
        Me.userLabel.AutoSize = True
        Me.userLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.userLabel.Location = New System.Drawing.Point(710, 73)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(88, 20)
        Me.userLabel.TabIndex = 10
        Me.userLabel.Text = "userLabel"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(848, 419)
        Me.Controls.Add(Me.userLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.welcomeLabel)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.userPortalButton)
        Me.Controls.Add(Me.loginGroupBox)
        Me.Controls.Add(Me.adminButton)
        Me.Controls.Add(Me.libraryHoursButton)
        Me.Controls.Add(Me.checkOutButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.dataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.Text = "Library Management System"
        Me.loginGroupBox.ResumeLayout(False)
        Me.loginGroupBox.PerformLayout()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loginButton As System.Windows.Forms.Button
    Friend WithEvents loginGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents registerButton As System.Windows.Forms.Button
    Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents userNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Search As System.Windows.Forms.GroupBox
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents searchByTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents genreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents checkOutButton As System.Windows.Forms.Button
    Friend WithEvents libraryHoursButton As System.Windows.Forms.Button
    Friend WithEvents adminButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents userPortalButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents logoutButton As System.Windows.Forms.Button
    Friend WithEvents userLabel As System.Windows.Forms.Label
    Friend WithEvents welcomeLabel As System.Windows.Forms.Label
End Class
