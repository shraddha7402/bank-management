Imports MySql.Data.MySqlClient
Public Class Updateaddress
    Dim conn As MySqlConnection
    Dim adpt As MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim builder As MySqlCommandBuilder

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        builder = New MySqlCommandBuilder(adpt)
        builder.GetUpdateCommand()
        For i = 0 To ds.Tables("baccounts").Rows.Count - 1
            If ds.Tables("baccounts").Rows(i).Item(0) = TextBox1.Text Then
                dr = ds.Tables("baccounts").Rows(i)
            End If

        Next


        If Not dr Is Nothing Then


            dr(3) = TextBox2.Text
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
    Private Sub Updateaddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;database=bank;uid=root;password=;SslMode=none")
        conn.Open()
        adpt = New MySqlDataAdapter("select * from baccounts", conn)
        adpt.Fill(ds, "baccounts")

    End Sub
End Class