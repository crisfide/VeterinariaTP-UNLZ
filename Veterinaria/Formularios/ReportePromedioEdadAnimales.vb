Imports System.Data.SqlClient
Public Class ReportePromedioEdadAnimales

    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CargarPromedioEdadPorEspecie()
    End Sub

    Private Sub CargarPromedioEdadPorEspecie()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT ID_Especie, AVG(Edad_Animal) AS PromedioEdad FROM [Veterinaria].[dbo].[Animales] GROUP BY ID_Especie"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using



    End Sub
End Class