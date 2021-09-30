Public Class Operations
    Dim BookLoan As Short
    Private Sub OperationsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OperationsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OperationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIBRARY_MANAGEMENTDataSet)

    End Sub

    Private Sub Operations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIBRARY_MANAGEMENTDataSet.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter.Fill(Me.LIBRARY_MANAGEMENTDataSet.MEMBER)
        'TODO: This line of code loads data into the 'LIBRARY_MANAGEMENTDataSet.BOOK' table. You can move, or remove it, as needed.
        Me.BOOKTableAdapter.Fill(Me.LIBRARY_MANAGEMENTDataSet.BOOK)
        'TODO: This line of code loads data into the 'LIBRARY_MANAGEMENTDataSet.Operations' table. You can move, or remove it, as needed.
        Me.OperationsTableAdapter.Fill(Me.LIBRARY_MANAGEMENTDataSet.Operations)

    End Sub

    Private Sub btBorrowed_Click(sender As Object, e As EventArgs) Handles btBorrowed.Click
        Dim BookDueDate As Date
        Select Case NumericUpDown1.Value
            Case 0
                BookLoan = 0

            Case 1
                BookLoan = 7
            Case 2
                BookLoan = 14
            Case 3
                BookLoan = 21
            Case 4
                BookLoan = 28
        End Select
        BookDueDate = ISSUE_DATEDateTimePicker.Value.AddDays(BookLoan)
        txtDateDue.Text = Format(BookDueDate, "dddd dd MMM yyyy")
    End Sub

    Private Sub btnReturned_Click(sender As Object, e As EventArgs)
        Dim DateDueBack As Date
        Dim DaysOverdue As Short
        Dim FineRate As Decimal
        Dim Fine As Decimal
        DateDueBack = txtDateDue.Text
        DaysOverdue = DateDiff("d", DateDueBack, txtDateReturned.Text)
        Select Case NumericUpDown1.Value
            Case 0
                BookLoan = 1
                FineRate = 0.5
            Case 1
                BookLoan = 3
                FineRate = 0.25
            Case 2
                BookLoan = 10
                FineRate = 0.1
            Case 3
                BookLoan = 30
                FineRate = 0.05
            Case 4
                BookLoan = 40
                FineRate = 0.95
            Case 5
                BookLoan = 10
                FineRate = 0.7
            Case 6
                BookLoan = 50
                FineRate = 0.37
            Case 7
                BookLoan = 60
                FineRate = 0.15
        End Select
        If DaysOverdue <= 0 Then
            DaysOverdue = 0

        End If
        If DaysOverdue > 0 Then
            Fine = FineRate * DaysOverdue
        Else
            Fine = 0
        End If
        txtDaysOverDue.Text = DaysOverdue & " days overdue"
        txtFine.Text = "Fine of" & Format(Fine, "Currency") & "to pay"
    End Sub

    Private Sub btnReturned_Click_1(sender As Object, e As EventArgs) Handles btnReturned.Click
        Dim DateDueBack As Date
        Dim DaysOverdue As Short
        Dim FineRate As Decimal
        Dim Fine As Decimal
        DateDueBack = txtDateDue.Text
        DaysOverdue = DateDiff("d", DateDueBack, txtDateReturned.Text)
        Select Case NumericUpDown1.Value
            Case 0
                BookLoan = 1
                FineRate = 0.5
            Case 1
                BookLoan = 3
                FineRate = 0.25
            Case 2
                BookLoan = 10
                FineRate = 0.1
            Case 3
                BookLoan = 30
                FineRate = 0.05
            Case 4
                BookLoan = 40
                FineRate = 0.95
            Case 5
                BookLoan = 10
                FineRate = 0.7
            Case 6
                BookLoan = 50
                FineRate = 0.37
            Case 7
                BookLoan = 60
                FineRate = 0.15
        End Select
        If DaysOverdue <= 0 Then
            DaysOverdue = 0

        End If
        If DaysOverdue > 0 Then
            Fine = FineRate * DaysOverdue
        Else
            Fine = 0
        End If
        txtDaysOverDue.Text = DaysOverdue & " days overdue"
        txtFine.Text = "Fine of" & Format(Fine, "Currency") & "to pay"

    End Sub
End Class