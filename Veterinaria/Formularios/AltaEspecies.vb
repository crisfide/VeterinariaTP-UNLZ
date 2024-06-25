Imports System.Data.SqlClient

Public Class AltaEspecies


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Nombre_Especie As String = TextBox1.Text
        Dim EdadMadurezStr As String = TextBox2.Text
        Dim Edad_Madurez As Integer
        Dim PesoPromedioStr As String = TextBox3.Text
        Dim Peso_Promedio As Integer

        Dim mensaje


        If Nombre_Especie = "" Or EdadMadurezStr = "" Or PesoPromedioStr = "" Then

            mensaje = "Error, Carga la edad y el peso del cliente"

        Else


            Integer.TryParse(EdadMadurezStr, Edad_Madurez)

            Integer.TryParse(PesoPromedioStr, Peso_Promedio)



            Dim connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

            Dim query As String = "INSERT INTO Especies (Nombre_Especie, Edad_Madurez, Peso_Promedio) VALUES (@Nombre_Especie, @Edad_Madurez ,@Peso_Promedio)"


            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@Nombre_Especie", Nombre_Especie)
                    command.Parameters.AddWithValue("@Edad_Madurez", Edad_Madurez)
                    command.Parameters.AddWithValue("@Peso_Promedio", Peso_Promedio)


                    connection.Open()

                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If result Then
                        MsgBox("Error en el Alta de la Especie :(")

                    Else
                        MsgBox("Alta de la Especie Exitosa!!!")
                        Me.Close()
                    End If




                End Using
            End Using


        End If

        Label5.Text = mensaje
        Label5.Visible = True

    End Sub
End Class