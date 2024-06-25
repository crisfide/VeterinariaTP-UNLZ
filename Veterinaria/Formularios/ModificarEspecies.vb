Imports System.Data.SqlClient
Imports Servicios
Imports Servicios.DAO
Imports Servicios.Modelos

Public Class ModificarEspecies

    Private valor As Integer

    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEspeciesName()
    End Sub

    Private daoE As New DAOEspecies
    Private Sub LoadEspeciesName()
        Try
            Dim listado As List(Of Especie) = daoE.GetAll()

            ComboBox1.DataSource = listado
            ComboBox1.DisplayMember = "nombre"
            ComboBox1.ValueMember = "id"
            ComboBox1.Text = "---" 'para que no se muestre un valor antes de seleccionar

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        If ComboBox1.SelectedValue IsNot Nothing Then
            'Dim valor As Integer  -> la declaro global
            Dim valorS As String = ComboBox1.SelectedValue.ToString()

            Integer.TryParse(valorS, valor)
            'MsgBox("ComboBox1.SelectedValue.ToString():  " & valor)

            Dim ID_Especie As Integer = valor
            MostrarDetallesEspecie(ID_Especie)
        End If
    End Sub


    Private Sub MostrarDetallesEspecie(ID_Especie As Integer)
        Dim especie As Especie
        Try
            especie = daoE.GetByID(ID_Especie)

            With especie
                'todo lo que empieza con . se refiere a la variable cliente
                TextBox1.Text = .nombre
                TextBox2.Text = .EdadMadurez.ToString()
                TextBox3.Text = .PesoPromedio.ToString()
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ID_Especie As Integer = valor
        Dim Nombre_Especie As String = TextBox1.Text

        Dim Edad_Madurez As Integer ' = CInt(TextBox2.Text)
        Dim Peso_Promedio As Decimal ' = CDec(TextBox3.Text)

        If Not Integer.TryParse(TextBox2.Text, Edad_Madurez) Then
            MessageBox.Show("Por favor, ingrese un número válido para Edad de Madurez.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Salir del evento si la conversión falla
        End If

        ' Validar Peso_Promedio
        If Not Decimal.TryParse(TextBox3.Text, Peso_Promedio) Then
            MessageBox.Show("Por favor, ingrese un número válido para Peso Promedio.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Salir del evento si la conversión falla
        End If

        Edad_Madurez = CInt(TextBox2.Text)
        Peso_Promedio = CDec(TextBox3.Text)

        ActualizarEspecie(ID_Especie, Nombre_Especie, Edad_Madurez, Peso_Promedio)

    End Sub
    Private Sub ActualizarEspecie(ID_Especie As Integer, Nombre_Especie As String, Edad_Madurez As Integer, Peso_Promedio As Decimal)
        Try
            If daoE.Update(ID_Especie, Nombre_Especie, Edad_Madurez, Peso_Promedio) Then
                MessageBox.Show("Especie actualizada correctamente.")
            Else
                Throw New Exception("No se pudo actualizar")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class