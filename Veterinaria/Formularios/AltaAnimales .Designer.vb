﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAltaAnimales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxClientes = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEspecie = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(671, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alta de Animales"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(732, 130)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(297, 22)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(732, 194)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(297, 22)
        Me.TextBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(727, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingresar el nombre del animal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(727, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingresar el peso del animal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(727, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ingresar la edad del animal:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(732, 250)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(297, 22)
        Me.TextBox3.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(792, 438)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 69)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Dar de alta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(729, 412)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(300, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(727, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Ingresar el ID del Cliente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(727, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(255, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Ingresar el ID de la Especie:"
        '
        'ComboBoxClientes
        '
        Me.ComboBoxClientes.FormattingEnabled = True
        Me.ComboBoxClientes.Location = New System.Drawing.Point(732, 308)
        Me.ComboBoxClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxClientes.Name = "ComboBoxClientes"
        Me.ComboBoxClientes.Size = New System.Drawing.Size(297, 24)
        Me.ComboBoxClientes.TabIndex = 13
        '
        'ComboBoxEspecie
        '
        Me.ComboBoxEspecie.FormattingEnabled = True
        Me.ComboBoxEspecie.Location = New System.Drawing.Point(732, 373)
        Me.ComboBoxEspecie.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxEspecie.Name = "ComboBoxEspecie"
        Me.ComboBoxEspecie.Size = New System.Drawing.Size(297, 24)
        Me.ComboBoxEspecie.TabIndex = 14
        '
        'FormularioAltaAnimales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 508)
        Me.Controls.Add(Me.ComboBoxEspecie)
        Me.Controls.Add(Me.ComboBoxClientes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormularioAltaAnimales"
        Me.Text = "FormlarioAlta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxClientes As ComboBox
    Friend WithEvents ComboBoxEspecie As ComboBox
End Class
