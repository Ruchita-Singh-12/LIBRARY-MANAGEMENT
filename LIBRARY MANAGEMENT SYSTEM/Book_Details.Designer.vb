<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book_Details
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBookId = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtMemberId = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.BOOKIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUTHORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEMBERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIBRARY_MANAGEMENTDataSet = New LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet2()
        Me.BOOKBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet2TableAdapters.LOGINTableAdapter()
        Me.BOOKTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet2TableAdapters.BOOKTableAdapter()
        Me.BOOKTableAdapter1 = New LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet2TableAdapters.BOOKTableAdapter()
        Me.BOOKBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOOKBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBRARY_MANAGEMENTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(367, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BOOK DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BOOK ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "BOOK NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "AUTHOR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "MEMBER ID"
        '
        'txtBookId
        '
        Me.txtBookId.Location = New System.Drawing.Point(489, 151)
        Me.txtBookId.Name = "txtBookId"
        Me.txtBookId.Size = New System.Drawing.Size(256, 22)
        Me.txtBookId.TabIndex = 5
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(489, 196)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(256, 22)
        Me.txtBookName.TabIndex = 6
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(489, 247)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(256, 22)
        Me.txtAuthor.TabIndex = 7
        '
        'txtMemberId
        '
        Me.txtMemberId.Location = New System.Drawing.Point(489, 303)
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(256, 22)
        Me.txtMemberId.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(4, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(209, 385)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(701, 385)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "CLEAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(876, 385)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AutoGenerateColumns = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BOOKIDDataGridViewTextBoxColumn, Me.BOOKNAMEDataGridViewTextBoxColumn, Me.AUTHORDataGridViewTextBoxColumn, Me.MEMBERIDDataGridViewTextBoxColumn})
        Me.dgvData.DataSource = Me.BOOKBindingSource3
        Me.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvData.Location = New System.Drawing.Point(4, 440)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(443, 150)
        Me.dgvData.TabIndex = 14
        '
        'BOOKIDDataGridViewTextBoxColumn
        '
        Me.BOOKIDDataGridViewTextBoxColumn.DataPropertyName = "BOOKID"
        Me.BOOKIDDataGridViewTextBoxColumn.HeaderText = "BOOKID"
        Me.BOOKIDDataGridViewTextBoxColumn.Name = "BOOKIDDataGridViewTextBoxColumn"
        '
        'BOOKNAMEDataGridViewTextBoxColumn
        '
        Me.BOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOKNAME"
        Me.BOOKNAMEDataGridViewTextBoxColumn.HeaderText = "BOOKNAME"
        Me.BOOKNAMEDataGridViewTextBoxColumn.Name = "BOOKNAMEDataGridViewTextBoxColumn"
        '
        'AUTHORDataGridViewTextBoxColumn
        '
        Me.AUTHORDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR"
        Me.AUTHORDataGridViewTextBoxColumn.HeaderText = "AUTHOR"
        Me.AUTHORDataGridViewTextBoxColumn.Name = "AUTHORDataGridViewTextBoxColumn"
        '
        'MEMBERIDDataGridViewTextBoxColumn
        '
        Me.MEMBERIDDataGridViewTextBoxColumn.DataPropertyName = "MEMBERID"
        Me.MEMBERIDDataGridViewTextBoxColumn.HeaderText = "MEMBERID"
        Me.MEMBERIDDataGridViewTextBoxColumn.Name = "MEMBERIDDataGridViewTextBoxColumn"
        '
        'BOOKBindingSource3
        '
        Me.BOOKBindingSource3.DataMember = "BOOK"
        Me.BOOKBindingSource3.DataSource = Me.LIBRARY_MANAGEMENTDataSet
        '
        'LIBRARY_MANAGEMENTDataSet
        '
        Me.LIBRARY_MANAGEMENTDataSet.DataSetName = "LIBRARY_MANAGEMENTDataSet"
        Me.LIBRARY_MANAGEMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BOOKBindingSource1
        '
        Me.BOOKBindingSource1.DataMember = "BOOK"
        Me.BOOKBindingSource1.DataSource = Me.LIBRARY_MANAGEMENTDataSet
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'BOOKTableAdapter
        '
        Me.BOOKTableAdapter.ClearBeforeFill = True
        '
        'BOOKTableAdapter1
        '
        Me.BOOKTableAdapter1.ClearBeforeFill = True
        '
        'BOOKBindingSource2
        '
        Me.BOOKBindingSource2.DataMember = "BOOK"
        Me.BOOKBindingSource2.DataSource = Me.LIBRARY_MANAGEMENTDataSet
        '
        'BOOKBindingSource4
        '
        Me.BOOKBindingSource4.DataMember = "BOOK"
        Me.BOOKBindingSource4.DataSource = Me.LIBRARY_MANAGEMENTDataSet
        '
        'Book_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 591)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMemberId)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.txtBookId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Book_Details"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBRARY_MANAGEMENTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBookId As System.Windows.Forms.TextBox
    Friend WithEvents txtBookName As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents LoginTableAdapter As LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet2TableAdapters.LOGINTableAdapter
    Friend WithEvents BOOKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKTableAdapter As LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet2TableAdapters.BOOKTableAdapter
    Friend WithEvents LIBRARY_MANAGEMENTDataSet As LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet2
    Friend WithEvents BOOKBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKTableAdapter1 As LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet2TableAdapters.BOOKTableAdapter
    Friend WithEvents BOOKBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOKNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AUTHORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEMBERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOKBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKBindingSource4 As System.Windows.Forms.BindingSource
End Class