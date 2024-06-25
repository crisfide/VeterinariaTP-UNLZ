Imports System.Data.SqlClient
Imports Servicios.DAO
Imports Servicios.Modelos

Public Class AltaUsuarios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Nombre_Usuario As String = TextBox1.Text
        Dim contraseña As String = TextBox2.Text
        Dim mensaje

        If Nombre_Usuario = "" Or contraseña = "" Then
            Label4.Text = "Error, Carga el nombre del usuario y la contraseña"
        Else

            Dim daoU As New DAOUsuarios
            Dim usuario As New Usuario(Nombre_Usuario, contraseña)
            Dim result As Boolean
            Try
                result = daoU.Insert(usuario)
                If result Then
                    MsgBox("Alta Exitosa!!!")
                    Me.Close()
                Else
                    MsgBox("Error en el Alta :(")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'Dim connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

            'Dim query As String = "INSERT INTO Usuarios (Nombre_Usuario) VALUES (@Nombre_Usuario)"


            'Using connection As New SqlConnection(connectionString)
            '    Using command As New SqlCommand(query, connection)

            '        command.Parameters.AddWithValue("@Nombre_Usuario", Nombre_Usuario)
            '        connection.Open()

            '        Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            '        If Result Then
            '            MsgBox("Error en el Alta del Usuario :(")

            '        Else
            '            MsgBox("Al iniciar nuevamente coloque su nombre y la contraseña que va a tener y se registrara su usuario")
            '            Me.Close()
            '        End If



            '    End Using
            'End Using


        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class