Public Class Cliente
    Public Property Id As Integer ' Se incluye Id para identificar al cliente en modificaciones

    Public Property Cedula As String
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Direccion As String
    Public Property Celular As String
    Public Property Correo As String
    Public Property Sexo As Char
    Public Property Estatus As Char

    Private db As New BD()

    ' Método para buscar un cliente por cédula
    Public Function BuscarCliente() As DataTable
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@p_Cedula", Cedula}
        }
        Return db.ExecuteProcedureWithResult("sp_Cliente_BuscarPorCedula", parameters)
    End Function

    ' Método para agregar un cliente
    Public Sub AgregarCliente()
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@p_Cedula", Cedula},
            {"@p_Nombre", Nombre},
            {"@p_Apellido", Apellido},
            {"@p_Direccion", Direccion},
            {"@p_Celular", Celular},
            {"@p_Correo", Correo},
            {"@p_Sexo", Sexo},
            {"@p_Estatus", Estatus}
        }
        db.ExecuteProcedureWithParams("sp_Cliente_Insertar", parameters)
    End Sub

    ' Método para modificar un cliente
    Public Sub ModificarCliente()
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@p_Id", Id}, ' Usa el Id como clave primaria para identificar al cliente
            {"@p_Nombre", Nombre},
            {"@p_Apellido", Apellido},
            {"@p_Direccion", Direccion},
            {"@p_Celular", Celular},
            {"@p_Correo", Correo},
            {"@p_Sexo", Sexo},
            {"@p_Estatus", Estatus}
        }
        db.ExecuteProcedureWithParams("sp_Cliente_Modificar", parameters)
    End Sub

    ' Método para eliminar un cliente por Id
    Public Sub EliminarCliente()
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@p_Id", Id} ' Usa el Id como clave primaria
        }
        db.ExecuteProcedureWithParams("sp_Cliente_Eliminar", parameters)
    End Sub

    ' Método para listar clientes ordenados
    Public Function ListarClientes(ordenarPor As String) As DataTable
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@p_OrderByField", ordenarPor} ' El parámetro coincide con el definido en sp_Cliente_Listar
        }
        Return db.ExecuteProcedureWithResult("sp_Cliente_Listar", parameters)
    End Function
End Class

