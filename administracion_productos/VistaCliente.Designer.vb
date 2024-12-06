<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VistaCliente
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label1 = New Label()
        searchCliente = New TextBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        BtnListarCliente = New Button()
        BtnEliminarCliente = New Button()
        BtnModificarCliente = New Button()
        BtnAdiccionarCliente = New Button()
        BtnLimpiarCliente = New Button()
        BtnBuscarCliente = New Button()
        DataGridViewCliente = New DataGridView()
        GroupBox1 = New GroupBox()
        rbCedula = New RadioButton()
        rbNombre = New RadioButton()
        PanelContenedor = New Panel()
        FlowLayoutPanel1.SuspendLayout()
        CType(DataGridViewCliente, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1077, 87)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 25)
        Label2.TabIndex = 9
        Label2.Text = "Busqueda por cedula"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(606, 38)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 38)
        Label1.TabIndex = 7
        Label1.Text = "Administracion de clientes"
        ' 
        ' searchCliente
        ' 
        searchCliente.Location = New Point(1077, 116)
        searchCliente.Margin = New Padding(4)
        searchCliente.Name = "searchCliente"
        searchCliente.PlaceholderText = "xx-xxx-xxxx"
        searchCliente.Size = New Size(230, 31)
        searchCliente.TabIndex = 6
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(BtnListarCliente)
        FlowLayoutPanel1.Controls.Add(BtnEliminarCliente)
        FlowLayoutPanel1.Controls.Add(BtnModificarCliente)
        FlowLayoutPanel1.Controls.Add(BtnAdiccionarCliente)
        FlowLayoutPanel1.Controls.Add(BtnLimpiarCliente)
        FlowLayoutPanel1.Location = New Point(43, 103)
        FlowLayoutPanel1.Margin = New Padding(4)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1016, 50)
        FlowLayoutPanel1.TabIndex = 5
        ' 
        ' BtnListarCliente
        ' 
        BtnListarCliente.Location = New Point(4, 4)
        BtnListarCliente.Margin = New Padding(4)
        BtnListarCliente.Name = "BtnListarCliente"
        BtnListarCliente.Size = New Size(188, 36)
        BtnListarCliente.TabIndex = 0
        BtnListarCliente.Text = "Ver Cliente"
        BtnListarCliente.UseVisualStyleBackColor = True
        ' 
        ' BtnEliminarCliente
        ' 
        BtnEliminarCliente.Location = New Point(200, 4)
        BtnEliminarCliente.Margin = New Padding(4)
        BtnEliminarCliente.Name = "BtnEliminarCliente"
        BtnEliminarCliente.Size = New Size(196, 36)
        BtnEliminarCliente.TabIndex = 1
        BtnEliminarCliente.Text = "Eliminar Cliente"
        BtnEliminarCliente.UseVisualStyleBackColor = True
        ' 
        ' BtnModificarCliente
        ' 
        BtnModificarCliente.Location = New Point(404, 4)
        BtnModificarCliente.Margin = New Padding(4)
        BtnModificarCliente.Name = "BtnModificarCliente"
        BtnModificarCliente.Size = New Size(192, 36)
        BtnModificarCliente.TabIndex = 2
        BtnModificarCliente.Text = "Modificar Cliente"
        BtnModificarCliente.UseVisualStyleBackColor = True
        ' 
        ' BtnAdiccionarCliente
        ' 
        BtnAdiccionarCliente.Location = New Point(604, 4)
        BtnAdiccionarCliente.Margin = New Padding(4)
        BtnAdiccionarCliente.Name = "BtnAdiccionarCliente"
        BtnAdiccionarCliente.Size = New Size(200, 36)
        BtnAdiccionarCliente.TabIndex = 3
        BtnAdiccionarCliente.Text = "Agregar Cliente"
        BtnAdiccionarCliente.UseVisualStyleBackColor = True
        ' 
        ' BtnLimpiarCliente
        ' 
        BtnLimpiarCliente.Location = New Point(812, 4)
        BtnLimpiarCliente.Margin = New Padding(4)
        BtnLimpiarCliente.Name = "BtnLimpiarCliente"
        BtnLimpiarCliente.Size = New Size(179, 36)
        BtnLimpiarCliente.TabIndex = 4
        BtnLimpiarCliente.Text = "Limpiar Salida"
        BtnLimpiarCliente.UseVisualStyleBackColor = True
        ' 
        ' BtnBuscarCliente
        ' 
        BtnBuscarCliente.Location = New Point(1315, 103)
        BtnBuscarCliente.Margin = New Padding(4)
        BtnBuscarCliente.Name = "BtnBuscarCliente"
        BtnBuscarCliente.Size = New Size(118, 46)
        BtnBuscarCliente.TabIndex = 5
        BtnBuscarCliente.Text = "Buscar"
        BtnBuscarCliente.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewCliente
        ' 
        DataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCliente.Location = New Point(47, 320)
        DataGridViewCliente.Margin = New Padding(4)
        DataGridViewCliente.MultiSelect = False
        DataGridViewCliente.Name = "DataGridViewCliente"
        DataGridViewCliente.RowHeadersWidth = 51
        DataGridViewCliente.Size = New Size(1392, 335)
        DataGridViewCliente.TabIndex = 10
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbCedula)
        GroupBox1.Controls.Add(rbNombre)
        GroupBox1.Location = New Point(71, 192)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(379, 98)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = "Oderdar los datos"
        ' 
        ' rbCedula
        ' 
        rbCedula.AutoSize = True
        rbCedula.Location = New Point(206, 45)
        rbCedula.Margin = New Padding(4)
        rbCedula.Name = "rbCedula"
        rbCedula.Size = New Size(91, 29)
        rbCedula.TabIndex = 1
        rbCedula.TabStop = True
        rbCedula.Text = "Cedula"
        rbCedula.UseVisualStyleBackColor = True
        ' 
        ' rbNombre
        ' 
        rbNombre.AutoSize = True
        rbNombre.Location = New Point(26, 45)
        rbNombre.Margin = New Padding(4)
        rbNombre.Name = "rbNombre"
        rbNombre.Size = New Size(103, 29)
        rbNombre.TabIndex = 0
        rbNombre.TabStop = True
        rbNombre.Text = "Nombre"
        rbNombre.UseVisualStyleBackColor = True
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.Location = New Point(475, 180)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(1018, 584)
        PanelContenedor.TabIndex = 15
        ' 
        ' VistaCliente
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1505, 793)
        Controls.Add(GroupBox1)
        Controls.Add(PanelContenedor)
        Controls.Add(DataGridViewCliente)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnBuscarCliente)
        Controls.Add(searchCliente)
        Controls.Add(FlowLayoutPanel1)
        Margin = New Padding(4)
        Name = "VistaCliente"
        Text = "VistaCliente"
        FlowLayoutPanel1.ResumeLayout(False)
        CType(DataGridViewCliente, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents searchCliente As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtnListarCliente As Button
    Friend WithEvents BtnEliminarCliente As Button
    Friend WithEvents BtnModificarCliente As Button
    Friend WithEvents BtnAdiccionarCliente As Button
    Friend WithEvents BtnLimpiarCliente As Button
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents DataGridViewCliente As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbCedula As RadioButton
    Friend WithEvents rbNombre As RadioButton
    Friend WithEvents PanelContenedor As Panel
End Class
