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
		Relojes = New RelojesComponente()
		txtIpAddress = New TextBox()
		Button3 = New Button()
		Button2 = New Button()
		Button1 = New Button()
		TabPage3 = New TabPage()
		lvEventos = New ListView()
		ColumnHeader1 = New ColumnHeader()
		ColumnHeader2 = New ColumnHeader()
		StatusStrip1.SuspendLayout()
		Panel1.SuspendLayout()
		TabControl1.SuspendLayout()
		TabPage1.SuspendLayout()
		TabPage3.SuspendLayout()
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
		StatusStrip1.Location = New Point(0, 384)
		StatusStrip1.Name = "StatusStrip1"
		StatusStrip1.Size = New Size(792, 22)
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
		Panel1.Controls.Add(TabControl1)
		Panel1.Controls.Add(Relojes)
		Panel1.Dock = DockStyle.Fill
		Panel1.Location = New Point(0, 0)
		Panel1.Name = "Panel1"
		Panel1.Padding = New Padding(12)
		Panel1.Size = New Size(792, 384)
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
		TabControl1.Size = New Size(516, 357)
		TabControl1.TabIndex = 10
		' 
		' TabPage1
		' 
		TabPage1.Controls.Add(FichaReloj1)
		TabPage1.Location = New Point(4, 24)
		TabPage1.Name = "TabPage1"
		TabPage1.Padding = New Padding(3)
		TabPage1.Size = New Size(508, 329)
		TabPage1.TabIndex = 0
		TabPage1.Text = "Configuración"
		TabPage1.UseVisualStyleBackColor = True
		' 
		' FichaReloj1
		' 
		FichaReloj1.Dock = DockStyle.Fill
		FichaReloj1.Location = New Point(3, 3)
		FichaReloj1.Name = "FichaReloj1"
		FichaReloj1.Size = New Size(502, 323)
		FichaReloj1.TabIndex = 0
		' 
		' TabPage2
		' 
		TabPage2.Location = New Point(4, 24)
		TabPage2.Name = "TabPage2"
		TabPage2.Padding = New Padding(3)
		TabPage2.Size = New Size(508, 329)
		TabPage2.TabIndex = 1
		TabPage2.Text = "Eventos"
		TabPage2.UseVisualStyleBackColor = True
		' 
		' Relojes
		' 
		Relojes.Dock = DockStyle.Left
		Relojes.Location = New Point(12, 12)
		Relojes.Name = "Relojes"
		Relojes.Size = New Size(243, 360)
		Relojes.TabIndex = 9
		' 
		' txtIpAddress
		' 
		txtIpAddress.Location = New Point(365, 57)
		txtIpAddress.Name = "txtIpAddress"
		txtIpAddress.Size = New Size(175, 23)
		txtIpAddress.TabIndex = 14
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
		' TabPage3
		' 
		TabPage3.Controls.Add(lvEventos)
		TabPage3.Location = New Point(4, 24)
		TabPage3.Name = "TabPage3"
		TabPage3.Padding = New Padding(3)
		TabPage3.Size = New Size(508, 329)
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
		lvEventos.Size = New Size(502, 323)
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
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(792, 406)
		Controls.Add(Panel1)
		Controls.Add(txtIpAddress)
		Controls.Add(StatusStrip1)
		Controls.Add(Button3)
		Controls.Add(Button2)
		Controls.Add(Button1)
		Icon = CType(resources.GetObject("$this.Icon"), Icon)
		Name = "Form1"
		Text = "Relojes"
		StatusStrip1.ResumeLayout(False)
		StatusStrip1.PerformLayout()
		Panel1.ResumeLayout(False)
		TabControl1.ResumeLayout(False)
		TabPage1.ResumeLayout(False)
		TabPage3.ResumeLayout(False)
		ResumeLayout(False)
		PerformLayout()
	End Sub
	Friend WithEvents ImageList1 As ImageList
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Relojes As RelojesComponente
    Friend WithEvents txtIpAddress As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
	Friend WithEvents FichaReloj1 As FichaReloj
	Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents lvEventos As ListView
	Friend WithEvents ColumnHeader1 As ColumnHeader
	Friend WithEvents ColumnHeader2 As ColumnHeader

End Class
