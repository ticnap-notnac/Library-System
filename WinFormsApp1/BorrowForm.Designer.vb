<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowForm
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
        Label1 = New Label()
        Label2 = New Label()
        MonthCalendar1 = New MonthCalendar()
        ddBookname = New ComboBox()
        txtboxStdnum = New TextBox()
        Label3 = New Label()
        btnEnter = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 0
        Label1.Text = "Book name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 1
        Label2.Text = "Student #:"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(88, 117)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 2
        ' 
        ' ddBookname
        ' 
        ddBookname.FormattingEnabled = True
        ddBookname.Location = New Point(88, 22)
        ddBookname.Name = "ddBookname"
        ddBookname.Size = New Size(121, 23)
        ddBookname.TabIndex = 0
        ' 
        ' txtboxStdnum
        ' 
        txtboxStdnum.Location = New Point(88, 72)
        txtboxStdnum.Name = "txtboxStdnum"
        txtboxStdnum.Size = New Size(121, 23)
        txtboxStdnum.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 5
        Label3.Text = "Return Date:"
        ' 
        ' btnEnter
        ' 
        btnEnter.Location = New Point(100, 301)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(75, 23)
        btnEnter.TabIndex = 3
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(226, 301)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' BorrowForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(372, 346)
        Controls.Add(btnCancel)
        Controls.Add(btnEnter)
        Controls.Add(Label3)
        Controls.Add(txtboxStdnum)
        Controls.Add(ddBookname)
        Controls.Add(MonthCalendar1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "BorrowForm"
        Text = "Borrow Book"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents ddBookname As ComboBox
    Friend WithEvents txtboxStdnum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnCancel As Button
End Class
