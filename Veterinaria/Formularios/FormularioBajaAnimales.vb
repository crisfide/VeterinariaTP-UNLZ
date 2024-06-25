Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Reflection.Emit
Imports Servicios.DAO
Imports Servicios.Modelos

Public Class FormularioBajaAnimales

    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAnimalesNames()
    End Sub


    'Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

    Private daoA As New DAOAnimales
    Private Sub LoadAnimalesNames()

        Try
            Dim listado As List(Of Animal) = daoA.GetAll()

            ComboBox1.DataSource = listado
            ComboBox1.DisplayMember = "nombre"
            ComboBox1.ValueMember = "id"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Using connection As New SqlConnection(connectionString)
        '    connection.Open()
        '    Dim query As String = "SELECT ID_Animal,Nombre_Animal FROM Animales"

        '    Dim adapter As New SqlDataAdapter(query, connection)
        '    Dim table As New DataTable()
        '    adapter.Fill(table)
        '    ComboBox1.DataSource = table
        '    ComboBox1.DisplayMember = "Nombre_Animal"
        '    ComboBox1.ValueMember = "ID_Animal"






        'End Using
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
            MsgBox("Por favor, selecciona un Animal.")
        End If
    End Sub

    Private Sub BorrarAnimal(ID_Animal)
        Try
            If daoA.Delete(ID_Animal) Then
                MsgBox("Eliminado correctamente")
            Else
                Throw New Exception("No se pudo eliminar")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Close()
    End Sub



End Class