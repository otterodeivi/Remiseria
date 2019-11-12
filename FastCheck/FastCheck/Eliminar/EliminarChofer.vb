Public Class EliminarChofer

    Private Sub ChoferBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ChoferBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)

    End Sub

    Private Sub EliminarChofer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.RemiseriaDataSet.chofer)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim id As Integer = Convert.ToInt32(TextBox1.Text)

        Dim fila As Integer
        fila = Me.ChoferBindingSource.Find("IDArticulo", id)
        If TextBox1.Text = "" Then
            MsgBox("Se debe  de completar el id del chofer")

        ElseIf fila = -1 Then
            MsgBox("no se encontro el id")
        Else
            Me.ChoferTableAdapter.BuscarChofer((Me.RemiseriaDataSet.chofer), id)
            NombreTextBox.Text = Me.ChoferBindingSource.Current("nombre")
            DniTextBox.Text = Me.ChoferBindingSource.Current("dni")
            ApellidoTextBox.Text = Me.ChoferBindingSource.Current("apellido")
            NombreTextBox.Text = Me.ChoferBindingSource.Current("nombre")
            DireccionTextBox.Text = Me.ChoferBindingSource.Current("direccion")
            TelefonoTextBox.Text = Me.ChoferBindingSource.Current("telefono")
            Dim rta As Integer
            rta = MsgBox("desea realmente eliminar, los cambios podrian ser permanente", 32 + 1, vbCritical)
            If rta = 1 Then
                ChoferTableAdapter.bajaChofer(id)
                MsgBox("se ha eliminado con exito")
            End If
        End If

    End Sub
End Class