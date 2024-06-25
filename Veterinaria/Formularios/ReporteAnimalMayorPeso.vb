Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports Servicios.DAO

Public Class ReporteAnimalMayorPeso

    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CargarAnimalesConMayorPeso()
    End Sub

    Private Sub CargarAnimalesConMayorPeso()
        Dim dao As New DAOAnimales

        Try
            DataGridView1.DataSource = dao.ordenarPorPeso(False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class