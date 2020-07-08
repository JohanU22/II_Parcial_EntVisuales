Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Conexion
    Public Conexion As SqlConnection = New SqlConnection("Data source= LAPTOP-GK4VNBDO\SQLEXPRESS ;Initial catalog=Tienda1; Integrated security=true")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")

        Catch ex As Exception
            MessageBox.Show("error al Conectado")
        Finally
            conexion.Close()

        End Try
    End Sub

    Function insertar(ByVal sql)
        Conexion.Open()
        comando = New SqlCommand(sql, Conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Sub consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, Conexion)
        cmb = New SqlCommandBuilder(da)

        da.Fill(ds, tabla)


    End Sub

    Function actualizar(sql As String)
        Conexion.Close()
        Conexion.Open()
        comando = New SqlCommand(sql, Conexion)

        Dim i As Integer = comando.ExecuteNonQuery()
        Conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False

        End If
    End Function

    Function eliminar(ByVal tabla, ByVal condicion)
        Try
            Conexion.Open()
            Dim elimina As String = "delete from " + tabla + " where " + condicion
            comando = New SqlCommand(elimina, Conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            Conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MessageBox.Show("Elimine primero el empleado")
        End Try

    End Function

End Class
