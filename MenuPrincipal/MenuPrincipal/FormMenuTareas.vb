Public Class FormMenuTareas
    Public Sub abrirFormulario(ByVal formHijo As Object)
        If PanelFormTareas.Controls.Count > 0 Then
            Me.PanelFormTareas.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.PanelFormTareas.Controls.Add(frm)
        Me.PanelFormTareas.Tag = frm
        frm.Show()
    End Sub

    Private Sub btnArreglos_Click(sender As Object, e As EventArgs) Handles btnArreglos.Click
        abrirFormulario(New FormArray_Vectores())
        btnArreglos.Hide()
        btnLibretaAhorros.Hide()

    End Sub

    Private Sub btnLibretaAhorros_Click(sender As Object, e As EventArgs) Handles btnLibretaAhorros.Click
        abrirFormulario(New FormLibretaAhorro())
        btnArreglos.Hide()
        btnLibretaAhorros.Hide()
    End Sub

    Private Sub btnBolsaSolidaria_Click(sender As Object, e As EventArgs) Handles btnBolsaSolidaria.Click
        abrirFormulario(New Form_BolsaSolidaria())
        btnArreglos.Hide()
        btnLibretaAhorros.Hide()
    End Sub
End Class