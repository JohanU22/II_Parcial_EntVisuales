Public Class FormClientes
    Dim Conexion As Conexion = New Conexion()

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClienteTableAdapter.Fill(Me.Tienda1_ClienteDataSet.cliente)
        Conexion.conectar()

    End Sub

    Public Sub mostrarDatos()
        Conexion.consulta("select * from factura1.cliente", "cliente")
        DataGridView_Clientes.DataSource = Conexion.ds.Tables("Tienda1")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim agregar As String = "insert into factura1.cliente values ( '" + txtIdcliente.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtDireccion.Text + "')"

            If Conexion.insertar(agregar) Then
                MsgBox("Datos Agregados")
                mostrarDatos()
            Else
                MsgBox("Error")
            End If
            txtIdcliente.Clear()
            txtNombre.Clear()
            txtApellido.Clear()
            txtDireccion.Clear()

        Catch ex As Exception
            MessageBox.Show("Registro existente")
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim actualizar As String = "nombre= '" + txtNombre.Text + "'  ,apellido= '" + txtApellido.Text + "', direccion='" + txtDireccion.Text + "')"
        Dim sql As String = String.Format("update factura1.cliente set  nombre='{0}', apellido='{1}', direccion='{2}' where idCliente={3}", txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtIdcliente.Text)
        If (Conexion.actualizar(sql)) Then
            MessageBox.Show("Datos actualizados")
            mostrarDatos()
        Else
            MessageBox.Show("Error al actualizar")

        End If
    End Sub

    Private Sub DataGridView_Clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Clientes.CellContentClick
        Dim vdtg As DataGridViewRow = DataGridView_Clientes.Rows(e.RowIndex)
        txtIdcliente.Text = vdtg.Cells(0).Value.ToString()
        txtNombre.Text = vdtg.Cells(1).Value.ToString()
        txtApellido.Text = vdtg.Cells(2).Value.ToString()
        txtDireccion.Text = vdtg.Cells(3).Value.ToString()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub


End Class