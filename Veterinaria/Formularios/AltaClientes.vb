Imports System.Data.SqlClient
Imports Servicios.DAO
Imports Servicios.Modelos

Public Class AltaClientes



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim nombreCliente As String = TextBox1.Text
        Dim dniClienteStr As String = TextBox2.Text
        Dim dniCliente As Integer
        Dim mensaje


        If nombreCliente = "" Or dniClienteStr = "" Then

            Me.Label5.Text = "Error, Carga el nombre y dni del cliente"

        Else

            Integer.TryParse(dniClienteStr, dniCliente)

            If dniCliente <= 0 Then
                MsgBox("Ingrese DNI correctamente")
                Return
            End If


            Dim daoC As New DAOClientes
            Dim cliente As New Cliente(nombreCliente, dniCliente)
            Dim result As Boolean
            Try
                result = daoC.Insert(cliente)
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

            'Dim query As String = "INSERT INTO Clientes (nombreCliente, dniCliente) VALUES (@nombreCliente, @dniCliente)"


            'Using connection As New SqlConnection(connectionString)
            '    Using command As New SqlCommand(query, connection)

            '        command.Parameters.AddWithValue("@nombreCliente", nombreCliente)
            '        command.Parameters.AddWithValue("@dniCliente", dniCliente)

            '        connection.Open()

            '        Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            '        If result Then
            '            MsgBox("Error en el Alta del Cliente :(")

            '        Else
            '            MsgBox("Alta del Cliente Exitosa!!!")
            '            Me.Close()
            '        End If




            '    End Using
            'End Using





        End If


        Label5.Text = mensaje
        Label5.Visible = True


    End Sub

    Private Sub AltaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class