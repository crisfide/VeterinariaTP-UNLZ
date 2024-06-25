Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class FormularioAltaAnimales



    ' Select Case a.Nombre_Animal, a.Peso_Animal, a.Edad_Animal, c.nombreCliente, e.Nombre_Especie 
    'FROM Animales As a
    'JOIN Clientes As c On a.ID_Cliente = c.Id_Cliente
    'JOIN Especies As e On a.ID_Especie = e.ID_Especie





    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadClientNames()
        'LoadEspeciesName()
    End Sub


    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"


    Private Sub LoadEspeciesName()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT Id_Especie,Nombre_Especie FROM Especies"

            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table2 As New DataTable()
            adapter.Fill(table2)
            ComboBoxEspecie.DataSource = table2
            ComboBoxEspecie.DisplayMember = "Nombre_Especie"
            ComboBoxEspecie.ValueMember = "Id_Especie"

        End Using
    End Sub





    Private Sub LoadClientNames()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT Id_Cliente,nombreCliente FROM Clientes"

            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            ComboBoxClientes.DataSource = table
            ComboBoxClientes.DisplayMember = "nombreCliente"
            ComboBoxClientes.ValueMember = "Id_Cliente"

        End Using
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Nombre_Animal As String = TextBox1.Text
        Dim PesoStr As String = TextBox2.Text
        Dim Peso_Animal As Integer
        Dim EdadStr As String = TextBox3.Text
        Dim Edad_Animal As Integer

        Dim ID_Cliente As Integer
        ' Dim IDEspecieStr As String = TextBox5.Text
        Dim ID_Especie As Integer


        Dim mensaje

        If Nombre_Animal = "" Or EdadStr = "" Or PesoStr = "" Then

            mensaje = "Error, Carga nuevamente"

        Else

            Integer.TryParse(EdadStr, Edad_Animal)

            Integer.TryParse(PesoStr, Peso_Animal)

            'Integer.TryParse(IDClienteStr, ID_Cliente)

            ' Integer.TryParse(IDEspecieStr, ID_Especie)




            If ComboBoxClientes.SelectedItem IsNot Nothing Then
                ID_Cliente = CInt(ComboBoxClientes.SelectedValue)
                ' Dim nombre As String = ComboBoxClientes.Text
                '   MessageBox.Show("Cliente seleccionado: " & nombre & " Edad: " & edad)
            Else
                MessageBox.Show("Por favor, selecciona un cliente.")
            End If


            If ComboBoxEspecie.SelectedItem IsNot Nothing Then
                ID_Especie = CInt(ComboBoxEspecie.SelectedValue)
                ' Dim nombre As String = ComboBoxClientes.Text
                '   MessageBox.Show("Cliente seleccionado: " & nombre & " Edad: " & edad)
            Else
                MessageBox.Show("Por favor, selecciona una especie.")
            End If







            Dim connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

            Dim query As String = "INSERT INTO Animales (Nombre_Animal, Edad_Animal, Peso_Animal, ID_Cliente, ID_Especie) VALUES (@Nombre_Animal, @Edad_Animal ,@Peso_Animal,@ID_Cliente,@ID_Especie)"


            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@Nombre_Animal", Nombre_Animal)
                    command.Parameters.AddWithValue("@Edad_Animal", Edad_Animal)
                    command.Parameters.AddWithValue("@Peso_Animal", Peso_Animal)
                    command.Parameters.AddWithValue("@ID_Cliente", ID_Cliente)
                    command.Parameters.AddWithValue("@ID_Especie", ID_Especie)



                    connection.Open()

                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If result Then
                        MsgBox("Error en el Alta del Animal :(")

                    Else
                        MsgBox("Alta del Animal Exitosa!!!")
                        Me.Close()
                    End If


                End Using
            End Using

        End If


        Label5.Text = mensaje
        Label5.Visible = True




    End Sub
End Class