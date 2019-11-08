'Imports System.Data
'Imports System.Data.Sql
'Imports System.Data.SqlClient


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

        'Me.ChoferTableAdapter.altaChofer(NombreTextBox.Text, ApellidoTextBox.Text, DateValue(DniTextBox.Text), DireccionTextBox.Text, DateValue(TelefonoTextBox.Text))

        'MsgBox("guardado con exito")

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
End Class