Public Class activosEnTurno

    Private Sub TurnosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TurnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)

    End Sub

    Private Sub activosEnTurno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.turnos' Puede moverla o quitarla según sea necesario.
        Me.TurnosTableAdapter.Fill(Me.RemiseriaDataSet.turnos)

    End Sub
End Class