﻿Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports Servicios.DAO

Public Class FormularioListadoAnimales


    'Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim dao As New DAOAnimales

        Try
            DataGridView1.DataSource = dao.GetAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'Using connection As New SqlConnection(connectionString)
        '    connection.Open()
        '    Dim query As String = "SELECT * FROM ANIMALES"
        '    Dim adapter As New SqlDataAdapter(query, connection)
        '    Dim table As New DataTable()
        '    adapter.Fill(table)
        '    DataGridView1.DataSource = table
        'End Using




    End Sub
End Class