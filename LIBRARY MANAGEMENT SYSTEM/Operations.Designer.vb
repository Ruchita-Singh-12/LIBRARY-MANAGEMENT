<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Operations
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
        Dim BOOKIDLabel As System.Windows.Forms.Label
        Dim MEMBERIDLabel As System.Windows.Forms.Label
        Dim ISSUE_DATELabel As System.Windows.Forms.Label
        Dim DUE_DATELabel As System.Windows.Forms.Label
        Dim DATE_RETURNEDLabel As System.Windows.Forms.Label
        Dim FINELabel As System.Windows.Forms.Label
        Dim lblDaysOverDue As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Operations))
        Me.LIBRARY_MANAGEMENTDataSet = New LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet()
        Me.OperationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperationsTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSetTableAdapters.OperationsTableAdapter()
        Me.TableAdapterManager = New LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSetTableAdapters.TableAdapterManager()
        Me.BOOKTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSetTableAdapters.BOOKTableAdapter()
        Me.MEMBERTableAdapter = New LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSetTableAdapters.MEMBERTableAdapter()
        Me.OperationsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OperationsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BOOKIDTextBox = New System.Windows.Forms.TextBox()
        Me.MEMBERIDTextBox = New System.Windows.Forms.TextBox()
        Me.ISSUE_DATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtDateDue = New System.Windows.Forms.DateTimePicker()
        Me.txtDateReturned = New System.Windows.Forms.DateTimePicker()
        Me.txtFine = New System.Windows.Forms.TextBox()
        Me.txtDaysOverDue = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BOOKIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUTHORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEMBERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MEMBERIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEMBERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MEMBERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btBorrowed = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnReturned = New System.Windows.Forms.Button()
        BOOKIDLabel = New System.Windows.Forms.Label()
        MEMBERIDLabel = New System.Windows.Forms.Label()
        ISSUE_DATELabel = New System.Windows.Forms.Label()
        DUE_DATELabel = New System.Windows.Forms.Label()
        DATE_RETURNEDLabel = New System.Windows.Forms.Label()
        FINELabel = New System.Windows.Forms.Label()
        lblDaysOverDue = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.LIBRARY_MANAGEMENTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OperationsBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BOOKIDLabel
        '
        BOOKIDLabel.AutoSize = True
        BOOKIDLabel.Location = New System.Drawing.Point(34, 72)
        BOOKIDLabel.Name = "BOOKIDLabel"
        BOOKIDLabel.Size = New System.Drawing.Size(62, 15)
        BOOKIDLabel.TabIndex = 1
        BOOKIDLabel.Text = "BOOKID:"
        '
        'MEMBERIDLabel
        '
        MEMBERIDLabel.AutoSize = True
        MEMBERIDLabel.Location = New System.Drawing.Point(34, 102)
        MEMBERIDLabel.Name = "MEMBERIDLabel"
        MEMBERIDLabel.Size = New System.Drawing.Size(78, 15)
        MEMBERIDLabel.TabIndex = 3
        MEMBERIDLabel.Text = "MEMBERID:"
        '
        'ISSUE_DATELabel
        '
        ISSUE_DATELabel.AutoSize = True
        ISSUE_DATELabel.Location = New System.Drawing.Point(34, 133)
        ISSUE_DATELabel.Name = "ISSUE_DATELabel"
        ISSUE_DATELabel.Size = New System.Drawing.Size(81, 15)
        ISSUE_DATELabel.TabIndex = 5
        ISSUE_DATELabel.Text = "ISSUE DATE:"
        '
        'DUE_DATELabel
        '
        DUE_DATELabel.AutoSize = True
        DUE_DATELabel.Location = New System.Drawing.Point(34, 163)
        DUE_DATELabel.Name = "DUE_DATELabel"
        DUE_DATELabel.Size = New System.Drawing.Size(70, 15)
        DUE_DATELabel.TabIndex = 7
        DUE_DATELabel.Text = "DUE DATE:"
        '
        'DATE_RETURNEDLabel
        '
        DATE_RETURNEDLabel.AutoSize = True
        DATE_RETURNEDLabel.Location = New System.Drawing.Point(34, 193)
        DATE_RETURNEDLabel.Name = "DATE_RETURNEDLabel"
        DATE_RETURNEDLabel.Size = New System.Drawing.Size(112, 15)
        DATE_RETURNEDLabel.TabIndex = 9
        DATE_RETURNEDLabel.Text = "DATE RETURNED:"
        '
        'FINELabel
        '
        FINELabel.AutoSize = True
        FINELabel.Location = New System.Drawing.Point(34, 222)
        FINELabel.Name = "FINELabel"
        FINELabel.Size = New System.Drawing.Size(38, 15)
        FINELabel.TabIndex = 11
        FINELabel.Text = "FINE:"
        '
        'lblDaysOverDue
        '
        lblDaysOverDue.AutoSize = True
        lblDaysOverDue.Location = New System.Drawing.Point(34, 252)
        lblDaysOverDue.Name = "lblDaysOverDue"
        lblDaysOverDue.Size = New System.Drawing.Size(106, 15)
        lblDaysOverDue.TabIndex = 13
        lblDaysOverDue.Text = "DAYS OVERDUE:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(34, 296)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(246, 15)
        Label3.TabIndex = 24
        Label3.Text = "WEEKS THE BOOK IS BORROWED FOR:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LIBRARY_MANAGEMENTDataSet
        '
        Me.LIBRARY_MANAGEMENTDataSet.DataSetName = "LIBRARY_MANAGEMENTDataSet"
        Me.LIBRARY_MANAGEMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OperationsBindingSource
        '
        Me.OperationsBindingSource.DataMember = "Operations"
        Me.OperationsBindingSource.DataSource = Me.LIBRARY_MANAGEMENTDataSet
        '
        'OperationsTableAdapter
        '
        Me.OperationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BOOKTableAdapter = Me.BOOKTableAdapter
        Me.TableAdapterManager.LOGINTableAdapter = Nothing
        Me.TableAdapterManager.MEMBERTableAdapter = Me.MEMBERTableAdapter
        Me.TableAdapterManager.OperationsTableAdapter = Me.OperationsTableAdapter
        Me.TableAdapterManager.UpdateOrder = LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BOOKTableAdapter
        '
        Me.BOOKTableAdapter.ClearBeforeFill = True
        '
        'MEMBERTableAdapter
        '
        Me.MEMBERTableAdapter.ClearBeforeFill = True
        '
        'OperationsBindingNavigator
        '
        Me.OperationsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OperationsBindingNavigator.BindingSource = Me.OperationsBindingSource
        Me.OperationsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OperationsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OperationsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OperationsBindingNavigatorSaveItem})
        Me.OperationsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OperationsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OperationsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OperationsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OperationsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OperationsBindingNavigator.Name = "OperationsBindingNavigator"
        Me.OperationsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OperationsBindingNavigator.Size = New System.Drawing.Size(1362, 25)
        Me.OperationsBindingNavigator.TabIndex = 0
        Me.OperationsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 25)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'OperationsBindingNavigatorSaveItem
        '
        Me.OperationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OperationsBindingNavigatorSaveItem.Image = CType(resources.GetObject("OperationsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OperationsBindingNavigatorSaveItem.Name = "OperationsBindingNavigatorSaveItem"
        Me.OperationsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OperationsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BOOKIDTextBox
        '
        Me.BOOKIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperationsBindingSource, "BOOKID", True))
        Me.BOOKIDTextBox.Location = New System.Drawing.Point(161, 68)
        Me.BOOKIDTextBox.Name = "BOOKIDTextBox"
        Me.BOOKIDTextBox.Size = New System.Drawing.Size(233, 22)
        Me.BOOKIDTextBox.TabIndex = 2
        '
        'MEMBERIDTextBox
        '
        Me.MEMBERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperationsBindingSource, "MEMBERID", True))
        Me.MEMBERIDTextBox.Location = New System.Drawing.Point(161, 98)
        Me.MEMBERIDTextBox.Name = "MEMBERIDTextBox"
        Me.MEMBERIDTextBox.Size = New System.Drawing.Size(233, 22)
        Me.MEMBERIDTextBox.TabIndex = 4
        '
        'ISSUE_DATEDateTimePicker
        '
        Me.ISSUE_DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OperationsBindingSource, "ISSUE DATE", True))
        Me.ISSUE_DATEDateTimePicker.Location = New System.Drawing.Point(161, 128)
        Me.ISSUE_DATEDateTimePicker.Name = "ISSUE_DATEDateTimePicker"
        Me.ISSUE_DATEDateTimePicker.Size = New System.Drawing.Size(233, 22)
        Me.ISSUE_DATEDateTimePicker.TabIndex = 6
        '
        'txtDateDue
        '
        Me.txtDateDue.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OperationsBindingSource, "DUE DATE", True))
        Me.txtDateDue.Location = New System.Drawing.Point(161, 158)
        Me.txtDateDue.Name = "txtDateDue"
        Me.txtDateDue.Size = New System.Drawing.Size(233, 22)
        Me.txtDateDue.TabIndex = 8
        '
        'txtDateReturned
        '
        Me.txtDateReturned.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OperationsBindingSource, "DATE RETURNED", True))
        Me.txtDateReturned.Location = New System.Drawing.Point(161, 188)
        Me.txtDateReturned.Name = "txtDateReturned"
        Me.txtDateReturned.Size = New System.Drawing.Size(233, 22)
        Me.txtDateReturned.TabIndex = 10
        '
        'txtFine
        '
        Me.txtFine.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperationsBindingSource, "FINE", True))
        Me.txtFine.Location = New System.Drawing.Point(161, 218)
        Me.txtFine.Name = "txtFine"
        Me.txtFine.Size = New System.Drawing.Size(233, 22)
        Me.txtFine.TabIndex = 12
        '
        'txtDaysOverDue
        '
        Me.txtDaysOverDue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OperationsBindingSource, "DAYS OVERDUE", True))
        Me.txtDaysOverDue.Location = New System.Drawing.Point(161, 248)
        Me.txtDaysOverDue.Name = "txtDaysOverDue"
        Me.txtDaysOverDue.Size = New System.Drawing.Size(233, 22)
        Me.txtDaysOverDue.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BOOKIDDataGridViewTextBoxColumn, Me.BOOKNAMEDataGridViewTextBoxColumn, Me.AUTHORDataGridViewTextBoxColumn, Me.MEMBERIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BOOKBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(41, 429)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(442, 237)
        Me.DataGridView1.TabIndex = 15
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
        'BOOKBindingSource
        '
        Me.BOOKBindingSource.DataMember = "BOOK"
        Me.BOOKBindingSource.DataSource = Me.LIBRARY_MANAGEMENTDataSet
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MEMBERIDDataGridViewTextBoxColumn1, Me.MEMBERNAMEDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.MEMBERBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(1000, 429)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(242, 238)
        Me.DataGridView2.TabIndex = 16
        '
        'MEMBERIDDataGridViewTextBoxColumn1
        '
        Me.MEMBERIDDataGridViewTextBoxColumn1.DataPropertyName = "MEMBERID"
        Me.MEMBERIDDataGridViewTextBoxColumn1.HeaderText = "MEMBERID"
        Me.MEMBERIDDataGridViewTextBoxColumn1.Name = "MEMBERIDDataGridViewTextBoxColumn1"
        '
        'MEMBERNAMEDataGridViewTextBoxColumn
        '
        Me.MEMBERNAMEDataGridViewTextBoxColumn.DataPropertyName = "MEMBERNAME"
        Me.MEMBERNAMEDataGridViewTextBoxColumn.HeaderText = "MEMBERNAME"
        Me.MEMBERNAMEDataGridViewTextBoxColumn.Name = "MEMBERNAMEDataGridViewTextBoxColumn"
        '
        'MEMBERBindingSource
        '
        Me.MEMBERBindingSource.DataMember = "MEMBER"
        Me.MEMBERBindingSource.DataSource = Me.LIBRARY_MANAGEMENTDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 22)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "BOOKS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(996, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 22)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "MEMBERS:"
        '
        'btBorrowed
        '
        Me.btBorrowed.Location = New System.Drawing.Point(1036, 106)
        Me.btBorrowed.Name = "btBorrowed"
        Me.btBorrowed.Size = New System.Drawing.Size(106, 34)
        Me.btBorrowed.TabIndex = 19
        Me.btBorrowed.Text = "BORROWED"
        Me.btBorrowed.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(359, 289)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(35, 22)
        Me.NumericUpDown1.TabIndex = 22
        '
        'btnReturned
        '
        Me.btnReturned.Location = New System.Drawing.Point(1036, 211)
        Me.btnReturned.Name = "btnReturned"
        Me.btnReturned.Size = New System.Drawing.Size(103, 34)
        Me.btnReturned.TabIndex = 23
        Me.btnReturned.Text = "Returned"
        Me.btnReturned.UseVisualStyleBackColor = True
        '
        'Operations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 678)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.btnReturned)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.btBorrowed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(BOOKIDLabel)
        Me.Controls.Add(Me.BOOKIDTextBox)
        Me.Controls.Add(MEMBERIDLabel)
        Me.Controls.Add(Me.MEMBERIDTextBox)
        Me.Controls.Add(ISSUE_DATELabel)
        Me.Controls.Add(Me.ISSUE_DATEDateTimePicker)
        Me.Controls.Add(DUE_DATELabel)
        Me.Controls.Add(Me.txtDateDue)
        Me.Controls.Add(DATE_RETURNEDLabel)
        Me.Controls.Add(Me.txtDateReturned)
        Me.Controls.Add(FINELabel)
        Me.Controls.Add(Me.txtFine)
        Me.Controls.Add(lblDaysOverDue)
        Me.Controls.Add(Me.txtDaysOverDue)
        Me.Controls.Add(Me.OperationsBindingNavigator)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Operations"
        Me.Text = "Operations"
        CType(Me.LIBRARY_MANAGEMENTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OperationsBindingNavigator.ResumeLayout(False)
        Me.OperationsBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LIBRARY_MANAGEMENTDataSet As LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSet
    Friend WithEvents OperationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperationsTableAdapter As LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSetTableAdapters.OperationsTableAdapter
    Friend WithEvents TableAdapterManager As LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OperationsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OperationsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BOOKIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MEMBERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ISSUE_DATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDateDue As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDateReturned As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFine As System.Windows.Forms.TextBox
    Friend WithEvents txtDaysOverDue As System.Windows.Forms.TextBox
    Friend WithEvents BOOKTableAdapter As LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSetTableAdapters.BOOKTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents BOOKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEMBERTableAdapter As LIBRARY_MANAGEMENT_SYSTEM.LIBRARY_MANAGEMENTDataSetTableAdapters.MEMBERTableAdapter
    Friend WithEvents BOOKIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOKNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AUTHORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEMBERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEMBERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEMBERIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MEMBERNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btBorrowed As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnReturned As System.Windows.Forms.Button
End Class
