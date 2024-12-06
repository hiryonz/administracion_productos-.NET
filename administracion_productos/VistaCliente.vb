Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class VistaCliente
    Private cliente As New Cliente() ' Instancia de la clase Cliente
    Private Property orderBy As String

    Private Sub VistaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarOrden()
        BtnListarCliente_Click(sender, e)
        MostrarDataGridView()
        ' Deshabilitar botones al inicio
        BtnModificarCliente.Enabled = False
        BtnEliminarCliente.Enabled = False
        BtnLimpiarCliente.Enabled = True ' Siempre habilitado
        BtnBuscarCliente.Enabled = True ' Siempre habilitado
        BtnAdiccionarCliente.Enabled = True ' Siempre habilitado
    End Sub

    Private Sub ActualizarOrden()
        If rbCedula.Checked Then
            orderBy = "Cedula"
        ElseIf rbNombre.Checked Then
            orderBy = "Nombre"
        Else
            orderBy = "Cedula" ' Valor predeterminado
        End If
    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        MostrarDataGridView()
        Dim valor As String = searchCliente.Text.Trim() ' Trim para eliminar espacios en blanco

        If String.IsNullOrEmpty(valor) Then
            MessageBox.Show("El campo está vacío.")
            Return ' Salir si el campo está vacío
        End If

        cliente.Cedula = valor
        Dim dt As DataTable = cliente.BuscarCliente()
        If dt.Rows.Count > 0 Then
            ' Limpiar el DataGridView
            DataGridViewCliente.DataSource = Nothing
            DataGridViewCliente.Rows.Clear() ' Limpiar filas si existen

            ' Definir las columnas si no están definidas
            If DataGridViewCliente.Columns.Count = 0 Then
                DataGridViewCliente.Columns.Add("Id", "Id")
                DataGridViewCliente.Columns.Add("Cedula", "Cédula")
                DataGridViewCliente.Columns.Add("Nombre", "Nombre")
                DataGridViewCliente.Columns.Add("Apellido", "Apellido")
                DataGridViewCliente.Columns.Add("Direccion", "Dirección")
                DataGridViewCliente.Columns.Add("Celular", "Celular")
                DataGridViewCliente.Columns.Add("Correo", "Correo")
                DataGridViewCliente.Columns.Add("Sexo", "Sexo")
                DataGridViewCliente.Columns.Add("Estatus", "Estatus")
            End If

            ' Agregar la fila del cliente encontrado al DataGridView
            Dim row As String() = New String() {
                dt.Rows(0)("Id").ToString(),
                dt.Rows(0)("Cedula").ToString(),
                dt.Rows(0)("Nombre").ToString(),
                dt.Rows(0)("Apellido").ToString(),
                dt.Rows(0)("Direccion").ToString(),
                dt.Rows(0)("Celular").ToString(),
                dt.Rows(0)("Correo").ToString(),
                dt.Rows(0)("Sexo").ToString(),
                dt.Rows(0)("Estatus").ToString()
            }
            DataGridViewCliente.Rows.Add(row) ' Agregar la fila al DataGridView

            ' Habilitar botones de modificar y eliminar
            BtnModificarCliente.Enabled = True
            BtnEliminarCliente.Enabled = True
            BtnBuscarCliente.Enabled = False ' Deshabilitar botón de buscar
            BtnAdiccionarCliente.Enabled = False ' Deshabilitar botón de agregar
        Else
            MessageBox.Show("Cliente no encontrado.")
            ' Habilitar botones de agregar y limpiar
            BtnAdiccionarCliente.Enabled = True
            BtnLimpiarCliente.Enabled = True
            BtnModificarCliente.Enabled = False
            BtnEliminarCliente.Enabled = False
        End If

        ' Limpiar el TextBox de búsqueda
        searchCliente.Text = ""
    End Sub

    Private Sub BtnLimpiarCliente_Click(sender As Object, e As EventArgs) Handles BtnLimpiarCliente.Click
        MostrarDataGridView()

        Try
            DataGridViewCliente.DataSource = Nothing ' Limpiar el DataGridView
            DataGridViewCliente.Rows.Clear() ' Limpiar filas si existen
            DataGridViewCliente.Columns.Clear() ' Limpiar columnas si existen
        Catch ex As Exception

        End Try
        searchCliente.Text = "" ' Limpiar el TextBox ' Deshabilitar botones de modificar y eliminar

        BtnModificarCliente.Enabled = False
        BtnEliminarCliente.Enabled = False
        BtnAdiccionarCliente.Enabled = True ' Habilitar botón de agregar
        BtnBuscarCliente.Enabled = True ' Habilitar botón de buscar
    End Sub

    Private Sub BtnListarCliente_Click(sender As Object, e As EventArgs) Handles BtnListarCliente.Click
        MostrarDataGridView()
        DataGridViewCliente.Columns.Clear()
        Dim dt As DataTable = cliente.ListarClientes(orderBy)
        DataGridViewCliente.DataSource = dt ' Usar DataGridViewCliente

        ' Habilitar el botón de limpiar
        BtnLimpiarCliente.Enabled = True
    End Sub

    Private Sub BtnEliminarCliente_Click(sender As Object, e As EventArgs) Handles BtnEliminarCliente.Click
        ' Verificar si hay una fila seleccionada
        If DataGridViewCliente.SelectedRows.Count > 0 Then
            ' Obtener el índice de la fila seleccionada
            Dim selectedRow As DataGridViewRow = DataGridViewCliente.SelectedRows(0)

            ' Obtener la cédula del cliente de la fila seleccionada
            Dim cedula As String = selectedRow.Cells("Cedula").Value.ToString()

            ' Asignar la cédula a la propiedad del objeto cliente
            cliente.Cedula = cedula

            ' Llamar al método para eliminar el cliente
            cliente.EliminarCliente()

            ' Mostrar mensaje de éxito
            MessageBox.Show("Cliente eliminado correctamente.")

            ' Actualizar el DataGridView
            BtnListarCliente_Click(sender, e)
        Else
            MessageBox.Show("Por favor, seleccione un cliente para eliminar.")
        End If
    End Sub

    Private Sub BtnModificarCliente_Click(sender As Object, e As EventArgs) Handles BtnModificarCliente.Click
        ' Verificar si hay una fila seleccionada
        If DataGridViewCliente.SelectedRows.Count > 0 Then
            ' Obtener el índice de la fila seleccionada
            Dim selectedRow As DataGridViewRow = DataGridViewCliente.SelectedRows(0)

            ' Obtener los valores de la fila seleccionada
            Dim id As String = selectedRow.Cells("Id").Value.ToString()
            Dim cedula As String = selectedRow.Cells("Cedula").Value.ToString()
            Dim nombre As String = selectedRow.Cells("Nombre").Value.ToString()
            Dim apellido As String = selectedRow.Cells("Apellido").Value.ToString()
            Dim celular As String = selectedRow.Cells("Celular").Value.ToString()
            Dim correo As String = selectedRow.Cells("Correo").Value.ToString()
            Dim sexo As Char = selectedRow.Cells("Sexo").Value.ToString().First() ' Asumiendo que Sexo es un solo carácter
            Dim direccion As String = selectedRow.Cells("Direccion").Value.ToString()
            Dim estatus As Char = selectedRow.Cells("Estatus").Value.ToString().First() ' Asumiendo que Estatus es un solo carácter



            ' Asignar los valores al objeto cliente
            cliente.Id = id
            cliente.Cedula = cedula
            cliente.Nombre = nombre
            cliente.Apellido = apellido
            cliente.Celular = celular
            cliente.Correo = correo
            cliente.Sexo = sexo
            cliente.Direccion = direccion
            cliente.Estatus = estatus

            ' Llamar al método para modificar el cliente
            Try
                cliente.ModificarCliente()
                ' Mostrar mensaje de éxito
                MessageBox.Show("Cliente modificado correctamente.")
                ' Actualizar el DataGridView
                BtnListarCliente_Click(sender, e)
            Catch ex As Exception
                MessageBox.Show("Error al modificar el cliente: " & ex.Message)
            End Try
        Else
            ' Si no hay ninguna fila seleccionada, mostrar un mensaje
            MessageBox.Show("Por favor, seleccione un cliente para modificar.")
        End If
    End Sub

    Public Sub MostrarDataGridView()
        DataGridViewCliente.Visible = True
        PanelContenedor.Visible = False
        PanelContenedor.Controls.OfType(Of Form).ToList().ForEach(Sub(f) f.Hide()) ' Ocultar cualquier formulario
    End Sub

    Public Sub ActualizarVista()
        BtnListarCliente.PerformClick()
    End Sub


    Private Sub MostrarFormularioAgregar()
        DataGridViewCliente.Visible = False
        PanelContenedor.Visible = True
        Dim formAgregar As New FormAgregarCliente(Me) ' Pasar referencia del padre
        formAgregar.TopLevel = False ' Hacer que el formulario sea un control hijo
        formAgregar.FormBorderStyle = FormBorderStyle.None ' Quitar bordes del formulario
        formAgregar.Dock = DockStyle.Fill ' Llenar el panel
        PanelContenedor.Controls.Clear() ' Limpiar el panel
        PanelContenedor.Controls.Add(formAgregar) ' Agregar el nuevo formulario al panel
        formAgregar.Show() ' Mostrar el formulario
    End Sub

    Private Sub BtnAdiccionarCliente_Click(sender As Object, e As EventArgs) Handles BtnAdiccionarCliente.Click
        MostrarFormularioAgregar()
    End Sub

    Private Sub rbCedula_CheckedChanged(sender As Object, e As EventArgs) Handles rbCedula.CheckedChanged
        ActualizarOrden()
        BtnListarCliente_Click(sender, e)
    End Sub

    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombre.CheckedChanged
        ActualizarOrden()
        BtnListarCliente_Click(sender, e)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub DataGridViewCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCliente.CellContentClick

    End Sub

    Private Sub DataGridViewCliente_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewCliente.SelectionChanged
        ' Verificar si hay una fila seleccionada
        If DataGridViewCliente.SelectedRows.Count > 0 Then
            ' Activar botones si hay una fila seleccionada
            BtnModificarCliente.Enabled = True
            BtnEliminarCliente.Enabled = True
        Else
            ' Desactivar botones si no hay filas seleccionadas
            BtnModificarCliente.Enabled = False
            BtnEliminarCliente.Enabled = False
        End If
    End Sub
End Class
