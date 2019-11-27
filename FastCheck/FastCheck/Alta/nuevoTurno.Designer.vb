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
        Me.RemiseriaDataSet = New FastCheck.remiseriaDataSet()
        Me.TurnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurnosTableAdapter = New FastCheck.remiseriaDataSetTableAdapters.turnosTableAdapter()
        Me.TableAdapterManager = New FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager()
        Me.IdChoferTextBox = New System.Windows.Forms.TextBox()
        Me.IdVehiculoTextBox = New System.Windows.Forms.TextBox()
        Me.IngresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EgresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TurnoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        IdChoferLabel = New System.Windows.Forms.Label()
        IdVehiculoLabel = New System.Windows.Forms.Label()
        IngresoLabel = New System.Windows.Forms.Label()
        EgresoLabel = New System.Windows.Forms.Label()
        TurnoLabel = New System.Windows.Forms.Label()
        CType(Me.RemiseriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RemiseriaDataSet
        '
        Me.RemiseriaDataSet.DataSetName = "remiseriaDataSet"
        Me.RemiseriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TurnosBindingSource
        '
        Me.TurnosBindingSource.DataMember = "turnos"
        Me.TurnosBindingSource.DataSource = Me.RemiseriaDataSet
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
        'IdChoferLabel
        '
        IdChoferLabel.AutoSize = True
        IdChoferLabel.Location = New System.Drawing.Point(32, 28)
        IdChoferLabel.Name = "IdChoferLabel"
        IdChoferLabel.Size = New System.Drawing.Size(52, 13)
        IdChoferLabel.TabIndex = 3
        IdChoferLabel.Text = "id Chofer:"
        '
        'IdChoferTextBox
        '
        Me.IdChoferTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurnosBindingSource, "idChofer", True))
        Me.IdChoferTextBox.Location = New System.Drawing.Point(100, 25)
        Me.IdChoferTextBox.Name = "IdChoferTextBox"
        Me.IdChoferTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdChoferTextBox.TabIndex = 4
        '
        'IdVehiculoLabel
        '
        IdVehiculoLabel.AutoSize = True
        IdVehiculoLabel.Location = New System.Drawing.Point(32, 54)
        IdVehiculoLabel.Name = "IdVehiculoLabel"
        IdVehiculoLabel.Size = New System.Drawing.Size(62, 13)
        IdVehiculoLabel.TabIndex = 5
        IdVehiculoLabel.Text = "id Vehiculo:"
        '
        'IdVehiculoTextBox
        '
        Me.IdVehiculoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurnosBindingSource, "idVehiculo", True))
        Me.IdVehiculoTextBox.Location = New System.Drawing.Point(100, 51)
        Me.IdVehiculoTextBox.Name = "IdVehiculoTextBox"
        Me.IdVehiculoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdVehiculoTextBox.TabIndex = 6
        '
        'IngresoLabel
        '
        IngresoLabel.AutoSize = True
        IngresoLabel.Location = New System.Drawing.Point(32, 81)
        IngresoLabel.Name = "IngresoLabel"
        IngresoLabel.Size = New System.Drawing.Size(44, 13)
        IngresoLabel.TabIndex = 7
        IngresoLabel.Text = "ingreso:"
        '
        'IngresoDateTimePicker
        '
        Me.IngresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TurnosBindingSource, "ingreso", True))
        Me.IngresoDateTimePicker.Location = New System.Drawing.Point(100, 77)
        Me.IngresoDateTimePicker.Name = "IngresoDateTimePicker"
        Me.IngresoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.IngresoDateTimePicker.TabIndex = 8
        '
        'EgresoLabel
        '
        EgresoLabel.AutoSize = True
        EgresoLabel.Location = New System.Drawing.Point(32, 107)
        EgresoLabel.Name = "EgresoLabel"
        EgresoLabel.Size = New System.Drawing.Size(42, 13)
        EgresoLabel.TabIndex = 9
        EgresoLabel.Text = "egreso:"
        '
        'EgresoDateTimePicker
        '
        Me.EgresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TurnosBindingSource, "egreso", True))
        Me.EgresoDateTimePicker.Location = New System.Drawing.Point(100, 103)
        Me.EgresoDateTimePicker.Name = "EgresoDateTimePicker"
        Me.EgresoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.EgresoDateTimePicker.TabIndex = 10
        '
        'TurnoLabel
        '
        TurnoLabel.AutoSize = True
        TurnoLabel.Location = New System.Drawing.Point(32, 132)
        TurnoLabel.Name = "TurnoLabel"
        TurnoLabel.Size = New System.Drawing.Size(34, 13)
        TurnoLabel.TabIndex = 11
        TurnoLabel.Text = "turno:"
        '
        'TurnoTextBox
        '
        Me.TurnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurnosBindingSource, "turno", True))
        Me.TurnoTextBox.Location = New System.Drawing.Point(100, 129)
        Me.TurnoTextBox.Name = "TurnoTextBox"
        Me.TurnoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TurnoTextBox.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 24)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "INGRESO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nuevoTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdChoferLabel)
        Me.Controls.Add(Me.IdChoferTextBox)
        Me.Controls.Add(IdVehiculoLabel)
        Me.Controls.Add(Me.IdVehiculoTextBox)
        Me.Controls.Add(IngresoLabel)
        Me.Controls.Add(Me.IngresoDateTimePicker)
        Me.Controls.Add(EgresoLabel)
        Me.Controls.Add(Me.EgresoDateTimePicker)
        Me.Controls.Add(TurnoLabel)
        Me.Controls.Add(Me.TurnoTextBox)
        Me.Name = "nuevoTurno"
        Me.Text = "nuevoTurno"
        CType(Me.RemiseriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RemiseriaDataSet As FastCheck.remiseriaDataSet
    Friend WithEvents TurnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TurnosTableAdapter As FastCheck.remiseriaDataSetTableAdapters.turnosTableAdapter
    Friend WithEvents TableAdapterManager As FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdChoferTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdVehiculoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IngresoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EgresoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TurnoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
