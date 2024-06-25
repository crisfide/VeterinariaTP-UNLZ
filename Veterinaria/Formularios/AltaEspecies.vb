Imports System.Data.SqlClient
Imports Servicios.DAO
Imports Servicios.Modelos

Public Class AltaEspecies


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Nombre_Especie As String = TextBox1.Text
        Dim EdadMadurezStr As String = TextBox2.Text
        Dim Edad_Madurez As Integer
        Dim PesoPromedioStr As String = TextBox3.Text
        Dim Peso_Promedio As Decimal

        Dim mensaje


        If Nombre_Especie = "" Or EdadMadurezStr = "" Or PesoPromedioStr = "" Then

            Label5.Text = "Error, Carga la edad y el peso"

        Else


            Integer.TryParse(EdadMadurezStr, Edad_Madurez)

            Decimal.TryParse(PesoPromedioStr, Peso_Promedio)

            If Edad_Madurez <= 0 Or Peso_Promedio <= 0 Then
                MsgBox("Ingrese la edad y el peso correctamente")
                Return
            End If


            Dim daoE As New DAOEspecies
            Dim especie As New Especie(Nombre_Especie, Edad_Madurez, Peso_Promedio)
            Dim result As Boolean
            Try
                result = daoE.Insert(especie)
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

            'Dim query As String = "INSERT INTO Especies (Nombre_Especie, Edad_Madurez, Peso_Promedio) VALUES (@Nombre_Especie, @Edad_Madurez ,@Peso_Promedio)"


            'Using connection As New SqlConnection(connectionString)
            '    Using command As New SqlCommand(query, connection)

            '        command.Parameters.AddWithValue("@Nombre_Especie", Nombre_Especie)
            '        command.Parameters.AddWithValue("@Edad_Madurez", Edad_Madurez)
            '        command.Parameters.AddWithValue("@Peso_Promedio", Peso_Promedio)


            '        connection.Open()

            '        Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            '        If result Then
            '            MsgBox("Error en el Alta de la Especie :(")

            '        Else
            '            MsgBox("Alta de la Especie Exitosa!!!")
            '            Me.Close()
            '        End If




            '    End Using
            'End Using


        End If

        Label5.Text = mensaje
        Label5.Visible = True

    End Sub
End Class