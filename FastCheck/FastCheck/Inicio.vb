Public Class Inicio

    Property DBNull As Object

 
    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.turnos' Puede moverla o quitarla según sea necesario.
        Me.TurnosTableAdapter.Fill(Me.RemiseriaDataSet.turnos)
        diseño()

    End Sub

    Private Sub diseño()
        PanelChoferMenu.Visible = False
        PanelSocioMenu.Visible = False
        panelTurnoMenu.Visible = False
        PanelVehiculoMenu.Visible = False

    End Sub
    Private Sub hideSubMenu()
        If PanelChoferMenu.Visible = True Then
            PanelChoferMenu.Visible = False

        End If
        If PanelSocioMenu.Visible = True Then
            PanelSocioMenu.Visible = False

        End If
        If panelTurnoMenu.Visible = True Then
            panelTurnoMenu.Visible = False

        End If
        If PanelVehiculoMenu.Visible = True Then
            PanelVehiculoMenu.Visible = False

        End If
    End Sub

    Private Sub mostrarSubMenu(ByVal subMenu As Panel)
        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub


    Private Sub btnViajeSubMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViajeSubMenu.Click

    End Sub


#Region "turno"


    Private Sub btnTurnosSubmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTurnosSubmenu.Click
        mostrarSubMenu(panelTurnoMenu)

    End Sub

    Private Sub btnNuevoTurno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoTurno.Click
        openChildForm(New nuevoTurno())
        hideSubMenu()

    End Sub

    Private Sub btnActivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivos.Click
        openChildForm(New activosEnTurno())
        hideSubMenu()

    End Sub

    Private Sub btnRegistroTurno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistroTurno.Click
        hideSubMenu()

    End Sub
#End Region
#Region "socio"
    Private Sub btnSocioSubmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocioSubmenu.Click
        mostrarSubMenu(PanelSocioMenu)

    End Sub

    Private Sub btnNuevoSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoSocio.Click
        openChildForm(New altaSocio())
        hideSubMenu()

    End Sub

    Private Sub btnBuscarSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarSocio.Click
        openChildForm(New modificarSocio())
        hideSubMenu()

    End Sub
#End Region
#Region "vehiculos"
    Private Sub btnVehiculoSubMenu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVehiculoSubMenu.Click
        mostrarSubMenu(PanelVehiculoMenu)
    End Sub

    Private Sub btnNuevoVehiculo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoVehiculo.Click
        openChildForm(New altaVehiculo())
        hideSubMenu()
    End Sub

    Private Sub btnBuscarVehiculo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarVehiculo.Click
        openChildForm(New modificarVehiculo())
        hideSubMenu()
    End Sub

#End Region
#Region "chofer"
    Private Sub btnChoferSubmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoferSubmenu.Click
        mostrarSubMenu(PanelChoferMenu)
    End Sub

    Private Sub btnNuevoChofer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoChofer.Click
        openChildForm(New altaChofer())
        hideSubMenu()
    End Sub

    Private Sub btnBuscarChofer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarChofer.Click
        openChildForm(New modificarChofer2())
        hideSubMenu()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        hideSubMenu()
    End Sub
#End Region
    Dim activo As Form = Nothing


    Private Sub openChildForm(ByVal childForm As Form)
        activo = Nothing

        If activo IsNot Nothing Then
            activo.Close()
        Else

            activo = childForm
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            childForm.Dock = DockStyle.Fill
            PanelContainer.Controls.Add(childForm)
            PanelContainer.Tag = childForm
            childForm.BringToFront()
            childForm.Show()




        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

End Class