Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports Servicios.DAO
Imports Servicios.Modelos

Public Class FormularioAltaAnimales


    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEspeciesName()
        LoadClientNames()
    End Sub


    Private Sub LoadEspeciesName()
        Dim daoE As New DAOEspecies
        Try
            Dim listado As List(Of Especie) = daoE.GetAll()

            ComboBoxEspecie.DataSource = listado
            ComboBoxEspecie.DisplayMember = "nombre"
            ComboBoxEspecie.ValueMember = "id"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub LoadClientNames()
        Dim daoC As New DAOClientes
        Try
            Dim listado As List(Of Cliente) = daoC.GetAll()

            ComboBoxClientes.DataSource = listado
            ComboBoxClientes.DisplayMember = "nombre"
            ComboBoxClientes.ValueMember = "id"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Nombre_Animal As String = TextBox1.Text
        Dim PesoStr As String = TextBox2.Text
        Dim Peso_Animal As Decimal
        Dim EdadStr As String = TextBox3.Text
        Dim Edad_Animal As Integer

        Dim ID_Cliente As Integer
        Dim ID_Especie As Integer

        Dim mensaje As String

        If Nombre_Animal = "" Or EdadStr = "" Or PesoStr = "" Then

            Label5.Text = "Error, Carga nuevamente"

        Else

            Integer.TryParse(EdadStr, Edad_Animal)
            Decimal.TryParse(PesoStr, Peso_Animal)

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

            If Edad_Animal <= 0 And Peso_Animal <= 0 Then
                MsgBox("Ingrese peso y edad correctamente")
                Return
            End If

            Dim daoA As New DAOAnimales
            Dim animal As New Animal(Nombre_Animal, Edad_Animal, Peso_Animal, ID_Cliente, ID_Especie)
            Dim result As Boolean
            Try
                result = daoA.Insert(animal)
                If result Then
                    MsgBox("Alta del Animal Exitosa!!!")
                    Me.Close()
                Else
                    MsgBox("Error en el Alta del Animal :(")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try






            'Dim connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

            'Dim query As String = "INSERT INTO Animales (Nombre_Animal, Edad_Animal, Peso_Animal, ID_Cliente, ID_Especie) VALUES (@Nombre_Animal, @Edad_Animal ,@Peso_Animal,@ID_Cliente,@ID_Especie)"



            'Using connection As New SqlConnection(connectionString)
            '    Using command As New SqlCommand(query, connection)

            '        command.Parameters.AddWithValue("@Nombre_Animal", Nombre_Animal)
            '        command.Parameters.AddWithValue("@Edad_Animal", Edad_Animal)
            '        command.Parameters.AddWithValue("@Peso_Animal", Peso_Animal)
            '        command.Parameters.AddWithValue("@ID_Cliente", ID_Cliente)
            '        command.Parameters.AddWithValue("@ID_Especie", ID_Especie)



            '        connection.Open()

            '        Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            '        If result Then
            '            MsgBox("Error en el Alta del Animal :(")

            '        Else
            '            MsgBox("Alta del Animal Exitosa!!!")
            '            Me.Close()
            '        End If


            '    End Using
            'End Using

        End If






    End Sub
End Class