Public Class Inicio

 
    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnVehiculoSubMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mostrarSubMenu(PanelVehiculoMenu)

    End Sub

    Private Sub btnNuevoVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        hideSubMenu()

    End Sub

    Private Sub btnBuscarVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        hideSubMenu()

    End Sub


    Private Sub btnTurnosSubmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTurnosSubmenu.Click
        mostrarSubMenu(panelTurnoMenu)

    End Sub

    Private Sub btnNuevoTurno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoTurno.Click
        hideSubMenu()

    End Sub

    Private Sub btnActivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivos.Click
        hideSubMenu()

    End Sub

    Private Sub btnRegistroTurno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistroTurno.Click
        hideSubMenu()

    End Sub

   
    Private Sub btnSocioSubmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocioSubmenu.Click
        mostrarSubMenu(PanelSocioMenu)

    End Sub

    Private Sub btnNuevoSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoSocio.Click
        hideSubMenu()

    End Sub

    Private Sub btnBuscarSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarSocio.Click
        hideSubMenu()

    End Sub

    Private Sub btnChoferSubmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoferSubmenu.Click
        mostrarSubMenu(PanelChoferMenu)

    End Sub

    Private Sub btnNuevoChofer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoChofer.Click
        hideSubMenu()

    End Sub

    Private Sub btnBuscarChofer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarChofer.Click
        hideSubMenu()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        hideSubMenu()

    End Sub

    
End Class