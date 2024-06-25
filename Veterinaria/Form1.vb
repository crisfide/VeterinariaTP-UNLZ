Imports Servicios.DAO
Imports Servicios.Modelos

Public Class Form1

    Private Sub cargarForm(formu As Form)
        'Dim formu As New FormularioListadoAnimales
        formu.MdiParent = Me
        formu.WindowState = FormWindowState.Maximized
        formu.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim daoU As New DAOUsuarios()
        Dim usuarioEnBD As Usuario = Nothing

        Try
            usuarioEnBD = daoU.verificarUsuario(Me.txtUsuario.Text, Me.txtContr.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If usuarioEnBD Is Nothing Then
            Dim nombreOK As String = "admin"
            Dim contraseñaOk As String = "123"
            Me.lblInfo.Text = $"Login incorrecto, ingrese '{nombreOK}' y '{contraseñaOk}'"
        Else
            TimerCarga.Enabled = True
            Me.lblInfo.Text = "Cargando..."
        End If

        lblInfo.Visible = True
    End Sub

    Private Sub TimerCarga_Tick(sender As Object, e As EventArgs) Handles TimerCarga.Tick
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Panel1.Hide()
            MenuStrip1.Visible = True
        Else
            Dim nuevoValor = ProgressBar1.Value + 10
            ProgressBar1.Value = Math.Min(nuevoValor, ProgressBar1.Maximum)
        End If

    End Sub

    'altas
    Private Sub aAnimalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles aAnimalesToolStripMenuItem.Click
        cargarForm(New FormularioAltaAnimales())
    End Sub
    Private Sub aClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles aClientesToolStripMenuItem.Click
        cargarForm(New AltaClientes())
    End Sub
    Private Sub aEspeciesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles aEspeciesToolStripMenuItem.Click
        cargarForm(New AltaEspecies())
    End Sub

    Private Sub aUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles aUsuariosToolStripMenuItem.Click
        cargarForm(New AltaUsuarios())
    End Sub




    'bajas
    Private Sub bAnimalesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles bAnimalesToolStripMenuItem1.Click
        cargarForm(New FormularioBajaAnimales())
    End Sub
    Private Sub bClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles bClientesToolStripMenuItem1.Click
        cargarForm(New FormularioBajaDeClientes())
    End Sub
    Private Sub bEspeciesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles bEspeciesToolStripMenuItem1.Click
        cargarForm(New FormularioBajaEspecies())
    End Sub
    Private Sub bUsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles bUsuariosToolStripMenuItem1.Click
        cargarForm(New FormularioBajaDeUsuarios())
    End Sub



    'modificar
    Private Sub mAnimalesToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles mAnimalesToolStripMenuItem3.Click
        cargarForm(New ModificarAnimales())
    End Sub
    Private Sub mClientesToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles mClientesToolStripMenuItem3.Click
        cargarForm(New ModificarClientes())
    End Sub
    Private Sub mEspeciesToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles mEspeciesToolStripMenuItem3.Click
        cargarForm(New ModificarEspecies())
    End Sub
    Private Sub mUsuariosToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles mUsuariosToolStripMenuItem3.Click
        cargarForm(New ModificarUsuarios())
    End Sub



    'listados
    Private Sub lVerListadoAnimalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles lVerListadoAnimalesToolStripMenuItem.Click
        cargarForm(New FormularioListadoAnimales())
    End Sub
    Private Sub lVerListadoClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles lVerListadoClientesToolStripMenuItem.Click
        cargarForm(New FormularioListadoClientes())
    End Sub
    Private Sub lVerListadoEspeciesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles lVerListadoEspeciesToolStripMenuItem.Click
        cargarForm(New FormularioListadoEspecies())
    End Sub
    Private Sub lVerListadoUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles lVerListadoUsuariosToolStripMenuItem.Click
        cargarForm(New FormularioListadoUsuarios())
    End Sub






    'salir
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class
