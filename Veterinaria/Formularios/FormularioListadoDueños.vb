Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class FormularioListadoDueños

    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        LoadData()
    End Sub

    Private Sub LoadData()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String =
                "SELECT a.Nombre_Animal AS NombreAnimal,e.Nombre_Especie as NombreEspecie,a.Edad_Animal as EdadAnimal ,c.nombreCliente as Dueño 
                  FROM Animales as a
                  JOIN Clientes as c ON a.ID_Cliente = c.Id_Cliente
                  JOIN Especies as e ON a.ID_Especie = e.ID_Especie
                "
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using



    End Sub
End Class