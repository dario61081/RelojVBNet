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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelojesList))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LeerEventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeleccionarTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeseleccionarTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Loading1 = New RelojVBNET.Loading()
        Me.LvDispositivos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BorrarMarcacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegistrarRelojToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarRelojToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeerEventosToolStripMenuItem, Me.ToolStripSeparator1, Me.SeleccionarTodosToolStripMenuItem, Me.DeseleccionarTodosToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(299, 88)
        '
        'LeerEventosToolStripMenuItem
        '
        Me.LeerEventosToolStripMenuItem.Image = Global.RelojVBNET.My.Resources.Resources.icons8_descargar_16
        Me.LeerEventosToolStripMenuItem.Name = "LeerEventosToolStripMenuItem"
        Me.LeerEventosToolStripMenuItem.Size = New System.Drawing.Size(298, 26)
        Me.LeerEventosToolStripMenuItem.Text = "Descargar eventos de marcación"
        Me.LeerEventosToolStripMenuItem.ToolTipText = "Descargar eventos de marcación"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(295, 6)
        '
        'SeleccionarTodosToolStripMenuItem
        '
        Me.SeleccionarTodosToolStripMenuItem.Image = Global.RelojVBNET.My.Resources.Resources.icons8_marque_todas_las_16
        Me.SeleccionarTodosToolStripMenuItem.Name = "SeleccionarTodosToolStripMenuItem"
        Me.SeleccionarTodosToolStripMenuItem.Size = New System.Drawing.Size(298, 26)
        Me.SeleccionarTodosToolStripMenuItem.Text = "Seleccionar todos"
        '
        'DeseleccionarTodosToolStripMenuItem
        '
        Me.DeseleccionarTodosToolStripMenuItem.Image = Global.RelojVBNET.My.Resources.Resources.icons8_desactive_todas_16
        Me.DeseleccionarTodosToolStripMenuItem.Name = "DeseleccionarTodosToolStripMenuItem"
        Me.DeseleccionarTodosToolStripMenuItem.Size = New System.Drawing.Size(298, 26)
        Me.DeseleccionarTodosToolStripMenuItem.Text = "Deseleccionar todos"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-reloj-16 (4).png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-reloj-16.png")
        Me.ImageList1.Images.SetKeyName(2, "icons8-de-acuerdo-16.png")
        Me.ImageList1.Images.SetKeyName(3, "icons8-alta-importancia-16.png")
        Me.ImageList1.Images.SetKeyName(4, "icons8-cancelar-16.png")
        Me.ImageList1.Images.SetKeyName(5, "icons8-reproducir-en-círculo-16.png")
        Me.ImageList1.Images.SetKeyName(6, "icons8-reloj-16 (2).png")
        Me.ImageList1.Images.SetKeyName(7, "icons8-reloj-16 (3).png")
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.LvDispositivos)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Loading1)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(256, 542)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(256, 569)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer1.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        '
        'Loading1
        '
        Me.Loading1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Loading1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Loading1.Location = New System.Drawing.Point(0, 0)
        Me.Loading1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Loading1.Name = "Loading1"
        Me.Loading1.Size = New System.Drawing.Size(256, 542)
        Me.Loading1.TabIndex = 2
        Me.Loading1.Visible = False
        '
        'LvDispositivos
        '
        Me.LvDispositivos.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LvDispositivos.CheckBoxes = True
        Me.LvDispositivos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LvDispositivos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LvDispositivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvDispositivos.FullRowSelect = True
        Me.LvDispositivos.GridLines = True
        Me.LvDispositivos.HideSelection = False
        Me.LvDispositivos.HoverSelection = True
        Me.LvDispositivos.Location = New System.Drawing.Point(0, 0)
        Me.LvDispositivos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LvDispositivos.Name = "LvDispositivos"
        Me.LvDispositivos.Size = New System.Drawing.Size(256, 542)
        Me.LvDispositivos.SmallImageList = Me.ImageList1
        Me.LvDispositivos.TabIndex = 2
        Me.LvDispositivos.UseCompatibleStateImageBehavior = False
        Me.LvDispositivos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Direccion IP"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Dispositivo #"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Estado"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(175, 27)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarMarcacionesToolStripMenuItem, Me.ToolStripSeparator4, Me.RegistrarRelojToolStripMenuItem, Me.BorrarRelojToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.RelojVBNET.My.Resources.Resources.icons8_ajustes_16
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(34, 24)
        Me.ToolStripDropDownButton1.Text = "Configuraciones extras"
        '
        'BorrarMarcacionesToolStripMenuItem
        '
        Me.BorrarMarcacionesToolStripMenuItem.Image = Global.RelojVBNET.My.Resources.Resources.icons8_basura_16
        Me.BorrarMarcacionesToolStripMenuItem.Name = "BorrarMarcacionesToolStripMenuItem"
        Me.BorrarMarcacionesToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.BorrarMarcacionesToolStripMenuItem.Text = "Borrar marcaciones..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(226, 6)
        '
        'RegistrarRelojToolStripMenuItem
        '
        Me.RegistrarRelojToolStripMenuItem.Image = Global.RelojVBNET.My.Resources.Resources.icons8_reloj_16
        Me.RegistrarRelojToolStripMenuItem.Name = "RegistrarRelojToolStripMenuItem"
        Me.RegistrarRelojToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.RegistrarRelojToolStripMenuItem.Text = "Registrar reloj..."
        '
        'BorrarRelojToolStripMenuItem
        '
        Me.BorrarRelojToolStripMenuItem.Image = Global.RelojVBNET.My.Resources.Resources.icons8_reloj_16__1_1
        Me.BorrarRelojToolStripMenuItem.Name = "BorrarRelojToolStripMenuItem"
        Me.BorrarRelojToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.BorrarRelojToolStripMenuItem.Text = "Borrar reloj..."
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.RelojVBNET.My.Resources.Resources.icons8_reloj_16__2_
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton4.Text = "Verificar"
        Me.ToolStripButton4.ToolTipText = "Verificar el estado de los relojes"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.RelojVBNET.My.Resources.Resources.icons8_marque_todas_las_16
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton1.Text = "Seleccionar todos"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.RelojVBNET.My.Resources.Resources.icons8_desactive_todas_16
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton2.Text = "Deseleccionar todos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.RelojVBNET.My.Resources.Resources.icons8_descargar_16
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton3.Text = "Descargar eventos de marcación"
        '
        'RelojesList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "RelojesList"
        Me.Size = New System.Drawing.Size(256, 569)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LeerEventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents LvDispositivos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SeleccionarTodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeseleccionarTodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents BorrarMarcacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents RegistrarRelojToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarRelojToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Loading1 As Loading
End Class
