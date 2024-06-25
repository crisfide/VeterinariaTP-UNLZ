Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Servicios
Imports Servicios.DAO
Imports Servicios.Modelos

Public Class ModificarClientes

    Private valor As Integer

    Private Sub FormularioAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClientesName()
    End Sub


    Dim daoC As New DAOClientes
    Private Sub LoadClientesName()
        Try
            Dim listado As List(Of Cliente) = daoC.GetAll()

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
            'MsgBox($"{ComboBox1.SelectedValue.ToString()}:  " & valor)

            Dim id_cliente As Integer = valor
            MostrarDetallesCliente(id_cliente)
        End If
    End Sub

    Private Sub MostrarDetallesCliente(ID_Cliente As Integer)
        Dim cliente As Cliente
        Try
            cliente = daoC.GetByID(ID_Cliente)

            With cliente
                'todo lo que empieza con . se refiere a la variable cliente
                TextBox1.Text = .nombre
                TextBox2.Text = .DNI.ToString()
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ID_Cliente As Integer = valor
        Dim nombreCliente As String = TextBox1.Text

        Dim dniCliente As Integer ' = CInt(TextBox2.Text)


        If Not Integer.TryParse(TextBox2.Text, dniCliente) Then
            MessageBox.Show("Por favor, ingrese un número válido para DNI Cliente.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Salir del evento si la conversión falla
        End If

        dniCliente = CInt(TextBox2.Text)

        ActualizarCliente(ID_Cliente, nombreCliente, dniCliente)

    End Sub

    Private Sub ActualizarCliente(ID_Cliente As Integer, nombreCliente As String, dniCliente As Integer)
        Try
            If daoC.Update(ID_Cliente, nombreCliente, dniCliente) Then
                MessageBox.Show("Cliente actualizado correctamente.")
            Else
                Throw New Exception("No se pudo actualizar")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


End Class