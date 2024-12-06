Public Class Producto
    ' Propiedades que representan los atributos de un producto
    Public Property CodigoBarra As String
    Public Property Descripcion As String
    Public Property Costo As Decimal
    Public Property Precio As Decimal
    Public Property Itbms As Decimal
    Public Property Existencia As Integer
    Public Property PuntoDeReorden As Integer
    Public Property Estatus As Char

    ' Instancia de la clase BD para realizar operaciones en la base de datos
    Private db As New BD()

    ' Método para buscar un producto por código de barra
    Public Function BuscarProducto() As DataTable
        ' Crear un diccionario de parámetros para el procedimiento almacenado
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@p_CodigoBarra", CodigoBarra} ' Agregar el código de barra como parámetro
        }
        ' Ejecutar el procedimiento almacenado y devolver el resultado
        Return db.ExecuteProcedureWithResult("sp_Producto_BuscarPorCodigo", parameters)
    End Function

    ' Método para agregar un producto a la base de datos
    Public Sub AgregarProducto()
        ' Crear un diccionario de parámetros para el procedimiento almacenado
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@p_CodigoBarra", CodigoBarra},
            {"@p_Descripcion", Descripcion},
            {"@p_Costo", Costo},
            {"@p_Precio", Precio},
            {"@p_ITBMS", Itbms},
            {"@p_Existencia", Existencia},
            {"@p_PuntoDeReorden", PuntoDeReorden},
            {"@p_Estatus", Estatus}
        }
        ' Ejecutar el procedimiento almacenado para agregar el producto
        db.ExecuteProcedureWithParams("sp_Producto_Insertar", parameters)
    End Sub

    ' Método para modificar un producto existente en la base de datos
    Public Sub ModificarProducto()
        ' Crear un diccionario de parámetros para el procedimiento almacenado
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@p_CodigoBarra", CodigoBarra},
            {"@p_Descripcion", Descripcion},
            {"@p_Costo", Costo},
            {"@p_Precio", Precio},
            {"@p_ITBMS", Itbms},
            {"@p_Existencia", Existencia},
            {"@p_PuntoDeReorden", PuntoDeReorden},
            {"@p_Estatus", Estatus}
        }
        ' Ejecutar el procedimiento almacenado para modificar el producto
        db.ExecuteProcedureWithParams("sp_Producto_Modificar", parameters)
    End Sub

    ' Método para eliminar un producto de la base de datos
    Public Sub EliminarProducto()
        ' Crear un diccionario de parámetros para el procedimiento almacenado
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@p_CodigoBarra", CodigoBarra} ' Agregar el código de barra como parámetro
        }
        ' Ejecutar el procedimiento almacenado para eliminar el producto
        db.ExecuteProcedureWithParams("sp_Producto_Eliminar", parameters)
    End Sub

    ' Método para listar productos, permitiendo ordenar por un criterio específico
    Public Function ListarProductos(ordenarPor As String) As DataTable
        ' Crear un diccionario de parámetros para el procedimiento almacenado
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@p_OrderByField", ordenarPor} ' Agregar el criterio de ordenamiento como parámetro
        }
        ' Ejecutar el procedimiento almacenado y devolver el resultado
        Return db.ExecuteProcedureWithResult("sp_Producto_Listar", parameters)
    End Function
End Class
