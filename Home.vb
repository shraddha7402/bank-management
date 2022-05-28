Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient

Public Class home


    Public totacc As Integer
    Public totemp As Integer
    Public bankbal As Integer
    Dim conn As MySqlConnection
    Dim adpt As MySqlDataAdapter
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim builder As MySqlCommandBuilder


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cls.Click
        En.Show()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub AccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountsToolStripMenuItem.Click


    End Sub

    Private Sub AddAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAccountToolStripMenuItem.Click
        addaccount.Show()
    End Sub

    Private Sub UpdateAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateAccountToolStripMenuItem.Click
        updateaccount.Show()
    End Sub

    Private Sub DeleteAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAccountToolStripMenuItem.Click


        deleteaccount.Show()
    End Sub

    Private Sub DepositToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepositToolStripMenuItem.Click
        Deposit.Show()

    End Sub

    Private Sub RegisterProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterProductToolStripMenuItem.Click
        Register.Show()

    End Sub

    Private Sub WithdrawToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithdrawToolStripMenuItem.Click
        Withdraw.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click


    End Sub

    Private Sub CreditsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditsToolStripMenuItem.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer1.Start()
        dat.Text = Date.Now.ToString("MM/dd/yyyy")



    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        addaccount.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Deposit.Show()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Withdraw.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

        bankdetails.Show()

    End Sub
    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        Help.Show()

    End Sub
    Private Sub dat_Click(sender As Object, e As EventArgs) Handles dat.Click

    End Sub


    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        employees.Show()

    End Sub

    Private Sub home_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;database=bank;uid=root;password=;SslMode=none")
        conn.Open()
        adpt = New MySqlDataAdapter("select * from bemployees", conn)
        adpt.Fill(ds, "bemployees")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "bemployees"
        dat.Text = Date.Now.ToString("MM/dd/yyyy")
        Timer1.Start()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        bankdetails.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        En.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        clock.Text = TimeOfDay

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class