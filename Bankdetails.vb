Public Class bankdetails

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cls_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        home.TextBox1.Text = TextBox1.Text
        home.TextBox2.Text = TextBox2.Text
        home.TextBox3.Text = TextBox3.Text
        MsgBox("Bank Details Updated")




    End Sub
    Private Sub bankd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class