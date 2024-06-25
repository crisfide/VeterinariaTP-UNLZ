Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Reflection.Emit
Imports Servicios
Imports Servicios.DAO
Imports Servicios.Modelos

Public Class FormularioBajaDeClientes

    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClientNames()
    End Sub

    'Private connectionString As String = "Data Source=NOTEBOOK_CASA\SQLEXPRESS01;Initial Catalog=Veterinaria;Integrated Security=True"

    Dim daoC As New DAOClientes
    Private Sub LoadClientNames()
        Try
            Dim listado As List(Of Cliente) = daoC.GetAll()

            ComboBox1.DataSource = listado
            ComboBox1.DisplayMember = "nombre"
            ComboBox1.ValueMember = "id"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ID_Cliente As Integer

        If ComboBox1.SelectedItem IsNot Nothing Then
            ID_Cliente = CInt(ComboBox1.SelectedValue)

            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Estas seguro de Borrar el Cliente seleccionado?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirmación")
            If respuesta = MsgBoxResult.Yes Then
                BorrarCliente(ID_Cliente)
            End If

        Else
            MessageBox.Show("Por favor, selecciona un cliente.")
        End If

    End Sub


    Private Sub BorrarCliente(ID_Cliente)
        Try
            If daoC.Delete(ID_Cliente) Then
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