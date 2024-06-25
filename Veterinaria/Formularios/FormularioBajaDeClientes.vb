Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Reflection.Emit


Public Class FormularioBajaDeClientes

    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClientNames()

    End Sub

    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

    Private Sub LoadClientNames()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT Id_Cliente,nombreCliente FROM Clientes"

            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            ComboBox1.DataSource = table
            ComboBox1.DisplayMember = "nombreCliente"
            ComboBox1.ValueMember = "Id_Cliente"






        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ID_Cliente As Integer


        If ComboBox1.SelectedItem IsNot Nothing Then
            ID_Cliente = CInt(ComboBox1.SelectedValue)

            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Estas seguro de Borrar el Cliente seleccionado?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirmación")
            If respuesta = MsgBoxResult.Yes Then
                BorrarCliente(ID_Cliente)
            End If




        Else
            MessageBox.Show("Por favor, selecciona un cliente.")
        End If

    End Sub


    Private Sub BorrarCliente(ID_Cliente)


        Dim connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

        Dim query As String = "DELETE FROM CLIENTES WHERE ID_Cliente = @ID_Cliente"


        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@ID_Cliente", ID_Cliente)
                connection.Open()

                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                If result Then
                    MsgBox("Error en la baja de Cliente :(")

                Else
                    MsgBox("Baja del Cliente Exitosa!!!")
                    Me.Close()
                End If

            End Using
        End Using

    End Sub

End Class