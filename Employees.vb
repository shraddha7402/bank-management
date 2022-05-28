Imports MySql.Data.MySqlClient
Public Class employees
    Dim conn As MySqlConnection
    Dim adpt As MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim builder As MySqlCommandBuilder
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub addemployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;database=bank;uid=root;password=;SslMode=none")
        conn.Open()
        adpt = New MySqlDataAdapter("select * from bemployees", conn)
        adpt.Fill(ds, "bemployees")


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        builder = New MySqlCommandBuilder(adpt)
        builder.GetInsertCommand()
        dr = ds.Tables("bemployees").NewRow()
        dr(0) = TextBox1.Text
        dr(1) = TextBox2.Text
        dr(2) = TextBox3.Text
        dr(3) = TextBox4.Text
        dr(4) = TextBox5.Text
        dr(5) = TextBox6.Text
        ds.Tables("bemployees").Rows.Add(dr)
        adpt.Update(ds, "bemployees")
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        builder = New MySqlCommandBuilder(adpt)
        builder.GetDeleteCommand()
        Dim i As Integer = 0
        Dim r As String
        For Each dr In ds.Tables("bemployees").Rows
            r = dr.Item(0)
            If r = TextBox1.Text Then
                ds.Tables("bemployees").Rows(i).Delete()

            End If
            i = i + 1

        Next
        MsgBox("record deleted ")
        adpt.Update(ds, "bemployees")
    End Sub
End Class