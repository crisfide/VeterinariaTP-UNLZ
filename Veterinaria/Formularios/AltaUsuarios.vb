Imports System.Data.SqlClient

Public Class AltaUsuarios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Nombre_Usuario As String = TextBox1.Text

        Dim mensaje

        If Nombre_Usuario = "" Then
            mensaje = "Error, Carga el nombre del usuario"
        Else

            Dim connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

            Dim query As String = "INSERT INTO Usuarios (Nombre_Usuario) VALUES (@Nombre_Usuario)"


            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@Nombre_Usuario", Nombre_Usuario)
                    connection.Open()

                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If Result Then
                        MsgBox("Error en el Alta del Usuario :(")

                    Else
                        MsgBox("Al iniciar nuevamente coloque su nombre y la contraseña que va a tener y se registrara su usuario")
                        Me.Close()
                    End If



                End Using
            End Using


        End If

    End Sub
End Class