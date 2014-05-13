<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageBooks))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bookNameTextBox = New System.Windows.Forms.TextBox()
        Me.genreTextBox = New System.Windows.Forms.TextBox()
        Me.bookDetailsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.clearGridButton = New System.Windows.Forms.Button()
        Me.deleteBookButton = New System.Windows.Forms.Button()
        Me.updateBookButton = New System.Windows.Forms.Button()
        Me.addBookButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.authorLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.authorFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.onShelfTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(312, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(287, 46)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Manage Books"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(56, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Book Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(56, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Book Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Location = New System.Drawing.Point(527, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Genre"
        '
        'bookNameTextBox
        '
        Me.bookNameTextBox.Location = New System.Drawing.Point(153, 74)
        Me.bookNameTextBox.Name = "bookNameTextBox"
        Me.bookNameTextBox.Size = New System.Drawing.Size(221, 20)
        Me.bookNameTextBox.TabIndex = 29
        '
        'genreTextBox
        '
        Me.genreTextBox.Location = New System.Drawing.Point(605, 56)
        Me.genreTextBox.Name = "genreTextBox"
        Me.genreTextBox.Size = New System.Drawing.Size(236, 20)
        Me.genreTextBox.TabIndex = 30
        '
        'bookDetailsRichTextBox
        '
        Me.bookDetailsRichTextBox.Location = New System.Drawing.Point(153, 113)
        Me.bookDetailsRichTextBox.Name = "bookDetailsRichTextBox"
        Me.bookDetailsRichTextBox.Size = New System.Drawing.Size(308, 96)
        Me.bookDetailsRichTextBox.TabIndex = 31
        Me.bookDetailsRichTextBox.Text = ""
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(153, 215)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(713, 147)
        Me.DataGridView1.TabIndex = 32
        '
        'clearGridButton
        '
        Me.clearGridButton.Location = New System.Drawing.Point(39, 326)
        Me.clearGridButton.Name = "clearGridButton"
        Me.clearGridButton.Size = New System.Drawing.Size(98, 30)
        Me.clearGridButton.TabIndex = 36
        Me.clearGridButton.Text = "Clear All"
        Me.clearGridButton.UseVisualStyleBackColor = True
        '
        'deleteBookButton
        '
        Me.deleteBookButton.Location = New System.Drawing.Point(39, 277)
        Me.deleteBookButton.Name = "deleteBookButton"
        Me.deleteBookButton.Size = New System.Drawing.Size(98, 30)
        Me.deleteBookButton.TabIndex = 35
        Me.deleteBookButton.Text = "Delete Book"
        Me.deleteBookButton.UseVisualStyleBackColor = True
        '
        'updateBookButton
        '
        Me.updateBookButton.Location = New System.Drawing.Point(39, 228)
        Me.updateBookButton.Name = "updateBookButton"
        Me.updateBookButton.Size = New System.Drawing.Size(98, 32)
        Me.updateBookButton.TabIndex = 34
        Me.updateBookButton.Text = "Update Book"
        Me.updateBookButton.UseVisualStyleBackColor = True
        '
        'addBookButton
        '
        Me.addBookButton.Location = New System.Drawing.Point(39, 178)
        Me.addBookButton.Name = "addBookButton"
        Me.addBookButton.Size = New System.Drawing.Size(98, 31)
        Me.addBookButton.TabIndex = 33
        Me.addBookButton.Text = "Add Book"
        Me.addBookButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.authorLastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.authorFirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(530, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 100)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Author Details"
        '
        'authorLastNameTextBox
        '
        Me.authorLastNameTextBox.Location = New System.Drawing.Point(114, 52)
        Me.authorLastNameTextBox.Name = "authorLastNameTextBox"
        Me.authorLastNameTextBox.Size = New System.Drawing.Size(177, 20)
        Me.authorLastNameTextBox.TabIndex = 41
        '
        'authorFirstNameTextBox
        '
        Me.authorFirstNameTextBox.Location = New System.Drawing.Point(114, 19)
        Me.authorFirstNameTextBox.Name = "authorFirstNameTextBox"
        Me.authorFirstNameTextBox.Size = New System.Drawing.Size(177, 20)
        Me.authorFirstNameTextBox.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.Location = New System.Drawing.Point(51, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Location = New System.Drawing.Point(51, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "First Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label6.Location = New System.Drawing.Point(527, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "On Shelf"
        '
        'onShelfTextBox
        '
        Me.onShelfTextBox.Location = New System.Drawing.Point(605, 86)
        Me.onShelfTextBox.Name = "onShelfTextBox"
        Me.onShelfTextBox.Size = New System.Drawing.Size(100, 20)
        Me.onShelfTextBox.TabIndex = 41
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 50)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'ManageBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(878, 374)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.onShelfTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.clearGridButton)
        Me.Controls.Add(Me.deleteBookButton)
        Me.Controls.Add(Me.updateBookButton)
        Me.Controls.Add(Me.addBookButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bookDetailsRichTextBox)
        Me.Controls.Add(Me.genreTextBox)
        Me.Controls.Add(Me.bookNameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Name = "ManageBooks"
        Me.Text = "ManageBooks"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bookNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents genreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents bookDetailsRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents clearGridButton As System.Windows.Forms.Button
    Friend WithEvents deleteBookButton As System.Windows.Forms.Button
    Friend WithEvents updateBookButton As System.Windows.Forms.Button
    Friend WithEvents addBookButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents authorLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents authorFirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents onShelfTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
