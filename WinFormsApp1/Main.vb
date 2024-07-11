Public Class LMS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        AddForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnborrow.Click
        BorrowForm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        ReturnForm.ShowDialog()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        RemoveForm.ShowDialog()
    End Sub
End Class
