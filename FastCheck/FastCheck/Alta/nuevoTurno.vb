Public Class nuevoTurno

    Private Sub TurnosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TurnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)

    End Sub

    Private Sub nuevoTurno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.RemiseriaDataSet.vehiculo)
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.RemiseriaDataSet.chofer)
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.turnos' Puede moverla o quitarla según sea necesario.
        Me.TurnosTableAdapter.Fill(Me.RemiseriaDataSet.turnos)
        With ComboBox1.Items
            .Add("Mañana")
            .Add("Tarde")
            .Add("Noche")

        End With
        Me.TurnosBindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TurnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)
        Me.TurnosBindingSource.Current("idChofer") = IdChoferComboBox.Text
        Me.TurnosBindingSource.Current("idVehiculo") = IdVehiculoComboBox.Text
        Me.TurnosBindingSource.Current("ingreso") = DateTimePicker1.Value.TimeOfDay
        Me.TurnosBindingSource.Current("egreso") = DateTimePicker2.Value.TimeOfDay
        Me.TurnosBindingSource.Current("turno") = ComboBox1.Text

        activosEnTurno.TurnosTableAdapter.Fill(activosEnTurno.RemiseriaDataSet.turnos)
        Me.TurnosTableAdapter.Fill(Me.RemiseriaDataSet.turnos)

        MsgBox("EL TURNO FUE AGREGADO CON EXITO")

        Me.TurnosBindingSource.AddNew()
    End Sub

End Class