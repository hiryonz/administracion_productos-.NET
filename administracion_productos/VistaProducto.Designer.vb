<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VistaProducto
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        BtnListarProducto = New Button()
        BtnEliminarProducto = New Button()
        BtnModificarProducto = New Button()
        BtnAdiccionarProducto = New Button()
        BtnLimpiarProducto = New Button()
        BtnBuscarProducto = New Button()
        searchProducto = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        DataGridViewProducto = New DataGridView()
        GroupBox1 = New GroupBox()
        rbDescripcion = New RadioButton()
        rbCodigoBarra = New RadioButton()
        PanelContenedor = New Panel()
        FlowLayoutPanel1.SuspendLayout()
        CType(DataGridViewProducto, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(BtnListarProducto)
        FlowLayoutPanel1.Controls.Add(BtnEliminarProducto)
        FlowLayoutPanel1.Controls.Add(BtnModificarProducto)
        FlowLayoutPanel1.Controls.Add(BtnAdiccionarProducto)
        FlowLayoutPanel1.Controls.Add(BtnLimpiarProducto)
        FlowLayoutPanel1.Location = New Point(44, 99)
        FlowLayoutPanel1.Margin = New Padding(4)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1005, 45)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' BtnListarProducto
        ' 
        BtnListarProducto.Location = New Point(4, 4)
        BtnListarProducto.Margin = New Padding(4)
        BtnListarProducto.Name = "BtnListarProducto"
        BtnListarProducto.Size = New Size(188, 36)
        BtnListarProducto.TabIndex = 0
        BtnListarProducto.Text = "Ver Producto"
        BtnListarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnEliminarProducto
        ' 
        BtnEliminarProducto.Location = New Point(200, 4)
        BtnEliminarProducto.Margin = New Padding(4)
        BtnEliminarProducto.Name = "BtnEliminarProducto"
        BtnEliminarProducto.Size = New Size(196, 36)
        BtnEliminarProducto.TabIndex = 1
        BtnEliminarProducto.Text = "Eliminar Producto"
        BtnEliminarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnModificarProducto
        ' 
        BtnModificarProducto.Location = New Point(404, 4)
        BtnModificarProducto.Margin = New Padding(4)
        BtnModificarProducto.Name = "BtnModificarProducto"
        BtnModificarProducto.Size = New Size(192, 36)
        BtnModificarProducto.TabIndex = 2
        BtnModificarProducto.Text = "ModificarProducto"
        BtnModificarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnAdiccionarProducto
        ' 
        BtnAdiccionarProducto.Location = New Point(604, 4)
        BtnAdiccionarProducto.Margin = New Padding(4)
        BtnAdiccionarProducto.Name = "BtnAdiccionarProducto"
        BtnAdiccionarProducto.Size = New Size(200, 36)
        BtnAdiccionarProducto.TabIndex = 3
        BtnAdiccionarProducto.Text = "Agreagar Producto"
        BtnAdiccionarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnLimpiarProducto
        ' 
        BtnLimpiarProducto.Location = New Point(812, 4)
        BtnLimpiarProducto.Margin = New Padding(4)
        BtnLimpiarProducto.Name = "BtnLimpiarProducto"
        BtnLimpiarProducto.Size = New Size(179, 36)
        BtnLimpiarProducto.TabIndex = 4
        BtnLimpiarProducto.Text = "Limpiar Salida"
        BtnLimpiarProducto.UseVisualStyleBackColor = True
        ' 
        ' BtnBuscarProducto
        ' 
        BtnBuscarProducto.Location = New Point(1321, 99)
        BtnBuscarProducto.Margin = New Padding(4)
        BtnBuscarProducto.Name = "BtnBuscarProducto"
        BtnBuscarProducto.Size = New Size(118, 45)
        BtnBuscarProducto.TabIndex = 5
        BtnBuscarProducto.Text = "Buscar"
        BtnBuscarProducto.UseVisualStyleBackColor = True
        ' 
        ' searchProducto
        ' 
        searchProducto.Location = New Point(1072, 108)
        searchProducto.Margin = New Padding(4)
        searchProducto.Name = "searchProducto"
        searchProducto.PlaceholderText = "codigo barra"
        searchProducto.Size = New Size(230, 31)
        searchProducto.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(630, 29)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(380, 38)
        Label1.TabIndex = 2
        Label1.Text = "Administracion de Producto "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1072, 76)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 25)
        Label2.TabIndex = 4
        Label2.Text = "Buscar productos:"
        ' 
        ' DataGridViewProducto
        ' 
        DataGridViewProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewProducto.Location = New Point(24, 312)
        DataGridViewProducto.Margin = New Padding(4)
        DataGridViewProducto.Name = "DataGridViewProducto"
        DataGridViewProducto.RowHeadersWidth = 51
        DataGridViewProducto.Size = New Size(1399, 338)
        DataGridViewProducto.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbDescripcion)
        GroupBox1.Controls.Add(rbCodigoBarra)
        GroupBox1.Location = New Point(44, 190)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(379, 98)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Order By "
        ' 
        ' rbDescripcion
        ' 
        rbDescripcion.AutoSize = True
        rbDescripcion.Location = New Point(206, 45)
        rbDescripcion.Margin = New Padding(4)
        rbDescripcion.Name = "rbDescripcion"
        rbDescripcion.Size = New Size(129, 29)
        rbDescripcion.TabIndex = 1
        rbDescripcion.TabStop = True
        rbDescripcion.Text = "Descripcion"
        rbDescripcion.UseVisualStyleBackColor = True
        ' 
        ' rbCodigoBarra
        ' 
        rbCodigoBarra.AutoSize = True
        rbCodigoBarra.Location = New Point(26, 45)
        rbCodigoBarra.Margin = New Padding(4)
        rbCodigoBarra.Name = "rbCodigoBarra"
        rbCodigoBarra.Size = New Size(141, 29)
        rbCodigoBarra.TabIndex = 0
        rbCodigoBarra.TabStop = True
        rbCodigoBarra.Text = "Codigo Barra"
        rbCodigoBarra.UseVisualStyleBackColor = True
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.BackColor = Color.Transparent
        PanelContenedor.Location = New Point(473, 164)
        PanelContenedor.Margin = New Padding(4)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(995, 578)
        PanelContenedor.TabIndex = 16
        ' 
        ' VistaProducto
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1490, 782)
        Controls.Add(PanelContenedor)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridViewProducto)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnBuscarProducto)
        Controls.Add(searchProducto)
        Controls.Add(FlowLayoutPanel1)
        Margin = New Padding(4)
        Name = "VistaProducto"
        Text = "VistaProducto"
        FlowLayoutPanel1.ResumeLayout(False)
        CType(DataGridViewProducto, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtnListarProducto As Button
    Friend WithEvents BtnEliminarProducto As Button
    Friend WithEvents BtnModificarProducto As Button
    Friend WithEvents BtnAdiccionarProducto As Button
    Friend WithEvents BtnLimpiarProducto As Button
    Friend WithEvents BtnBuscarProducto As Button
    Friend WithEvents searchProducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewProducto As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbDescripcion As RadioButton
    Friend WithEvents rbCodigoBarra As RadioButton
    Friend WithEvents PanelContenedor As Panel
End Class
