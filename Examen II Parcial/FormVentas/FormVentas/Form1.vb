Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form1
    Dim Conexion As Conexion = New Conexion()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VentaTableAdapter.Fill(Me.Tienda1_ClienteDataSet.Venta)
        Conexion.conectar()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim agregar As String = "insert into factura1.Venta  values  ( '" + txtCodigoCliente.Text + "','" + txtIDVenta.Text + "','" + txtPrecio.Text + "','" + txtCantidad.Text + "','" + txtFecha.Text + "','" + txtCodProducto.Text + "')"
            If (Conexion.insertar(agregar)) Then
                MessageBox.Show("Datos Agregados Correctamente")
                mostrardatos()
            Else
                MessageBox.Show("error al agregar")

            End If
        Catch ex As Exception
            MessageBox.Show("Dato ya existente")
        End Try
    End Sub

    Public Sub mostrarDatos()
        Conexion.consulta("select * from factura1.Venta", "Venta")
        DataGridView1.DataSource = Conexion.ds.Tables("Tienda1")
    End Sub

    Private Sub txtBuscar_Click(sender As Object, e As EventArgs) Handles txtBuscar.Click
        Try
            Dim conexion As String
            conexion = "data source =LAPTOP-GK4VNBDO\SQLEXPRESS;initial catalog=Tienda;integrated security =true"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlDataAdapter("select * from venta where idVenta=" & txtIDVenta.Text & " ", cn)
            Dim ds As New DataSet
            adaptador.Fill(ds, "Venta")
            If ds.Tables("Venta").Rows.Count > 0 Then
                txtIDVenta.Text = ds.Tables("Venta").Rows(0).Item(0).ToString
                txtFecha.Text = ds.Tables("Venta").Rows(0).Item(1).ToString
                txtPrecio.Text = ds.Tables("Venta").Rows(0).Item(2).ToString
                txtCantidad.Text = ds.Tables("Venta").Rows(0).Item(3).ToString
                txtCodigoCliente.Text = ds.Tables("Venta").Rows(0).Item(4).ToString
                txtCodProducto.Text = ds.Tables("Venta").Rows(0).Item(5).ToString

                DataGridView1.DataSource = ds.Tables("Venta")
            Else

                MessageBox.Show("El dato no existe")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtEliminar_Click(sender As Object, e As EventArgs) Handles txtEliminar.Click
        If (Conexion.eliminar("Venta", "idVenta = " + txtIDVenta.Text)) Then
            MessageBox.Show("Registro eliminado correctamente")
            mostrarDatos()
        Else
            MessageBox.Show("error al eliminar")

        End If
    End Sub

End Class
