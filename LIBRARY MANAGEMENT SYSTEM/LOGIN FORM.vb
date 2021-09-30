Imports System.Data.OleDb
Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uname As String = ""
        Dim pword As String = ""
        Dim username As String = ""
        Dim pass As String = ""
        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            MsgBox("Please fill all the info")
        Else
            uname = TextBox1.Text
            pword = TextBox2.Text
            Dim query As String = "select Password from LOGIN where Name='" & uname & "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""|DataDirectory|\LIBRARY MANAGEMENT.accdb"""
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(query, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Username does not exist")
            End Try


            If (pword = pass) Then
                MsgBox("Login success")
                LIBRARY.Show()
                If LIBRARY.Visible Then
                    Me.Hide()
                End If
            Else
                MsgBox("Login Failed")
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If



    End Sub
End Class