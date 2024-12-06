Imports MySql.Data.MySqlClient


Public Class BD
    Private conexion As String = "server=localhost;database=admin_productos;user id=root;password="

    ' Método para obtener una conexión a la base de datos
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(conexion)
    End Function

    ' Método para ejecutar procedimientos almacenados sin parámetros
    Public Sub ExecuteProcedure(procedureName As String)
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(procedureName, conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Método para ejecutar procedimientos almacenados con parámetros
    Public Sub ExecuteProcedureWithParams(procedureName As String, parameters As Dictionary(Of String, Object))
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(procedureName, conn)
                cmd.CommandType = CommandType.StoredProcedure
                For Each param In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Método para obtener resultados de procedimientos almacenados
    Public Function ExecuteProcedureWithResult(procedureName As String, parameters As Dictionary(Of String, Object)) As DataTable
        Dim result As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(procedureName, conn)
                cmd.CommandType = CommandType.StoredProcedure
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        Return result
    End Function

    ' Método para ejecutar consultas SQL directas (evitar en producción, usar procedimientos almacenados)
    Public Function ExecuteQuery(query As String) As DataTable
        Dim result As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    result.Load(reader)
                End Using
            End Using
        End Using
        Return result
    End Function
End Class
