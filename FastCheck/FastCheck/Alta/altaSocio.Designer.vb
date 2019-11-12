<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaSocio
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
        Dim DniLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Me.RemiseriaDataSet = New FastCheck.remiseriaDataSet()
        Me.SociosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SociosTableAdapter = New FastCheck.remiseriaDataSetTableAdapters.sociosTableAdapter()
        Me.TableAdapterManager = New FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager()
        Me.DniTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        DniLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CType(Me.RemiseriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RemiseriaDataSet
        '
        Me.RemiseriaDataSet.DataSetName = "remiseriaDataSet"
        Me.RemiseriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SociosBindingSource
        '
        Me.SociosBindingSource.DataMember = "socios"
        Me.SociosBindingSource.DataSource = Me.RemiseriaDataSet
        '
        'SociosTableAdapter
        '
        Me.SociosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.choferTableAdapter = Nothing
        Me.TableAdapterManager.liqCtaCteTableAdapter = Nothing
        Me.TableAdapterManager.resumenRemiseriaTableAdapter = Nothing
        Me.TableAdapterManager.sociosTableAdapter = Me.SociosTableAdapter
        Me.TableAdapterManager.turnosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.valoresTableAdapter = Nothing
        Me.TableAdapterManager.vehiculoTableAdapter = Nothing
        Me.TableAdapterManager.viajesTableAdapter = Nothing
        '
        'DniLabel
        '
        DniLabel.AutoSize = True
        DniLabel.Location = New System.Drawing.Point(59, 55)
        DniLabel.Name = "DniLabel"
        DniLabel.Size = New System.Drawing.Size(24, 13)
        DniLabel.TabIndex = 3
        DniLabel.Text = "dni:"
        '
        'DniTextBox
        '
        Me.DniTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "dni", True))
        Me.DniTextBox.Location = New System.Drawing.Point(113, 51)
        Me.DniTextBox.Name = "DniTextBox"
        Me.DniTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DniTextBox.TabIndex = 4
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(59, 80)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(113, 77)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 6
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(59, 106)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(46, 13)
        ApellidoLabel.TabIndex = 7
        ApellidoLabel.Text = "apellido:"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(113, 103)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 8
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(59, 132)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(48, 13)
        TelefonoLabel.TabIndex = 9
        TelefonoLabel.Text = "telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SociosBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(113, 129)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "CREAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(138, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "VOLVER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'altaSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 265)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DniLabel)
        Me.Controls.Add(Me.DniTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Name = "altaSocio"
        Me.Text = "altaSocio"
        CType(Me.RemiseriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RemiseriaDataSet As FastCheck.remiseriaDataSet
    Friend WithEvents SociosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SociosTableAdapter As FastCheck.remiseriaDataSetTableAdapters.sociosTableAdapter
    Friend WithEvents TableAdapterManager As FastCheck.remiseriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
