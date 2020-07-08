Public Class FormProducto
    Private Sub FormProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tienda1_ClienteDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.Tienda1_ClienteDataSet.producto)

    End Sub
End Class