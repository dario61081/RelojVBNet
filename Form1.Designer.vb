<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ImageList1 = New ImageList(components)
        NotifyIcon1 = New NotifyIcon(components)
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        Panel1 = New Panel()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        FichaReloj1 = New FichaReloj()
        TabPage2 = New TabPage()
        lvLog = New ListView()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        TabPage3 = New TabPage()
        lvEventos = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        Relojes = New RelojesComponente()
        MenuStrip1 = New MenuStrip()
        SistemaToolStripMenuItem = New ToolStripMenuItem()
        CerrarToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "icons8-reloj-16.png")
        ImageList1.Images.SetKeyName(1, "icons8-de-acuerdo-16.png")
        ImageList1.Images.SetKeyName(2, "icons8-cancelar-16.png")
        ImageList1.Images.SetKeyName(3, "icons8-reproducir-en-círculo-16.png")
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2})
        StatusStrip1.Location = New Point(0, 539)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(784, 22)
        StatusStrip1.TabIndex = 7
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
        ToolStripStatusLabel2.Size = New Size(72, 17)
        ToolStripStatusLabel2.Text = "Versión: 1.01"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(240))
        Panel1.Controls.Add(TabControl1)
        Panel1.Controls.Add(Relojes)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 24)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(12)
        Panel1.Size = New Size(784, 515)
        Panel1.TabIndex = 9
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(261, 15)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(508, 488)
        TabControl1.TabIndex = 10
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(FichaReloj1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(500, 460)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Configuración"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' FichaReloj1
        ' 
        FichaReloj1.Dock = DockStyle.Fill
        FichaReloj1.Location = New Point(3, 3)
        FichaReloj1.Name = "FichaReloj1"
        FichaReloj1.Size = New Size(494, 454)
        FichaReloj1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(lvLog)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(621, 440)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Eventos"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' lvLog
        ' 
        lvLog.Columns.AddRange(New ColumnHeader() {ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6})
        lvLog.Dock = DockStyle.Fill
        lvLog.Location = New Point(3, 3)
        lvLog.Name = "lvLog"
        lvLog.Size = New Size(615, 434)
        lvLog.TabIndex = 1
        lvLog.UseCompatibleStateImageBehavior = False
        lvLog.View = View.Details
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Fecha/Hora"
        ColumnHeader3.Width = 120
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Entrada/Salida"
        ColumnHeader4.Width = 80
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Numero Id"
        ColumnHeader5.Width = 80
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Verificación"
        ColumnHeader6.Width = 80
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(lvEventos)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(621, 440)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Eventos del sistema"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' lvEventos
        ' 
        lvEventos.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        lvEventos.Dock = DockStyle.Fill
        lvEventos.Location = New Point(3, 3)
        lvEventos.Name = "lvEventos"
        lvEventos.Size = New Size(615, 434)
        lvEventos.TabIndex = 0
        lvEventos.UseCompatibleStateImageBehavior = False
        lvEventos.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Fecha/Hora"
        ColumnHeader1.Width = 90
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Evento"
        ColumnHeader2.Width = 300
        ' 
        ' Relojes
        ' 
        Relojes.Dock = DockStyle.Left
        Relojes.ListaBloqueada = False
        Relojes.Location = New Point(12, 12)
        Relojes.Name = "Relojes"
        Relojes.Size = New Size(243, 491)
        Relojes.TabIndex = 9
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(784, 24)
        MenuStrip1.TabIndex = 15
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
        CerrarToolStripMenuItem.Size = New Size(180, 22)
        CerrarToolStripMenuItem.Text = "&Cerrar"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(240))
        ClientSize = New Size(784, 561)
        Controls.Add(Panel1)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MinimumSize = New Size(800, 600)
        Name = "Form1"
        Text = "Relojes"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Relojes As RelojesComponente
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
	Friend WithEvents FichaReloj1 As FichaReloj
	Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents lvEventos As ListView
	Friend WithEvents ColumnHeader1 As ColumnHeader
	Friend WithEvents ColumnHeader2 As ColumnHeader
	Friend WithEvents lvLog As ListView
	Friend WithEvents ColumnHeader3 As ColumnHeader
	Friend WithEvents ColumnHeader4 As ColumnHeader
	Friend WithEvents ColumnHeader5 As ColumnHeader
	Friend WithEvents ColumnHeader6 As ColumnHeader
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem

End Class
