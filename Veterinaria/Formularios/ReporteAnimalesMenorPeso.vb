﻿Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class ReporteAnimalesMenorPeso

    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CargarAnimalesConMenorPeso()
    End Sub

    Private Sub CargarAnimalesConMenorPeso()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "  SELECT Nombre_Animal, Edad_Animal,id_Especie,  Peso_Animal FROM Animales ORDER BY Peso_Animal ASC"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using


    End Sub
End Class