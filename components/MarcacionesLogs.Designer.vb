<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarcacionesLogs
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
        ToolStripContainer1 = New ToolStripContainer()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ToolStrip1 = New ToolStrip()
        ToolStripButton1 = New ToolStripButton()
        ToolStripContainer1.ContentPanel.SuspendLayout()
        ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        ToolStripContainer1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStripContainer1
        ' 
        ' 
        ' ToolStripContainer1.ContentPanel
        ' 
        ToolStripContainer1.ContentPanel.Controls.Add(ListView1)
        ToolStripContainer1.ContentPanel.Size = New Size(570, 352)
        ToolStripContainer1.Dock = DockStyle.Fill
        ToolStripContainer1.Location = New Point(0, 0)
        ToolStripContainer1.Name = "ToolStripContainer1"
        ToolStripContainer1.Size = New Size(570, 377)
        ToolStripContainer1.TabIndex = 0
        ToolStripContainer1.Text = "ToolStripContainer1"
        ' 
        ' ToolStripContainer1.TopToolStripPanel
        ' 
        ToolStripContainer1.TopToolStripPanel.Controls.Add(ToolStrip1)
        ' 
        ' ListView1
        ' 
        ListView1.CheckBoxes = True
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        ListView1.Dock = DockStyle.Fill
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Location = New Point(0, 0)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(570, 352)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Fecha/hora"
        ColumnHeader1.Width = 120
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Legajo N°"
        ColumnHeader2.Width = 120
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "TipoEvento"
        ColumnHeader3.Width = 120
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Dispositivo #"
        ColumnHeader4.Width = 120
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton1})
        ToolStrip1.Location = New Point(3, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(35, 25)
        ToolStrip1.TabIndex = 0
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = My.Resources.Resources.icons8_subir_16
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 22)
        ToolStripButton1.Text = "Upload a base de datos"
        ' 
        ' MarcacionesLogs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ToolStripContainer1)
        Name = "MarcacionesLogs"
        Size = New Size(570, 377)
        ToolStripContainer1.ContentPanel.ResumeLayout(False)
        ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        ToolStripContainer1.TopToolStripPanel.PerformLayout()
        ToolStripContainer1.ResumeLayout(False)
        ToolStripContainer1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton

End Class
