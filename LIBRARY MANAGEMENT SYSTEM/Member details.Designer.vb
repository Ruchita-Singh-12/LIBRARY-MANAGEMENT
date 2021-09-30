<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Member_details
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.MEMBERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEMBERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()

        Me.MEMBERBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIBRARY_MANAGEMENTDataSet = New LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet2()
        Me.MEMBERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEMBERTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet2TableAdapters.MEMBERTableAdapter()
        Me.MEMBERBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBRARY_MANAGEMENTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(314, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MEMBER DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MEMBER ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MEMBER NAME"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(413, 126)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 22)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(413, 201)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(220, 22)
        Me.TextBox2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(231, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(567, 269)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "CLEAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(722, 269)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AutoGenerateColumns = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MEMBERIDDataGridViewTextBoxColumn, Me.MEMBERNAMEDataGridViewTextBoxColumn})
        Me.dgvData.DataSource = Me.MEMBERBindingSource2
        Me.dgvData.Location = New System.Drawing.Point(22, 309)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(448, 150)
        Me.dgvData.TabIndex = 10
        '
        'MEMBERIDDataGridViewTextBoxColumn
        '
        Me.MEMBERIDDataGridViewTextBoxColumn.DataPropertyName = "MEMBERID"
        Me.MEMBERIDDataGridViewTextBoxColumn.HeaderText = "MEMBERID"
        Me.MEMBERIDDataGridViewTextBoxColumn.Name = "MEMBERIDDataGridViewTextBoxColumn"
        '
        'MEMBERNAMEDataGridViewTextBoxColumn
        '
        Me.MEMBERNAMEDataGridViewTextBoxColumn.DataPropertyName = "MEMBERNAME"
        Me.MEMBERNAMEDataGridViewTextBoxColumn.HeaderText = "MEMBERNAME"
        Me.MEMBERNAMEDataGridViewTextBoxColumn.Name = "MEMBERNAMEDataGridViewTextBoxColumn"
        '
        'MEMBERBindingSource2
        '
        Me.MEMBERBindingSource2.DataMember = "MEMBER"
        Me.MEMBERBindingSource2.DataSource = Me.LIBRARY_MANAGEMENTDataSet
        '
        'LIBRARY_MANAGEMENTDataSet
        '
        Me.LIBRARY_MANAGEMENTDataSet.DataSetName = "Database4DataSet1"
        Me.LIBRARY_MANAGEMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEMBERBindingSource
        '
        Me.MEMBERBindingSource.DataMember = "MEMBER"
        Me.MEMBERBindingSource.DataSource = Me.LIBRARY_MANAGEMENTDataSet
        '
        'MEMBERTableAdapter
        '
        Me.MEMBERTableAdapter.ClearBeforeFill = True
        '
        'MEMBERBindingSource1
        '
        Me.MEMBERBindingSource1.DataMember = "MEMBER"
        Me.MEMBERBindingSource1.DataSource = Me.LIBRARY_MANAGEMENTDataSet
        '
        'Member_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 501)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Member_details"
        Me.Text = "Member_details"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBRARY_MANAGEMENTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents LIBRARY_MANAGEMENTDataSet As LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet2
    Friend WithEvents MEMBERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEMBERTableAdapter As LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet2TableAdapters.MEMBERTableAdapter
    Friend WithEvents MEMBERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEMBERNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEMBERBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MEMBERBindingSource2 As System.Windows.Forms.BindingSource
End Class
