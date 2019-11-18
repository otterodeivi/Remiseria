Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data


Public Class conexion
    Public conexion As New SqlConnection("Data Source = .; Initial Catalog = remiseria; Integrated Security = True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New remiseriaDataSet() 'C:\Users\user\Desktop\GITKRAKEN\Project-AutoWolf-Original\ProyectoAutoloboOriginal\pruebaBD\bin\Debug\PruebaLocalConeccion.sdf
    Public da As SqlDataAdapter
    Public comando As SqlCommand




    Public Sub conectar()
        Try
            conexion.Open()
            MsgBox("conectado")
        Catch ex As Exception
            MsgBox("error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)

        ds.Tables.Clear()

        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)

    End Sub
End Class
