Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Servicios
Imports Servicios.DAO
Imports Servicios.Modelos

Public Class ModificarUsuarios

    Private valor As Integer
    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsuariosName()
    End Sub

    Private daoU As New DAOUsuarios
    Private Sub LoadUsuariosName()
        Try
            Dim listado As List(Of Usuario) = daoU.GetAll()

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

            Dim ID_Usuarios As Integer = valor
            MostrarDetallesUsuario(ID_Usuarios)
        End If
    End Sub

    Private Sub MostrarDetallesUsuario(ID_Usuarios As Integer)
        Dim usuario As Usuario
        Try
            usuario = daoU.GetByID(ID_Usuarios)

            With usuario
                'todo lo que empieza con . se refiere a la variable cliente
                TextBox1.Text = .nombre
                TextBox2.Text = .clave
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ID_Usuarios As Integer = valor
        Dim Nombre_Usuario As String = TextBox1.Text

        Dim Contrasenia_Usuario As String = TextBox2.Text ' = CInt(TextBox2.Text)


        If Nombre_Usuario = "" Or Contrasenia_Usuario = "" Then
            MessageBox.Show("Por favor, ingrese un nombre de usuario y contraseña.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Salir del evento si la conversión falla
        End If

        ActualizarUsuario(ID_Usuarios, Nombre_Usuario, Contrasenia_Usuario)

    End Sub


    Private Sub ActualizarUsuario(ID_Usuarios As Integer, Nombre_Usuario As String, Contrasenia_Usuario As String)
        Try
            If daoU.Update(ID_Usuarios, Nombre_Usuario, Contrasenia_Usuario) Then
                MessageBox.Show("Usuario actualizado correctamente.")
            Else
                Throw New Exception("No se pudo actualizar")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


End Class