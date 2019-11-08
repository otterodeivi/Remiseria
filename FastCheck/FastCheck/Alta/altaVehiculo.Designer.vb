<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaVehiculo
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
        Dim DuenioLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim AnioLabel As System.Windows.Forms.Label
        Dim DominioLabel As System.Windows.Forms.Label
        Dim SeguroLabel As System.Windows.Forms.Label
        Dim Venc_gncLabel As System.Windows.Forms.Label
        Dim Venc_vtvLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RemiseriaDataSet = New FastCheck.remiseriaDataSet()
        Me.VehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiculoTableAdapter = New FastCheck.remiseriaDataSetTableAdapters.vehiculoTableAdapter()
        Me.TableAdapterManager = New FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager()
        Me.DuenioTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.AnioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DominioTextBox = New System.Windows.Forms.TextBox()
        Me.SeguroTextBox = New System.Windows.Forms.TextBox()
        Me.Venc_gncDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Venc_vtvDateTimePicker = New System.Windows.Forms.DateTimePicker()
        DuenioLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        AnioLabel = New System.Windows.Forms.Label()
        DominioLabel = New System.Windows.Forms.Label()
        SeguroLabel = New System.Windows.Forms.Label()
        Venc_gncLabel = New System.Windows.Forms.Label()
        Venc_vtvLabel = New System.Windows.Forms.Label()
        CType(Me.RemiseriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DuenioLabel
        '
        DuenioLabel.AutoSize = True
        DuenioLabel.Location = New System.Drawing.Point(72, 85)
        DuenioLabel.Name = "DuenioLabel"
        DuenioLabel.Size = New System.Drawing.Size(42, 13)
        DuenioLabel.TabIndex = 5
        DuenioLabel.Text = "duenio:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(72, 111)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(44, 13)
        ModeloLabel.TabIndex = 7
        ModeloLabel.Text = "modelo:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(72, 137)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(39, 13)
        MarcaLabel.TabIndex = 9
        MarcaLabel.Text = "marca:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(72, 163)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(33, 13)
        ColorLabel.TabIndex = 11
        ColorLabel.Text = "color:"
        '
        'AnioLabel
        '
        AnioLabel.AutoSize = True
        AnioLabel.Location = New System.Drawing.Point(72, 190)
        AnioLabel.Name = "AnioLabel"
        AnioLabel.Size = New System.Drawing.Size(30, 13)
        AnioLabel.TabIndex = 13
        AnioLabel.Text = "anio:"
        '
        'DominioLabel
        '
        DominioLabel.AutoSize = True
        DominioLabel.Location = New System.Drawing.Point(72, 215)
        DominioLabel.Name = "DominioLabel"
        DominioLabel.Size = New System.Drawing.Size(46, 13)
        DominioLabel.TabIndex = 15
        DominioLabel.Text = "dominio:"
        '
        'SeguroLabel
        '
        SeguroLabel.AutoSize = True
        SeguroLabel.Location = New System.Drawing.Point(72, 241)
        SeguroLabel.Name = "SeguroLabel"
        SeguroLabel.Size = New System.Drawing.Size(42, 13)
        SeguroLabel.TabIndex = 17
        SeguroLabel.Text = "seguro:"
        '
        'Venc_gncLabel
        '
        Venc_gncLabel.AutoSize = True
        Venc_gncLabel.Location = New System.Drawing.Point(72, 268)
        Venc_gncLabel.Name = "Venc_gncLabel"
        Venc_gncLabel.Size = New System.Drawing.Size(55, 13)
        Venc_gncLabel.TabIndex = 19
        Venc_gncLabel.Text = "venc gnc:"
        '
        'Venc_vtvLabel
        '
        Venc_vtvLabel.AutoSize = True
        Venc_vtvLabel.Location = New System.Drawing.Point(72, 294)
        Venc_vtvLabel.Name = "Venc_vtvLabel"
        Venc_vtvLabel.Size = New System.Drawing.Size(52, 13)
        Venc_vtvLabel.TabIndex = 21
        Venc_vtvLabel.Text = "venc vtv:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CREAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(171, 385)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "VOLVER"
        Me.Button2.UseVisualStyleBackColor = True
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
        'DuenioTextBox
        '
        Me.DuenioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "duenio", True))
        Me.DuenioTextBox.Location = New System.Drawing.Point(140, 82)
        Me.DuenioTextBox.Name = "DuenioTextBox"
        Me.DuenioTextBox.Size = New System.Drawing.Size(117, 20)
        Me.DuenioTextBox.TabIndex = 6
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(140, 108)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(117, 20)
        Me.ModeloTextBox.TabIndex = 8
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(140, 134)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(117, 20)
        Me.MarcaTextBox.TabIndex = 10
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(140, 160)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(117, 20)
        Me.ColorTextBox.TabIndex = 12
        '
        'AnioDateTimePicker
        '
        Me.AnioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehiculoBindingSource, "anio", True))
        Me.AnioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AnioDateTimePicker.Location = New System.Drawing.Point(140, 186)
        Me.AnioDateTimePicker.Name = "AnioDateTimePicker"
        Me.AnioDateTimePicker.Size = New System.Drawing.Size(117, 20)
        Me.AnioDateTimePicker.TabIndex = 14
        '
        'DominioTextBox
        '
        Me.DominioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "dominio", True))
        Me.DominioTextBox.Location = New System.Drawing.Point(140, 212)
        Me.DominioTextBox.Name = "DominioTextBox"
        Me.DominioTextBox.Size = New System.Drawing.Size(117, 20)
        Me.DominioTextBox.TabIndex = 16
        '
        'SeguroTextBox
        '
        Me.SeguroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiculoBindingSource, "seguro", True))
        Me.SeguroTextBox.Location = New System.Drawing.Point(140, 238)
        Me.SeguroTextBox.Name = "SeguroTextBox"
        Me.SeguroTextBox.Size = New System.Drawing.Size(117, 20)
        Me.SeguroTextBox.TabIndex = 18
        '
        'Venc_gncDateTimePicker
        '
        Me.Venc_gncDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehiculoBindingSource, "venc_gnc", True))
        Me.Venc_gncDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Venc_gncDateTimePicker.Location = New System.Drawing.Point(140, 264)
        Me.Venc_gncDateTimePicker.Name = "Venc_gncDateTimePicker"
        Me.Venc_gncDateTimePicker.Size = New System.Drawing.Size(117, 20)
        Me.Venc_gncDateTimePicker.TabIndex = 20
        '
        'Venc_vtvDateTimePicker
        '
        Me.Venc_vtvDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VehiculoBindingSource, "venc_vtv", True))
        Me.Venc_vtvDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Venc_vtvDateTimePicker.Location = New System.Drawing.Point(140, 290)
        Me.Venc_vtvDateTimePicker.Name = "Venc_vtvDateTimePicker"
        Me.Venc_vtvDateTimePicker.Size = New System.Drawing.Size(117, 20)
        Me.Venc_vtvDateTimePicker.TabIndex = 22
        '
        'altaVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 434)
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
        Me.Controls.Add(Venc_gncLabel)
        Me.Controls.Add(Me.Venc_gncDateTimePicker)
        Me.Controls.Add(Venc_vtvLabel)
        Me.Controls.Add(Me.Venc_vtvDateTimePicker)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "altaVehiculo"
        Me.Text = "altaVehiculo"
        CType(Me.RemiseriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RemiseriaDataSet As FastCheck.remiseriaDataSet
    Friend WithEvents VehiculoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiculoTableAdapter As FastCheck.remiseriaDataSetTableAdapters.vehiculoTableAdapter
    Friend WithEvents TableAdapterManager As FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DuenioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnioDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DominioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SeguroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Venc_gncDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Venc_vtvDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
