Imports System.Data.OleDb
Imports stock_management.insertfunction
Public Class Form1
    Dim row As Integer
    Dim gettable As New insertfunction
    Dim addcustomer As New insertfunction
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gettable.getdata(DataGridView1)
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        addcustomer.insertcustomer(MetroTextBox1.Text, MetroTextBox2.Text, MetroTextBox3.Text, MetroTextBox4.Text)
        gettable.getdata(DataGridView1)
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        row = DataGridView1.CurrentCell.RowIndex
        register1.MetroTextBox1.Text = getdatatable.Rows(row).Item("kod")
        register1.MetroTextBox2.Text = getdatatable.Rows(row).Item("nama")
        register1.MetroTextBox3.Text = getdatatable.Rows(row).Item("alamat")
        register1.MetroTextBox4.Text = getdatatable.Rows(row).Item("telefon")
        register1.Show()
    End Sub
End Class
