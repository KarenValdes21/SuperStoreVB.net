<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregarPedido = New System.Windows.Forms.Button()
        Me.BtnEditarPedido = New System.Windows.Forms.Button()
        Me.TxtDate = New System.Windows.Forms.DateTimePicker()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtGanancia = New System.Windows.Forms.TextBox()
        Me.CBMetodoEnvio = New System.Windows.Forms.ComboBox()
        Me.TxtDate2 = New System.Windows.Forms.DateTimePicker()
        Me.CbPedidoID = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(481, 318)
        Me.DataGridView1.TabIndex = 1
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(630, 194)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(79, 20)
        Me.txtCantidad.TabIndex = 22
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(545, 194)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(79, 20)
        Me.TxtPrecio.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(542, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre Producto  "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(549, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Pedido ID"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(693, 378)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 18
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnAgregarPedido
        '
        Me.BtnAgregarPedido.Location = New System.Drawing.Point(531, 378)
        Me.BtnAgregarPedido.Name = "BtnAgregarPedido"
        Me.BtnAgregarPedido.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregarPedido.TabIndex = 17
        Me.BtnAgregarPedido.Text = "Agregar"
        Me.BtnAgregarPedido.UseVisualStyleBackColor = True
        '
        'BtnEditarPedido
        '
        Me.BtnEditarPedido.Location = New System.Drawing.Point(612, 378)
        Me.BtnEditarPedido.Name = "BtnEditarPedido"
        Me.BtnEditarPedido.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditarPedido.TabIndex = 16
        Me.BtnEditarPedido.Text = "Editar"
        Me.BtnEditarPedido.UseVisualStyleBackColor = True
        '
        'TxtDate
        '
        Me.TxtDate.Location = New System.Drawing.Point(545, 298)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.Size = New System.Drawing.Size(142, 20)
        Me.TxtDate.TabIndex = 15
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Location = New System.Drawing.Point(545, 152)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(118, 20)
        Me.TxtNombreProducto.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Pedidos"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 86)
        Me.Panel1.TabIndex = 24
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(545, 236)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(79, 20)
        Me.txtDescuento.TabIndex = 25
        '
        'txtGanancia
        '
        Me.txtGanancia.Location = New System.Drawing.Point(630, 236)
        Me.txtGanancia.Name = "txtGanancia"
        Me.txtGanancia.Size = New System.Drawing.Size(79, 20)
        Me.txtGanancia.TabIndex = 26
        '
        'CBMetodoEnvio
        '
        Me.CBMetodoEnvio.FormattingEnabled = True
        Me.CBMetodoEnvio.Location = New System.Drawing.Point(545, 271)
        Me.CBMetodoEnvio.Name = "CBMetodoEnvio"
        Me.CBMetodoEnvio.Size = New System.Drawing.Size(164, 21)
        Me.CBMetodoEnvio.TabIndex = 28
        '
        'TxtDate2
        '
        Me.TxtDate2.Location = New System.Drawing.Point(545, 338)
        Me.TxtDate2.Name = "TxtDate2"
        Me.TxtDate2.Size = New System.Drawing.Size(142, 20)
        Me.TxtDate2.TabIndex = 29
        '
        'CbPedidoID
        '
        Me.CbPedidoID.FormattingEnabled = True
        Me.CbPedidoID.Location = New System.Drawing.Point(542, 108)
        Me.CbPedidoID.Name = "CbPedidoID"
        Me.CbPedidoID.Size = New System.Drawing.Size(121, 21)
        Me.CbPedidoID.TabIndex = 30
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CbPedidoID)
        Me.Controls.Add(Me.TxtDate2)
        Me.Controls.Add(Me.CBMetodoEnvio)
        Me.Controls.Add(Me.txtGanancia)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregarPedido)
        Me.Controls.Add(Me.BtnEditarPedido)
        Me.Controls.Add(Me.TxtDate)
        Me.Controls.Add(Me.TxtNombreProducto)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAgregarPedido As Button
    Friend WithEvents BtnEditarPedido As Button
    Friend WithEvents TxtDate As DateTimePicker
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtGanancia As TextBox
    Friend WithEvents CBMetodoEnvio As ComboBox
    Friend WithEvents TxtDate2 As DateTimePicker
    Friend WithEvents CbPedidoID As ComboBox
End Class
