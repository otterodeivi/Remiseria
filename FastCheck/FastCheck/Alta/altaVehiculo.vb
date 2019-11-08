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

      
        Me.VehiculoTableAdapter.altaVehiculo(DuenioTextBox.Text, ModeloTextBox.Text, MarcaTextBox.Text, ColorTextBox.Text, AnioDateTimePicker.Value.Date, DominioTextBox.Text, SeguroTextBox.Text, Venc_gncDateTimePicker.Value.Date, Venc_vtvDateTimePicker.Value.Date)

        MsgBox("guardado con exito")


       
    




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