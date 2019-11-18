
Public Class altaChofer

    Private Sub ChoferBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ChoferBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)

    End Sub

    Private Sub choferAlta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.RemiseriaDataSet.chofer)
        Me.ChoferBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If NombreTextBox.Text = "" Then
            NombreTextBox.Focus()
            MsgBox("El campo nombre esta vacio")
        Else
            Me.ChoferBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)
            Me.ChoferTableAdapter.Fill(Me.RemiseriaDataSet.chofer)
            Me.ChoferBindingSource.MoveLast()
            MsgBox("codigo de chofer es:" & ChoferBindingSource.Current("idChofer"))
            NombreTextBox.Focus()
            Me.ChoferBindingSource.AddNew()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fila, CodConsulta, aux As Integer
        CodConsulta = InputBox("Ingrese el numero de chofer que desea eliminar")
        fila = Me.ChoferBindingSource.Find("idChofer", CodConsulta)
        If fila = -1 Then
            MsgBox("El chofer no existe, jamas existio o fue eliminaro el...")
        Else
            ChoferBindingSource.Position = fila
            aux = MsgBox("quiere eliminar el chofer: " & CodConsulta, 32 + 1, "eliminar")
            If aux = 1 Then
                Me.ChoferBindingSource.RemoveCurrent()
                Me.ChoferBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)
                MsgBox("el chofer fue eliminado con exito")
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        modificarChofer.Show()
    End Sub
End Class