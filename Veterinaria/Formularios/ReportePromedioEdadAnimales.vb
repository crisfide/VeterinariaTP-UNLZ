Imports System.Data.SqlClient
Imports Servicios.DAO

Public Class ReportePromedioEdadAnimales

    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CargarPromedioEdadPorEspecie()
    End Sub

    Private Sub CargarPromedioEdadPorEspecie()
        Dim dao As New DAOAnimales

        Try
            DataGridView1.DataSource = dao.GetAll("
                    SELECT ESPECIE_ID, AVG(EDAD) AS PromedioEdad 
                    FROM Animales 
                    GROUP BY ESPECIE_ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
End Class