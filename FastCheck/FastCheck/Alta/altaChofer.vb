﻿
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

    End Sub
End Class