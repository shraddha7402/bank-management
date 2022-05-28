Imports MySql.Data.MySqlClient
Public Class deleteaccount
    Dim conn As MySqlConnection
    Dim adpt As MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim builder As MySqlCommandBuilder

    Private Sub deleteaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;database=bank;uid=root;password=;SslMode=none")
        conn.Open()
        adpt = New MySqlDataAdapter("select * from baccounts", conn)
        adpt.Fill(ds, "baccounts")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "baccounts"

    End Sub

    Private Sub cls_Click(sender As Object, e As EventArgs) 
        Me.Close()
        home.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        builder = New MySqlCommandBuilder(adpt)
        builder.GetDeleteCommand()
        Dim i As Integer = 0
        Dim r As String
        For Each dr In ds.Tables("baccounts").Rows
            r = dr.Item(0)
            If r = TextBox1.Text Then
                ds.Tables("baccounts").Rows(i).Delete()

            End If
            i = i + 1

        Next
        MsgBox("record deleted ")
        adpt.Update(ds, "baccounts")

    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        home.Show()

    End Sub

    Private Sub AddAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAccountToolStripMenuItem.Click
        addaccount.Show()

    End Sub

    Private Sub UpdateAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAccountToolStripMenuItem.Click
        updateaccount.Show()
    End Sub

    Private Sub DeleteAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAccountToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub DepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositToolStripMenuItem.Click
        Deposit.Show()

    End Sub

    Private Sub WithdrawToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithdrawToolStripMenuItem.Click
        Withdraw.Show()

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

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        Help.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class