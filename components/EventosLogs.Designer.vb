<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventsLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EventsLogs))
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ExportarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripContainer1 = New ToolStripContainer()
        lvLog = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ImageList1 = New ImageList(components)
        ToolStrip1 = New ToolStrip()
        ToolStripButton1 = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        ToolStripButton2 = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        lblContador = New ToolStripLabel()
        ToolStripButton3 = New ToolStripButton()
        ContextMenuStrip1.SuspendLayout()
        ToolStripContainer1.ContentPanel.SuspendLayout()
        ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        ToolStripContainer1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ExportarToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(128, 26)
        ' 
        ' ExportarToolStripMenuItem
        ' 
        ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        ExportarToolStripMenuItem.Size = New Size(127, 22)
        ExportarToolStripMenuItem.Text = "Exportar..."
        ' 
        ' ToolStripContainer1
        ' 
        ' 
        ' ToolStripContainer1.ContentPanel
        ' 
        ToolStripContainer1.ContentPanel.Controls.Add(lvLog)
        ToolStripContainer1.ContentPanel.Size = New Size(599, 261)
        ToolStripContainer1.Dock = DockStyle.Fill
        ToolStripContainer1.Location = New Point(0, 0)
        ToolStripContainer1.Name = "ToolStripContainer1"
        ToolStripContainer1.Size = New Size(599, 286)
        ToolStripContainer1.TabIndex = 1
        ToolStripContainer1.Text = "ToolStripContainer1"
        ' 
        ' ToolStripContainer1.TopToolStripPanel
        ' 
        ToolStripContainer1.TopToolStripPanel.Controls.Add(ToolStrip1)
        ' 
        ' lvLog
        ' 
        lvLog.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader8, ColumnHeader9})
        lvLog.Dock = DockStyle.Fill
        lvLog.FullRowSelect = True
        lvLog.GridLines = True
        lvLog.HideSelection = False
        lvLog.Location = New Point(0, 0)
        lvLog.Name = "lvLog"
        lvLog.Size = New Size(599, 261)
        lvLog.SmallImageList = ImageList1
        lvLog.TabIndex = 3
        lvLog.UseCompatibleStateImageBehavior = False
        lvLog.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Fecha Evento"
        ColumnHeader1.Width = 120
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "IdDispositivo"
        ColumnHeader2.Width = 120
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "TipoEvento"
        ColumnHeader8.Width = 120
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Descripción"
        ColumnHeader9.Width = 300
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "icons8-información-16.png")
        ImageList1.Images.SetKeyName(1, "icons8-alta-importancia-16 (1).png")
        ImageList1.Images.SetKeyName(2, "icons8-error-16.png")
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton1, ToolStripButton3, ToolStripSeparator1, ToolStripButton2, ToolStripSeparator2, lblContador})
        ToolStrip1.Location = New Point(3, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(217, 25)
        ToolStrip1.TabIndex = 0
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = My.Resources.Resources.icons8_basura_16
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 22)
        ToolStripButton1.Text = "Limpiar salida"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.Image = My.Resources.Resources.icons8_descargar_16
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(23, 22)
        ToolStripButton2.Text = "Descargar contenido en archivo..."
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' lblContador
        ' 
        lblContador.Name = "lblContador"
        lblContador.Size = New Size(93, 22)
        lblContador.Text = "Encontrado(s): 0"
        ' 
        ' ToolStripButton3
        ' 
        ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton3.Image = My.Resources.Resources.icons8_cambiar_tamaño_horizontal_16
        ToolStripButton3.ImageTransparentColor = Color.Magenta
        ToolStripButton3.Name = "ToolStripButton3"
        ToolStripButton3.Size = New Size(23, 22)
        ToolStripButton3.Text = "Auto ajustar columnas"
        ' 
        ' EventsLogs
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ToolStripContainer1)
        Name = "EventsLogs"
        Size = New Size(599, 286)
        ContextMenuStrip1.ResumeLayout(False)
        ToolStripContainer1.ContentPanel.ResumeLayout(False)
        ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        ToolStripContainer1.TopToolStripPanel.PerformLayout()
        ToolStripContainer1.ResumeLayout(False)
        ToolStripContainer1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents lvLog As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents lblContador As ToolStripLabel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolStripButton3 As ToolStripButton

End Class
