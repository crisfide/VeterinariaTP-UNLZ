Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ModificarClientes

    Private valor As Integer

    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadClientesName()
    End Sub

    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"



    Private Sub LoadClientesName()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT Id_Cliente,nombreCliente FROM Clientes"

            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table2 As New DataTable()
            adapter.Fill(table2)

            ComboBox1.DataSource = table2
            ComboBox1.DisplayMember = "nombreCliente"
            ComboBox1.ValueMember = "Id_Cliente"

        End Using
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedValue IsNot Nothing Then
            'Dim valor As Integer  -> la declaro global
            Dim valorS As String = ComboBox1.SelectedValue.ToString()

            Integer.TryParse(valorS, valor)
            'MsgBox("ComboBox1.SelectedValue.ToString():  " & valor)

            Dim ID_Cliente As Integer = valor
            MostrarDetallesCliente(ID_Cliente)
        End If



    End Sub

    Private Sub MostrarDetallesCliente(ID_Cliente As Integer)

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT nombreCliente, dniCliente FROM Clientes WHERE ID_Cliente = @ID_Cliente"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID_Cliente", ID_Cliente)

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    TextBox1.Text = reader("nombreCliente").ToString()
                    TextBox2.Text = reader("dniCliente").ToString()

                End If
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ID_Cliente As Integer = valor
        Dim nombreCliente As String = TextBox1.Text

        Dim dniCliente As Integer ' = CInt(TextBox2.Text)


        If Not Integer.TryParse(TextBox2.Text, dniCliente) Then
            MessageBox.Show("Por favor, ingrese un número válido para DNI Cliente.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Salir del evento si la conversión falla
        End If

        ' Validar Peso_Promedio




        dniCliente = CInt(TextBox2.Text)




        ActualizarCliente(ID_Cliente, nombreCliente, dniCliente)



    End Sub

    Private Sub ActualizarCliente(ID_Cliente As Integer, nombreCliente As String, dniCliente As Integer)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "UPDATE Clientes SET nombreCliente = @nombreCliente, dniCliente = @dniCliente WHERE ID_Cliente = @ID_Cliente"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID_Cliente", ID_Cliente)
            command.Parameters.AddWithValue("@nombreCliente", nombreCliente)
            command.Parameters.AddWithValue("@dniCliente", dniCliente)


            Try
                command.ExecuteNonQuery()
                MessageBox.Show("Cliente actualizado correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


End Class