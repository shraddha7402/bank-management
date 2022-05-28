Imports MySql.Data.MySqlClient
Public Class Deposit
    Dim conn As MySqlConnection
    Dim adpt As MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim builder As MySqlCommandBuilder

    Private Sub Cls_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Hide()
    End Sub

    'Private Sub Deposit_Load(sender As Object, e As EventArgs)
    '    conn = New MySqlConnection("server=localhost;database=bank;uid=root;password=;SslMode=none")
    '    conn.Open()
    '    adpt = New MySqlDataAdapter("select * from baccounts", conn)
    '    adpt.Fill(ds, "baccounts")
    '    DataGridView1.DataSource = ds
    '    DataGridView1.DataMember = "baccounts"

    '    dat.Text = Date.Now.ToString("MM/dd/yyyy")
    '    Timer1.Start()


    'End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Dat_Click(sender As Object, e As EventArgs) Handles dat.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        clock.Text = TimeOfDay

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        home.Show()

    End Sub

    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountsToolStripMenuItem.Click

    End Sub

    Private Sub AddAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAccountToolStripMenuItem.Click
        addaccount.Show()

    End Sub

    Private Sub UpdateAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAccountToolStripMenuItem.Click
        updateaccount.Show()


    End Sub

    Private Sub DeleteAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAccountToolStripMenuItem.Click
        deleteaccount.Show()
    End Sub

    Private Sub DepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositToolStripMenuItem.Click
        Me.Show()

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

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To ds.Tables("baccounts").Rows.Count - 1
            If ds.Tables("baccounts").Rows(i).Item(0) = TextBox1.Text Then
                dr = ds.Tables("baccounts").Rows(i)
                builder = New MySqlCommandBuilder(adpt)
                builder.GetUpdateCommand()

            End If

        Next
        If Not dr Is Nothing Then
            dr.Item(6) = dr.Item(6) + TextBox2.Text
            MsgBox("Deposit successfullly")


        End If
        adpt.Update(ds, "baccounts")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub clock_Click(sender As Object, e As EventArgs) Handles clock.Click

    End Sub

    Private Sub Deposit_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;database=bank;uid=root;password=;SslMode=none")
        conn.Open()
        adpt = New MySqlDataAdapter("select * from baccounts", conn)
        adpt.Fill(ds, "baccounts")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "baccounts"

        dat.Text = Date.Now.ToString("MM/dd/yyyy")
        Timer1.Start()

    End Sub

End Class