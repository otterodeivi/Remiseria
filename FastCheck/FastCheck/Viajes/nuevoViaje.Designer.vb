<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevoViaje
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
        Dim Fecha_origenLabel As System.Windows.Forms.Label
        Dim OrigenLabel As System.Windows.Forms.Label
        Dim DestinoLabel As System.Windows.Forms.Label
        Dim IdChoferLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim IdSocioLabel As System.Windows.Forms.Label
        Dim DniLabel As System.Windows.Forms.Label
        Dim IdVehiculoLabel As System.Windows.Forms.Label
        Dim DominioLabel As System.Windows.Forms.Label
        Me.RemiseriaDataSet = New FastCheck.remiseriaDataSet()
        Me.ViajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViajesTableAdapter = New FastCheck.remiseriaDataSetTableAdapters.viajesTableAdapter()
        Me.TableAdapterManager = New FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager()
        Me.ChoferTableAdapter = New FastCheck.remiseriaDataSetTableAdapters.choferTableAdapter()
        Me.SociosTableAdapter = New FastCheck.remiseriaDataSetTableAdapters.sociosTableAdapter()
        Me.VehiculoTableAdapter = New FastCheck.remiseriaDataSetTableAdapters.vehiculoTableAdapter()
        Me.Fecha_origenDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OrigenTextBox = New System.Windows.Forms.TextBox()
        Me.DestinoTextBox = New System.Windows.Forms.TextBox()
        Me.ChoferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdChoferComboBox = New System.Windows.Forms.ComboBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.SociosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DniTextBox = New System.Windows.Forms.TextBox()
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdVehiculoComboBox = New System.Windows.Forms.ComboBox()
        Me.DominioTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IdSocioComboBox = New System.Windows.Forms.ComboBox()
        Me.CtaCheck = New System.Windows.Forms.CheckBox()
        Me.ReservaCheck = New System.Windows.Forms.CheckBox()
        Fecha_origenLabel = New System.Windows.Forms.Label()
        OrigenLabel = New System.Windows.Forms.Label()
        DestinoLabel = New System.Windows.Forms.Label()
        IdChoferLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        IdSocioLabel = New System.Windows.Forms.Label()
        DniLabel = New System.Windows.Forms.Label()
        IdVehiculoLabel = New System.Windows.Forms.Label()
        DominioLabel = New System.Windows.Forms.Label()
        CType(Me.RemiseriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fecha_origenLabel
        '
        Fecha_origenLabel.AutoSize = True
        Fecha_origenLabel.Location = New System.Drawing.Point(24, 137)
        Fecha_origenLabel.Name = "Fecha_origenLabel"
        Fecha_origenLabel.Size = New System.Drawing.Size(69, 13)
        Fecha_origenLabel.TabIndex = 9
        Fecha_origenLabel.Text = "fecha origen:"
        '
        'OrigenLabel
        '
        OrigenLabel.AutoSize = True
        OrigenLabel.Location = New System.Drawing.Point(24, 172)
        OrigenLabel.Name = "OrigenLabel"
        OrigenLabel.Size = New System.Drawing.Size(39, 13)
        OrigenLabel.TabIndex = 15
        OrigenLabel.Text = "origen:"
        '
        'DestinoLabel
        '
        DestinoLabel.AutoSize = True
        DestinoLabel.Location = New System.Drawing.Point(24, 207)
        DestinoLabel.Name = "DestinoLabel"
        DestinoLabel.Size = New System.Drawing.Size(44, 13)
        DestinoLabel.TabIndex = 17
        DestinoLabel.Text = "destino:"
        '
        'IdChoferLabel
        '
        IdChoferLabel.AutoSize = True
        IdChoferLabel.Location = New System.Drawing.Point(24, 20)
        IdChoferLabel.Name = "IdChoferLabel"
        IdChoferLabel.Size = New System.Drawing.Size(52, 13)
        IdChoferLabel.TabIndex = 22
        IdChoferLabel.Text = "id Chofer:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(219, 20)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(80, 13)
        NombreLabel.TabIndex = 23
        NombreLabel.Text = "Nombre chofer:"
        '
        'IdSocioLabel
        '
        IdSocioLabel.AutoSize = True
        IdSocioLabel.Location = New System.Drawing.Point(24, 53)
        IdSocioLabel.Name = "IdSocioLabel"
        IdSocioLabel.Size = New System.Drawing.Size(48, 13)
        IdSocioLabel.TabIndex = 24
        IdSocioLabel.Text = "id Socio:"
        '
        'DniLabel
        '
        DniLabel.AutoSize = True
        DniLabel.Location = New System.Drawing.Point(240, 53)
        DniLabel.Name = "DniLabel"
        DniLabel.Size = New System.Drawing.Size(59, 13)
        DniLabel.TabIndex = 25
        DniLabel.Text = "DNI Socio:"
        '
        'IdVehiculoLabel
        '
        IdVehiculoLabel.AutoSize = True
        IdVehiculoLabel.Location = New System.Drawing.Point(24, 93)
        IdVehiculoLabel.Name = "IdVehiculoLabel"
        IdVehiculoLabel.Size = New System.Drawing.Size(62, 13)
        IdVehiculoLabel.TabIndex = 26
        IdVehiculoLabel.Text = "id Vehiculo:"
        '
        'DominioLabel
        '
        DominioLabel.AutoSize = True
        DominioLabel.Location = New System.Drawing.Point(251, 93)
        DominioLabel.Name = "DominioLabel"
        DominioLabel.Size = New System.Drawing.Size(48, 13)
        DominioLabel.TabIndex = 27
        DominioLabel.Text = "Dominio:"
        '
        'RemiseriaDataSet
        '
        Me.RemiseriaDataSet.DataSetName = "remiseriaDataSet"
        Me.RemiseriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViajesBindingSource
        '
        Me.ViajesBindingSource.DataMember = "viajes"
        Me.ViajesBindingSource.DataSource = Me.RemiseriaDataSet
        '
        'ViajesTableAdapter
        '
        Me.ViajesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.choferTableAdapter = Me.ChoferTableAdapter
        Me.TableAdapterManager.liqCtaCteTableAdapter = Nothing
        Me.TableAdapterManager.resumenRemiseriaTableAdapter = Nothing
        Me.TableAdapterManager.sociosTableAdapter = Me.SociosTableAdapter
        Me.TableAdapterManager.turnosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.valoresTableAdapter = Nothing
        Me.TableAdapterManager.vehiculoTableAdapter = Me.VehiculoTableAdapter
        Me.TableAdapterManager.viajesTableAdapter = Me.ViajesTableAdapter
        '
        'ChoferTableAdapter
        '
        Me.ChoferTableAdapter.ClearBeforeFill = True
        '
        'SociosTableAdapter
        '
        Me.SociosTableAdapter.ClearBeforeFill = True
        '
        'VehiculoTableAdapter
        '
        Me.VehiculoTableAdapter.ClearBeforeFill = True
        '
        'Fecha_origenDateTimePicker
        '
        Me.Fecha_origenDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ViajesBindingSource, "fecha_origen", True))
        Me.Fecha_origenDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Fecha_origenDateTimePicker.Location = New System.Drawing.Point(104, 133)
        Me.Fecha_origenDateTimePicker.Name = "Fecha_origenDateTimePicker"
        Me.Fecha_origenDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.Fecha_origenDateTimePicker.TabIndex = 10
        '
        'OrigenTextBox
        '
        Me.OrigenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "origen", True))
        Me.OrigenTextBox.Location = New System.Drawing.Point(104, 169)
        Me.OrigenTextBox.Name = "OrigenTextBox"
        Me.OrigenTextBox.Size = New System.Drawing.Size(89, 20)
        Me.OrigenTextBox.TabIndex = 16
        '
        'DestinoTextBox
        '
        Me.DestinoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ViajesBindingSource, "destino", True))
        Me.DestinoTextBox.Location = New System.Drawing.Point(104, 204)
        Me.DestinoTextBox.Name = "DestinoTextBox"
        Me.DestinoTextBox.Size = New System.Drawing.Size(89, 20)
        Me.DestinoTextBox.TabIndex = 18
        '
        'ChoferBindingSource
        '
        Me.ChoferBindingSource.DataMember = "chofer"
        Me.ChoferBindingSource.DataSource = Me.RemiseriaDataSet
        '
        'IdChoferComboBox
        '
        Me.IdChoferComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "idChofer", True))
        Me.IdChoferComboBox.DataSource = Me.ChoferBindingSource
        Me.IdChoferComboBox.DisplayMember = "idChofer"
        Me.IdChoferComboBox.FormattingEnabled = True
        Me.IdChoferComboBox.Location = New System.Drawing.Point(104, 17)
        Me.IdChoferComboBox.Name = "IdChoferComboBox"
        Me.IdChoferComboBox.Size = New System.Drawing.Size(89, 21)
        Me.IdChoferComboBox.TabIndex = 23
        Me.IdChoferComboBox.ValueMember = "idChofer"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChoferBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(316, 17)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 24
        '
        'SociosBindingSource
        '
        Me.SociosBindingSource.DataMember = "socios"
        Me.SociosBindingSource.DataSource = Me.RemiseriaDataSet
        '
        'DniTextBox
        '
        Me.DniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "dni", True))
        Me.DniTextBox.Location = New System.Drawing.Point(316, 50)
        Me.DniTextBox.Name = "DniTextBox"
        Me.DniTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DniTextBox.TabIndex = 26
        '
        'VehiculoBindingSource
        '
        Me.VehiculoBindingSource.DataMember = "vehiculo"
        Me.VehiculoBindingSource.DataSource = Me.RemiseriaDataSet
        '
        'IdVehiculoComboBox
        '
        Me.IdVehiculoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "idVehiculo", True))
        Me.IdVehiculoComboBox.DataSource = Me.VehiculoBindingSource
        Me.IdVehiculoComboBox.DisplayMember = "idVehiculo"
        Me.IdVehiculoComboBox.FormattingEnabled = True
        Me.IdVehiculoComboBox.Location = New System.Drawing.Point(104, 90)
        Me.IdVehiculoComboBox.Name = "IdVehiculoComboBox"
        Me.IdVehiculoComboBox.Size = New System.Drawing.Size(89, 21)
        Me.IdVehiculoComboBox.TabIndex = 27
        Me.IdVehiculoComboBox.ValueMember = "idVehiculo"
        '
        'DominioTextBox
        '
        Me.DominioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "dominio", True))
        Me.DominioTextBox.Location = New System.Drawing.Point(316, 90)
        Me.DominioTextBox.Name = "DominioTextBox"
        Me.DominioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DominioTextBox.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(159, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 33)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "NUEVO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IdSocioComboBox
        '
        Me.IdSocioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "idSocio", True))
        Me.IdSocioComboBox.DataSource = Me.SociosBindingSource
        Me.IdSocioComboBox.DisplayMember = "idSocio"
        Me.IdSocioComboBox.FormattingEnabled = True
        Me.IdSocioComboBox.Location = New System.Drawing.Point(104, 53)
        Me.IdSocioComboBox.Name = "IdSocioComboBox"
        Me.IdSocioComboBox.Size = New System.Drawing.Size(89, 21)
        Me.IdSocioComboBox.TabIndex = 30
        Me.IdSocioComboBox.ValueMember = "idSocio"
        '
        'CtaCheck
        '
        Me.CtaCheck.AutoSize = True
        Me.CtaCheck.Location = New System.Drawing.Point(282, 172)
        Me.CtaCheck.Name = "CtaCheck"
        Me.CtaCheck.Size = New System.Drawing.Size(60, 17)
        Me.CtaCheck.TabIndex = 31
        Me.CtaCheck.Text = "Cta cte"
        Me.CtaCheck.UseVisualStyleBackColor = True
        '
        'ReservaCheck
        '
        Me.ReservaCheck.AutoSize = True
        Me.ReservaCheck.Location = New System.Drawing.Point(282, 217)
        Me.ReservaCheck.Name = "ReservaCheck"
        Me.ReservaCheck.Size = New System.Drawing.Size(66, 17)
        Me.ReservaCheck.TabIndex = 32
        Me.ReservaCheck.Text = "Reserva"
        Me.ReservaCheck.UseVisualStyleBackColor = True
        '
        'nuevoViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 299)
        Me.Controls.Add(Me.ReservaCheck)
        Me.Controls.Add(Me.CtaCheck)
        Me.Controls.Add(Me.IdSocioComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DominioLabel)
        Me.Controls.Add(Me.DominioTextBox)
        Me.Controls.Add(IdVehiculoLabel)
        Me.Controls.Add(Me.IdVehiculoComboBox)
        Me.Controls.Add(DniLabel)
        Me.Controls.Add(Me.DniTextBox)
        Me.Controls.Add(IdSocioLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(IdChoferLabel)
        Me.Controls.Add(Me.IdChoferComboBox)
        Me.Controls.Add(Fecha_origenLabel)
        Me.Controls.Add(Me.Fecha_origenDateTimePicker)
        Me.Controls.Add(OrigenLabel)
        Me.Controls.Add(Me.OrigenTextBox)
        Me.Controls.Add(DestinoLabel)
        Me.Controls.Add(Me.DestinoTextBox)
        Me.Name = "nuevoViaje"
        Me.Text = "nuevoViaje"
        CType(Me.RemiseriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChoferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RemiseriaDataSet As FastCheck.remiseriaDataSet
    Friend WithEvents ViajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViajesTableAdapter As FastCheck.remiseriaDataSetTableAdapters.viajesTableAdapter
    Friend WithEvents TableAdapterManager As FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ChoferTableAdapter As FastCheck.remiseriaDataSetTableAdapters.choferTableAdapter
    Friend WithEvents Fecha_origenDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OrigenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DestinoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChoferBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SociosTableAdapter As FastCheck.remiseriaDataSetTableAdapters.sociosTableAdapter
    Friend WithEvents IdChoferComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SociosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VehiculoTableAdapter As FastCheck.remiseriaDataSetTableAdapters.vehiculoTableAdapter
    Friend WithEvents VehiculoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdVehiculoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DominioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IdSocioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CtaCheck As System.Windows.Forms.CheckBox
    Friend WithEvents ReservaCheck As System.Windows.Forms.CheckBox
End Class
