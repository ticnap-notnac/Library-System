<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnForm
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
        btnEnter = New Button()
        txtboxStudnum = New TextBox()
        Label2 = New Label()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' ddBookname
        ' 
        ddBookname.FormattingEnabled = True
        ddBookname.Location = New Point(122, 29)
        ddBookname.Name = "ddBookname"
        ddBookname.Size = New Size(121, 23)
        ddBookname.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 1
        Label1.Text = "Student #: "
        ' 
        ' btnEnter
        ' 
        btnEnter.Location = New Point(46, 140)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(75, 23)
        btnEnter.TabIndex = 2
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = True
        ' 
        ' txtboxStudnum
        ' 
        txtboxStudnum.Location = New Point(122, 80)
        txtboxStudnum.Name = "txtboxStudnum"
        txtboxStudnum.Size = New Size(121, 23)
        txtboxStudnum.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 1
        Label2.Text = "Book name:"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(198, 140)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 2
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' ReturnForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(312, 207)
        Controls.Add(txtboxStudnum)
        Controls.Add(btnCancel)
        Controls.Add(btnEnter)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ddBookname)
        Name = "ReturnForm"
        Text = "Return Book"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ddBookname As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtboxStudnum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
End Class
