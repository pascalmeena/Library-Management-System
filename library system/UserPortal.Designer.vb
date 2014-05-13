<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserPortal
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
        Me.borrowBook = New System.Windows.Forms.Button()
        Me.finesButton = New System.Windows.Forms.Button()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'borrowBook
        '
        Me.borrowBook.Location = New System.Drawing.Point(88, 91)
        Me.borrowBook.Name = "borrowBook"
        Me.borrowBook.Size = New System.Drawing.Size(137, 47)
        Me.borrowBook.TabIndex = 0
        Me.borrowBook.Text = "Borrow Book"
        Me.borrowBook.UseVisualStyleBackColor = True
        '
        'finesButton
        '
        Me.finesButton.Location = New System.Drawing.Point(88, 156)
        Me.finesButton.Name = "finesButton"
        Me.finesButton.Size = New System.Drawing.Size(137, 45)
        Me.finesButton.TabIndex = 1
        Me.finesButton.Text = "My Fines"
        Me.finesButton.UseVisualStyleBackColor = True
        '
        'logoutButton
        '
        Me.logoutButton.Location = New System.Drawing.Point(88, 228)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(137, 43)
        Me.logoutButton.TabIndex = 3
        Me.logoutButton.Text = "Logout"
        Me.logoutButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(81, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "My Portal"
        '
        'UserPortal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(305, 291)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.finesButton)
        Me.Controls.Add(Me.borrowBook)
        Me.Name = "UserPortal"
        Me.Text = "UserPortal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents borrowBook As System.Windows.Forms.Button
    Friend WithEvents finesButton As System.Windows.Forms.Button
    Friend WithEvents logoutButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
