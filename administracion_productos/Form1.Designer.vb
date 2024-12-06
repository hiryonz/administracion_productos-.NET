<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        PresentacionToolStripMenuItem = New ToolStripMenuItem()
        MantenimientoToolStripMenuItem = New ToolStripMenuItem()
        ClienteToolStripMenuItem = New ToolStripMenuItem()
        ProductoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, MantenimientoToolStripMenuItem, ToolStripMenuItem1, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.Size = New Size(1553, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InicioToolStripMenuItem
        ' 
        InicioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PresentacionToolStripMenuItem})
        InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        InicioToolStripMenuItem.Size = New Size(70, 29)
        InicioToolStripMenuItem.Text = "Inicio"
        ' 
        ' PresentacionToolStripMenuItem
        ' 
        PresentacionToolStripMenuItem.Name = "PresentacionToolStripMenuItem"
        PresentacionToolStripMenuItem.Size = New Size(214, 34)
        PresentacionToolStripMenuItem.Text = "Presentacion"
        ' 
        ' MantenimientoToolStripMenuItem
        ' 
        MantenimientoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClienteToolStripMenuItem, ProductoToolStripMenuItem})
        MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        MantenimientoToolStripMenuItem.Size = New Size(148, 29)
        MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        ' 
        ' ClienteToolStripMenuItem
        ' 
        ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        ClienteToolStripMenuItem.Size = New Size(187, 34)
        ClienteToolStripMenuItem.Text = "Cliente"
        ' 
        ' ProductoToolStripMenuItem
        ' 
        ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        ProductoToolStripMenuItem.Size = New Size(187, 34)
        ProductoToolStripMenuItem.Text = "Producto"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(16, 29)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(61, 29)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1553, 807)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PresentacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem

End Class
