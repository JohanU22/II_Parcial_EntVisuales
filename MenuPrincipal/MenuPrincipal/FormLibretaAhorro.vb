Public Class FormLibretaAhorro
    Private monto As Double
    Private Cuenta_Banco(,) As String
    Private cuenta, nombre, pais, cuidad, edad As String





    ''Procedimientos
    'Private Sub activarControles()
    '    txtNombre.Enabled = False
    '    txtMonto.Enabled = False
    '    btnAperturar.Enabled = False
    '    btnRetirar.Enabled = True
    '    btnDepositar.Enabled = True
    'End Sub

    'Private Sub desactivarControles()
    '    txtNombre.Enabled = True
    '    txtMonto.Enabled = True
    '    btnAperturar.Enabled = True
    '    btnRetirar.Enabled = False
    '    btnDepositar.Enabled = False
    'End Sub

    'Private Sub limpiar()
    '    desactivarControles()
    '    txtNombre.Clear()
    '    txtSaldoTotal.Clear()
    '    txtMonto.Clear()
    '    lstDepositos.Items.Clear()
    '    lstRetiros.Items.Clear()
    'End Sub

    Private Sub frmLibretaAhorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'desactivarControles()
    End Sub

    'Private Sub mostrarSaldo()
    '    txtSaldoTotal.Text = monto
    'End Sub

    'Private Sub btnAperturar_Click(sender As Object, e As EventArgs)
    '    Dim cliente As String


    '    If (monto > 0) Then
    '        activarControles()
    '    Else
    '        MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    'Private Function leer(mensaje As String)
    '    Dim cantidad As Double
    '    cantidad = InputBox("Ingrese un monto a " & mensaje, "Operación")
    '    mostrarSaldo()
    '    Return cantidad
    'End Function

    'Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
    '    limpiar()
    'End Sub

    'Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
    '    Dim deposito As Double
    '    deposito = leer("Depositar")
    '    monto += deposito
    '    lstDepositos.Items.Add(deposito)
    '    mostrarSaldo()
    'End Sub

    'Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
    '    Dim retiro As Double
    '    retiro = leer("Retirar")
    '    If (retiro > monto) Then
    '        MessageBox.Show("Saldo insuficiente", "Deposite mas", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Else
    '        monto -= retiro
    '        lstRetiros.Items.Add(retiro)
    '        mostrarSaldo()
    '    End If
    'End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        cuenta = txtCuenta.Text
        nombre = txtNombre.Text
        edad = txtEdad.Text
        pais = txtPais.Text
        cuidad = txtCuidad.Text

        If (cuenta.Length = 15) And (cuenta <> "" And pais <> "" And edad <> "" And cuidad <> "" And nombre <> "") Then
            MessageBox.Show("Se ha Registrado Exitosamente", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Debe llenar todos los campos correspondientes", "No Registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
End Class