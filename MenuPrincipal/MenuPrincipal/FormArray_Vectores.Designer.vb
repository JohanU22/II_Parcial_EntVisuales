<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArray_Vectores
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbSolicitar = New System.Windows.Forms.ComboBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.txtCantComp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cmbPrecios = New System.Windows.Forms.ComboBox()
        Me.btnPrecios = New System.Windows.Forms.Button()
        Me.cmbCompu = New System.Windows.Forms.ComboBox()
        Me.btnGenCompu = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidad1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Precio = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Marca = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantVender = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbSolicitar)
        Me.GroupBox2.Controls.Add(Me.btnSolicitar)
        Me.GroupBox2.Controls.Add(Me.txtCantComp)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 212)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DINAMICO"
        '
        'cmbSolicitar
        '
        Me.cmbSolicitar.FormattingEnabled = True
        Me.cmbSolicitar.Location = New System.Drawing.Point(94, 143)
        Me.cmbSolicitar.Name = "cmbSolicitar"
        Me.cmbSolicitar.Size = New System.Drawing.Size(131, 21)
        Me.cmbSolicitar.TabIndex = 3
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(124, 97)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(75, 23)
        Me.btnSolicitar.TabIndex = 2
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'txtCantComp
        '
        Me.txtCantComp.Location = New System.Drawing.Point(182, 55)
        Me.txtCantComp.Name = "txtCantComp"
        Me.txtCantComp.Size = New System.Drawing.Size(100, 20)
        Me.txtCantComp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad de Computadoras"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.cmbPrecios)
        Me.GroupBox1.Controls.Add(Me.btnPrecios)
        Me.GroupBox1.Controls.Add(Me.cmbCompu)
        Me.GroupBox1.Controls.Add(Me.btnGenCompu)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 190)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "UNIDIMENSIONALES"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(140, 138)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Li&mpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cmbPrecios
        '
        Me.cmbPrecios.FormattingEnabled = True
        Me.cmbPrecios.Location = New System.Drawing.Point(183, 90)
        Me.cmbPrecios.Name = "cmbPrecios"
        Me.cmbPrecios.Size = New System.Drawing.Size(145, 21)
        Me.cmbPrecios.TabIndex = 1
        '
        'btnPrecios
        '
        Me.btnPrecios.Location = New System.Drawing.Point(210, 23)
        Me.btnPrecios.Name = "btnPrecios"
        Me.btnPrecios.Size = New System.Drawing.Size(99, 44)
        Me.btnPrecios.TabIndex = 2
        Me.btnPrecios.Text = "&Generar Precios"
        Me.btnPrecios.UseVisualStyleBackColor = True
        '
        'cmbCompu
        '
        Me.cmbCompu.FormattingEnabled = True
        Me.cmbCompu.Location = New System.Drawing.Point(16, 90)
        Me.cmbCompu.Name = "cmbCompu"
        Me.cmbCompu.Size = New System.Drawing.Size(145, 21)
        Me.cmbCompu.TabIndex = 0
        '
        'btnGenCompu
        '
        Me.btnGenCompu.Location = New System.Drawing.Point(40, 23)
        Me.btnGenCompu.Name = "btnGenCompu"
        Me.btnGenCompu.Size = New System.Drawing.Size(99, 44)
        Me.btnGenCompu.TabIndex = 0
        Me.btnGenCompu.Text = "&Generar Computadoras"
        Me.btnGenCompu.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRegistrar)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtCantidad1)
        Me.GroupBox3.Location = New System.Drawing.Point(388, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(411, 124)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dinamico"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(160, 81)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 8
        Me.btnRegistrar.Text = "Re&gistrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cantidad de Computadoras"
        '
        'txtCantidad1
        '
        Me.txtCantidad1.Location = New System.Drawing.Point(218, 39)
        Me.txtCantidad1.Name = "txtCantidad1"
        Me.txtCantidad1.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad1.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnBuscar)
        Me.GroupBox4.Controls.Add(Me.txtCantidad)
        Me.GroupBox4.Controls.Add(Me.Cantidad)
        Me.GroupBox4.Controls.Add(Me.txtPrecio)
        Me.GroupBox4.Controls.Add(Me.Precio)
        Me.GroupBox4.Controls.Add(Me.txtModelo)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtMarca)
        Me.GroupBox4.Controls.Add(Me.Marca)
        Me.GroupBox4.Location = New System.Drawing.Point(388, 161)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(411, 241)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Registro"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(286, 95)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(99, 167)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(136, 20)
        Me.txtCantidad.TabIndex = 7
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Location = New System.Drawing.Point(34, 170)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.Cantidad.TabIndex = 6
        Me.Cantidad.Text = "Cantidad"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(99, 119)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(136, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'Precio
        '
        Me.Precio.AutoSize = True
        Me.Precio.Location = New System.Drawing.Point(34, 122)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(37, 13)
        Me.Precio.TabIndex = 4
        Me.Precio.Text = "Precio"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(99, 73)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(136, 20)
        Me.txtModelo.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Modelo"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(99, 32)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(136, 20)
        Me.txtMarca.TabIndex = 1
        '
        'Marca
        '
        Me.Marca.AutoSize = True
        Me.Marca.Location = New System.Drawing.Point(34, 35)
        Me.Marca.Name = "Marca"
        Me.Marca.Size = New System.Drawing.Size(37, 13)
        Me.Marca.TabIndex = 0
        Me.Marca.Text = "Marca"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnVender)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.txtCantVender)
        Me.GroupBox5.Location = New System.Drawing.Point(388, 408)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(411, 113)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Dinamico"
        '
        'btnVender
        '
        Me.btnVender.Location = New System.Drawing.Point(160, 81)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(75, 23)
        Me.btnVender.TabIndex = 8
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cantidad a Vender"
        '
        'txtCantVender
        '
        Me.txtCantVender.Location = New System.Drawing.Point(176, 45)
        Me.txtCantVender.Name = "txtCantVender"
        Me.txtCantVender.Size = New System.Drawing.Size(100, 20)
        Me.txtCantVender.TabIndex = 7
        '
        'FormArray_Vectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 559)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormArray_Vectores"
        Me.Text = "FormArray_Vectores"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbSolicitar As ComboBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents txtCantComp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cmbPrecios As ComboBox
    Friend WithEvents btnPrecios As Button
    Friend WithEvents cmbCompu As ComboBox
    Friend WithEvents btnGenCompu As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantidad1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnVender As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCantVender As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Cantidad As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Precio As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Marca As Label
    Friend WithEvents btnBuscar As Button
End Class
