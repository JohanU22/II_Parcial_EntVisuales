<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuTareas
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
        Me.btnArreglos = New System.Windows.Forms.Button()
        Me.PanelFormTareas = New System.Windows.Forms.Panel()
        Me.PanelFormTareas.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnArreglos
        '
        Me.btnArreglos.Location = New System.Drawing.Point(338, 232)
        Me.btnArreglos.Name = "btnArreglos"
        Me.btnArreglos.Size = New System.Drawing.Size(75, 23)
        Me.btnArreglos.TabIndex = 0
        Me.btnArreglos.Text = "Arreglos"
        Me.btnArreglos.UseVisualStyleBackColor = True
        '
        'PanelFormTareas
        '
        Me.PanelFormTareas.Controls.Add(Me.btnArreglos)
        Me.PanelFormTareas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormTareas.Location = New System.Drawing.Point(0, 0)
        Me.PanelFormTareas.Name = "PanelFormTareas"
        Me.PanelFormTareas.Size = New System.Drawing.Size(940, 559)
        Me.PanelFormTareas.TabIndex = 1
        '
        'FormMenuTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 559)
        Me.Controls.Add(Me.PanelFormTareas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuTareas"
        Me.Text = "FormMenuTareas"
        Me.PanelFormTareas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnArreglos As Button
    Friend WithEvents PanelFormTareas As Panel
End Class
