Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Reflection.Emit

Public Class FormularioBajaEspecies


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

            table2.Columns.Add("DisplayColumn", GetType(String), "CONVERT(Id_Especie, System.String) + ' - ' + Nombre_Especie")

            ComboBox1.DataSource = table2
            ComboBox1.DisplayMember = "DisplayColumn"
            ComboBox1.ValueMember = "Id_Especie"

        End Using
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ID_Especie As Integer


        If ComboBox1.SelectedItem IsNot Nothing Then
            ID_Especie = CInt(ComboBox1.SelectedValue)

            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Estas seguro de Borrar la especie seleccionada?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirmación")
            If respuesta = MsgBoxResult.Yes Then
                BorrarEspecie(ID_Especie)
            End If





        Else
            MessageBox.Show("Por favor, selecciona una especie.")
        End If



    End Sub




    Private Sub BorrarEspecie(ID_Especie As Integer)


        Dim connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

        Dim query As String = "DELETE FROM ESPECIES WHERE ID_Especie = @ID_Especie"


        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@ID_Especie", ID_Especie)
                connection.Open()

                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                If result Then
                    MsgBox("Error en la baja de Especie :(")

                Else
                    MsgBox("Baja de la especie Exitosa!!!")
                    Me.Close()
                End If



            End Using
        End Using




    End Sub


End Class