Imports System.Data.SqlClient
Imports entidad
Public Class fusuario

    Inherits conexion

    Public Function validarusuario(ByVal dts As eusuario) As DataTable

        conectado()
        cmd = New SqlCommand("_iniciosesion")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnn

        cmd.Parameters.AddWithValue("@usuario", dts._usuario)
        cmd.Parameters.AddWithValue("@contrasena", dts._contrasena)

        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Else
            Return Nothing
        End If
    End Function
End Class
