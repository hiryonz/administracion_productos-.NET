Public Class VistaProducto
    Private producto As New Producto() ' Instancia de la clase Producto

    Private Property orderBy As String

    Private Sub VistaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarOrden()
        BtnListarProducto_Click(sender, e)
        MostrarDataGridView()
        ' Deshabilitar botones al inicio
        BtnModificarProducto.Enabled = True
        BtnEliminarProducto.Enabled = True

        BtnLimpiarProducto.Enabled = True ' Siempre habilitado
        BtnBuscarProducto.Enabled = True ' Siempre habilitado
        BtnAdiccionarProducto.Enabled = True ' Siempre habilitado
    End Sub

    Private Sub ActualizarOrden()
        If rbDescripcion.Checked Then
            orderBy = "Descripcion"
        ElseIf rbCodigoBarra.Checked Then
            orderBy = "CodigoBarra"
        Else
            orderBy = "Descripcion" ' Valor predeterminado
        End If
    End Sub

    Private Sub BtnListarProducto_Click(sender As Object, e As EventArgs) Handles BtnListarProducto.Click
        MostrarDataGridView()
        DataGridViewProducto.Columns.Clear()
        ' Listar productos y mostrar el resultado en el DataGridView
        Dim dt As DataTable = producto.ListarProductos(orderBy)
        DataGridViewProducto.DataSource = dt ' Usar DataGridViewProducto
    End Sub

    Private Sub BtnEliminarProducto_Click(sender As Object, e As EventArgs) Handles BtnEliminarProducto.Click
        ' Verificar si hay una fila seleccionada
        If DataGridViewProducto.SelectedRows.Count > 0 Then
            ' Obtener el índice de la fila seleccionada
            Dim selectedRow As DataGridViewRow = DataGridViewProducto.SelectedRows(0)

            ' Obtener el código de barra del producto de la fila seleccionada
            Dim codigoBarra As String = selectedRow.Cells("CodigoBarra").Value.ToString()

            ' Asignar el código de barra a la propiedad del objeto producto
            producto.CodigoBarra = codigoBarra

            ' Llamar al método para eliminar el producto
            producto.EliminarProducto()

            ' Mostrar mensaje de éxito
            MessageBox.Show("Producto eliminado correctamente.")

            ' Actualizar el DataGridView
            BtnListarProducto_Click(sender, e)
        Else
            ' Si no hay ninguna fila seleccionada, mostrar un mensaje
            MessageBox.Show("Por favor, seleccione un producto para eliminar.")
        End If
    End Sub

    Private Sub BtnLimpiarProducto_Click(sender As Object, e As EventArgs) Handles BtnLimpiarProducto.Click
        MostrarDataGridView()

        Try

            DataGridViewProducto.DataSource = Nothing ' Limpiar el DataGridView
            ' Limpiar el DataGridView antes de buscar
            DataGridViewProducto.Rows.Clear() ' Limpiar filas si existen
            DataGridViewProducto.Columns.Clear() ' Limpiar columnas si existen

        Catch ex As Exception

        End Try

        searchProducto.Text = "" ' Limpiar el TextBox de búsqueda

        ' Habilitar cédula o código para buscar otro producto
        BtnBuscarProducto.Enabled = True
        BtnAdiccionarProducto.Enabled = True
        BtnModificarProducto.Enabled = False
        BtnEliminarProducto.Enabled = False
    End Sub

    Private Sub BtnBuscarProducto_Click(sender As Object, e As EventArgs) Handles BtnBuscarProducto.Click
        MostrarDataGridView()
        Dim valor As String = searchProducto.Text
        If valor = "" Then
            MessageBox.Show("El campo está vacío.")
        Else
            producto.CodigoBarra = valor
            Dim dt As DataTable = producto.BuscarProducto()
            If dt.Rows.Count > 0 Then
                ' Limpiar el DataGridView
                DataGridViewProducto.DataSource = Nothing
                DataGridViewProducto.Rows.Clear() ' Limpiar filas si existen

                ' Definir las columnas si no están definidas
                If DataGridViewProducto.Columns.Count = 0 Then
                    DataGridViewProducto.Columns.Add("Id", "Id")
                    DataGridViewProducto.Columns.Add("CodigoBarra", "Código de Barra")
                    DataGridViewProducto.Columns.Add("Descripcion", "Descripción")
                    DataGridViewProducto.Columns.Add("Costo", "Costo")
                    DataGridViewProducto.Columns.Add("Precio", "Precio")
                    DataGridViewProducto.Columns.Add("Itbms", "ITBMS")
                    DataGridViewProducto.Columns.Add("Existencia", "Existencia")
                    DataGridViewProducto.Columns.Add("PuntoDeReorden", "Punto Reorden")
                    DataGridViewProducto.Columns.Add("Estatus", "Estatus")
                End If
                ' Agregar la fila del producto encontrado al DataGridView
                Dim row As String() = New String() {
                    dt.Rows(0)("Id").ToString(),
                    dt.Rows(0)("CodigoBarra").ToString(),
                    dt.Rows(0)("Descripcion").ToString(),
                    dt.Rows(0)("Costo").ToString(),
                    dt.Rows(0)("Precio").ToString(),
                    dt.Rows(0)("Itbms").ToString(),
                    dt.Rows(0)("Existencia").ToString(),
                    dt.Rows(0)("PuntoDeReorden").ToString(),
                    dt.Rows(0)("Estatus").ToString()
                }
                DataGridViewProducto.Rows.Add(row) ' Agregar la fila al DataGridView

                ' Habilitar botones de modificar y eliminar
                BtnModificarProducto.Enabled = True
                BtnEliminarProducto.Enabled = True
                BtnBuscarProducto.Enabled = False ' Deshabilitar botón de buscar
                BtnAdiccionarProducto.Enabled = False ' Deshabilitar botón de agregar
            Else
                MessageBox.Show("Producto no encontrado.")
                ' Habilitar botones de agregar y limpiar
                BtnAdiccionarProducto.Enabled = True
                BtnLimpiarProducto.Enabled = True
                BtnModificarProducto.Enabled = False
                BtnEliminarProducto.Enabled = False
            End If
        End If
        ' Limpiar el TextBox de búsqueda
        searchProducto.Text = ""
    End Sub

    Public Sub MostrarDataGridView()
        DataGridViewProducto.Visible = True
        PanelContenedor.Visible = False
        PanelContenedor.Controls.OfType(Of Form).ToList().ForEach(Sub(f) f.Hide()) ' Ocultar cualquier formulario
    End Sub

    Public Sub ActualizarVista()
        BtnListarProducto.PerformClick()
    End Sub

    Private Sub MostrarFormularioAgregar()
        DataGridViewProducto.Visible = False
        PanelContenedor.Visible = True
        Dim formAgregar As New FormAgregarProducto(Me)
        formAgregar.TopLevel = False ' Hacer que el formulario sea un control hijo
        formAgregar.FormBorderStyle = FormBorderStyle.None ' Quitar bordes del formulario
        formAgregar.Dock = DockStyle.Fill ' Llenar el panel
        PanelContenedor.Controls.Clear() ' Limpiar el panel
        PanelContenedor.Controls.Add(formAgregar) ' Agregar el nuevo formulario al panel
        formAgregar.Show() ' Mostrar el formulario
    End Sub

    Private Sub BtnAdiccionarProducto_Click(sender As Object, e As EventArgs) Handles BtnAdiccionarProducto.Click
        MostrarFormularioAgregar()
    End Sub

    Private Sub BtnModificarProducto_Click(sender As Object, e As EventArgs) Handles BtnModificarProducto.Click
        ' Verificar si hay una fila seleccionada
        If DataGridViewProducto.SelectedRows.Count > 0 Then
            ' Obtener el índice de la fila seleccionada
            Dim selectedRow As DataGridViewRow = DataGridViewProducto.SelectedRows(0)

            ' Obtener el código de barra del producto de la fila seleccionada
            Dim codigoBarra As String = selectedRow.Cells("CodigoBarra").Value.ToString()
            Dim estatus As Char = selectedRow.Cells("Estatus").Value.ToString().First() ' Asumimos que "A" o "I"
            Dim puntoReorden As Integer = Convert.ToInt32(selectedRow.Cells("PuntoDeReorden").Value)
            Dim existencia As Integer = Convert.ToInt32(selectedRow.Cells("Existencia").Value)
            Dim itbms As Integer = Convert.ToInt32(selectedRow.Cells("ITBMS").Value)
            Dim precio As Decimal = Convert.ToDecimal(selectedRow.Cells("Precio").Value)
            Dim costo As Decimal = Convert.ToDecimal(selectedRow.Cells("Costo").Value)
            Dim descripcion As String = selectedRow.Cells("Descripcion").Value.ToString()

            ' Asignar los valores a la propiedad del objeto producto
            producto.CodigoBarra = codigoBarra
            producto.Descripcion = descripcion
            producto.Costo = costo
            producto.Precio = precio
            producto.Itbms = itbms
            producto.Existencia = existencia
            producto.PuntoDeReorden = puntoReorden
            producto.Estatus = estatus

            ' Llamar al método para modificar el producto
            Try
                producto.ModificarProducto()
                ' Mostrar mensaje de éxito
                MessageBox.Show("Producto modificado correctamente.")
                ' Actualizar el DataGridView
                BtnListarProducto_Click(sender, e)
            Catch ex As Exception
                MessageBox.Show("Error al modificar el producto: " & ex.Message)
            End Try
        Else
            ' Si no hay ninguna fila seleccionada, mostrar un mensaje
            MessageBox.Show("Por favor, seleccione un producto para modificar.")
        End If
    End Sub

    Private Sub rbDescripcion_CheckedChanged(sender As Object, e As EventArgs) Handles rbDescripcion.CheckedChanged
        ActualizarOrden()
        BtnListarProducto_Click(sender, e)
    End Sub

    Private Sub rbCodigoBarra_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigoBarra.CheckedChanged
        ActualizarOrden()
        BtnListarProducto_Click(sender, e)
    End Sub



    Private Sub DataGridViewProducto_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewProducto.SelectionChanged
        ' Verificar si hay una fila seleccionada
        If DataGridViewProducto.SelectedRows.Count > 0 Then
            ' Activar botones si hay una fila seleccionada
            BtnModificarProducto.Enabled = True
            BtnEliminarProducto.Enabled = True
        Else
            ' Desactivar botones si no hay filas seleccionadas
            BtnModificarProducto.Enabled = False
            BtnEliminarProducto.Enabled = False
        End If
    End Sub


End Class