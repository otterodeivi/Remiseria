Public Class modificarChofer

    Private Sub ChoferBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ChoferBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)

    End Sub

    Private Sub modificarChofer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.chofer' Puede moverla o quitarla según sea necesario.
        Me.ChoferTableAdapter.Fill(Me.RemiseriaDataSet.chofer)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fila, CodConsulta As Integer
        CodConsulta = InputBox("ingrese el numero del chofer")
        fila = Me.ChoferBindingSource.Find("idChofer", CodConsulta)
        If fila = -1 Then

            MsgBox("El chofer no se encontro")
        Else
            ChoferBindingSource.Position = fila

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ChoferBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class