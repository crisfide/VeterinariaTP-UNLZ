Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports Servicios.DAO

Public Class ReporteAnimalesMenorPeso

    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CargarAnimalesConMenorPeso()
    End Sub

    Private Sub CargarAnimalesConMenorPeso()
        Dim dao As New DAOAnimales

        Try
            DataGridView1.DataSource = dao.ordenarPorPeso(True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class