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
        Me.btnLibretaAhorros = New System.Windows.Forms.Button()
        Me.btnBolsaSolidaria = New System.Windows.Forms.Button()
        Me.PanelFormTareas.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnArreglos
        '
        Me.btnArreglos.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnArreglos.FlatAppearance.BorderSize = 0
        Me.btnArreglos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnArreglos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnArreglos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArreglos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArreglos.ForeColor = System.Drawing.Color.Transparent
        Me.btnArreglos.Location = New System.Drawing.Point(152, 166)
        Me.btnArreglos.Name = "btnArreglos"
        Me.btnArreglos.Size = New System.Drawing.Size(136, 48)
        Me.btnArreglos.TabIndex = 0
        Me.btnArreglos.Text = "Arreglos"
        Me.btnArreglos.UseVisualStyleBackColor = False
        '
        'PanelFormTareas
        '
        Me.PanelFormTareas.Controls.Add(Me.btnBolsaSolidaria)
        Me.PanelFormTareas.Controls.Add(Me.btnLibretaAhorros)
        Me.PanelFormTareas.Controls.Add(Me.btnArreglos)
        Me.PanelFormTareas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormTareas.Location = New System.Drawing.Point(0, 0)
        Me.PanelFormTareas.Name = "PanelFormTareas"
        Me.PanelFormTareas.Size = New System.Drawing.Size(940, 559)
        Me.PanelFormTareas.TabIndex = 1
        '
        'btnLibretaAhorros
        '
        Me.btnLibretaAhorros.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnLibretaAhorros.FlatAppearance.BorderSize = 0
        Me.btnLibretaAhorros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnLibretaAhorros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnLibretaAhorros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibretaAhorros.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLibretaAhorros.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLibretaAhorros.Location = New System.Drawing.Point(360, 157)
        Me.btnLibretaAhorros.Name = "btnLibretaAhorros"
        Me.btnLibretaAhorros.Size = New System.Drawing.Size(136, 67)
        Me.btnLibretaAhorros.TabIndex = 1
        Me.btnLibretaAhorros.Text = "Libreta de Ahorros"
        Me.btnLibretaAhorros.UseVisualStyleBackColor = False
        '
        'btnBolsaSolidaria
        '
        Me.btnBolsaSolidaria.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnBolsaSolidaria.FlatAppearance.BorderSize = 0
        Me.btnBolsaSolidaria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnBolsaSolidaria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnBolsaSolidaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBolsaSolidaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBolsaSolidaria.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBolsaSolidaria.Location = New System.Drawing.Point(554, 157)
        Me.btnBolsaSolidaria.Name = "btnBolsaSolidaria"
        Me.btnBolsaSolidaria.Size = New System.Drawing.Size(136, 67)
        Me.btnBolsaSolidaria.TabIndex = 2
        Me.btnBolsaSolidaria.Text = "Bolsa Solidaria"
        Me.btnBolsaSolidaria.UseVisualStyleBackColor = False
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
    Friend WithEvents btnLibretaAhorros As Button
    Friend WithEvents btnBolsaSolidaria As Button
End Class
