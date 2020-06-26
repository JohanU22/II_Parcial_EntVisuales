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
    End Sub
End Class