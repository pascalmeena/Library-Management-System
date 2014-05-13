<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.manageUsersButton = New System.Windows.Forms.Button()
        Me.manageBooksButton = New System.Windows.Forms.Button()
        Me.viewReportsButton = New System.Windows.Forms.Button()
        Me.lateReturnButton = New System.Windows.Forms.Button()
        Me.issueBooksButton = New System.Windows.Forms.Button()
        Me.ETLButton = New System.Windows.Forms.Button()
        Me.DashboardButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'manageUsersButton
        '
        Me.manageUsersButton.Location = New System.Drawing.Point(42, 83)
        Me.manageUsersButton.Name = "manageUsersButton"
        Me.manageUsersButton.Size = New System.Drawing.Size(243, 43)
        Me.manageUsersButton.TabIndex = 7
        Me.manageUsersButton.Text = "Manage Users"
        Me.manageUsersButton.UseVisualStyleBackColor = True
        '
        'manageBooksButton
        '
        Me.manageBooksButton.Location = New System.Drawing.Point(42, 132)
        Me.manageBooksButton.Name = "manageBooksButton"
        Me.manageBooksButton.Size = New System.Drawing.Size(243, 33)
        Me.manageBooksButton.TabIndex = 8
        Me.manageBooksButton.Text = "Manage Books"
        Me.manageBooksButton.UseVisualStyleBackColor = True
        '
        'viewReportsButton
        '
        Me.viewReportsButton.Location = New System.Drawing.Point(42, 171)
        Me.viewReportsButton.Name = "viewReportsButton"
        Me.viewReportsButton.Size = New System.Drawing.Size(243, 35)
        Me.viewReportsButton.TabIndex = 9
        Me.viewReportsButton.Text = "View Reports"
        Me.viewReportsButton.UseVisualStyleBackColor = True
        '
        'lateReturnButton
        '
        Me.lateReturnButton.Location = New System.Drawing.Point(42, 212)
        Me.lateReturnButton.Name = "lateReturnButton"
        Me.lateReturnButton.Size = New System.Drawing.Size(243, 34)
        Me.lateReturnButton.TabIndex = 11
        Me.lateReturnButton.Text = "Late Returns"
        Me.lateReturnButton.UseVisualStyleBackColor = True
        '
        'issueBooksButton
        '
        Me.issueBooksButton.Location = New System.Drawing.Point(42, 252)
        Me.issueBooksButton.Name = "issueBooksButton"
        Me.issueBooksButton.Size = New System.Drawing.Size(243, 34)
        Me.issueBooksButton.TabIndex = 12
        Me.issueBooksButton.Text = "Issue Books"
        Me.issueBooksButton.UseVisualStyleBackColor = True
        '
        'ETLButton
        '
        Me.ETLButton.Location = New System.Drawing.Point(42, 292)
        Me.ETLButton.Name = "ETLButton"
        Me.ETLButton.Size = New System.Drawing.Size(243, 34)
        Me.ETLButton.TabIndex = 13
        Me.ETLButton.Text = "ETL"
        Me.ETLButton.UseVisualStyleBackColor = True
        '
        'DashboardButton
        '
        Me.DashboardButton.Location = New System.Drawing.Point(42, 338)
        Me.DashboardButton.Name = "DashboardButton"
        Me.DashboardButton.Size = New System.Drawing.Size(243, 34)
        Me.DashboardButton.TabIndex = 14
        Me.DashboardButton.Text = "Dashboard"
        Me.DashboardButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(61, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 39)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Admin Portal"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(349, 384)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DashboardButton)
        Me.Controls.Add(Me.ETLButton)
        Me.Controls.Add(Me.issueBooksButton)
        Me.Controls.Add(Me.lateReturnButton)
        Me.Controls.Add(Me.viewReportsButton)
        Me.Controls.Add(Me.manageBooksButton)
        Me.Controls.Add(Me.manageUsersButton)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents manageUsersButton As System.Windows.Forms.Button
    Friend WithEvents manageBooksButton As System.Windows.Forms.Button
    Friend WithEvents viewReportsButton As System.Windows.Forms.Button
    Friend WithEvents lateReturnButton As System.Windows.Forms.Button
    Friend WithEvents issueBooksButton As System.Windows.Forms.Button
    Friend WithEvents ETLButton As System.Windows.Forms.Button
    Friend WithEvents DashboardButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
