<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveForm
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
        ddBookname = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        ddAuthor = New ComboBox()
        Button2 = New Button()
        btnEnter = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' ddBookname
        ' 
        ddBookname.FormattingEnabled = True
        ddBookname.Location = New Point(107, 34)
        ddBookname.Name = "ddBookname"
        ddBookname.Size = New Size(121, 23)
        ddBookname.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 1
        Label1.Text = "Book name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 1
        Label2.Text = "Author:"
        ' 
        ' ddAuthor
        ' 
        ddAuthor.FormattingEnabled = True
        ddAuthor.Location = New Point(107, 105)
        ddAuthor.Name = "ddAuthor"
        ddAuthor.Size = New Size(121, 23)
        ddAuthor.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(281, 163)
        Button2.Name = "Button2"
        Button2.Size = New Size(8, 8)
        Button2.TabIndex = 4
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnEnter
        ' 
        btnEnter.Location = New Point(59, 174)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(75, 23)
        btnEnter.TabIndex = 5
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(179, 174)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' RemoveForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(296, 232)
        Controls.Add(btnCancel)
        Controls.Add(btnEnter)
        Controls.Add(Button2)
        Controls.Add(ddAuthor)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ddBookname)
        Name = "RemoveForm"
        Text = "Remove Book"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ddBookname As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ddAuthor As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnCancel As Button
End Class
