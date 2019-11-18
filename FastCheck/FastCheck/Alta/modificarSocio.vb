Public Class modificarSocio

    Private Sub SociosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)

    End Sub

    Private Sub modificarSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.socios' Puede moverla o quitarla según sea necesario.
        Me.SociosTableAdapter.Fill(Me.RemiseriaDataSet.socios)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.SociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fila, CodConsulta As Integer
        CodConsulta = InputBox("ingrese el numero del socio")
        fila = Me.SociosBindingSource.Find("idSocio", CodConsulta)
        If fila = -1 Then

            MsgBox("El chofer no se encontro")
        Else
            SociosBindingSource.Position = fila

        End If
    End Sub
End Class