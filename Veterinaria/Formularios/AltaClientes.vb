Imports System.Data.SqlClient

Public Class AltaClientes



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim nombreCliente As String = TextBox1.Text
        Dim dniClienteStr As String = TextBox2.Text
        Dim dniCliente As Integer
        Dim mensaje


        If nombreCliente = "" Or dniClienteStr = "" Then

            mensaje = "Error, Carga el nombre y dni del cliente"

        Else


            Integer.TryParse(dniClienteStr, dniCliente)



            Dim connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

            Dim query As String = "INSERT INTO Clientes (nombreCliente, dniCliente) VALUES (@nombreCliente, @dniCliente)"


            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@nombreCliente", nombreCliente)
                    command.Parameters.AddWithValue("@dniCliente", dniCliente)

                    connection.Open()

                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If result Then
                        MsgBox("Error en el Alta del Cliente :(")

                    Else
                        MsgBox("Alta del Cliente Exitosa!!!")
                        Me.Close()
                    End If




                End Using
            End Using





        End If


        Label4.Text = mensaje
        Label4.Visible = True


    End Sub
End Class