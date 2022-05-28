Imports MySql.Data.MySqlClient

Public Class Withdraw
    Dim conn As MySqlConnection
    Dim adpt As MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim builder As MySqlCommandBuilder
    Dim cmd As MySqlCommand
    Private Sub AddAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAccountToolStripMenuItem.Click

    End Sub

    Private Sub cls_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Hide()

    End Sub


    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;database=bank;uid=root;password=;SslMode=none")
        conn.Open()
        adpt = New MySqlDataAdapter("select * from baccounts", conn)
        adpt.Fill(ds, "baccounts")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "baccounts"

        dat.Text = Date.Now.ToString("MM/dd/yyyy")
        Timer1.Start()

    End Sub

    Private Sub dat_Click(sender As Object, e As EventArgs) Handles dat.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        clock.Text = TimeOfDay

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        builder = New MySqlCommandBuilder(adpt)
        builder.GetUpdateCommand()

        For i = 0 To ds.Tables("baccounts").Rows.Count - 1
            If ds.Tables("baccounts").Rows(i).Item(0) = TextBox1.Text Then
                dr = ds.Tables("baccounts").Rows(i)
            End If


        Next
        If Not dr Is Nothing Then
            dr.Item(6) = dr.Item(6) - TextBox2.Text
            MsgBox("Withdraw sucessfully ")
        End If
        adpt.Update(ds, "baccounts")

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub clock_Click(sender As Object, e As EventArgs) Handles clock.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class