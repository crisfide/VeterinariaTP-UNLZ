Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Reflection.Emit
Imports Servicios
Imports Servicios.DAO
Imports Servicios.Modelos

Public Class FormularioBajaDeUsuarios

    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsuariosNames()
    End Sub

    Private daoU As New DAOUsuarios

    Private Sub LoadUsuariosNames()
        Try
            Dim listado As List(Of Usuario) = daoU.GetAll()

            ComboBox1.DataSource = listado
            ComboBox1.DisplayMember = "nombre"
            ComboBox1.ValueMember = "id"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ID_Usuarios As Integer

        If ComboBox1.SelectedItem IsNot Nothing Then
            ID_Usuarios = CInt(ComboBox1.SelectedValue)

            Dim respuesta As MsgBoxResult
            respuesta = MsgBox("¿Estas seguro de Borrar el usuario seleccionado?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirmación")
            If respuesta = MsgBoxResult.Yes Then
                BorrarUsuario(ID_Usuarios)
            End If
        Else
            MessageBox.Show("Por favor, selecciona un Usuario")
        End If

    End Sub


    Private Sub BorrarUsuario(ID_Usuarios)

        Try
            If daoU.Delete(ID_Usuarios) Then
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