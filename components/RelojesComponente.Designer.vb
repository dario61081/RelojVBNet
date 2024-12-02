<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelojesComponente
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
		components = New ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelojesComponente))
		GroupBox1 = New GroupBox()
		lvdispositivos = New ListView()
		ColumnHeader1 = New ColumnHeader()
		ColumnHeader2 = New ColumnHeader()
		ContextMenuStrip1 = New ContextMenuStrip(components)
		ConectarRelojToolStripMenuItem = New ToolStripMenuItem()
		DesconectarRelojToolStripMenuItem = New ToolStripMenuItem()
		ToolStripSeparator1 = New ToolStripSeparator()
		LeerEventosToolStripMenuItem = New ToolStripMenuItem()
		BorrarEventosToolStripMenuItem = New ToolStripMenuItem()
		ImageList1 = New ImageList(components)
		GroupBox1.SuspendLayout()
		ContextMenuStrip1.SuspendLayout()
		SuspendLayout()
		' 
		' GroupBox1
		' 
		GroupBox1.Controls.Add(lvdispositivos)
		GroupBox1.Dock = DockStyle.Fill
		GroupBox1.Location = New Point(0, 0)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(224, 427)
		GroupBox1.TabIndex = 1
		GroupBox1.TabStop = False
		GroupBox1.Text = "Dispositivos"
		' 
		' lvdispositivos
		' 
		lvdispositivos.Activation = ItemActivation.OneClick
		lvdispositivos.CheckBoxes = True
		lvdispositivos.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
		lvdispositivos.ContextMenuStrip = ContextMenuStrip1
		lvdispositivos.Dock = DockStyle.Fill
		lvdispositivos.FullRowSelect = True
		lvdispositivos.GridLines = True
		lvdispositivos.HeaderStyle = ColumnHeaderStyle.Nonclickable
		lvdispositivos.HoverSelection = True
		lvdispositivos.Location = New Point(3, 19)
		lvdispositivos.Name = "lvdispositivos"
		lvdispositivos.Size = New Size(218, 405)
		lvdispositivos.SmallImageList = ImageList1
		lvdispositivos.TabIndex = 0
		lvdispositivos.UseCompatibleStateImageBehavior = False
		lvdispositivos.View = View.Details
		' 
		' ColumnHeader1
		' 
		ColumnHeader1.Text = "Direccion IP"
		ColumnHeader1.Width = 120
		' 
		' ColumnHeader2
		' 
		ColumnHeader2.Text = "Nombre"
		ColumnHeader2.Width = 80
		' 
		' ContextMenuStrip1
		' 
		ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ConectarRelojToolStripMenuItem, DesconectarRelojToolStripMenuItem, ToolStripSeparator1, LeerEventosToolStripMenuItem, BorrarEventosToolStripMenuItem})
		ContextMenuStrip1.Name = "ContextMenuStrip1"
		ContextMenuStrip1.Size = New Size(166, 98)
		' 
		' ConectarRelojToolStripMenuItem
		' 
		ConectarRelojToolStripMenuItem.Name = "ConectarRelojToolStripMenuItem"
		ConectarRelojToolStripMenuItem.Size = New Size(165, 22)
		ConectarRelojToolStripMenuItem.Text = "Conectar reloj"
		' 
		' DesconectarRelojToolStripMenuItem
		' 
		DesconectarRelojToolStripMenuItem.Name = "DesconectarRelojToolStripMenuItem"
		DesconectarRelojToolStripMenuItem.Size = New Size(165, 22)
		DesconectarRelojToolStripMenuItem.Text = "Desconectar reloj"
		' 
		' ToolStripSeparator1
		' 
		ToolStripSeparator1.Name = "ToolStripSeparator1"
		ToolStripSeparator1.Size = New Size(162, 6)
		' 
		' LeerEventosToolStripMenuItem
		' 
		LeerEventosToolStripMenuItem.Name = "LeerEventosToolStripMenuItem"
		LeerEventosToolStripMenuItem.Size = New Size(165, 22)
		LeerEventosToolStripMenuItem.Text = "Leer eventos..."
		' 
		' BorrarEventosToolStripMenuItem
		' 
		BorrarEventosToolStripMenuItem.Name = "BorrarEventosToolStripMenuItem"
		BorrarEventosToolStripMenuItem.Size = New Size(165, 22)
		BorrarEventosToolStripMenuItem.Text = "Borrar eventos..."
		' 
		' ImageList1
		' 
		ImageList1.ColorDepth = ColorDepth.Depth32Bit
		ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
		ImageList1.TransparentColor = Color.Transparent
		ImageList1.Images.SetKeyName(0, "icons8-reloj-16.png")
		ImageList1.Images.SetKeyName(1, "icons8-de-acuerdo-16.png")
		ImageList1.Images.SetKeyName(2, "icons8-alta-importancia-16.png")
		ImageList1.Images.SetKeyName(3, "icons8-cancelar-16.png")
		ImageList1.Images.SetKeyName(4, "icons8-reproducir-en-círculo-16.png")
		' 
		' RelojesComponente
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		Controls.Add(GroupBox1)
		Name = "RelojesComponente"
		Size = New Size(224, 427)
		GroupBox1.ResumeLayout(False)
		ContextMenuStrip1.ResumeLayout(False)
		ResumeLayout(False)
	End Sub

	Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lvdispositivos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ConectarRelojToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesconectarRelojToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LeerEventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarEventosToolStripMenuItem As ToolStripMenuItem

End Class
