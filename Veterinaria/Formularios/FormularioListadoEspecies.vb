Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports Servicios.DAO

Public Class FormularioListadoEspecies


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim dao As New DAOEspecies

        Try
            DataGridView1.DataSource = dao.GetAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class