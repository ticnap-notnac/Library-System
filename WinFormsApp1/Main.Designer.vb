<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LMS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnadd = New Button()
        btnborrow = New Button()
        btnreturn = New Button()
        DataGridView1 = New DataGridView()
        Bktitle = New DataGridViewTextBoxColumn()
        BkAuthor = New DataGridViewTextBoxColumn()
        Bkavailable = New DataGridViewTextBoxColumn()
        BKborrowed = New DataGridViewTextBoxColumn()
        bkgenre = New DataGridViewTextBoxColumn()
        btnRemove = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnadd
        ' 
        btnadd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnadd.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnadd.Location = New Point(570, 9)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(119, 25)
        btnadd.TabIndex = 0
        btnadd.Text = "Add Book"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btnborrow
        ' 
        btnborrow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnborrow.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnborrow.Location = New Point(570, 40)
        btnborrow.Name = "btnborrow"
        btnborrow.Size = New Size(119, 25)
        btnborrow.TabIndex = 1
        btnborrow.Text = "Borrow Book"
        btnborrow.UseVisualStyleBackColor = True
        ' 
        ' btnreturn
        ' 
        btnreturn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnreturn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnreturn.Location = New Point(570, 71)
        btnreturn.Name = "btnreturn"
        btnreturn.Size = New Size(119, 25)
        btnreturn.TabIndex = 2
        btnreturn.Text = "Return Book"
        btnreturn.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Bktitle, BkAuthor, Bkavailable, BKborrowed, bkgenre})
        DataGridView1.Dock = DockStyle.Left
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(564, 412)
        DataGridView1.TabIndex = 3
        ' 
        ' Bktitle
        ' 
        Bktitle.HeaderText = "title"
        Bktitle.Name = "Bktitle"
        ' 
        ' BkAuthor
        ' 
        BkAuthor.HeaderText = "Author"
        BkAuthor.Name = "BkAuthor"
        ' 
        ' Bkavailable
        ' 
        Bkavailable.HeaderText = "Available/Borrow"
        Bkavailable.Name = "Bkavailable"
        ' 
        ' BKborrowed
        ' 
        BKborrowed.HeaderText = "# of times borrowed"
        BKborrowed.Name = "BKborrowed"
        ' 
        ' bkgenre
        ' 
        bkgenre.HeaderText = "Genre"
        bkgenre.Name = "bkgenre"
        ' 
        ' btnRemove
        ' 
        btnRemove.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRemove.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnRemove.Location = New Point(570, 102)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(119, 25)
        btnRemove.TabIndex = 3
        btnRemove.Text = "Remove Book"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' LMS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(701, 412)
        Controls.Add(DataGridView1)
        Controls.Add(btnRemove)
        Controls.Add(btnreturn)
        Controls.Add(btnborrow)
        Controls.Add(btnadd)
        Name = "LMS"
        Text = "LMS"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnadd As Button
    Friend WithEvents btnborrow As Button
    Friend WithEvents btnreturn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Bktitle As DataGridViewTextBoxColumn
    Friend WithEvents BkAuthor As DataGridViewTextBoxColumn
    Friend WithEvents Bkavailable As DataGridViewTextBoxColumn
    Friend WithEvents BKborrowed As DataGridViewTextBoxColumn
    Friend WithEvents bkgenre As DataGridViewTextBoxColumn
    Friend WithEvents btnRemove As Button

End Class
