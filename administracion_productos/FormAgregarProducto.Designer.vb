<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregarProducto
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
        BtnAgregarProdcuto = New Button()
        Panel1 = New Panel()
        Label6 = New Label()
        txtPuntoDeReorden = New TextBox()
        txtExistencia = New TextBox()
        txtDescripcion = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel7 = New Panel()
        rbInactivo = New CheckBox()
        rbActivo = New CheckBox()
        Label7 = New Label()
        txtCosto = New TextBox()
        txtITBMS = New TextBox()
        txtPrecio = New TextBox()
        Label4 = New Label()
        txtCodigoBarra = New TextBox()
        Label8 = New Label()
        Label1 = New Label()
        Label9 = New Label()
        Panel1.SuspendLayout()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnAgregarProdcuto
        ' 
        BtnAgregarProdcuto.Location = New Point(386, 393)
        BtnAgregarProdcuto.Margin = New Padding(4)
        BtnAgregarProdcuto.Name = "BtnAgregarProdcuto"
        BtnAgregarProdcuto.Size = New Size(221, 52)
        BtnAgregarProdcuto.TabIndex = 0
        BtnAgregarProdcuto.Text = "Agregar Producto"
        BtnAgregarProdcuto.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtPuntoDeReorden)
        Panel1.Controls.Add(txtExistencia)
        Panel1.Controls.Add(txtDescripcion)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(txtCosto)
        Panel1.Controls.Add(txtITBMS)
        Panel1.Controls.Add(txtPrecio)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtCodigoBarra)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(66, 98)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(902, 274)
        Panel1.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 227)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 25)
        Label6.TabIndex = 0
        Label6.Text = "Punto de Reorden"
        ' 
        ' txtPuntoDeReorden
        ' 
        txtPuntoDeReorden.Location = New Point(182, 224)
        txtPuntoDeReorden.Margin = New Padding(4)
        txtPuntoDeReorden.Name = "txtPuntoDeReorden"
        txtPuntoDeReorden.Size = New Size(226, 31)
        txtPuntoDeReorden.TabIndex = 1
        ' 
        ' txtExistencia
        ' 
        txtExistencia.Location = New Point(182, 171)
        txtExistencia.Margin = New Padding(4)
        txtExistencia.Name = "txtExistencia"
        txtExistencia.Size = New Size(226, 31)
        txtExistencia.TabIndex = 1
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(182, 75)
        txtDescripcion.Margin = New Padding(4)
        txtDescripcion.Multiline = True
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(226, 78)
        txtDescripcion.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 171)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 25)
        Label5.TabIndex = 0
        Label5.Text = "Existencia"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(466, 134)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 0
        Label2.Text = "Costo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 78)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 25)
        Label3.TabIndex = 0
        Label3.Text = "Descripcion"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(rbInactivo)
        Panel7.Controls.Add(rbActivo)
        Panel7.Controls.Add(Label7)
        Panel7.Location = New Point(466, 196)
        Panel7.Margin = New Padding(4)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(431, 59)
        Panel7.TabIndex = 8
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
        Label7.Size = New Size(68, 25)
        Label7.TabIndex = 0
        Label7.Text = "Estatus"
        ' 
        ' txtCosto
        ' 
        txtCosto.Location = New Point(535, 134)
        txtCosto.Margin = New Padding(4)
        txtCosto.Name = "txtCosto"
        txtCosto.Size = New Size(226, 31)
        txtCosto.TabIndex = 1
        ' 
        ' txtITBMS
        ' 
        txtITBMS.Location = New Point(535, 78)
        txtITBMS.Margin = New Padding(4)
        txtITBMS.Name = "txtITBMS"
        txtITBMS.ReadOnly = True
        txtITBMS.Size = New Size(226, 31)
        txtITBMS.TabIndex = 1
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(535, 22)
        txtPrecio.Margin = New Padding(4)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(226, 31)
        txtPrecio.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(467, 78)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 25)
        Label4.TabIndex = 0
        Label4.Text = "Itbms"
        ' 
        ' txtCodigoBarra
        ' 
        txtCodigoBarra.Location = New Point(182, 14)
        txtCodigoBarra.Margin = New Padding(4)
        txtCodigoBarra.Name = "txtCodigoBarra"
        txtCodigoBarra.Size = New Size(226, 31)
        txtCodigoBarra.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(467, 20)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 25)
        Label8.TabIndex = 0
        Label8.Text = "Precio"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 22)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 25)
        Label1.TabIndex = 0
        Label1.Text = "Codigo de Barra"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(365, 22)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(305, 45)
        Label9.TabIndex = 9
        Label9.Text = "Agreagar Producto"
        ' 
        ' FormAgregarProducto
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(986, 470)
        Controls.Add(Label9)
        Controls.Add(Panel1)
        Controls.Add(BtnAgregarProdcuto)
        Margin = New Padding(4)
        Name = "FormAgregarProducto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormAgregarProducto"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnAgregarProdcuto As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCodigoBarra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtITBMS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtExistencia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPuntoDeReorden As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents rbInactivo As CheckBox
    Friend WithEvents rbActivo As CheckBox
End Class
