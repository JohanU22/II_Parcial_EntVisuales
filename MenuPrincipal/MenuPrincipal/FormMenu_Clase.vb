Public Class FormMenu_Clase
    Public Sub abrirFormulario(ByVal formHijo As Object)
        If PanelFormClases.Controls.Count > 0 Then
            Me.PanelFormClases.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.PanelFormClases.Controls.Add(frm)
        Me.PanelFormClases.Tag = frm
        frm.Show()
    End Sub

    Private Sub btnEstudiantes_Click(sender As Object, e As EventArgs) Handles btnEstudiantes.Click
        abrirFormulario(New FormEstudiante())
    End Sub
End Class