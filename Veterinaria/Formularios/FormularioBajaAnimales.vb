Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Reflection.Emit


Public Class FormularioBajaAnimales

    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAnimalesNames()

    End Sub


    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

    Private Sub LoadAnimalesNames()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT ID_Animal,Nombre_Animal FROM Animales"

            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            ComboBox1.DataSource = table
            ComboBox1.DisplayMember = "Nombre_Animal"
            ComboBox1.ValueMember = "ID_Animal"






        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim ID_Animal As Integer


        If ComboBox1.SelectedItem IsNot Nothing Then
            ID_Animal = CInt(ComboBox1.SelectedValue)

            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Estas seguro de Borrar el Animal seleccionado?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirmación")
            If respuesta = MsgBoxResult.Yes Then
                BorrarAnimal(ID_Animal)
            End If



        Else
            MessageBox.Show("Por favor, selecciona un Animal.")
        End If
    End Sub

    Private Sub BorrarAnimal(ID_Animal)


        Dim connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

        Dim query As String = "DELETE FROM ANIMALES WHERE ID_Animal = @ID_Animal"


        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@ID_Animal", ID_Animal)
                connection.Open()

                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                If result Then
                    MsgBox("Error en la baja del animal :(")

                Else
                    MsgBox("Baja del animal Exitosa!!!")
                    Me.Close()
                End If

            End Using
        End Using

    End Sub



End Class