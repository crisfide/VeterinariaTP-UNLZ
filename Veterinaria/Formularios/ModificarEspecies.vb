Imports System.Data.SqlClient

Public Class ModificarEspecies

    Private valor As Integer

    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadEspeciesName()
    End Sub

    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"



    Private Sub LoadEspeciesName()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT Id_Especie,Nombre_Especie FROM Especies"

            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table2 As New DataTable()
            adapter.Fill(table2)

            ComboBox1.DataSource = table2
            ComboBox1.DisplayMember = "Nombre_Especie"
            ComboBox1.ValueMember = "Id_Especie"

        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedValue IsNot Nothing Then
            'Dim valor As Integer  -> la declaro global
            Dim valorS As String = ComboBox1.SelectedValue.ToString()

            Integer.TryParse(valorS, valor)
            'MsgBox("ComboBox1.SelectedValue.ToString():  " & valor)

            Dim ID_Especie As Integer = valor
            MostrarDetallesEspecie(ID_Especie)
        End If

    End Sub



    Private Sub MostrarDetallesEspecie(ID_Especie As Integer)

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT Nombre_Especie, Edad_Madurez, Peso_Promedio FROM Especies WHERE Id_Especie = @Id_Especie"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Id_Especie", ID_Especie)

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    TextBox1.Text = reader("Nombre_Especie").ToString()
                    TextBox2.Text = reader("Edad_Madurez").ToString()
                    TextBox3.Text = reader("Peso_Promedio").ToString()
                End If
            End Using
        End Using

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ID_Especie As Integer = valor
        Dim Nombre_Especie As String = TextBox1.Text

        Dim Edad_Madurez As Integer ' = CInt(TextBox2.Text)
        Dim Peso_Promedio As Decimal ' = CDec(TextBox3.Text)

        If Not Integer.TryParse(TextBox2.Text, Edad_Madurez) Then
            MessageBox.Show("Por favor, ingrese un número válido para Edad de Madurez.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Salir del evento si la conversión falla
        End If

        ' Validar Peso_Promedio
        If Not Decimal.TryParse(TextBox3.Text, Peso_Promedio) Then
            MessageBox.Show("Por favor, ingrese un número válido para Peso Promedio.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Salir del evento si la conversión falla
        End If



        Edad_Madurez = CInt(TextBox2.Text)
        Peso_Promedio = CDec(TextBox3.Text)







        ActualizarEspecie(ID_Especie, Nombre_Especie, Edad_Madurez, Peso_Promedio)

    End Sub
    Private Sub ActualizarEspecie(ID_Especie As Integer, Nombre_Especie As String, Edad_Madurez As Integer, Peso_Promedio As Decimal)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "UPDATE Especies SET Nombre_Especie = @Nombre_Especie, Edad_Madurez = @Edad_Madurez, Peso_Promedio = @Peso_Promedio WHERE ID_Especie = @ID_Especie"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID_Especie", ID_Especie)
            command.Parameters.AddWithValue("@Nombre_Especie", Nombre_Especie)
            command.Parameters.AddWithValue("@Edad_Madurez", Edad_Madurez)
            command.Parameters.AddWithValue("@Peso_Promedio", Peso_Promedio)

            Try
                command.ExecuteNonQuery()
                MessageBox.Show("Especie actualizada correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

End Class