<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarCliente
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
        Label9 = New Label()
        Panel7 = New Panel()
        rbInactivo = New CheckBox()
        rbActivo = New CheckBox()
        Label7 = New Label()
        txtDireccion = New TextBox()
        txtCorreo = New TextBox()
        Label5 = New Label()
        txtCelular = New TextBox()
        Label4 = New Label()
        txtNombre = New TextBox()
        Label3 = New Label()
        txtApellido = New TextBox()
        Label2 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel6 = New Panel()
        rbMasculino = New CheckBox()
        rbFemenino = New CheckBox()
        Label6 = New Label()
        Label8 = New Label()
        txtCedula = New TextBox()
        Label1 = New Label()
        BtnAgregarCliente = New Button()
        Panel7.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(346, 34)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(256, 45)
        Label9.TabIndex = 19
        Label9.Text = "Agregar Cliente"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(rbInactivo)
        Panel7.Controls.Add(rbActivo)
        Panel7.Controls.Add(Label7)
        Panel7.Location = New Point(14, 120)
        Panel7.Margin = New Padding(4)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(431, 59)
        Panel7.TabIndex = 18
        ' 
        ' rbInactivo
        ' 
        rbInactivo.AutoSize = True
        rbInactivo.Location = New Point(261, 18)
        rbInactivo.Margin = New Padding(4)
        rbInactivo.Name = "rbInactivo"
        rbInactivo.Size = New Size(100, 29)
        rbInactivo.TabIndex = 2
        rbInactivo.Text = "Inactivo"
        rbInactivo.UseVisualStyleBackColor = True
        ' 
        ' rbActivo
        ' 
        rbActivo.AutoSize = True
        rbActivo.Location = New Point(114, 18)
        rbActivo.Margin = New Padding(4)
        rbActivo.Name = "rbActivo"
        rbActivo.Size = New Size(88, 29)
        rbActivo.TabIndex = 1
        rbActivo.Text = "Activo"
        rbActivo.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(18, 18)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 25)
        Label7.TabIndex = 0
        Label7.Text = "Estatus:"
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(100, 253)
        txtDireccion.Margin = New Padding(4)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.PlaceholderText = "direcion"
        txtDireccion.Size = New Size(226, 31)
        txtDireccion.TabIndex = 1
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(100, 187)
        txtCorreo.Margin = New Padding(4)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.PlaceholderText = "ejemplo@dominio.com"
        txtCorreo.Size = New Size(226, 31)
        txtCorreo.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 187)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 25)
        Label5.TabIndex = 0
        Label5.Text = "Correo:"
        ' 
        ' txtCelular
        ' 
        txtCelular.Location = New Point(100, 315)
        txtCelular.Margin = New Padding(4)
        txtCelular.Name = "txtCelular"
        txtCelular.PlaceholderText = "xxxx-xxxx"
        txtCelular.Size = New Size(226, 31)
        txtCelular.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 318)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 25)
        Label4.TabIndex = 0
        Label4.Text = "Celular:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(100, 70)
        txtNombre.Margin = New Padding(4)
        txtNombre.Name = "txtNombre"
        txtNombre.PlaceholderText = "nombre"
        txtNombre.Size = New Size(226, 31)
        txtNombre.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 73)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 25)
        Label3.TabIndex = 0
        Label3.Text = "Nombre:"
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(100, 119)
        txtApellido.Margin = New Padding(4)
        txtApellido.Name = "txtApellido"
        txtApellido.PlaceholderText = "apellid"
        txtApellido.Size = New Size(226, 31)
        txtApellido.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 125)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 25)
        Label2.TabIndex = 0
        Label2.Text = "Apellido:"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtDireccion)
        Panel1.Controls.Add(txtApellido)
        Panel1.Controls.Add(txtCorreo)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtNombre)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtCelular)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtCedula)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(29, 100)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(879, 388)
        Panel1.TabIndex = 11
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel7)
        Panel2.Location = New Point(376, 73)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(468, 208)
        Panel2.TabIndex = 20
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(rbMasculino)
        Panel6.Controls.Add(rbFemenino)
        Panel6.Controls.Add(Label6)
        Panel6.Location = New Point(14, 34)
        Panel6.Margin = New Padding(4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(431, 59)
        Panel6.TabIndex = 20
        ' 
        ' rbMasculino
        ' 
        rbMasculino.AutoSize = True
        rbMasculino.Location = New Point(261, 18)
        rbMasculino.Margin = New Padding(4)
        rbMasculino.Name = "rbMasculino"
        rbMasculino.Size = New Size(118, 29)
        rbMasculino.TabIndex = 2
        rbMasculino.Text = "Masculino"
        rbMasculino.UseVisualStyleBackColor = True
        ' 
        ' rbFemenino
        ' 
        rbFemenino.AutoSize = True
        rbFemenino.Location = New Point(114, 18)
        rbFemenino.Margin = New Padding(4)
        rbFemenino.Name = "rbFemenino"
        rbFemenino.Size = New Size(116, 29)
        rbFemenino.TabIndex = 1
        rbFemenino.Text = "Femenino"
        rbFemenino.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(18, 18)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 25)
        Label6.TabIndex = 0
        Label6.Text = "Sexo:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 253)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(89, 25)
        Label8.TabIndex = 2
        Label8.Text = "Direccion:"
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(100, 17)
        txtCedula.Margin = New Padding(4)
        txtCedula.Name = "txtCedula"
        txtCedula.PlaceholderText = "xx-xxx-xxxx"
        txtCedula.Size = New Size(226, 31)
        txtCedula.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 22)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 25)
        Label1.TabIndex = 0
        Label1.Text = "Cedula:"
        ' 
        ' BtnAgregarCliente
        ' 
        BtnAgregarCliente.Location = New Point(359, 496)
        BtnAgregarCliente.Margin = New Padding(4)
        BtnAgregarCliente.Name = "BtnAgregarCliente"
        BtnAgregarCliente.Size = New Size(221, 48)
        BtnAgregarCliente.TabIndex = 10
        BtnAgregarCliente.Text = "Agregar Cliente"
        BtnAgregarCliente.UseVisualStyleBackColor = True
        ' 
        ' FormAgregarCliente
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 562)
        Controls.Add(Label9)
        Controls.Add(Panel1)
        Controls.Add(BtnAgregarCliente)
        Margin = New Padding(4)
        Name = "FormAgregarCliente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormAgregarCliente"
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents rbInactivo As CheckBox
    Friend WithEvents rbActivo As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAgregarCliente As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents rbMasculino As CheckBox
    Friend WithEvents rbFemenino As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
End Class
