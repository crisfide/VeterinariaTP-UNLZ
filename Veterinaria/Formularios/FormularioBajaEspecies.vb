Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Reflection.Emit
Imports Servicios
Imports Servicios.DAO
Imports Servicios.Modelos

Public Class FormularioBajaEspecies


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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ID_Especie As Integer

        If ComboBox1.SelectedItem IsNot Nothing Then
            ID_Especie = CInt(ComboBox1.SelectedValue)

            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Estas seguro de Borrar la especie seleccionada?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirmación")
            If respuesta = MsgBoxResult.Yes Then
                BorrarEspecie(ID_Especie)
            End If

        Else
            MessageBox.Show("Por favor, selecciona una especie.")
        End If



    End Sub




    Private Sub BorrarEspecie(ID_Especie As Integer)

        Try
            If daoE.Delete(ID_Especie) Then
                MsgBox("Eliminado correctamente")
            Else
                Throw New Exception("No se pudo eliminar")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Close()

    End Sub


End Class