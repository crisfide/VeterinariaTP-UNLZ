Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports Servicios.DAO

Public Class FormularioListadoClientes


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim dao As New DAOClientes

        Try
            DataGridView1.DataSource = dao.GetAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class