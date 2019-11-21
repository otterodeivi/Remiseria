<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.PanelMenuSide = New System.Windows.Forms.Panel()
        Me.btnVehiculoSubMenu = New System.Windows.Forms.Button()
        Me.PanelChoferMenu = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnBuscarChofer = New System.Windows.Forms.Button()
        Me.btnNuevoChofer = New System.Windows.Forms.Button()
        Me.btnChoferSubmenu = New System.Windows.Forms.Button()
        Me.PanelSocioMenu = New System.Windows.Forms.Panel()
        Me.btnBuscarSocio = New System.Windows.Forms.Button()
        Me.btnNuevoSocio = New System.Windows.Forms.Button()
        Me.btnSocioSubmenu = New System.Windows.Forms.Button()
        Me.panelTurnoMenu = New System.Windows.Forms.Panel()
        Me.btnRegistroTurno = New System.Windows.Forms.Button()
        Me.btnActivos = New System.Windows.Forms.Button()
        Me.btnNuevoTurno = New System.Windows.Forms.Button()
        Me.btnTurnosSubmenu = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnViajeSubMenu = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelVehiculoMenu = New System.Windows.Forms.Panel()
        Me.btnBuscarVehiculo = New System.Windows.Forms.Button()
        Me.btnNuevoVehiculo = New System.Windows.Forms.Button()
        Me.PanelMenuSide.SuspendLayout()
        Me.PanelChoferMenu.SuspendLayout()
        Me.PanelSocioMenu.SuspendLayout()
        Me.panelTurnoMenu.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelVehiculoMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenuSide
        '
        Me.PanelMenuSide.AutoScroll = True
        Me.PanelMenuSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelMenuSide.Controls.Add(Me.PanelVehiculoMenu)
        Me.PanelMenuSide.Controls.Add(Me.btnVehiculoSubMenu)
        Me.PanelMenuSide.Controls.Add(Me.PanelChoferMenu)
        Me.PanelMenuSide.Controls.Add(Me.btnChoferSubmenu)
        Me.PanelMenuSide.Controls.Add(Me.PanelSocioMenu)
        Me.PanelMenuSide.Controls.Add(Me.btnSocioSubmenu)
        Me.PanelMenuSide.Controls.Add(Me.panelTurnoMenu)
        Me.PanelMenuSide.Controls.Add(Me.btnTurnosSubmenu)
        Me.PanelMenuSide.Controls.Add(Me.Panel4)
        Me.PanelMenuSide.Controls.Add(Me.Panel2)
        Me.PanelMenuSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuSide.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuSide.Name = "PanelMenuSide"
        Me.PanelMenuSide.Size = New System.Drawing.Size(281, 741)
        Me.PanelMenuSide.TabIndex = 0
        '
        'btnVehiculoSubMenu
        '
        Me.btnVehiculoSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnVehiculoSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVehiculoSubMenu.FlatAppearance.BorderSize = 0
        Me.btnVehiculoSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVehiculoSubMenu.Location = New System.Drawing.Point(0, 484)
        Me.btnVehiculoSubMenu.Name = "btnVehiculoSubMenu"
        Me.btnVehiculoSubMenu.Size = New System.Drawing.Size(281, 44)
        Me.btnVehiculoSubMenu.TabIndex = 13
        Me.btnVehiculoSubMenu.Text = "Vehiculo"
        Me.btnVehiculoSubMenu.UseVisualStyleBackColor = False
        '
        'PanelChoferMenu
        '
        Me.PanelChoferMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelChoferMenu.Controls.Add(Me.Button6)
        Me.PanelChoferMenu.Controls.Add(Me.btnBuscarChofer)
        Me.PanelChoferMenu.Controls.Add(Me.btnNuevoChofer)
        Me.PanelChoferMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelChoferMenu.Location = New System.Drawing.Point(0, 395)
        Me.PanelChoferMenu.Name = "PanelChoferMenu"
        Me.PanelChoferMenu.Size = New System.Drawing.Size(281, 89)
        Me.PanelChoferMenu.TabIndex = 12
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Snow
        Me.Button6.Location = New System.Drawing.Point(0, 56)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(281, 28)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Nuevo Turno"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnBuscarChofer
        '
        Me.btnBuscarChofer.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarChofer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBuscarChofer.FlatAppearance.BorderSize = 0
        Me.btnBuscarChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarChofer.ForeColor = System.Drawing.Color.Snow
        Me.btnBuscarChofer.Location = New System.Drawing.Point(0, 28)
        Me.btnBuscarChofer.Name = "btnBuscarChofer"
        Me.btnBuscarChofer.Size = New System.Drawing.Size(281, 28)
        Me.btnBuscarChofer.TabIndex = 3
        Me.btnBuscarChofer.Text = "Buscar Chofer"
        Me.btnBuscarChofer.UseVisualStyleBackColor = False
        '
        'btnNuevoChofer
        '
        Me.btnNuevoChofer.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoChofer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNuevoChofer.FlatAppearance.BorderSize = 0
        Me.btnNuevoChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoChofer.ForeColor = System.Drawing.Color.Snow
        Me.btnNuevoChofer.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevoChofer.Name = "btnNuevoChofer"
        Me.btnNuevoChofer.Size = New System.Drawing.Size(281, 28)
        Me.btnNuevoChofer.TabIndex = 2
        Me.btnNuevoChofer.Text = "Nuevo Chofer"
        Me.btnNuevoChofer.UseVisualStyleBackColor = False
        '
        'btnChoferSubmenu
        '
        Me.btnChoferSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnChoferSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnChoferSubmenu.FlatAppearance.BorderSize = 0
        Me.btnChoferSubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoferSubmenu.Location = New System.Drawing.Point(0, 351)
        Me.btnChoferSubmenu.Name = "btnChoferSubmenu"
        Me.btnChoferSubmenu.Size = New System.Drawing.Size(281, 44)
        Me.btnChoferSubmenu.TabIndex = 11
        Me.btnChoferSubmenu.Text = "Chofer"
        Me.btnChoferSubmenu.UseVisualStyleBackColor = False
        '
        'PanelSocioMenu
        '
        Me.PanelSocioMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelSocioMenu.Controls.Add(Me.btnBuscarSocio)
        Me.PanelSocioMenu.Controls.Add(Me.btnNuevoSocio)
        Me.PanelSocioMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSocioMenu.Location = New System.Drawing.Point(0, 292)
        Me.PanelSocioMenu.Name = "PanelSocioMenu"
        Me.PanelSocioMenu.Size = New System.Drawing.Size(281, 59)
        Me.PanelSocioMenu.TabIndex = 10
        '
        'btnBuscarSocio
        '
        Me.btnBuscarSocio.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarSocio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBuscarSocio.FlatAppearance.BorderSize = 0
        Me.btnBuscarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarSocio.ForeColor = System.Drawing.Color.Snow
        Me.btnBuscarSocio.Location = New System.Drawing.Point(0, 28)
        Me.btnBuscarSocio.Name = "btnBuscarSocio"
        Me.btnBuscarSocio.Size = New System.Drawing.Size(281, 28)
        Me.btnBuscarSocio.TabIndex = 3
        Me.btnBuscarSocio.Text = "Buscar Socio"
        Me.btnBuscarSocio.UseVisualStyleBackColor = False
        '
        'btnNuevoSocio
        '
        Me.btnNuevoSocio.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoSocio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNuevoSocio.FlatAppearance.BorderSize = 0
        Me.btnNuevoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoSocio.ForeColor = System.Drawing.Color.Snow
        Me.btnNuevoSocio.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevoSocio.Name = "btnNuevoSocio"
        Me.btnNuevoSocio.Size = New System.Drawing.Size(281, 28)
        Me.btnNuevoSocio.TabIndex = 2
        Me.btnNuevoSocio.Text = "Nuevo Socio"
        Me.btnNuevoSocio.UseVisualStyleBackColor = False
        '
        'btnSocioSubmenu
        '
        Me.btnSocioSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnSocioSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSocioSubmenu.FlatAppearance.BorderSize = 0
        Me.btnSocioSubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSocioSubmenu.Location = New System.Drawing.Point(0, 248)
        Me.btnSocioSubmenu.Name = "btnSocioSubmenu"
        Me.btnSocioSubmenu.Size = New System.Drawing.Size(281, 44)
        Me.btnSocioSubmenu.TabIndex = 9
        Me.btnSocioSubmenu.Text = "Socio"
        Me.btnSocioSubmenu.UseVisualStyleBackColor = False
        '
        'panelTurnoMenu
        '
        Me.panelTurnoMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelTurnoMenu.Controls.Add(Me.btnRegistroTurno)
        Me.panelTurnoMenu.Controls.Add(Me.btnActivos)
        Me.panelTurnoMenu.Controls.Add(Me.btnNuevoTurno)
        Me.panelTurnoMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTurnoMenu.Location = New System.Drawing.Point(0, 159)
        Me.panelTurnoMenu.Name = "panelTurnoMenu"
        Me.panelTurnoMenu.Size = New System.Drawing.Size(281, 89)
        Me.panelTurnoMenu.TabIndex = 8
        '
        'btnRegistroTurno
        '
        Me.btnRegistroTurno.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistroTurno.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegistroTurno.FlatAppearance.BorderSize = 0
        Me.btnRegistroTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistroTurno.ForeColor = System.Drawing.Color.Snow
        Me.btnRegistroTurno.Location = New System.Drawing.Point(0, 56)
        Me.btnRegistroTurno.Name = "btnRegistroTurno"
        Me.btnRegistroTurno.Size = New System.Drawing.Size(281, 28)
        Me.btnRegistroTurno.TabIndex = 4
        Me.btnRegistroTurno.Text = "Registro en turno"
        Me.btnRegistroTurno.UseVisualStyleBackColor = False
        '
        'btnActivos
        '
        Me.btnActivos.BackColor = System.Drawing.Color.Transparent
        Me.btnActivos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActivos.FlatAppearance.BorderSize = 0
        Me.btnActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivos.ForeColor = System.Drawing.Color.Snow
        Me.btnActivos.Location = New System.Drawing.Point(0, 28)
        Me.btnActivos.Name = "btnActivos"
        Me.btnActivos.Size = New System.Drawing.Size(281, 28)
        Me.btnActivos.TabIndex = 3
        Me.btnActivos.Text = "Activos en turno"
        Me.btnActivos.UseVisualStyleBackColor = False
        '
        'btnNuevoTurno
        '
        Me.btnNuevoTurno.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoTurno.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNuevoTurno.FlatAppearance.BorderSize = 0
        Me.btnNuevoTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoTurno.ForeColor = System.Drawing.Color.Snow
        Me.btnNuevoTurno.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevoTurno.Name = "btnNuevoTurno"
        Me.btnNuevoTurno.Size = New System.Drawing.Size(281, 28)
        Me.btnNuevoTurno.TabIndex = 2
        Me.btnNuevoTurno.Text = "NuevoTurno"
        Me.btnNuevoTurno.UseVisualStyleBackColor = False
        '
        'btnTurnosSubmenu
        '
        Me.btnTurnosSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnTurnosSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTurnosSubmenu.FlatAppearance.BorderSize = 0
        Me.btnTurnosSubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTurnosSubmenu.Location = New System.Drawing.Point(0, 115)
        Me.btnTurnosSubmenu.Name = "btnTurnosSubmenu"
        Me.btnTurnosSubmenu.Size = New System.Drawing.Size(281, 44)
        Me.btnTurnosSubmenu.TabIndex = 7
        Me.btnTurnosSubmenu.Text = "Turnos"
        Me.btnTurnosSubmenu.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnViajeSubMenu)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(281, 45)
        Me.Panel4.TabIndex = 2
        '
        'btnViajeSubMenu
        '
        Me.btnViajeSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnViajeSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnViajeSubMenu.FlatAppearance.BorderSize = 0
        Me.btnViajeSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViajeSubMenu.Location = New System.Drawing.Point(0, 0)
        Me.btnViajeSubMenu.Name = "btnViajeSubMenu"
        Me.btnViajeSubMenu.Size = New System.Drawing.Size(281, 44)
        Me.btnViajeSubMenu.TabIndex = 1
        Me.btnViajeSubMenu.Text = "NUEVO VIAJE"
        Me.btnViajeSubMenu.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(281, 70)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(281, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(934, 741)
        Me.Panel3.TabIndex = 1
        '
        'PanelVehiculoMenu
        '
        Me.PanelVehiculoMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelVehiculoMenu.Controls.Add(Me.btnBuscarVehiculo)
        Me.PanelVehiculoMenu.Controls.Add(Me.btnNuevoVehiculo)
        Me.PanelVehiculoMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVehiculoMenu.Location = New System.Drawing.Point(0, 528)
        Me.PanelVehiculoMenu.Name = "PanelVehiculoMenu"
        Me.PanelVehiculoMenu.Size = New System.Drawing.Size(281, 68)
        Me.PanelVehiculoMenu.TabIndex = 14
        '
        'btnBuscarVehiculo
        '
        Me.btnBuscarVehiculo.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarVehiculo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBuscarVehiculo.FlatAppearance.BorderSize = 0
        Me.btnBuscarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarVehiculo.ForeColor = System.Drawing.Color.Snow
        Me.btnBuscarVehiculo.Location = New System.Drawing.Point(0, 28)
        Me.btnBuscarVehiculo.Name = "btnBuscarVehiculo"
        Me.btnBuscarVehiculo.Size = New System.Drawing.Size(281, 28)
        Me.btnBuscarVehiculo.TabIndex = 3
        Me.btnBuscarVehiculo.Text = "Buscar Vehiculo"
        Me.btnBuscarVehiculo.UseVisualStyleBackColor = False
        '
        'btnNuevoVehiculo
        '
        Me.btnNuevoVehiculo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevoVehiculo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNuevoVehiculo.FlatAppearance.BorderSize = 0
        Me.btnNuevoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoVehiculo.ForeColor = System.Drawing.Color.Snow
        Me.btnNuevoVehiculo.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevoVehiculo.Name = "btnNuevoVehiculo"
        Me.btnNuevoVehiculo.Size = New System.Drawing.Size(281, 28)
        Me.btnNuevoVehiculo.TabIndex = 2
        Me.btnNuevoVehiculo.Text = "Nuevo Vehiculo"
        Me.btnNuevoVehiculo.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 741)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelMenuSide)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.PanelMenuSide.ResumeLayout(False)
        Me.PanelChoferMenu.ResumeLayout(False)
        Me.PanelSocioMenu.ResumeLayout(False)
        Me.panelTurnoMenu.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.PanelVehiculoMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenuSide As System.Windows.Forms.Panel
    Friend WithEvents btnViajeSubMenu As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents panelTurnoMenu As System.Windows.Forms.Panel
    Friend WithEvents btnRegistroTurno As System.Windows.Forms.Button
    Friend WithEvents btnActivos As System.Windows.Forms.Button
    Friend WithEvents btnNuevoTurno As System.Windows.Forms.Button
    Friend WithEvents btnTurnosSubmenu As System.Windows.Forms.Button
    Friend WithEvents PanelSocioMenu As System.Windows.Forms.Panel
    Friend WithEvents btnBuscarSocio As System.Windows.Forms.Button
    Friend WithEvents btnNuevoSocio As System.Windows.Forms.Button
    Friend WithEvents btnSocioSubmenu As System.Windows.Forms.Button
    Friend WithEvents PanelChoferMenu As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnBuscarChofer As System.Windows.Forms.Button
    Friend WithEvents btnNuevoChofer As System.Windows.Forms.Button
    Friend WithEvents btnChoferSubmenu As System.Windows.Forms.Button
    Friend WithEvents btnVehiculoSubMenu As System.Windows.Forms.Button
    Friend WithEvents PanelVehiculoMenu As System.Windows.Forms.Panel
    Friend WithEvents btnBuscarVehiculo As System.Windows.Forms.Button
    Friend WithEvents btnNuevoVehiculo As System.Windows.Forms.Button
End Class
