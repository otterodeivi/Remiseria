﻿Public Class altaSocio

    Private Sub SociosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)

    End Sub

    Private Sub altaSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.socios' Puede moverla o quitarla según sea necesario.
        Me.SociosTableAdapter.Fill(Me.RemiseriaDataSet.socios)
        Me.SociosBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DniTextBox.Text = "" Then
            DniTextBox.Focus()
            MsgBox("El campo nombre esta vacio")
        Else
            Me.SociosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.RemiseriaDataSet)
            Me.SociosTableAdapter.Fill(Me.RemiseriaDataSet.socios)
            Me.SociosBindingSource.MoveLast()
            MsgBox("codigo de socio es:" & SociosBindingSource.Current("idSocio"))
            DniTextBox.Focus()
            Me.SociosBindingSource.AddNew()
        End If
    End Sub
End Class