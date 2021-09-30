Imports System.Data.OleDb
Public Class LIBRARY

    Private Sub MemberDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberDetailsToolStripMenuItem.Click
        Member_details.Show()
    End Sub

    Private Sub BookDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookDetailsToolStripMenuItem.Click
        Book_Details.Show()
    End Sub




    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub



    Private Sub OperationsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OperationsToolStripMenuItem.Click
        Operations.Show()
    End Sub
End Class