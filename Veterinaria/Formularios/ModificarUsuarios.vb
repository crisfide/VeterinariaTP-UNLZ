Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class ModificarUsuarios

    Private valor As Integer

    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadUsuariosName()
    End Sub

    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"


    Private Sub LoadUsuariosName()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT ID_Usuarios,Nombre_Usuario FROM Usuarios"

            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table2 As New DataTable()
            adapter.Fill(table2)

            ComboBox1.DataSource = table2
            ComboBox1.DisplayMember = "Nombre_Usuario"
            ComboBox1.ValueMember = "ID_Usuarios"

        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedValue IsNot Nothing Then
            'Dim valor As Integer  -> la declaro global
            Dim valorS As String = ComboBox1.SelectedValue.ToString()

            Integer.TryParse(valorS, valor)
            'MsgBox("ComboBox1.SelectedValue.ToString():  " & valor)

            Dim ID_Usuarios As Integer = valor
            MostrarDetallesUsuario(ID_Usuarios)
        End If

    End Sub

    Private Sub MostrarDetallesUsuario(ID_Usuarios As Integer)

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT Nombre_Usuario, Contrasenia_Usuario FROM Usuarios WHERE ID_Usuarios = @ID_Usuarios"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID_Usuarios", ID_Usuarios)

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    TextBox1.Text = reader("Nombre_Usuario").ToString()
                    TextBox2.Text = reader("Contrasenia_Usuario").ToString()

                End If
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim ID_Usuarios As Integer = valor
        Dim Nombre_Usuario As String = TextBox1.Text

        Dim Contrasenia_Usuario As String = TextBox2.Text ' = CInt(TextBox2.Text)


        '  If Not Integer.TryParse(TextBox2.Text, Contrasenia_Usuario) Then
        '  MessageBox.Show("Por favor, ingrese un número válido para DNI Cliente.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' Return ' Salir del evento si la conversión falla
        ' End If

        ' Validar Peso_Promedio




        ' Contrasenia_Usuario = CInt(TextBox2.Text)




        ActualizarUsuario(ID_Usuarios, Nombre_Usuario, Contrasenia_Usuario)






    End Sub


    Private Sub ActualizarUsuario(ID_Usuarios As Integer, Nombre_Usuario As String, Contrasenia_Usuario As String)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "UPDATE Usuarios SET Nombre_Usuario = @Nombre_Usuario, Contrasenia_Usuario = @Contrasenia_Usuario WHERE ID_Usuarios = @ID_Usuarios"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID_Usuarios", ID_Usuarios)
            command.Parameters.AddWithValue("@Nombre_Usuario", Nombre_Usuario)
            command.Parameters.AddWithValue("@Contrasenia_Usuario", Contrasenia_Usuario)


            Try
                command.ExecuteNonQuery()
                MessageBox.Show("Usuario actualizado correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Class