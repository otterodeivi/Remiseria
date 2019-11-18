Public Class nuevoViaje

    Private Sub ViajesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ViajesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)

    End Sub

    Private Sub nuevoViaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.RemiseriaDataSet.vehiculo)
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.socios' Puede moverla o quitarla según sea necesario.
        Me.SociosTableAdapter.Fill(Me.RemiseriaDataSet.socios)
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.RemiseriaDataSet.chofer)
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.RemiseriaDataSet.viajes)
        Me.ViajesBindingSource.AddNew()
        Fecha_origenDateTimePicker.Value = Now


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim reserva, cta As Byte
        Dim estado As String
        Dim chofer, vehiculo, socio As Integer
        chofer = Convert.ToInt32(IdChoferComboBox.Text)
        vehiculo = Convert.ToInt32(IdVehiculoComboBox.Text)
        socio = Convert.ToInt32(IdSocioComboBox.Text)

        If ReservaCheck.Checked Then
            reserva = 1
            estado = "reserva"
        Else
            reserva = 0
            estado = "en curso"
        End If


        If CtaCheck.Checked Then
            cta = 1
        Else
            cta = 0
        End If

        If OrigenTextBox.Text <> "" And DestinoTextBox.Text <> "" Then


            'Me.ViajesBindingSource.Current("idChofer") = IdChoferComboBox.SelectedItem
            'Me.ViajesBindingSource.Current("idSocio") = IdSocioComboBox.SelectedItem
            'Me.ViajesBindingSource.Current("idVehiculo") = IdVehiculoComboBox.SelectedItem
            'Me.ViajesBindingSource.Current("fecha_origen") = Fecha_origenDateTimePicker.Value
            'Me.ViajesBindingSource.Current("origen") = OrigenTextBox.Text
            'Me.ViajesBindingSource.Current("destino") = DestinoTextBox.Text
            'Me.ViajesBindingSource.Current("reserva") = reserva
            'Me.ViajesBindingSource.Current("cta_cte") = cta
            'Me.ViajesBindingSource.Current("estado") = estado
            Me.ViajesTableAdapter.nuevoViaje(chofer, socio, vehiculo, Fecha_origenDateTimePicker.Value, OrigenTextBox.Text, DestinoTextBox.Text, reserva, cta, estado)
            MsgBox("el viaje se ha realizado con exito")
            Form1.llenar()
            Me.Close()

        Else
            MsgBox("Por favor complete todos los campos")

        End If


   

    End Sub

    Private Sub Fecha_origenDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha_origenDateTimePicker.ValueChanged
        If Fecha_origenDateTimePicker.Value <> Now Then
            ReservaCheck.Checked = True
        ElseIf Fecha_origenDateTimePicker.Value = Now Then
            ReservaCheck.Checked = False
        End If
    End Sub
End Class