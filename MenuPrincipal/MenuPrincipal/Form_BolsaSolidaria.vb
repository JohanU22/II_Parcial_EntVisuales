Public Class Form_BolsaSolidaria

    Private identidad, nombre, municipio, direccion, departamneto As String
    Private integrantes As Integer
    Private i, cont As Integer
    Private info(,) As String
    Private id(15) As String

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        integrantes = Val(txtIntegrantes.Text)
        cont += 1

        If integrantes >= 1 And integrantes <= 3 Then
            lstContenido.Items.Clear()
            lbBasica.Visible = True
            lstContenido.Items.Add("Frijoles")
            lstContenido.Items.Add("Arroz")
            lstContenido.Items.Add("Manteca")
            lstContenido.Items.Add("Jabón")
            lstContenido.Items.Add("Harina")
            lstContenido.Items.Add("Papel Higiénico")
            lstContenido.Items.Add("Sal")
            MsgBox("Bolsa Entregada con exito", vbInformation)

        ElseIf integrantes > 3 Then
            lstContenido.Items.Clear()
            lbRegular.Visible = True
            lstContenido.Items.Add("Frijoles")
            lstContenido.Items.Add("Arroz")
            lstContenido.Items.Add("Manteca")
            lstContenido.Items.Add("Jabón")
            lstContenido.Items.Add("Harina")
            lstContenido.Items.Add("Papel Higiénico")
            lstContenido.Items.Add("Sal")
            lstContenido.Items.Add("Pasta")
            lstContenido.Items.Add("Desinfectante")
            lstContenido.Items.Add("Azúcar")
            MsgBox("Bolsa Entregada con exito", vbInformation)
        End If

    End Sub


    Private Sub btnNueo_Click(sender As Object, e As EventArgs) Handles btnNueo.Click
        txtNombre.Clear()
        txtDireccion.Clear()
        txtMunicipio.Clear()
        txtIdentidad.Clear()
        txtIntegrantes.Clear()
        grpDatosFam.Enabled = False
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Dim x As String
        Dim itemDepartamento As String
        ReDim Preserve id(15)
        ReDim Preserve info(100, 5)
        itemDepartamento = cmbDepartamento.SelectedItem
        municipio = txtMunicipio.Text
        nombre = txtNombre.Text
        direccion = txtDireccion.Text

        x = txtIdentidad.Text
        Try
            If txtNombre.Text = "" Then
                MsgBox("Ingrese un Nombre")
            ElseIf IsNumeric(txtNombre.Text) Then
                MsgBox("Ingrese un nombre correcto")
            ElseIf txtDireccion.Text = "" Then
                MsgBox("Ingrese una Direccion")
            ElseIf txtMunicipio.Text = "" Then
                MsgBox("Ingrese Municipio")
            ElseIf cmbDepartamento.Text = "" Then
                MsgBox("Ingrese Departamento")
            ElseIf txtIdentidad.Text = "" Then
                MsgBox("Ingrese Municipio")
            ElseIf Not IsNumeric(txtIdentidad.Text) Then
                MsgBox("Ingrese un valor numerico")
            ElseIf x.Length <> 13 Then
                MsgBox("Ingrese una identidad Correcta")
            Else
                For j = 0 To 10 Step 1
                    If x = identidad(j) Then
                        MessageBox.Show("¡La bolsa ya ha sido entregada a esta persona!", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtIdentidad.Clear()
                        grpDatosFam.Enabled = False
                    Else
                        For c = 0 To i Step 1
                            'info(c) = txtIdentidad.Text
                            info(c, 0) = nombre
                            info(c, 1) = x
                            info(c, 2) = municipio
                            info(c, 3) = itemDepartamento
                            info(c, 4) = direccion
                            grpDatosFam.Enabled = True

                        Next
                    End If
                Next
            End If
            mostrarReporte(info)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub mostrarReporte(info(,) As String)
        Dim idEstado, f, c As Integer
        Dim itemEstado As String
        idEstado = cmbEstado.SelectedIndex
        itemEstado = cmbDepartamento.SelectedItem.ToString

        lstReporte.Items.Clear()
        For c = 0 To i Step 1
            If integrantes >= 1 And integrantes <= 3 Then
                info(c, 5) = "Básica"
            ElseIf integrantes <= 3 Then
                info(c, 5) = "Regular"
            End If
        Next

        For f = 0 To UBound(info)
            For c = 0 To UBound(info)
                lstReporte.Items.Add(info(f, c))
            Next
        Next

        txtTotal.Text = cont
    End Sub
End Class