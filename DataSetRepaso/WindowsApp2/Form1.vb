Public Class Form1
    Private Sub NuevoPedidoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoPedidoToolStripMenuItem1.Click
        Dim mv As Integer
        mv = MsgBox("Crear nuevo pedido? ", vbYesNo)

        Select Case mv
            Case 6 'yes
                Dim tabla As DataTable = ds.Tables("pedidos")
                Dim nuevoPedido As DataRow
                Dim nuevoId = BuscarMax()
                nuevoPedido = tabla.NewRow
                ''instaciamos valores
                nuevoPedido.BeginEdit()
                nuevoPedido("idpedido") = nuevoId
                nuevoPedido("fecha") = Date.Today
                nuevoPedido("cerrado") = 0
                nuevoPedido("totalneto") = 0
                nuevoPedido("totaliva") = 0
                nuevoPedido("totalpagar") = 0
                nuevoPedido.EndEdit()
                ''añadimos nuevo pedido y le pasamos el valor a pedido actual
                tabla.Rows.Add(nuevoPedido)
                pedidoActual = nuevoId

                ''mostramos nuevo form
                Dim np As NuevoProducto = New NuevoProducto()
                np.Show()
            Case 7 'no
                Return
        End Select

    End Sub

    Private Function BuscarMax() As Integer
        Dim tabla As DataTable = ds.Tables("pedidos")
        Dim rows() As DataRow = tabla.Select("MAX(idpedido)")

        If rows.Length = 0 Then
            Return 1
        Else
            Dim numero As Object = rows(0).Item("idpedido")
            Return numero + 1
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        daPedidos.Fill(ds, "pedidos")
        daProductos.Fill(ds, "productos")
        daLineasDetalle.Fill(ds, "lineasdetalle")

        Dim table As DataTable = ds.Tables("pedidos")
        Dim key(0) As DataColumn

        key(0) = table.Columns("idpedido")
        table.PrimaryKey = key

        table = ds.Tables("productos")
        key(0) = table.Columns("idproducto")
        table.PrimaryKey = key

        table = ds.Tables("lineasdetalles")
        key(0) = table.Columns("iddetalle")
        table.PrimaryKey = key

        ''instanciamos columnas
        Dim colx, coly As DataColumn

        colx = ds.Tables("pedidos").Columns("idpedido")
        coly = ds.Tables("productos").Columns("idpedido")

        Dim detped As DataRelation = New DataRelation("DetallesPedidos", colx, coly)

        ds.Relations.Add(detped)

        colx = ds.Tables("productos").Columns("idproducto")





    End Sub
End Class
