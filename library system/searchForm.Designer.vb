<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchForm
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
        Me.Search = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchByAuthorLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.searchByAuthorFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.genreComboBox = New System.Windows.Forms.ComboBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.searchByTitleTextBox = New System.Windows.Forms.TextBox()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.borrowButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Search.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Search.Controls.Add(Me.GroupBox1)
        Me.Search.Controls.Add(Me.Label6)
        Me.Search.Controls.Add(Me.Label4)
        Me.Search.Controls.Add(Me.genreComboBox)
        Me.Search.Controls.Add(Me.searchButton)
        Me.Search.Controls.Add(Me.searchByTitleTextBox)
        Me.Search.Location = New System.Drawing.Point(118, 75)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(504, 143)
        Me.Search.TabIndex = 5
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.searchByAuthorLastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.searchByAuthorFirstNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 74)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By Author"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(34, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Last Name"
        '
        'searchByAuthorLastNameTextBox
        '
        Me.searchByAuthorLastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchByAuthorLastNameTextBox.Location = New System.Drawing.Point(137, 42)
        Me.searchByAuthorLastNameTextBox.Name = "searchByAuthorLastNameTextBox"
        Me.searchByAuthorLastNameTextBox.Size = New System.Drawing.Size(199, 20)
        Me.searchByAuthorLastNameTextBox.TabIndex = 10
        Me.searchByAuthorLastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.Location = New System.Drawing.Point(34, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "First Name"
        '
        'searchByAuthorFirstNameTextBox
        '
        Me.searchByAuthorFirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchByAuthorFirstNameTextBox.Location = New System.Drawing.Point(137, 16)
        Me.searchByAuthorFirstNameTextBox.Name = "searchByAuthorFirstNameTextBox"
        Me.searchByAuthorFirstNameTextBox.Size = New System.Drawing.Size(199, 20)
        Me.searchByAuthorFirstNameTextBox.TabIndex = 8
        Me.searchByAuthorFirstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label6.Location = New System.Drawing.Point(23, 42)
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
        Me.genreComboBox.Location = New System.Drawing.Point(131, 36)
        Me.genreComboBox.Name = "genreComboBox"
        Me.genreComboBox.Size = New System.Drawing.Size(199, 21)
        Me.genreComboBox.TabIndex = 5
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(353, 10)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(136, 33)
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
        'dataGridView
        '
        Me.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Location = New System.Drawing.Point(151, 224)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(482, 198)
        Me.dataGridView.TabIndex = 4
        '
        'borrowButton
        '
        Me.borrowButton.Location = New System.Drawing.Point(32, 235)
        Me.borrowButton.Name = "borrowButton"
        Me.borrowButton.Size = New System.Drawing.Size(102, 46)
        Me.borrowButton.TabIndex = 6
        Me.borrowButton.Text = "Borrow"
        Me.borrowButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(165, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 39)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Advanced Search Form"
        '
        'searchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(697, 432)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.borrowButton)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.dataGridView)
        Me.Name = "searchForm"
        Me.Text = "searchForm"
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Search As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents genreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents searchByTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents borrowButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents searchByAuthorLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents searchByAuthorFirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
