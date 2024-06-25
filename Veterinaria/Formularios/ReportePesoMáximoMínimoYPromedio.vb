Imports System.Data.SqlClient
Imports Servicios.DAO

Public Class ReportePesoMáximoMínimoYPromedio

    Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim desdeint As Integer
        Dim hastaint As Integer
        Dim desde As String = TextBox1.Text
        Dim convertedNumber As Integer

        If Integer.TryParse(desde, convertedNumber) Then
            ' La conversión fue exitosa
            desdeint = convertedNumber.ToString()
        Else
            ' La conversión falló
            MsgBox("Por favor, ingrese un anio válido.")
        End If


        Dim hasta As String = TextBox2.Text
        Dim convertedNumber2 As Integer

        If Integer.TryParse(hasta, convertedNumber2) Then
            ' La conversión fue exitosa
            hastaint = convertedNumber2.ToString()
        Else
            ' La conversión falló
            MsgBox("Por favor, ingrese un anio válido.")
        End If


        CargarDatos(desdeint, hastaint)
    End Sub

    Private Sub CargarDatos(desdeint As Integer, hastaint As Integer)
        Dim dao As New DAOAnimales

        '      Dim query As String = "SELECT E.Nombre_Especie AS NombreEspecie,MAX(A.Peso_Animal) AS PesoMaximo , MIN (A.Peso_Animal) AS PesoMinimo ,AVG (A.Peso_Animal)AS PesoPromedio 
        'FROM Animales AS A
        'JOIN Especies AS E ON E.ID_Especie = A.ID_Especie
        'WHERE A.Edad_Animal BETWEEN " & desdeint & " AND " & hastaint & " GROUP BY Nombre_Especie"
        Dim query As String = "SELECT E.NOMBRE AS NombreEspecie,MAX(A.PESO) AS PesoMaximo , MIN (A.PESO) AS PesoMinimo, AVG (A.PESO) AS PesoPromedio 
            FROM Animales AS A
            JOIN Especies AS E ON E.ID = A.ESPECIE_ID
            WHERE A.EDAD BETWEEN " & desdeint.ToString & " AND " & hastaint.ToString & " GROUP BY E.NOMBRE"
        Try
            DataGridView1.DataSource = dao.getDt(query)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class