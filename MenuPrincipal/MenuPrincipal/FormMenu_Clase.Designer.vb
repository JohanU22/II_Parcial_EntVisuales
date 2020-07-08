<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu_Clase
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEstudiantes = New System.Windows.Forms.Button()
        Me.PanelFormClases = New System.Windows.Forms.Panel()
        Me.PanelFormClases.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEstudiantes
        '
        Me.btnEstudiantes.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnEstudiantes.FlatAppearance.BorderSize = 0
        Me.btnEstudiantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnEstudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstudiantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstudiantes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEstudiantes.Location = New System.Drawing.Point(309, 168)
        Me.btnEstudiantes.Name = "btnEstudiantes"
        Me.btnEstudiantes.Size = New System.Drawing.Size(136, 67)
        Me.btnEstudiantes.TabIndex = 3
        Me.btnEstudiantes.Text = "Estudiantes"
        Me.btnEstudiantes.UseVisualStyleBackColor = False
        '
        'PanelFormClases
        '
        Me.PanelFormClases.Controls.Add(Me.btnEstudiantes)
        Me.PanelFormClases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormClases.Location = New System.Drawing.Point(0, 0)
        Me.PanelFormClases.Name = "PanelFormClases"
        Me.PanelFormClases.Size = New System.Drawing.Size(811, 452)
        Me.PanelFormClases.TabIndex = 4
        '
        'FormMenu_Clase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 452)
        Me.Controls.Add(Me.PanelFormClases)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenu_Clase"
        Me.Text = "FormMenu_Clase"
        Me.PanelFormClases.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEstudiantes As Button
    Friend WithEvents PanelFormClases As Panel
End Class
