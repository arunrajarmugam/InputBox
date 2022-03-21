Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblEnter_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub cmdClick_Click(sender As Object, e As EventArgs) Handles cmdClick.Click
        Dim strName As String = txtName.Text
        Dim strOutput As String = "Hello " + strName

        lblOutput.text = strOutput
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub
End Class
