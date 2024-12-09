<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelojesList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelojesList))
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ConectarRelojToolStripMenuItem = New ToolStripMenuItem()
        DesconectarRelojToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        LeerEventosToolStripMenuItem = New ToolStripMenuItem()
        BorrarEventosToolStripMenuItem = New ToolStripMenuItem()
        ImageList1 = New ImageList(components)
        ToolStripContainer1 = New ToolStripContainer()
        LvDispositivos = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ToolStrip1 = New ToolStrip()
        ToolStripButton1 = New ToolStripButton()
        ToolStripButton2 = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        ToolStripButton3 = New ToolStripButton()
        StatusStrip1 = New StatusStrip()
        ContextMenuStrip1.SuspendLayout()
        ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        ToolStripContainer1.ContentPanel.SuspendLayout()
        ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        ToolStripContainer1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
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
        ' ToolStripContainer1
        ' 
        ' 
        ' ToolStripContainer1.BottomToolStripPanel
        ' 
        ToolStripContainer1.BottomToolStripPanel.Controls.Add(StatusStrip1)
        ' 
        ' ToolStripContainer1.ContentPanel
        ' 
        ToolStripContainer1.ContentPanel.Controls.Add(LvDispositivos)
        ToolStripContainer1.ContentPanel.Size = New Size(224, 380)
        ToolStripContainer1.Dock = DockStyle.Fill
        ToolStripContainer1.Location = New Point(0, 0)
        ToolStripContainer1.Name = "ToolStripContainer1"
        ToolStripContainer1.Size = New Size(224, 427)
        ToolStripContainer1.TabIndex = 1
        ToolStripContainer1.Text = "ToolStripContainer1"
        ' 
        ' ToolStripContainer1.TopToolStripPanel
        ' 
        ToolStripContainer1.TopToolStripPanel.Controls.Add(ToolStrip1)
        ' 
        ' LvDispositivos
        ' 
        LvDispositivos.Activation = ItemActivation.OneClick
        LvDispositivos.CheckBoxes = True
        LvDispositivos.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        LvDispositivos.ContextMenuStrip = ContextMenuStrip1
        LvDispositivos.Dock = DockStyle.Fill
        LvDispositivos.FullRowSelect = True
        LvDispositivos.GridLines = True
        LvDispositivos.HoverSelection = True
        LvDispositivos.Location = New Point(0, 0)
        LvDispositivos.Name = "LvDispositivos"
        LvDispositivos.Size = New Size(224, 380)
        LvDispositivos.SmallImageList = ImageList1
        LvDispositivos.TabIndex = 2
        LvDispositivos.UseCompatibleStateImageBehavior = False
        LvDispositivos.View = View.Details
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
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton1, ToolStripButton2, ToolStripSeparator2, ToolStripButton3})
        ToolStrip1.Location = New Point(3, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(87, 25)
        ToolStrip1.TabIndex = 0
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = My.Resources.Resources.icons8_marque_todas_las_16
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 22)
        ToolStripButton1.Text = "Seleccionar todos"
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.Image = My.Resources.Resources.icons8_desactive_todas_16
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(23, 22)
        ToolStripButton2.Text = "Deseleccionar todos"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' ToolStripButton3
        ' 
        ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton3.Image = My.Resources.Resources.icons8_descargar_16
        ToolStripButton3.ImageTransparentColor = Color.Magenta
        ToolStripButton3.Name = "ToolStripButton3"
        ToolStripButton3.Size = New Size(23, 22)
        ToolStripButton3.Text = "Descargar eventos de marcación"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Dock = DockStyle.None
        StatusStrip1.Location = New Point(0, 0)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(224, 22)
        StatusStrip1.TabIndex = 0
        ' 
        ' RelojesList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ToolStripContainer1)
        Name = "RelojesList"
        Size = New Size(224, 427)
        ContextMenuStrip1.ResumeLayout(False)
        ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        ToolStripContainer1.ContentPanel.ResumeLayout(False)
        ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        ToolStripContainer1.TopToolStripPanel.PerformLayout()
        ToolStripContainer1.ResumeLayout(False)
        ToolStripContainer1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ConectarRelojToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesconectarRelojToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LeerEventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarEventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents LvDispositivos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip

End Class
