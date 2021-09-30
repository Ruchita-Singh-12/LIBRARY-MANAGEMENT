Imports System.Data.OleDb
Public Class Book_Details
    Dim cnn As New OleDb.OleDbConnection
    Private Sub Book_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_LIBRARY_MANAGEMENTDataSet.BOOK' table. You can move, or remove it, as needed.
        Me.BOOKTableAdapter1.Fill(Me.LIBRARY_MANAGEMENTDataSet.BOOK)
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""|DataDirectory|\LIBRARY MANAGEMENT.accdb"""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New OleDb.OleDbCommand
        If Not cnn.State = ConnectionState.Open Then
            'open connection if it is not yet open
            cnn.Open()
        End If
        cmd.Connection = cnn
        cmd.CommandText = "INSERT INTO BOOK(BOOKID,BOOKNAME,AUTHOR,MEMBERID) " & _
            " VALUES('" & Me.txtBookId.Text & "','" & Me.txtBookName.Text & "','" & Me.txtAuthor.Text & "','" & Me.txtMemberId.Text & "')"
        cmd.ExecuteNonQuery()
       
        cnn.Close()
        MsgBox("Record inserted!")
        Me.RefreshData()

    End Sub
    Private Sub RefreshData()
        If Not cnn.State = ConnectionState.Open Then
            'open connection if it is not yet open
            cnn.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("Select * from BOOK order by BOOKID", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.dgvData.DataSource = dt
        cnn.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtBookId.Text = ""
        txtBookName.Text = ""
        txtAuthor.Text = ""
        txtMemberId.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""|DataDirectory|\LIBRARY MANAGEMENT.accdb"""
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        MsgBox("Data will be Permently Deleted")
        Dim str As String = txtBookId.Text
        Dim Res As Integer

        Res = MsgBox("click ok to delete BOOK data   " & txtBookId.Text, 1, "notice")
        If Res = 1 Then
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cnn
            cmd.CommandText = "DELETE * FROM BOOK WHERE BOOKID='" & str & " ' "
            cmd.ExecuteNonQuery()
            cnn.Close()
            Me.RefreshData()
        End If
       

    End Sub

End Class