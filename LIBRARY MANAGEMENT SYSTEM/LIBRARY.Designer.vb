<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LIBRARY
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MemberDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberDetailsToolStripMenuItem, Me.BookDetailsToolStripMenuItem, Me.OperationsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(485, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MemberDetailsToolStripMenuItem
        '
        Me.MemberDetailsToolStripMenuItem.Name = "MemberDetailsToolStripMenuItem"
        Me.MemberDetailsToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.MemberDetailsToolStripMenuItem.Text = "Member Details"
        '
        'BookDetailsToolStripMenuItem
        '
        Me.BookDetailsToolStripMenuItem.Name = "BookDetailsToolStripMenuItem"
        Me.BookDetailsToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.BookDetailsToolStripMenuItem.Text = "Book Details"
        '
        'OperationsToolStripMenuItem
        '
        Me.OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem"
        Me.OperationsToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.OperationsToolStripMenuItem.Text = "Operations"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LIBRARY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(485, 306)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LIBRARY"
        Me.Text = "LIBRARY"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MemberDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
