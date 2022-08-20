<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.SimuTallerDataSet = New SimuTaller.simuTallerDataSet()
        Me.TandaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TandaTableAdapter = New SimuTaller.simuTallerDataSetTableAdapters.tandaTableAdapter()
        Me.TableAdapterManager = New SimuTaller.simuTallerDataSetTableAdapters.TableAdapterManager()
        Me.TandaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TandaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.grdTandas = New System.Windows.Forms.DataGridView()
        Me.codtanda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.destanda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.canequipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SimuTallerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TandaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TandaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TandaBindingNavigator.SuspendLayout()
        CType(Me.grdTandas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimuTallerDataSet
        '
        Me.SimuTallerDataSet.DataSetName = "simuTallerDataSet"
        Me.SimuTallerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TandaBindingSource
        '
        Me.TandaBindingSource.DataMember = "tanda"
        Me.TandaBindingSource.DataSource = Me.SimuTallerDataSet
        '
        'TandaTableAdapter
        '
        Me.TandaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.equipos_vs_fallosTableAdapter = Nothing
        Me.TableAdapterManager.equiposTableAdapter = Nothing
        Me.TableAdapterManager.fallosTableAdapter = Nothing
        Me.TableAdapterManager.problemasTableAdapter = Nothing
        Me.TableAdapterManager.resultadosTableAdapter = Nothing
        Me.TableAdapterManager.tandaTableAdapter = Me.TandaTableAdapter
        Me.TableAdapterManager.tipo_equiposTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SimuTaller.simuTallerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TandaBindingNavigator
        '
        Me.TandaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TandaBindingNavigator.BindingSource = Me.TandaBindingSource
        Me.TandaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TandaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TandaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TandaBindingNavigatorSaveItem})
        Me.TandaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TandaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TandaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TandaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TandaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TandaBindingNavigator.Name = "TandaBindingNavigator"
        Me.TandaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TandaBindingNavigator.Size = New System.Drawing.Size(550, 25)
        Me.TandaBindingNavigator.TabIndex = 0
        Me.TandaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'TandaBindingNavigatorSaveItem
        '
        Me.TandaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TandaBindingNavigatorSaveItem.Image = CType(resources.GetObject("TandaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TandaBindingNavigatorSaveItem.Name = "TandaBindingNavigatorSaveItem"
        Me.TandaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TandaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'grdTandas
        '
        Me.grdTandas.AutoGenerateColumns = False
        Me.grdTandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTandas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codtanda, Me.destanda, Me.a, Me.b, Me.canequipo})
        Me.grdTandas.DataSource = Me.TandaBindingSource
        Me.grdTandas.Location = New System.Drawing.Point(0, 28)
        Me.grdTandas.Name = "grdTandas"
        Me.grdTandas.Size = New System.Drawing.Size(550, 220)
        Me.grdTandas.TabIndex = 1
        '
        'codtanda
        '
        Me.codtanda.DataPropertyName = "codtanda"
        Me.codtanda.HeaderText = "codtanda"
        Me.codtanda.Name = "codtanda"
        '
        'destanda
        '
        Me.destanda.DataPropertyName = "destanda"
        Me.destanda.HeaderText = "Tanda"
        Me.destanda.Name = "destanda"
        '
        'a
        '
        Me.a.DataPropertyName = "a"
        Me.a.HeaderText = "Tiempo Minimo llegadas"
        Me.a.Name = "a"
        '
        'b
        '
        Me.b.DataPropertyName = "b"
        Me.b.HeaderText = "Tiempo Maximo llegadas"
        Me.b.Name = "b"
        '
        'canequipo
        '
        Me.canequipo.DataPropertyName = "canequipo"
        Me.canequipo.HeaderText = "Cant. Equipos por dias"
        Me.canequipo.Name = "canequipo"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 255)
        Me.Controls.Add(Me.grdTandas)
        Me.Controls.Add(Me.TandaBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.Text = "Entrada de Tandas"
        CType(Me.SimuTallerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TandaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TandaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TandaBindingNavigator.ResumeLayout(False)
        Me.TandaBindingNavigator.PerformLayout()
        CType(Me.grdTandas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimuTallerDataSet As SimuTaller.simuTallerDataSet
    Friend WithEvents TandaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TandaTableAdapter As SimuTaller.simuTallerDataSetTableAdapters.tandaTableAdapter
    Friend WithEvents TableAdapterManager As SimuTaller.simuTallerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TandaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TandaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdTandas As System.Windows.Forms.DataGridView
    Friend WithEvents codtanda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents destanda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents a As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents b As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents canequipo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
