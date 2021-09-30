Imports System.Data.OleDb
Public Class Member_details
    Dim cnn As New OleDb.OleDbConnection

    Private Sub Member_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIBRARY_MANAGEMENTDataSet.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter.Fill(Me.LIBRARY_MANAGEMENTDataSet.MEMBER)
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
        cmd.CommandText = "INSERT INTO MEMBER(MEMBERID,MEMBERNAME) " & _
            " VALUES('" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "')"
        cmd.ExecuteNonQuery()

        cnn.Close()
        Me.RefreshData()
        MsgBox("Record inserted!")


    End Sub
    Private Sub RefreshData()
        If Not cnn.State = ConnectionState.Open Then
            'open connection if it is not yet open
            cnn.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("Select * from MEMBER order by MEMBERID", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.dgvData.DataSource = dt
        cnn.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""|DataDirectory|\LIBRARY MANAGEMENT.accdb"""
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        MsgBox("Data will be Permently Deleted")
        Dim str As String = TextBox1.Text
        Dim res As Integer

        res = MsgBox("click ok to delete MEMBER data   " & TextBox1.Text, 1, "notice")
        If res = 1 Then
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cnn
            cmd.CommandText = "DELETE * FROM MEMBER WHERE MEMBERID='" & str & " ' "
            cmd.ExecuteNonQuery()
            cnn.Close()
            Me.RefreshData()

        End If
        
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class