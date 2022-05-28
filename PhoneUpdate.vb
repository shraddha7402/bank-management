Imports MySql.Data.MySqlClient

Public Class Update_Phone_Number
    Dim conn As MySqlConnection
    Dim adpt As MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim builder As MySqlCommandBuilder

    Private Sub Update_Phone_Number_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;database=bank;uid=root;password=;SslMode=none")
        conn.Open()
        adpt = New MySqlDataAdapter("select * from baccounts", conn)
        adpt.Fill(ds, "baccounts")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("I am MsgBox")
        builder = New MySqlCommandBuilder(adpt)
        builder.GetUpdateCommand()
        For i = 0 To ds.Tables("baccounts").Rows.Count - 1
            If ds.Tables("baccounts").Rows(i).Item(0) = TextBox1.Text Then
                dr = ds.Tables("baccounts").Rows(i)
            End If

        Next


        If Not dr Is Nothing Then


            dr(2) = TextBox2.Text
            MsgBox("record updated ")

            adpt.Update(ds, "baccounts")
            updateaccount.Dispose()


            Me.Dispose()
        End If
        updateaccount.DataGridView1.DataSource = ds
        updateaccount.DataGridView1.DataMember = "baccounts"
        updateaccount.Show()
        Me.Hide()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class