Public Class FormAgregarCliente
    Private ReadOnly cliente As New Cliente() ' Instancia de la clase Cliente
    Private ReadOnly _formPadre As Form

    ' Constructor que recibe el formulario padre
    Public Sub New(formPadre As Form)
        InitializeComponent()
        _formPadre = formPadre
    End Sub

    Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles BtnAgregarCliente.Click
        Try
            ' Validar y asignar los datos ingresados
            If Not ValidarDatos() Then Return

            ' Configurar los datos del cliente
            cliente.Cedula = txtCedula.Text.Trim()
            cliente.Nombre = txtNombre.Text.Trim()
            cliente.Apellido = txtApellido.Text.Trim()
            cliente.Direccion = txtDireccion.Text.Trim()
            cliente.Celular = txtCelular.Text.Trim()
            cliente.Correo = txtCorreo.Text.Trim()
            cliente.Sexo = If(rbMasculino.Checked, "M"c, "F"c)
            cliente.Estatus = If(rbActivo.Checked, "A"c, "I"c)

            ' Intentar agregar al cliente
            cliente.AgregarCliente()
            MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar campos y actualizar vista en el formulario padre
            LimpiarCampos()
            If TypeOf _formPadre Is VistaCliente Then
                DirectCast(_formPadre, VistaCliente).MostrarDataGridView()
                DirectCast(_formPadre, VistaCliente).ActualizarVista()
            End If

        Catch ex As Exception
            ' Manejar cualquier error
            MessageBox.Show($"Error al agregar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Método para validar los datos ingresados
    Private Function ValidarDatos() As Boolean
        If String.IsNullOrWhiteSpace(txtCedula.Text) OrElse txtCedula.Text.Length > 15 Then
            MostrarError("La cédula no puede estar vacía y debe tener un máximo de 15 caracteres.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse txtNombre.Text.Length > 30 Then
            MostrarError("El nombre no puede estar vacío y debe tener un máximo de 30 caracteres.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtApellido.Text) OrElse txtApellido.Text.Length > 30 Then
            MostrarError("El apellido no puede estar vacío y debe tener un máximo de 30 caracteres.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtDireccion.Text) OrElse txtDireccion.Text.Length > 50 Then
            MostrarError("La dirección no puede estar vacía y debe tener un máximo de 50 caracteres.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCelular.Text) OrElse txtCelular.Text.Length <> 9 OrElse Not txtCelular.Text Like "####-####" Then
            MostrarError("El celular debe tener el formato 9999-9999 y no puede estar vacío.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCorreo.Text) OrElse txtCorreo.Text.Length > 50 OrElse Not txtCorreo.Text.Contains("@") Then
            MostrarError("El correo no puede estar vacío, debe tener un máximo de 50 caracteres y ser válido.")
            Return False
        End If

        If Not (rbMasculino.Checked OrElse rbFemenino.Checked) Then
            MostrarError("Debes seleccionar el sexo (Masculino/Femenino).")
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
        txtCedula.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDireccion.Clear()
        txtCelular.Clear()
        txtCorreo.Clear()
        rbMasculino.Checked = False
        rbFemenino.Checked = False
        rbActivo.Checked = False
        rbInactivo.Checked = False
    End Sub
End Class
