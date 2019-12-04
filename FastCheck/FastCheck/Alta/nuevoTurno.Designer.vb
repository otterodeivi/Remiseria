<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevoTurno
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
        Dim IdChoferLabel As System.Windows.Forms.Label
        Dim IdVehiculoLabel As System.Windows.Forms.Label
        Dim IngresoLabel As System.Windows.Forms.Label
        Dim EgresoLabel As System.Windows.Forms.Label
        Dim TurnoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DominioLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TurnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RemiseriaDataSet = New FastCheck.remiseriaDataSet()
        Me.TurnosTableAdapter = New FastCheck.remiseriaDataSetTableAdapters.turnosTableAdapter()
        Me.TableAdapterManager = New FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChoferTableAdapter = New FastCheck.remiseriaDataSetTableAdapters.choferTableAdapter()
        Me.IdChoferComboBox = New System.Windows.Forms.ComboBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiculoTableAdapter = New FastCheck.remiseriaDataSetTableAdapters.vehiculoTableAdapter()
        Me.IdVehiculoComboBox = New System.Windows.Forms.ComboBox()
        Me.DominioTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        IdChoferLabel = New System.Windows.Forms.Label()
        IdVehiculoLabel = New System.Windows.Forms.Label()
        IngresoLabel = New System.Windows.Forms.Label()
        EgresoLabel = New System.Windows.Forms.Label()
        TurnoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DominioLabel = New System.Windows.Forms.Label()
        CType(Me.TurnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemiseriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdChoferLabel
        '
        IdChoferLabel.AutoSize = True
        IdChoferLabel.Location = New System.Drawing.Point(26, 23)
        IdChoferLabel.Name = "IdChoferLabel"
        IdChoferLabel.Size = New System.Drawing.Size(52, 13)
        IdChoferLabel.TabIndex = 3
        IdChoferLabel.Text = "id Chofer:"
        '
        'IdVehiculoLabel
        '
        IdVehiculoLabel.AutoSize = True
        IdVehiculoLabel.Location = New System.Drawing.Point(26, 49)
        IdVehiculoLabel.Name = "IdVehiculoLabel"
        IdVehiculoLabel.Size = New System.Drawing.Size(62, 13)
        IdVehiculoLabel.TabIndex = 5
        IdVehiculoLabel.Text = "id Vehiculo:"
        '
        'IngresoLabel
        '
        IngresoLabel.AutoSize = True
        IngresoLabel.Location = New System.Drawing.Point(26, 76)
        IngresoLabel.Name = "IngresoLabel"
        IngresoLabel.Size = New System.Drawing.Size(44, 13)
        IngresoLabel.TabIndex = 7
        IngresoLabel.Text = "ingreso:"
        '
        'EgresoLabel
        '
        EgresoLabel.AutoSize = True
        EgresoLabel.Location = New System.Drawing.Point(26, 102)
        EgresoLabel.Name = "EgresoLabel"
        EgresoLabel.Size = New System.Drawing.Size(42, 13)
        EgresoLabel.TabIndex = 9
        EgresoLabel.Text = "egreso:"
        '
        'TurnoLabel
        '
        TurnoLabel.AutoSize = True
        TurnoLabel.Location = New System.Drawing.Point(26, 132)
        TurnoLabel.Name = "TurnoLabel"
        TurnoLabel.Size = New System.Drawing.Size(34, 13)
        TurnoLabel.TabIndex = 11
        TurnoLabel.Text = "turno:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(134, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 63)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "INGRESO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TurnosBindingSource
        '
        Me.TurnosBindingSource.DataMember = "turnos"
        Me.TurnosBindingSource.DataSource = Me.RemiseriaDataSet
        '
        'RemiseriaDataSet
        '
        Me.RemiseriaDataSet.DataSetName = "remiseriaDataSet"
        Me.RemiseriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TurnosTableAdapter
        '
        Me.TurnosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.choferTableAdapter = Nothing
        Me.TableAdapterManager.liqCtaCteTableAdapter = Nothing
        Me.TableAdapterManager.resumenRemiseriaTableAdapter = Nothing
        Me.TableAdapterManager.sociosTableAdapter = Nothing
        Me.TableAdapterManager.turnosTableAdapter = Me.TurnosTableAdapter
        Me.TableAdapterManager.UpdateOrder = FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.valoresTableAdapter = Nothing
        Me.TableAdapterManager.vehiculoTableAdapter = Nothing
        Me.TableAdapterManager.viajesTableAdapter = Nothing
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(94, 76)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(85, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(94, 102)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(85, 20)
        Me.DateTimePicker2.TabIndex = 17
        '
        'ChoferBindingSource
        '
        Me.ChoferBindingSource.DataMember = "chofer"
        Me.ChoferBindingSource.DataSource = Me.RemiseriaDataSet
        '
        'ChoferTableAdapter
        '
        Me.ChoferTableAdapter.ClearBeforeFill = True
        '
        'IdChoferComboBox
        '
        Me.IdChoferComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "idChofer", True))
        Me.IdChoferComboBox.DataSource = Me.ChoferBindingSource
        Me.IdChoferComboBox.DisplayMember = "idChofer"
        Me.IdChoferComboBox.FormattingEnabled = True
        Me.IdChoferComboBox.Location = New System.Drawing.Point(94, 20)
        Me.IdChoferComboBox.Name = "IdChoferComboBox"
        Me.IdChoferComboBox.Size = New System.Drawing.Size(85, 21)
        Me.IdChoferComboBox.TabIndex = 18
        Me.IdChoferComboBox.ValueMember = "idChofer"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(220, 22)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 18
        NombreLabel.Text = "nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(271, 19)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 19
        '
        'VehiculoBindingSource
        '
        Me.VehiculoBindingSource.DataMember = "vehiculo"
        Me.VehiculoBindingSource.DataSource = Me.RemiseriaDataSet
        '
        'VehiculoTableAdapter
        '
        Me.VehiculoTableAdapter.ClearBeforeFill = True
        '
        'IdVehiculoComboBox
        '
        Me.IdVehiculoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "idVehiculo", True))
        Me.IdVehiculoComboBox.DataSource = Me.VehiculoBindingSource
        Me.IdVehiculoComboBox.DisplayMember = "idVehiculo"
        Me.IdVehiculoComboBox.FormattingEnabled = True
        Me.IdVehiculoComboBox.Location = New System.Drawing.Point(94, 49)
        Me.IdVehiculoComboBox.Name = "IdVehiculoComboBox"
        Me.IdVehiculoComboBox.Size = New System.Drawing.Size(85, 21)
        Me.IdVehiculoComboBox.TabIndex = 20
        Me.IdVehiculoComboBox.ValueMember = "idVehiculo"
        '
        'DominioLabel
        '
        DominioLabel.AutoSize = True
        DominioLabel.Location = New System.Drawing.Point(219, 53)
        DominioLabel.Name = "DominioLabel"
        DominioLabel.Size = New System.Drawing.Size(46, 13)
        DominioLabel.TabIndex = 20
        DominioLabel.Text = "dominio:"
        '
        'DominioTextBox
        '
        Me.DominioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "dominio", True))
        Me.DominioTextBox.Location = New System.Drawing.Point(271, 50)
        Me.DominioTextBox.Name = "DominioTextBox"
        Me.DominioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DominioTextBox.TabIndex = 21
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(94, 132)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(85, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'nuevoTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 351)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(DominioLabel)
        Me.Controls.Add(Me.DominioTextBox)
        Me.Controls.Add(Me.IdVehiculoComboBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.IdChoferComboBox)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdChoferLabel)
        Me.Controls.Add(IdVehiculoLabel)
        Me.Controls.Add(IngresoLabel)
        Me.Controls.Add(EgresoLabel)
        Me.Controls.Add(TurnoLabel)
        Me.Name = "nuevoTurno"
        Me.Text = "nuevoTurno"
        CType(Me.TurnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemiseriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RemiseriaDataSet As FastCheck.remiseriaDataSet
    Friend WithEvents TurnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TurnosTableAdapter As FastCheck.remiseriaDataSetTableAdapters.turnosTableAdapter
    Friend WithEvents TableAdapterManager As FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChoferTableAdapter As FastCheck.remiseriaDataSetTableAdapters.choferTableAdapter
    Friend WithEvents IdChoferComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VehiculoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiculoTableAdapter As FastCheck.remiseriaDataSetTableAdapters.vehiculoTableAdapter
    Friend WithEvents IdVehiculoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DominioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
