Imports MySql.Data.MySqlClient

Public Class addaccount
    Dim conn As MySqlConnection
    Dim adpt As MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim builder As MySqlCommandBuilder

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        builder = New MySqlCommandBuilder(adpt)
        builder.GetInsertCommand()
        dr = ds.Tables("baccounts").NewRow()
        dr(0) = TextBox1.Text
        dr(1) = TextBox2.Text
        dr(2) = TextBox3.Text
        dr(3) = TextBox4.Text
        dr(4) = TextBox5.Text
        dr(5) = TextBox6.Text
        ds.Tables("baccounts").Rows.Add(dr)
        adpt.Update(ds, "baccounts")


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value

    End Sub

    Private Sub Cls_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Close()

    End Sub

    Private Sub DepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositToolStripMenuItem.Click
        Deposit.Show()


    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        home.Show()

    End Sub

    Private Sub AddAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAccountToolStripMenuItem.Click
        Me.Show()


    End Sub

    Private Sub UpdateAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAccountToolStripMenuItem.Click
        updateaccount.Show()

    End Sub

    Private Sub DeleteAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAccountToolStripMenuItem.Click
        deleteaccount.Show()

    End Sub

    Private Sub WithdrawToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithdrawToolStripMenuItem.Click
        Withdraw.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub

    Private Sub RegisterProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterProductToolStripMenuItem.Click
        Register.Show()

    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        about.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()

    End Sub

    Private Sub addaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;database=bank;uid=root;password=;SslMode=none")
        conn.Open()
        adpt = New MySqlDataAdapter("select * from baccounts", conn)
        adpt.Fill(ds, "baccounts")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "baccounts"

    End Sub
End Class