Imports Servicios.DAO

Public Class ReporteCantidadPorDuenio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CargarDatos()
    End Sub

    Private Sub CargarDatos()
        Dim dao As New DAOAnimales
        Dim query As String = "SELECT d.id AS id_dueño, d.nombre AS nombre_del_dueño, COUNT(a.id) AS cantidad_de_animales
            FROM clientes as d
            LEFT JOIN animales a ON d.id = a.CLIENTE_ID
            GROUP BY d.ID, d.NOMBRE
            ORDER BY cantidad_de_animales ASC"
        Try
            DataGridView1.DataSource = dao.getDt(query)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class