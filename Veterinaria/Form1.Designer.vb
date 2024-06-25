<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aAltasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aAnimalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aEspeciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bBajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bAnimalesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.bClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.bEspeciesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.bUsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mAnimalesToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mClientesToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mEspeciesToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mUsuariosToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lVerListadoAnimalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lVerListadoClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lVerListadoEspeciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lVerListadoUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListadoAnimalesConDueñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtContr = New System.Windows.Forms.TextBox()
        Me.TimerCarga = New System.Windows.Forms.Timer(Me.components)
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarElPesoMáximoMínimoYPromedioAgrupadoPorEspecieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarLaCantidadDeAnimalesConLosQueCuentaCadaDueñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaestrosToolStripMenuItem, Me.InformesToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(711, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MaestrosToolStripMenuItem
        '
        Me.MaestrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aAltasToolStripMenuItem, Me.bBajasToolStripMenuItem, Me.mModificarToolStripMenuItem})
        Me.MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem"
        Me.MaestrosToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.MaestrosToolStripMenuItem.Text = "Maestros"
        '
        'aAltasToolStripMenuItem
        '
        Me.aAltasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aAnimalesToolStripMenuItem, Me.aClientesToolStripMenuItem, Me.aEspeciesToolStripMenuItem, Me.aUsuariosToolStripMenuItem})
        Me.aAltasToolStripMenuItem.Name = "aAltasToolStripMenuItem"
        Me.aAltasToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.aAltasToolStripMenuItem.Text = "Altas"
        '
        'aAnimalesToolStripMenuItem
        '
        Me.aAnimalesToolStripMenuItem.Name = "aAnimalesToolStripMenuItem"
        Me.aAnimalesToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.aAnimalesToolStripMenuItem.Text = "Animales"
        '
        'aClientesToolStripMenuItem
        '
        Me.aClientesToolStripMenuItem.Name = "aClientesToolStripMenuItem"
        Me.aClientesToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.aClientesToolStripMenuItem.Text = "Clientes"
        '
        'aEspeciesToolStripMenuItem
        '
        Me.aEspeciesToolStripMenuItem.Name = "aEspeciesToolStripMenuItem"
        Me.aEspeciesToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.aEspeciesToolStripMenuItem.Text = "Especies"
        '
        'aUsuariosToolStripMenuItem
        '
        Me.aUsuariosToolStripMenuItem.Name = "aUsuariosToolStripMenuItem"
        Me.aUsuariosToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.aUsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'bBajasToolStripMenuItem
        '
        Me.bBajasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bAnimalesToolStripMenuItem1, Me.bClientesToolStripMenuItem1, Me.bEspeciesToolStripMenuItem1, Me.bUsuariosToolStripMenuItem1})
        Me.bBajasToolStripMenuItem.Name = "bBajasToolStripMenuItem"
        Me.bBajasToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.bBajasToolStripMenuItem.Text = "Bajas"
        '
        'bAnimalesToolStripMenuItem1
        '
        Me.bAnimalesToolStripMenuItem1.Name = "bAnimalesToolStripMenuItem1"
        Me.bAnimalesToolStripMenuItem1.Size = New System.Drawing.Size(153, 26)
        Me.bAnimalesToolStripMenuItem1.Text = "Animales"
        '
        'bClientesToolStripMenuItem1
        '
        Me.bClientesToolStripMenuItem1.Name = "bClientesToolStripMenuItem1"
        Me.bClientesToolStripMenuItem1.Size = New System.Drawing.Size(153, 26)
        Me.bClientesToolStripMenuItem1.Text = "Clientes"
        '
        'bEspeciesToolStripMenuItem1
        '
        Me.bEspeciesToolStripMenuItem1.Name = "bEspeciesToolStripMenuItem1"
        Me.bEspeciesToolStripMenuItem1.Size = New System.Drawing.Size(153, 26)
        Me.bEspeciesToolStripMenuItem1.Text = "Especies"
        '
        'bUsuariosToolStripMenuItem1
        '
        Me.bUsuariosToolStripMenuItem1.Name = "bUsuariosToolStripMenuItem1"
        Me.bUsuariosToolStripMenuItem1.Size = New System.Drawing.Size(153, 26)
        Me.bUsuariosToolStripMenuItem1.Text = "Usuarios"
        '
        'mModificarToolStripMenuItem
        '
        Me.mModificarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mAnimalesToolStripMenuItem3, Me.mClientesToolStripMenuItem3, Me.mEspeciesToolStripMenuItem3, Me.mUsuariosToolStripMenuItem3})
        Me.mModificarToolStripMenuItem.Name = "mModificarToolStripMenuItem"
        Me.mModificarToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.mModificarToolStripMenuItem.Text = "Modificar"
        '
        'mAnimalesToolStripMenuItem3
        '
        Me.mAnimalesToolStripMenuItem3.Name = "mAnimalesToolStripMenuItem3"
        Me.mAnimalesToolStripMenuItem3.Size = New System.Drawing.Size(153, 26)
        Me.mAnimalesToolStripMenuItem3.Text = "Animales"
        '
        'mClientesToolStripMenuItem3
        '
        Me.mClientesToolStripMenuItem3.Name = "mClientesToolStripMenuItem3"
        Me.mClientesToolStripMenuItem3.Size = New System.Drawing.Size(153, 26)
        Me.mClientesToolStripMenuItem3.Text = "Clientes"
        '
        'mEspeciesToolStripMenuItem3
        '
        Me.mEspeciesToolStripMenuItem3.Name = "mEspeciesToolStripMenuItem3"
        Me.mEspeciesToolStripMenuItem3.Size = New System.Drawing.Size(153, 26)
        Me.mEspeciesToolStripMenuItem3.Text = "Especies"
        '
        'mUsuariosToolStripMenuItem3
        '
        Me.mUsuariosToolStripMenuItem3.Name = "mUsuariosToolStripMenuItem3"
        Me.mUsuariosToolStripMenuItem3.Size = New System.Drawing.Size(153, 26)
        Me.mUsuariosToolStripMenuItem3.Text = "Usuarios"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lVerListadoAnimalesToolStripMenuItem, Me.lVerListadoClientesToolStripMenuItem, Me.lVerListadoEspeciesToolStripMenuItem, Me.lVerListadoUsuariosToolStripMenuItem, Me.VerListadoAnimalesConDueñoToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.InformesToolStripMenuItem.Text = "Informes "
        '
        'lVerListadoAnimalesToolStripMenuItem
        '
        Me.lVerListadoAnimalesToolStripMenuItem.Name = "lVerListadoAnimalesToolStripMenuItem"
        Me.lVerListadoAnimalesToolStripMenuItem.Size = New System.Drawing.Size(299, 26)
        Me.lVerListadoAnimalesToolStripMenuItem.Text = "Ver listado animales"
        '
        'lVerListadoClientesToolStripMenuItem
        '
        Me.lVerListadoClientesToolStripMenuItem.Name = "lVerListadoClientesToolStripMenuItem"
        Me.lVerListadoClientesToolStripMenuItem.Size = New System.Drawing.Size(299, 26)
        Me.lVerListadoClientesToolStripMenuItem.Text = "Ver listado clientes"
        '
        'lVerListadoEspeciesToolStripMenuItem
        '
        Me.lVerListadoEspeciesToolStripMenuItem.Name = "lVerListadoEspeciesToolStripMenuItem"
        Me.lVerListadoEspeciesToolStripMenuItem.Size = New System.Drawing.Size(299, 26)
        Me.lVerListadoEspeciesToolStripMenuItem.Text = "Ver listado especies"
        '
        'lVerListadoUsuariosToolStripMenuItem
        '
        Me.lVerListadoUsuariosToolStripMenuItem.Name = "lVerListadoUsuariosToolStripMenuItem"
        Me.lVerListadoUsuariosToolStripMenuItem.Size = New System.Drawing.Size(299, 26)
        Me.lVerListadoUsuariosToolStripMenuItem.Text = "Ver listado usuarios"
        '
        'VerListadoAnimalesConDueñoToolStripMenuItem
        '
        Me.VerListadoAnimalesConDueñoToolStripMenuItem.Name = "VerListadoAnimalesConDueñoToolStripMenuItem"
        Me.VerListadoAnimalesConDueñoToolStripMenuItem.Size = New System.Drawing.Size(299, 26)
        Me.VerListadoAnimalesConDueñoToolStripMenuItem.Text = "Ver listado animales con dueño"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblInfo)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txtContr)
        Me.Panel1.Location = New System.Drawing.Point(82, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 341)
        Me.Panel1.TabIndex = 4
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(180, 90)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(167, 22)
        Me.txtUsuario.TabIndex = 6
        Me.txtUsuario.Text = "admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ingrese Usuario:"
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(17, 230)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(512, 25)
        Me.lblInfo.TabIndex = 4
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(75, 271)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(372, 24)
        Me.ProgressBar1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(207, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese contraseña"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(202, 182)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(117, 46)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Iniciar"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtContr
        '
        Me.txtContr.Location = New System.Drawing.Point(180, 148)
        Me.txtContr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtContr.Name = "txtContr"
        Me.txtContr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContr.Size = New System.Drawing.Size(167, 22)
        Me.txtContr.TabIndex = 0
        '
        'TimerCarga
        '
        Me.TimerCarga.Interval = 50
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarElPesoMáximoMínimoYPromedioAgrupadoPorEspecieToolStripMenuItem, Me.MostrarLaCantidadDeAnimalesConLosQueCuentaCadaDueñoToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'MostrarElPesoMáximoMínimoYPromedioAgrupadoPorEspecieToolStripMenuItem
        '
        Me.MostrarElPesoMáximoMínimoYPromedioAgrupadoPorEspecieToolStripMenuItem.Name = "MostrarElPesoMáximoMínimoYPromedioAgrupadoPorEspecieToolStripMenuItem"
        Me.MostrarElPesoMáximoMínimoYPromedioAgrupadoPorEspecieToolStripMenuItem.Size = New System.Drawing.Size(542, 26)
        Me.MostrarElPesoMáximoMínimoYPromedioAgrupadoPorEspecieToolStripMenuItem.Text = "Mostrar el peso máximo, mínimo y promedio agrupado por especie"
        '
        'MostrarLaCantidadDeAnimalesConLosQueCuentaCadaDueñoToolStripMenuItem
        '
        Me.MostrarLaCantidadDeAnimalesConLosQueCuentaCadaDueñoToolStripMenuItem.Name = "MostrarLaCantidadDeAnimalesConLosQueCuentaCadaDueñoToolStripMenuItem"
        Me.MostrarLaCantidadDeAnimalesConLosQueCuentaCadaDueñoToolStripMenuItem.Size = New System.Drawing.Size(542, 26)
        Me.MostrarLaCantidadDeAnimalesConLosQueCuentaCadaDueñoToolStripMenuItem.Text = "Mostrar la cantidad de animales con los que cuenta cada dueño"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 360)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Veterinaria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MaestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lVerListadoAnimalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtContr As TextBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TimerCarga As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents aAltasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents aAnimalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents aClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents aEspeciesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents aUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bBajasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bAnimalesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents bClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents bEspeciesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents bUsuariosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mAnimalesToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents mClientesToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents mEspeciesToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents mUsuariosToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents lVerListadoClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lVerListadoEspeciesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lVerListadoUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerListadoAnimalesConDueñoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarElPesoMáximoMínimoYPromedioAgrupadoPorEspecieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarLaCantidadDeAnimalesConLosQueCuentaCadaDueñoToolStripMenuItem As ToolStripMenuItem
End Class
