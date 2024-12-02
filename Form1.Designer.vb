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
		MenuStrip1 = New MenuStrip()
		SistemaToolStripMenuItem = New ToolStripMenuItem()
		CerrarToolStripMenuItem = New ToolStripMenuItem()
		DispositivosToolStripMenuItem = New ToolStripMenuItem()
		AgregarRelojToolStripMenuItem = New ToolStripMenuItem()
		BorrarRelojToolStripMenuItem = New ToolStripMenuItem()
		ToolStripSeparator1 = New ToolStripSeparator()
		ActualizarListaToolStripMenuItem = New ToolStripMenuItem()
		EventosToolStripMenuItem = New ToolStripMenuItem()
		StatusStrip1 = New StatusStrip()
		ToolStripStatusLabel1 = New ToolStripStatusLabel()
		Panel1 = New Panel()
		TabControl1 = New TabControl()
		TabPage1 = New TabPage()
		TabPage2 = New TabPage()
		Relojes = New RelojesComponente()
		txtIpAddress = New TextBox()
		lbmessages = New ListBox()
		Button3 = New Button()
		Button2 = New Button()
		Button1 = New Button()
		FichaReloj1 = New FichaReloj()
		MenuStrip1.SuspendLayout()
		StatusStrip1.SuspendLayout()
		Panel1.SuspendLayout()
		TabControl1.SuspendLayout()
		TabPage1.SuspendLayout()
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
		' MenuStrip1
		' 
		MenuStrip1.Items.AddRange(New ToolStripItem() {SistemaToolStripMenuItem, DispositivosToolStripMenuItem, EventosToolStripMenuItem})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(644, 24)
		MenuStrip1.TabIndex = 6
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
		CerrarToolStripMenuItem.Size = New Size(106, 22)
		CerrarToolStripMenuItem.Text = "&Cerrar"
		' 
		' DispositivosToolStripMenuItem
		' 
		DispositivosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarRelojToolStripMenuItem, BorrarRelojToolStripMenuItem, ToolStripSeparator1, ActualizarListaToolStripMenuItem})
		DispositivosToolStripMenuItem.Name = "DispositivosToolStripMenuItem"
		DispositivosToolStripMenuItem.Size = New Size(82, 20)
		DispositivosToolStripMenuItem.Text = "Dispositivos"
		' 
		' AgregarRelojToolStripMenuItem
		' 
		AgregarRelojToolStripMenuItem.Name = "AgregarRelojToolStripMenuItem"
		AgregarRelojToolStripMenuItem.Size = New Size(159, 22)
		AgregarRelojToolStripMenuItem.Text = "Agregar reloj..."
		' 
		' BorrarRelojToolStripMenuItem
		' 
		BorrarRelojToolStripMenuItem.Name = "BorrarRelojToolStripMenuItem"
		BorrarRelojToolStripMenuItem.Size = New Size(159, 22)
		BorrarRelojToolStripMenuItem.Text = "Borrar reloj..."
		' 
		' ToolStripSeparator1
		' 
		ToolStripSeparator1.Name = "ToolStripSeparator1"
		ToolStripSeparator1.Size = New Size(156, 6)
		' 
		' ActualizarListaToolStripMenuItem
		' 
		ActualizarListaToolStripMenuItem.Name = "ActualizarListaToolStripMenuItem"
		ActualizarListaToolStripMenuItem.Size = New Size(159, 22)
		ActualizarListaToolStripMenuItem.Text = "Actualizar lista..."
		' 
		' EventosToolStripMenuItem
		' 
		EventosToolStripMenuItem.Name = "EventosToolStripMenuItem"
		EventosToolStripMenuItem.Size = New Size(60, 20)
		EventosToolStripMenuItem.Text = "Eventos"
		' 
		' StatusStrip1
		' 
		StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
		StatusStrip1.Location = New Point(0, 384)
		StatusStrip1.Name = "StatusStrip1"
		StatusStrip1.Size = New Size(644, 22)
		StatusStrip1.TabIndex = 7
		StatusStrip1.Text = "StatusStrip1"
		' 
		' ToolStripStatusLabel1
		' 
		ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
		ToolStripStatusLabel1.Size = New Size(52, 17)
		ToolStripStatusLabel1.Text = "NexTech"
		' 
		' Panel1
		' 
		Panel1.Controls.Add(TabControl1)
		Panel1.Controls.Add(Relojes)
		Panel1.Dock = DockStyle.Fill
		Panel1.Location = New Point(0, 24)
		Panel1.Name = "Panel1"
		Panel1.Padding = New Padding(12)
		Panel1.Size = New Size(644, 360)
		Panel1.TabIndex = 9
		' 
		' TabControl1
		' 
		TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
		TabControl1.Controls.Add(TabPage1)
		TabControl1.Controls.Add(TabPage2)
		TabControl1.Location = New Point(261, 15)
		TabControl1.Name = "TabControl1"
		TabControl1.SelectedIndex = 0
		TabControl1.Size = New Size(368, 333)
		TabControl1.TabIndex = 10
		' 
		' TabPage1
		' 
		TabPage1.Controls.Add(FichaReloj1)
		TabPage1.Location = New Point(4, 24)
		TabPage1.Name = "TabPage1"
		TabPage1.Padding = New Padding(3)
		TabPage1.Size = New Size(360, 305)
		TabPage1.TabIndex = 0
		TabPage1.Text = "Configuración"
		TabPage1.UseVisualStyleBackColor = True
		' 
		' TabPage2
		' 
		TabPage2.Location = New Point(4, 24)
		TabPage2.Name = "TabPage2"
		TabPage2.Padding = New Padding(3)
		TabPage2.Size = New Size(360, 305)
		TabPage2.TabIndex = 1
		TabPage2.Text = "Eventos"
		TabPage2.UseVisualStyleBackColor = True
		' 
		' Relojes
		' 
		Relojes.Dock = DockStyle.Left
		Relojes.Location = New Point(12, 12)
		Relojes.Name = "Relojes"
		Relojes.Size = New Size(243, 336)
		Relojes.TabIndex = 9
		' 
		' txtIpAddress
		' 
		txtIpAddress.Location = New Point(365, 57)
		txtIpAddress.Name = "txtIpAddress"
		txtIpAddress.Size = New Size(175, 23)
		txtIpAddress.TabIndex = 14
		' 
		' lbmessages
		' 
		lbmessages.FormattingEnabled = True
		lbmessages.ItemHeight = 15
		lbmessages.Location = New Point(365, 114)
		lbmessages.Name = "lbmessages"
		lbmessages.Size = New Size(565, 79)
		lbmessages.TabIndex = 13
		' 
		' Button3
		' 
		Button3.Location = New Point(271, 114)
		Button3.Name = "Button3"
		Button3.Size = New Size(75, 23)
		Button3.TabIndex = 12
		Button3.Text = "Desconectar"
		Button3.UseVisualStyleBackColor = True
		' 
		' Button2
		' 
		Button2.Location = New Point(271, 85)
		Button2.Name = "Button2"
		Button2.Size = New Size(75, 23)
		Button2.TabIndex = 11
		Button2.Text = "Leer logs"
		Button2.UseVisualStyleBackColor = True
		' 
		' Button1
		' 
		Button1.Location = New Point(271, 56)
		Button1.Name = "Button1"
		Button1.Size = New Size(75, 23)
		Button1.TabIndex = 10
		Button1.Text = "Conectar"
		Button1.UseVisualStyleBackColor = True
		' 
		' FichaReloj1
		' 
		FichaReloj1.Dock = DockStyle.Fill
		FichaReloj1.Location = New Point(3, 3)
		FichaReloj1.Name = "FichaReloj1"
		FichaReloj1.Size = New Size(354, 299)
		FichaReloj1.TabIndex = 0
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(644, 406)
		Controls.Add(Panel1)
		Controls.Add(txtIpAddress)
		Controls.Add(lbmessages)
		Controls.Add(StatusStrip1)
		Controls.Add(Button3)
		Controls.Add(MenuStrip1)
		Controls.Add(Button2)
		Controls.Add(Button1)
		Icon = CType(resources.GetObject("$this.Icon"), Icon)
		MainMenuStrip = MenuStrip1
		Name = "Form1"
		Text = "Relojes"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		StatusStrip1.ResumeLayout(False)
		StatusStrip1.PerformLayout()
		Panel1.ResumeLayout(False)
		TabControl1.ResumeLayout(False)
		TabPage1.ResumeLayout(False)
		ResumeLayout(False)
		PerformLayout()
	End Sub
	Friend WithEvents ImageList1 As ImageList
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Relojes As RelojesComponente
    Friend WithEvents txtIpAddress As TextBox
    Friend WithEvents lbmessages As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DispositivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarRelojToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarRelojToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ActualizarListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
	Friend WithEvents FichaReloj1 As FichaReloj

End Class
