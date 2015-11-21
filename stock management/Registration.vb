Imports System.Data.OleDb
Imports System.IO

Public Class insertfunction
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Napang\Documents\stokdb.accdb;")
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim imagepath As String
    Public Shared getdatatable As New DataTable
    Public Function insertcustomer(ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String)
        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "insert into customer(kod,nama,alamat,telefon) values('" & a & "','" & b & "','" & c & "','" & d & "')"
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Berjaya!")
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try

        Return 0
    End Function

    Public Function getdata(ByVal dtgrd As Object)
        conn.Open()
        cmd.Connection = conn
        cmd.CommandText = "select id,kod,nama,alamat,telefon from customer"
        conn.Close()
        da.SelectCommand = cmd
        da.Fill(getdatatable)
        dtgrd.DataSource = getdatatable
        dtgrd.Columns(0).visible = False
        dtgrd.Columns(1).HeaderCell.Value = "KOD ID"
        dtgrd.Columns(2).HeaderCell.Value = "NAME"
        dtgrd.Columns(3).HeaderCell.Value = "ADDRESS"
        dtgrd.Columns(4).HeaderCell.Value = "TELEPHONE"
        da.Dispose()
        Return 0
    End Function

    Public Function updatecustomer(ByVal a As String, ByVal b As String, ByVal c As String, ByVal d As String, ByVal f As String)
        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "update customer set kod='" & a & "', nama='" & b & "', alamat='" & c & "', telefon='" & d & "' where id='" & f & "'"

        Catch ex As Exception

        End Try
    End Function

    Public Function savegambar()
        Dim np As String = "C:\images\" + Path.GetExtension(imagepath)
        Return 0
    End Function
End Class
