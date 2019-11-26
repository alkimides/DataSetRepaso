<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoProducto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnNuevalinea = New System.Windows.Forms.Button()
        Me.Precio = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtNewproduct = New System.Windows.Forms.TextBox()
        Me.txtNewprice = New System.Windows.Forms.TextBox()
        Me.txtNewunidad = New System.Windows.Forms.TextBox()
        Me.txtNewtotal = New System.Windows.Forms.TextBox()
        Me.txtTotalprice = New System.Windows.Forms.TextBox()
        Me.txtTotallin = New System.Windows.Forms.TextBox()
        Me.txtTotalunid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdPedido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(470, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(65, 75)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(527, 125)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nueva Linea"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(164, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(250, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Unidades"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(360, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "TotalLinea"
        '
        'btnNuevalinea
        '
        Me.btnNuevalinea.Location = New System.Drawing.Point(517, 269)
        Me.btnNuevalinea.Name = "btnNuevalinea"
        Me.btnNuevalinea.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevalinea.TabIndex = 8
        Me.btnNuevalinea.Text = "Agregar"
        Me.btnNuevalinea.UseVisualStyleBackColor = True
        '
        'Precio
        '
        Me.Precio.AutoSize = True
        Me.Precio.Location = New System.Drawing.Point(62, 343)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(37, 13)
        Me.Precio.TabIndex = 9
        Me.Precio.Text = "Precio"
        Me.Precio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(293, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Total Linea"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(164, 343)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Unidades"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(517, 356)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(65, 49)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 13
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(473, 49)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 14
        '
        'txtNewproduct
        '
        Me.txtNewproduct.Location = New System.Drawing.Point(65, 295)
        Me.txtNewproduct.Name = "txtNewproduct"
        Me.txtNewproduct.Size = New System.Drawing.Size(80, 20)
        Me.txtNewproduct.TabIndex = 15
        '
        'txtNewprice
        '
        Me.txtNewprice.Location = New System.Drawing.Point(167, 294)
        Me.txtNewprice.Name = "txtNewprice"
        Me.txtNewprice.Size = New System.Drawing.Size(66, 20)
        Me.txtNewprice.TabIndex = 16
        '
        'txtNewunidad
        '
        Me.txtNewunidad.Location = New System.Drawing.Point(253, 294)
        Me.txtNewunidad.Name = "txtNewunidad"
        Me.txtNewunidad.Size = New System.Drawing.Size(49, 20)
        Me.txtNewunidad.TabIndex = 17
        '
        'txtNewtotal
        '
        Me.txtNewtotal.Location = New System.Drawing.Point(363, 294)
        Me.txtNewtotal.Name = "txtNewtotal"
        Me.txtNewtotal.Size = New System.Drawing.Size(80, 20)
        Me.txtNewtotal.TabIndex = 18
        '
        'txtTotalprice
        '
        Me.txtTotalprice.Location = New System.Drawing.Point(65, 371)
        Me.txtTotalprice.Name = "txtTotalprice"
        Me.txtTotalprice.Size = New System.Drawing.Size(80, 20)
        Me.txtTotalprice.TabIndex = 19
        '
        'txtTotallin
        '
        Me.txtTotallin.Location = New System.Drawing.Point(296, 371)
        Me.txtTotallin.Name = "txtTotallin"
        Me.txtTotallin.Size = New System.Drawing.Size(77, 20)
        Me.txtTotallin.TabIndex = 20
        '
        'txtTotalunid
        '
        Me.txtTotalunid.Location = New System.Drawing.Point(167, 371)
        Me.txtTotalunid.Name = "txtTotalunid"
        Me.txtTotalunid.Size = New System.Drawing.Size(77, 20)
        Me.txtTotalunid.TabIndex = 21
        '
        'NuevoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 432)
        Me.Controls.Add(Me.txtTotalunid)
        Me.Controls.Add(Me.txtTotallin)
        Me.Controls.Add(Me.txtTotalprice)
        Me.Controls.Add(Me.txtNewtotal)
        Me.Controls.Add(Me.txtNewunidad)
        Me.Controls.Add(Me.txtNewprice)
        Me.Controls.Add(Me.txtNewproduct)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Precio)
        Me.Controls.Add(Me.btnNuevalinea)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NuevoProducto"
        Me.Text = "NuevoProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnNuevalinea As Button
    Friend WithEvents Precio As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtNewproduct As TextBox
    Friend WithEvents txtNewprice As TextBox
    Friend WithEvents txtNewunidad As TextBox
    Friend WithEvents txtNewtotal As TextBox
    Friend WithEvents txtTotalprice As TextBox
    Friend WithEvents txtTotallin As TextBox
    Friend WithEvents txtTotalunid As TextBox
End Class
