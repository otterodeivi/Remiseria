Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data

Public Class Form1
    Dim conexion As conexion = New conexion()

    Public Sub llenar()

        conexion.Consulta("SELECT registro, idChofer, idSocio ,fecha_origen, origen ,destino, estado FROM enCurso where estado= 'en curso'", "enCurso")

        DataGridView1.DataSource = conexion.ds.Tables("enCurso")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.RemiseriaDataSet.viajes)
        'TODO: esta línea de código carga datos en la tabla 'RemiseriaDataSet.chofer' Puede moverla o quitarla según sea necesario.

        llenar()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        altaVehiculo.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        altaChofer.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        altaSocio.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        nuevoViaje.ShowDialog()

    End Sub
End Class
