Public Class nuevoTurno

    Private Sub TurnosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TurnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)

    End Sub

    Private Sub nuevoTurno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.turnos' Puede moverla o quitarla según sea necesario.
        Me.TurnosTableAdapter.Fill(Me.RemiseriaDataSet.turnos)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TurnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)
        activosEnTurno.TurnosTableAdapter.Fill(activosEnTurno.RemiseriaDataSet.turnos)
        Me.TurnosTableAdapter.Fill(Me.RemiseriaDataSet.turnos)
        Me.TurnosBindingSource.MoveLast()
        MsgBox("EL TURNO FUE AGREGADO CON EXITO")
        IdChoferTextBox.Focus()
        Me.TurnosBindingSource.AddNew()
    End Sub
End Class