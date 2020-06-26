<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelBarra = New System.Windows.Forms.Panel()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExamen = New System.Windows.Forms.Button()
        Me.btnEjClases = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.btnTareas = New System.Windows.Forms.Button()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.timerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.timerMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBarra.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBarra
        '
        Me.PanelBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PanelBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBarra.Controls.Add(Me.ButtonCerrar)
        Me.PanelBarra.Controls.Add(Me.BtnRestaurar)
        Me.PanelBarra.Controls.Add(Me.BtnMinimizar)
        Me.PanelBarra.Controls.Add(Me.BtnMaximizar)
        Me.PanelBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarra.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarra.Name = "PanelBarra"
        Me.PanelBarra.Size = New System.Drawing.Size(1000, 36)
        Me.PanelBarra.TabIndex = 1
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCerrar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCerrar.FlatAppearance.BorderSize = 0
        Me.ButtonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.ButtonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrar.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonCerrar.Image = Global.MenuPrincipal.My.Resources.Resources.cerrar123
        Me.ButtonCerrar.Location = New System.Drawing.Point(960, -2)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(35, 38)
        Me.ButtonCerrar.TabIndex = 3
        Me.ButtonCerrar.UseVisualStyleBackColor = False
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurar.FlatAppearance.BorderSize = 0
        Me.BtnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestaurar.Image = Global.MenuPrincipal.My.Resources.Resources.restaurar123
        Me.BtnRestaurar.Location = New System.Drawing.Point(918, -2)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(40, 37)
        Me.BtnRestaurar.TabIndex = 1
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        Me.BtnRestaurar.Visible = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Image = Global.MenuPrincipal.My.Resources.Resources.minimizar123
        Me.BtnMinimizar.Location = New System.Drawing.Point(875, 0)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(37, 35)
        Me.BtnMinimizar.TabIndex = 2
        Me.BtnMinimizar.UseVisualStyleBackColor = False
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizar.FlatAppearance.BorderSize = 0
        Me.BtnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximizar.Image = Global.MenuPrincipal.My.Resources.Resources.expandir123
        Me.BtnMaximizar.Location = New System.Drawing.Point(918, -1)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(40, 37)
        Me.BtnMaximizar.TabIndex = 4
        Me.BtnMaximizar.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.btnExamen)
        Me.PanelMenu.Controls.Add(Me.btnEjClases)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Controls.Add(Me.btnTareas)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.PanelMenu.Location = New System.Drawing.Point(0, 36)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 559)
        Me.PanelMenu.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 332)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 52)
        Me.Panel3.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 210)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 62)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 51)
        Me.Panel1.TabIndex = 0
        '
        'btnExamen
        '
        Me.btnExamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExamen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExamen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExamen.FlatAppearance.BorderSize = 0
        Me.btnExamen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnExamen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExamen.Font = New System.Drawing.Font("Century751 BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExamen.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExamen.Image = Global.MenuPrincipal.My.Resources.Resources.exam
        Me.btnExamen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExamen.Location = New System.Drawing.Point(10, 332)
        Me.btnExamen.Name = "btnExamen"
        Me.btnExamen.Size = New System.Drawing.Size(188, 52)
        Me.btnExamen.TabIndex = 10
        Me.btnExamen.Text = "  Ex&amen"
        Me.btnExamen.UseVisualStyleBackColor = False
        '
        'btnEjClases
        '
        Me.btnEjClases.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEjClases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEjClases.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEjClases.FlatAppearance.BorderSize = 0
        Me.btnEjClases.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnEjClases.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEjClases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEjClases.Font = New System.Drawing.Font("Century751 BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjClases.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEjClases.Image = Global.MenuPrincipal.My.Resources.Resources.class1
        Me.btnEjClases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEjClases.Location = New System.Drawing.Point(10, 210)
        Me.btnEjClases.Name = "btnEjClases"
        Me.btnEjClases.Size = New System.Drawing.Size(187, 62)
        Me.btnEjClases.TabIndex = 8
        Me.btnEjClases.Text = "     Ej&ercicios " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Clase"
        Me.btnEjClases.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = Global.MenuPrincipal.My.Resources.Resources.menu123
        Me.btnMenu.Location = New System.Drawing.Point(155, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(45, 30)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 6
        Me.btnMenu.TabStop = False
        '
        'btnTareas
        '
        Me.btnTareas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTareas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTareas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTareas.FlatAppearance.BorderSize = 0
        Me.btnTareas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnTareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTareas.Font = New System.Drawing.Font("Century751 BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTareas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTareas.Image = Global.MenuPrincipal.My.Resources.Resources.homework
        Me.btnTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTareas.Location = New System.Drawing.Point(10, 118)
        Me.btnTareas.Name = "btnTareas"
        Me.btnTareas.Size = New System.Drawing.Size(188, 51)
        Me.btnTareas.TabIndex = 6
        Me.btnTareas.Text = "  Tar&eas"
        Me.btnTareas.UseVisualStyleBackColor = False
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(200, 36)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(800, 559)
        Me.PanelForm.TabIndex = 3
        '
        'timerOcultarMenu
        '
        '
        'timerMostrarMenu
        '
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 595)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelBarra.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarra As Panel
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExamen As Button
    Friend WithEvents btnEjClases As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents btnTareas As Button
    Friend WithEvents PanelForm As Panel
    Friend WithEvents timerOcultarMenu As Timer
    Friend WithEvents timerMostrarMenu As Timer
End Class
