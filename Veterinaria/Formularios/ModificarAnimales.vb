Imports System.Data.SqlClient
Public Class ModificarAnimales

    Private valor As Integer

    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadAnimalesName()
    End Sub

    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"



    Private Sub LoadAnimalesName()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT ID_Animal,Nombre_Animal FROM Animales"

            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table2 As New DataTable()
            adapter.Fill(table2)

            ComboBox1.DataSource = table2
            ComboBox1.DisplayMember = "Nombre_Animal"
            ComboBox1.ValueMember = "ID_Animal"

        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedValue IsNot Nothing Then
            'Dim valor As Integer  -> la declaro global
            Dim valorS As String = ComboBox1.SelectedValue.ToString()

            Integer.TryParse(valorS, valor)
            'MsgBox("ComboBox1.SelectedValue.ToString():  " & valor)

            Dim ID_Animal As Integer = valor
            MostrarDetallesAnimal(ID_Animal)
        End If

    End Sub

    Private Sub MostrarDetallesAnimal(ID_Animal As Integer)

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT Nombre_Animal, Edad_Animal, Peso_Animal, ID_Cliente,ID_Especie FROM Animales WHERE ID_Animal = @ID_Animal"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID_Animal", ID_Animal)

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    TextBox1.Text = reader("Nombre_Animal").ToString()
                    TextBox2.Text = reader("Edad_Animal").ToString()
                    TextBox3.Text = reader("Peso_Animal").ToString()
                    TextBox4.Text = reader("ID_Cliente").ToString()
                    TextBox5.Text = reader("ID_Especie").ToString()

                End If
            End Using
        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ID_Animal As Integer = valor
        Dim Nombre_Animal As String = TextBox1.Text

        Dim Edad_Animal As Integer ' = CInt(TextBox2.Text)
        Dim Peso_Animal As Decimal ' = CDec(TextBox3.Text)
        Dim ID_Cliente As Integer
        Dim ID_Especie As Integer

        If Not Integer.TryParse(TextBox2.Text, Edad_Animal) Then
            MessageBox.Show("Por favor, ingrese un número válido para Edad del animal.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Salir del evento si la conversión falla
        End If

        ' Validar Peso_Promedio
        If Not Decimal.TryParse(TextBox3.Text, Peso_Animal) Then
            MessageBox.Show("Por favor, ingrese un número válido para Peso del animal.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Salir del evento si la conversión falla
        End If

        If Not Integer.TryParse(TextBox4.Text, ID_Cliente) Then
            MessageBox.Show("Por favor, ingrese un número válido para ID del Cliente.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Salir del evento si la conversión falla
        End If

        If Not Integer.TryParse(TextBox5.Text, ID_Especie) Then
            MessageBox.Show("Por favor, ingrese un número válido para ID del Cliente.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Salir del evento si la conversión falla
        End If



        Edad_Animal = CInt(TextBox2.Text)
        Peso_Animal = CDec(TextBox3.Text)
        ID_Cliente = CInt(TextBox4.Text)
        ID_Especie = CDec(TextBox5.Text)







        ActualizarAnimal(ID_Animal, Nombre_Animal, Edad_Animal, Peso_Animal, ID_Cliente, ID_Especie)


    End Sub

    Private Sub ActualizarAnimal(ID_Animal As Integer, Nombre_Animal As String, Edad_Animal As Integer, Peso_Animal As Decimal, ID_Cliente As Integer, ID_Especie As Integer)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "UPDATE Animales SET Nombre_Animal = @Nombre_Animal, Edad_Animal = @Edad_Animal, Peso_Animal = @Peso_Animal, ID_Cliente = @ID_Cliente, ID_Especie = @ID_Especie WHERE ID_Animal = @ID_Animal"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID_Animal", ID_Animal)
            command.Parameters.AddWithValue("@Nombre_Animal", Nombre_Animal)
            command.Parameters.AddWithValue("@Edad_Animal", Edad_Animal)
            command.Parameters.AddWithValue("@Peso_Animal", Peso_Animal)
            command.Parameters.AddWithValue("@ID_Cliente", ID_Cliente)
            command.Parameters.AddWithValue("@ID_Especie", ID_Especie)


            Try
                command.ExecuteNonQuery()
                MessageBox.Show("Animal actualizado correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


End Class