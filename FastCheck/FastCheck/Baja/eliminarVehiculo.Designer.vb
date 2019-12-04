<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eliminarVehiculo
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
        Dim IdVehiculoLabel As System.Windows.Forms.Label
        Dim DuenioLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim AnioLabel As System.Windows.Forms.Label
        Dim DominioLabel As System.Windows.Forms.Label
        Dim SeguroLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RemiseriaDataSet = New FastCheck.remiseriaDataSet()
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiculoTableAdapter = New FastCheck.remiseriaDataSetTableAdapters.vehiculoTableAdapter()
        Me.TableAdapterManager = New FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager()
        Me.IdVehiculoComboBox = New System.Windows.Forms.ComboBox()
        Me.DuenioTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.AnioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DominioTextBox = New System.Windows.Forms.TextBox()
        Me.SeguroTextBox = New System.Windows.Forms.TextBox()
        IdVehiculoLabel = New System.Windows.Forms.Label()
        DuenioLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        AnioLabel = New System.Windows.Forms.Label()
        DominioLabel = New System.Windows.Forms.Label()
        SeguroLabel = New System.Windows.Forms.Label()
        CType(Me.RemiseriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 59)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ELIMINAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RemiseriaDataSet
        '
        Me.RemiseriaDataSet.DataSetName = "remiseriaDataSet"
        Me.RemiseriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.choferTableAdapter = Nothing
        Me.TableAdapterManager.liqCtaCteTableAdapter = Nothing
        Me.TableAdapterManager.resumenRemiseriaTableAdapter = Nothing
        Me.TableAdapterManager.sociosTableAdapter = Nothing
        Me.TableAdapterManager.turnosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.valoresTableAdapter = Nothing
        Me.TableAdapterManager.vehiculoTableAdapter = Me.VehiculoTableAdapter
        Me.TableAdapterManager.viajesTableAdapter = Nothing
        '
        'IdVehiculoLabel
        '
        IdVehiculoLabel.AutoSize = True
        IdVehiculoLabel.Location = New System.Drawing.Point(66, 77)
        IdVehiculoLabel.Name = "IdVehiculoLabel"
        IdVehiculoLabel.Size = New System.Drawing.Size(62, 13)
        IdVehiculoLabel.TabIndex = 2
        IdVehiculoLabel.Text = "id Vehiculo:"
        '
        'IdVehiculoComboBox
        '
        Me.IdVehiculoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "idVehiculo", True))
        Me.IdVehiculoComboBox.FormattingEnabled = True
        Me.IdVehiculoComboBox.Location = New System.Drawing.Point(134, 74)
        Me.IdVehiculoComboBox.Name = "IdVehiculoComboBox"
        Me.IdVehiculoComboBox.Size = New System.Drawing.Size(137, 21)
        Me.IdVehiculoComboBox.TabIndex = 3
        '
        'DuenioLabel
        '
        DuenioLabel.AutoSize = True
        DuenioLabel.Location = New System.Drawing.Point(66, 104)
        DuenioLabel.Name = "DuenioLabel"
        DuenioLabel.Size = New System.Drawing.Size(42, 13)
        DuenioLabel.TabIndex = 4
        DuenioLabel.Text = "duenio:"
        '
        'DuenioTextBox
        '
        Me.DuenioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "duenio", True))
        Me.DuenioTextBox.Location = New System.Drawing.Point(134, 101)
        Me.DuenioTextBox.Name = "DuenioTextBox"
        Me.DuenioTextBox.Size = New System.Drawing.Size(137, 20)
        Me.DuenioTextBox.TabIndex = 5
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(66, 130)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(44, 13)
        ModeloLabel.TabIndex = 6
        ModeloLabel.Text = "modelo:"
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(134, 127)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(137, 20)
        Me.ModeloTextBox.TabIndex = 7
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(66, 156)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(39, 13)
        MarcaLabel.TabIndex = 8
        MarcaLabel.Text = "marca:"
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(134, 153)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(137, 20)
        Me.MarcaTextBox.TabIndex = 9
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(66, 182)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(33, 13)
        ColorLabel.TabIndex = 10
        ColorLabel.Text = "color:"
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(134, 179)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(137, 20)
        Me.ColorTextBox.TabIndex = 11
        '
        'AnioLabel
        '
        AnioLabel.AutoSize = True
        AnioLabel.Location = New System.Drawing.Point(66, 209)
        AnioLabel.Name = "AnioLabel"
        AnioLabel.Size = New System.Drawing.Size(30, 13)
        AnioLabel.TabIndex = 12
        AnioLabel.Text = "anio:"
        '
        'AnioDateTimePicker
        '
        Me.AnioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehiculoBindingSource, "anio", True))
        Me.AnioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AnioDateTimePicker.Location = New System.Drawing.Point(134, 205)
        Me.AnioDateTimePicker.Name = "AnioDateTimePicker"
        Me.AnioDateTimePicker.Size = New System.Drawing.Size(137, 20)
        Me.AnioDateTimePicker.TabIndex = 13
        '
        'DominioLabel
        '
        DominioLabel.AutoSize = True
        DominioLabel.Location = New System.Drawing.Point(66, 234)
        DominioLabel.Name = "DominioLabel"
        DominioLabel.Size = New System.Drawing.Size(46, 13)
        DominioLabel.TabIndex = 14
        DominioLabel.Text = "dominio:"
        '
        'DominioTextBox
        '
        Me.DominioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "dominio", True))
        Me.DominioTextBox.Location = New System.Drawing.Point(134, 231)
        Me.DominioTextBox.Name = "DominioTextBox"
        Me.DominioTextBox.Size = New System.Drawing.Size(137, 20)
        Me.DominioTextBox.TabIndex = 15
        '
        'SeguroLabel
        '
        SeguroLabel.AutoSize = True
        SeguroLabel.Location = New System.Drawing.Point(66, 260)
        SeguroLabel.Name = "SeguroLabel"
        SeguroLabel.Size = New System.Drawing.Size(42, 13)
        SeguroLabel.TabIndex = 16
        SeguroLabel.Text = "seguro:"
        '
        'SeguroTextBox
        '
        Me.SeguroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "seguro", True))
        Me.SeguroTextBox.Location = New System.Drawing.Point(134, 257)
        Me.SeguroTextBox.Name = "SeguroTextBox"
        Me.SeguroTextBox.Size = New System.Drawing.Size(137, 20)
        Me.SeguroTextBox.TabIndex = 17
        '
        'eliminarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 447)
        Me.Controls.Add(IdVehiculoLabel)
        Me.Controls.Add(Me.IdVehiculoComboBox)
        Me.Controls.Add(DuenioLabel)
        Me.Controls.Add(Me.DuenioTextBox)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(AnioLabel)
        Me.Controls.Add(Me.AnioDateTimePicker)
        Me.Controls.Add(DominioLabel)
        Me.Controls.Add(Me.DominioTextBox)
        Me.Controls.Add(SeguroLabel)
        Me.Controls.Add(Me.SeguroTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "eliminarVehiculo"
        Me.Text = "eliminarVehiculo"
        CType(Me.RemiseriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RemiseriaDataSet As FastCheck.remiseriaDataSet
    Friend WithEvents VehiculoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiculoTableAdapter As FastCheck.remiseriaDataSetTableAdapters.vehiculoTableAdapter
    Friend WithEvents TableAdapterManager As FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdVehiculoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DuenioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DominioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SeguroTextBox As System.Windows.Forms.TextBox
End Class
