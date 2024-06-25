Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Reflection.Emit

Public Class FormularioBajaDeUsuarios

    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsuariosNames()

    End Sub

    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

    Private Sub LoadUsuariosNames()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT ID_Usuarios,Nombre_Usuario FROM Usuarios"

            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            ComboBox1.DataSource = table
            ComboBox1.DisplayMember = "Nombre_Usuario"
            ComboBox1.ValueMember = "ID_Usuarios"






        End Using
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ID_Usuarios As Integer


        If ComboBox1.SelectedItem IsNot Nothing Then
            ID_Usuarios = CInt(ComboBox1.SelectedValue)

            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Estas seguro de Borrar el usuario seleccionado?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirmación")
            If respuesta = MsgBoxResult.Yes Then
                BorrarUsuario(ID_Usuarios)
            End If


        Else
                MessageBox.Show("Por favor, selecciona un Usuario")
        End If

    End Sub


    Private Sub BorrarUsuario(ID_Usuarios)


        Dim connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

        Dim query As String = "DELETE FROM USUARIOS WHERE ID_Usuarios = @ID_Usuarios"


        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@ID_Usuarios", ID_Usuarios)
                connection.Open()

                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                If result Then
                    MsgBox("Error en la baja del usuario :(")

                Else
                    MsgBox("Baja del usuario Exitosa!!!")
                    Me.Close()
                End If

            End Using
        End Using

    End Sub

End Class