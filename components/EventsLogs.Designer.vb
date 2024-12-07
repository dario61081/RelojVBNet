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
        lvLog = New ListView()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ExportarToolStripMenuItem = New ToolStripMenuItem()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lvLog
        ' 
        lvLog.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader8, ColumnHeader9})
        lvLog.Dock = DockStyle.Fill
        lvLog.Location = New Point(0, 0)
        lvLog.Name = "lvLog"
        lvLog.Size = New Size(702, 520)
        lvLog.TabIndex = 2
        lvLog.UseCompatibleStateImageBehavior = False
        lvLog.View = View.Details
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
        ' EventsLogs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lvLog)
        Name = "EventsLogs"
        Size = New Size(702, 520)
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lvLog As ListView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader

End Class
