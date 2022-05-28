Imports MySql.Data.MySqlClient

Public Class updateemail
    Dim conn As MySqlConnection
    Dim adpt As MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim builder As MySqlCommandBuilder

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To ds.Tables("baccounts").Rows.Count - 1
            If ds.Tables("baccounts").Rows(i).Item(4) = TextBox1.Text Then
                dr = ds.Tables("baccounts").Rows(i)
                builder = New MySqlCommandBuilder(adpt)
                builder.GetUpdateCommand()

            End If

        Next
        If Not dr Is Nothing Then
            dr(4) = TextBox2.Text
            MsgBox("Email Updated Successfully ")


        End If
        adpt.Update(ds, "baccounts")

    End Sub

    Private Sub updateemail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;database=bank;uid=root;password=;SslMode=none")
        conn.Open()
        adpt = New MySqlDataAdapter("select * from baccounts", conn)
        adpt.Fill(ds, "baccounts")

    End Sub
End Class