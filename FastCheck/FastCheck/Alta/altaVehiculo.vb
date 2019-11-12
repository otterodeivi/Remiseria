Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class altaVehiculo



    Private Sub altaVehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.RemiseriaDataSet.vehiculo)
        Me.VehiculoBindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim anio, gnc, vtv As Date
        anio = AnioDateTimePicker.Value.Date
        gnc = Venc_gncDateTimePicker.Value.Date
        vtv = Venc_gncDateTimePicker.Value.Date

        If DuenioTextBox.Text = "" Then
            DuenioTextBox.Focus()
            MsgBox("El campo nombre esta vacio")
        Else
            Me.VehiculoBindingSource.EndEdit()
            Me.VehiculoBindingSource.Current("anio") = anio
            Me.VehiculoBindingSource.Current("venc_gnc") = gnc
            Me.VehiculoBindingSource.Current("venc_vtv") = vtv
            Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)
            Me.VehiculoTableAdapter.Fill(Me.RemiseriaDataSet.vehiculo)
            Me.VehiculoBindingSource.MoveLast()
            MsgBox("codigo de vehiculo es:" & VehiculoBindingSource.Current("idVehiculo"))
            DuenioTextBox.Focus()
            Me.VehiculoBindingSource.AddNew()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub VehiculoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VehiculoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)

    End Sub

    Private Sub DuenioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuenioTextBox.TextChanged

    End Sub
End Class