Public Class FormAgregarProducto
    Private ReadOnly producto As New Producto() ' Instancia de la clase Producto
    Private ReadOnly _formPadre As Form

    ' Constructor que recibe el formulario padre
    Public Sub New(formPadre As Form)
        InitializeComponent()
        _formPadre = formPadre
    End Sub

    Private Sub BtnAgregarProducto_Click(sender As Object, e As EventArgs) Handles BtnAgregarProdcuto.Click
        Try
            ' Validar datos ingresados
            If Not ValidarDatos() Then Return

            ' Asignar valores al objeto Producto
            producto.CodigoBarra = txtCodigoBarra.Text.Trim()
            producto.Descripcion = txtDescripcion.Text.Trim()
            producto.Costo = Decimal.Parse(txtCosto.Text.Trim())
            producto.Precio = Decimal.Parse(txtPrecio.Text.Trim())
            producto.Itbms = Decimal.Parse(txtITBMS.Text.Trim())
            producto.Existencia = Integer.Parse(txtExistencia.Text.Trim())
            producto.PuntoDeReorden = Integer.Parse(txtPuntoDeReorden.Text.Trim())
            producto.Estatus = If(rbActivo.Checked, "A"c, "I"c)

            ' Agregar producto a la base de datos
            producto.AgregarProducto()
            MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar campos y actualizar vista en el formulario padre
            LimpiarCampos()
            If TypeOf _formPadre Is VistaProducto Then
                DirectCast(_formPadre, VistaProducto).MostrarDataGridView()
                DirectCast(_formPadre, VistaProducto).ActualizarVista()
            End If

        Catch ex As Exception
            ' Manejar errores
            MessageBox.Show($"Error al agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Método para validar los datos ingresados
    Private Function ValidarDatos() As Boolean
        If String.IsNullOrWhiteSpace(txtCodigoBarra.Text) OrElse txtCodigoBarra.Text.Length <> 12 Then
            MostrarError("El código de barra debe tener 12 dígitos y no puede estar vacío.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtDescripcion.Text) OrElse txtDescripcion.Text.Length > 50 Then
            MostrarError("La descripción no puede estar vacía y debe tener un máximo de 50 caracteres.")
            Return False
        End If

        If Not Decimal.TryParse(txtCosto.Text, Nothing) OrElse Decimal.Parse(txtCosto.Text) < 0 Then
            MostrarError("El costo debe ser un número decimal positivo.")
            Return False
        End If

        If Not Decimal.TryParse(txtPrecio.Text, Nothing) OrElse Decimal.Parse(txtPrecio.Text) < 0 Then
            MostrarError("El precio debe ser un número decimal positivo.")
            Return False
        End If

        If Not Decimal.TryParse(txtITBMS.Text, Nothing) OrElse Decimal.Parse(txtITBMS.Text) < 0 Then
            MostrarError("El ITBMS debe ser un número decimal positivo.")
            Return False
        End If

        If Not Integer.TryParse(txtExistencia.Text, Nothing) OrElse Integer.Parse(txtExistencia.Text) < 0 Then
            MostrarError("La existencia debe ser un número entero positivo.")
            Return False
        End If

        If Not Integer.TryParse(txtPuntoDeReorden.Text, Nothing) OrElse Integer.Parse(txtPuntoDeReorden.Text) < 0 Then
            MostrarError("El punto de reorden debe ser un número entero positivo.")
            Return False
        End If

        If Not (rbActivo.Checked OrElse rbInactivo.Checked) Then
            MostrarError("Debes seleccionar el estatus (Activo/Inactivo).")
            Return False
        End If

        Return True
    End Function

    ' Método para mostrar mensajes de error
    Private Sub MostrarError(mensaje As String)
        MessageBox.Show(mensaje, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    ' Método para limpiar los campos del formulario
    Private Sub LimpiarCampos()
        txtCodigoBarra.Clear()
        txtDescripcion.Clear()
        txtCosto.Clear()
        txtPrecio.Clear()
        txtITBMS.Clear()
        txtExistencia.Clear()
        txtPuntoDeReorden.Clear()
        rbActivo.Checked = False
        rbInactivo.Checked = False
    End Sub

    ' Calcular el ITBMS automáticamente cuando cambia el precio
    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        Try
            Dim precio As Decimal
            If Decimal.TryParse(txtPrecio.Text, precio) Then
                txtITBMS.Text = (precio * 0.07D).ToString("F2") ' ITBMS al 7%, formato de 2 decimales
            Else
                txtITBMS.Text = String.Empty
            End If
        Catch ex As Exception
            MessageBox.Show("Error al calcular ITBMS: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
