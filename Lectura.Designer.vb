<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lectura
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lectura))
        ToolStripContainer1 = New ToolStripContainer()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        ToolStripStatusLabel3 = New ToolStripStatusLabel()
        SplitContainer1 = New SplitContainer()
        TabTree = New TabControl()
        TabPage2 = New TabPage()
        RelojesList1 = New RelojesList()
        SplitContainer2 = New SplitContainer()
        TabControl2 = New TabControl()
        TabPage4 = New TabPage()
        MarcacionesLogs1 = New MarcacionesLogs()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        EventsLogs1 = New EventsLogs()
        MenuStrip1 = New MenuStrip()
        SistemaToolStripMenuItem = New ToolStripMenuItem()
        CerrarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripContainer2 = New ToolStripContainer()
        ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        ToolStripContainer1.ContentPanel.SuspendLayout()
        ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        ToolStripContainer1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        TabTree.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        TabControl2.SuspendLayout()
        TabPage4.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        ToolStripContainer2.SuspendLayout()
        SuspendLayout()
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
        ToolStripContainer1.ContentPanel.Controls.Add(SplitContainer1)
        ToolStripContainer1.ContentPanel.Size = New Size(784, 515)
        ToolStripContainer1.Dock = DockStyle.Fill
        ToolStripContainer1.Location = New Point(0, 0)
        ToolStripContainer1.Name = "ToolStripContainer1"
        ToolStripContainer1.Size = New Size(784, 561)
        ToolStripContainer1.TabIndex = 0
        ToolStripContainer1.Text = "ToolStripContainer1"
        ' 
        ' ToolStripContainer1.TopToolStripPanel
        ' 
        ToolStripContainer1.TopToolStripPanel.Controls.Add(MenuStrip1)
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Dock = DockStyle.None
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2, ToolStripStatusLabel3})
        StatusStrip1.Location = New Point(0, 0)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.RenderMode = ToolStripRenderMode.Professional
        StatusStrip1.Size = New Size(784, 22)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(52, 17)
        ToolStripStatusLabel1.Text = "NexTech"
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(50, 17)
        ToolStripStatusLabel2.Text = "Ver: 1.01"
        ' 
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.Image = My.Resources.Resources.icons8_cancelar_16
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(98, 17)
        ToolStripStatusLabel3.Text = "Desconectado"
        ToolStripStatusLabel3.Visible = False
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(TabTree)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New Size(784, 515)
        SplitContainer1.SplitterDistance = 230
        SplitContainer1.TabIndex = 0
        ' 
        ' TabTree
        ' 
        TabTree.Controls.Add(TabPage2)
        TabTree.Dock = DockStyle.Fill
        TabTree.Location = New Point(0, 0)
        TabTree.Name = "TabTree"
        TabTree.SelectedIndex = 0
        TabTree.Size = New Size(230, 515)
        TabTree.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(RelojesList1)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(222, 487)
        TabPage2.TabIndex = 0
        TabPage2.Text = "Relojes"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' RelojesList1
        ' 
        RelojesList1.Dock = DockStyle.Fill
        RelojesList1.Location = New Point(3, 3)
        RelojesList1.Name = "RelojesList1"
        RelojesList1.Size = New Size(216, 481)
        RelojesList1.TabIndex = 1
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(TabControl2)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(TabControl1)
        SplitContainer2.Size = New Size(550, 515)
        SplitContainer2.SplitterDistance = 305
        SplitContainer2.TabIndex = 0
        ' 
        ' TabControl2
        ' 
        TabControl2.Controls.Add(TabPage4)
        TabControl2.Dock = DockStyle.Fill
        TabControl2.Location = New Point(0, 0)
        TabControl2.Name = "TabControl2"
        TabControl2.SelectedIndex = 0
        TabControl2.Size = New Size(550, 305)
        TabControl2.TabIndex = 0
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(MarcacionesLogs1)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(542, 277)
        TabPage4.TabIndex = 2
        TabPage4.Text = "Marcaciones"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' MarcacionesLogs1
        ' 
        MarcacionesLogs1.Dock = DockStyle.Fill
        MarcacionesLogs1.Location = New Point(3, 3)
        MarcacionesLogs1.Name = "MarcacionesLogs1"
        MarcacionesLogs1.Size = New Size(536, 271)
        MarcacionesLogs1.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(550, 206)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(EventsLogs1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(542, 178)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Eventos del sistema"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' EventsLogs1
        ' 
        EventsLogs1.Dock = DockStyle.Fill
        EventsLogs1.Location = New Point(3, 3)
        EventsLogs1.Name = "EventsLogs1"
        EventsLogs1.Size = New Size(536, 172)
        EventsLogs1.TabIndex = 0
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(784, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SistemaToolStripMenuItem
        ' 
        SistemaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CerrarToolStripMenuItem})
        SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        SistemaToolStripMenuItem.Size = New Size(60, 20)
        SistemaToolStripMenuItem.Text = "&Sistema"
        ' 
        ' CerrarToolStripMenuItem
        ' 
        CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        CerrarToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        CerrarToolStripMenuItem.Size = New Size(180, 22)
        CerrarToolStripMenuItem.Text = "&Cerrar"
        ' 
        ' ToolStripContainer2
        ' 
        ' 
        ' ToolStripContainer2.ContentPanel
        ' 
        ToolStripContainer2.ContentPanel.Size = New Size(784, 536)
        ToolStripContainer2.Dock = DockStyle.Fill
        ToolStripContainer2.Location = New Point(0, 0)
        ToolStripContainer2.Name = "ToolStripContainer2"
        ToolStripContainer2.Size = New Size(784, 561)
        ToolStripContainer2.TabIndex = 0
        ToolStripContainer2.Text = "ToolStripContainer2"
        ' 
        ' Lectura
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 561)
        Controls.Add(ToolStripContainer1)
        Controls.Add(ToolStripContainer2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MinimumSize = New Size(800, 600)
        Name = "Lectura"
        Text = "Lectura"
        ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        ToolStripContainer1.ContentPanel.ResumeLayout(False)
        ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        ToolStripContainer1.TopToolStripPanel.PerformLayout()
        ToolStripContainer1.ResumeLayout(False)
        ToolStripContainer1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        TabTree.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        TabControl2.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStripContainer2.ResumeLayout(False)
        ToolStripContainer2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents RelojesComponente1 As RelojesList
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents EventsLogs1 As EventsLogs
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DataLogs1 As MarcacionesLogs
    Friend WithEvents ToolStripContainer2 As ToolStripContainer
    Friend WithEvents MarcacionesLogs1 As MarcacionesLogs
    Friend WithEvents TabTree As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RelojesList1 As RelojesList
End Class
