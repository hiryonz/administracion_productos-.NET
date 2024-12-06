Public Class Form1

    ' Método de carga del formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PresentacionToolStripMenuItem.PerformClick()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub cerrarVentanas()
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click

        Dim vista = New VistaCliente()
        cerrarVentanas()
        vista.MdiParent = Me ' Establecer el formulario principal como MdiParent
        vista.WindowState = FormWindowState.Maximized ' Establecer el estado de la ventana a maximizado
        vista.Show() ' Mostrar el formulario
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Dim vista = New VistaProducto()
        cerrarVentanas()
        vista.MdiParent = Me ' Establecer el formulario principal como MdiParent
        vista.WindowState = FormWindowState.Maximized ' Establecer el estado de la ventana a maximizado
        vista.Show() ' Mostrar el formulario
    End Sub

    Private Sub PresentacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentacionToolStripMenuItem.Click
        Dim vista = New VistaPresentacion()
        cerrarVentanas()
        vista.MdiParent = Me ' Establecer el formulario principal como MdiParent
        vista.WindowState = FormWindowState.Maximized ' Establecer el estado de la ventana a maximizado
        vista.Show() ' Mostrar el formulario
    End Sub
End Class

