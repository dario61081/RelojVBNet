<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FichaReloj
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
        GroupBox1 = New GroupBox()
        ComboBox2 = New ComboBox()
        Label8 = New Label()
        edtPassword = New TextBox()
        Label7 = New Label()
        TextBox1 = New TextBox()
        Label6 = New Label()
        btnProbarConexion = New Button()
        edtTerminalNumber = New TextBox()
        Label5 = New Label()
        edtSerialNumber = New TextBox()
        Label4 = New Label()
        edtDireccionIp = New TextBox()
        Label3 = New Label()
        edtNombre = New TextBox()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(edtPassword)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(btnProbarConexion)
        GroupBox1.Controls.Add(edtTerminalNumber)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(edtSerialNumber)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(edtDireccionIp)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(edtNombre)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(498, 192)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Conexión info"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"TCP/IP"})
        ComboBox2.Location = New Point(336, 128)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(143, 23)
        ComboBox2.TabIndex = 16
        ComboBox2.Text = "Habilitado"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(256, 128)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 15)
        Label8.TabIndex = 15
        Label8.Text = "Estado"
        ' 
        ' edtPassword
        ' 
        edtPassword.Location = New Point(96, 128)
        edtPassword.Name = "edtPassword"
        edtPassword.PasswordChar = "*"c
        edtPassword.PlaceholderText = "Password"
        edtPassword.Size = New Size(144, 23)
        edtPassword.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(16, 128)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 15)
        Label7.TabIndex = 13
        Label7.Text = "Contraseña"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(336, 96)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "4370"
        TextBox1.Size = New Size(143, 23)
        TextBox1.TabIndex = 12
        TextBox1.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(256, 96)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 11
        Label6.Text = "Puerto"
        ' 
        ' btnProbarConexion
        ' 
        btnProbarConexion.Location = New Point(336, 160)
        btnProbarConexion.Name = "btnProbarConexion"
        btnProbarConexion.Size = New Size(144, 23)
        btnProbarConexion.TabIndex = 10
        btnProbarConexion.Text = "Probar conexión..."
        btnProbarConexion.UseVisualStyleBackColor = True
        ' 
        ' edtTerminalNumber
        ' 
        edtTerminalNumber.Location = New Point(336, 64)
        edtTerminalNumber.Name = "edtTerminalNumber"
        edtTerminalNumber.PlaceholderText = "1"
        edtTerminalNumber.Size = New Size(143, 23)
        edtTerminalNumber.TabIndex = 9
        edtTerminalNumber.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(256, 64)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 15)
        Label5.TabIndex = 8
        Label5.Text = "Terminal N#"
        ' 
        ' edtSerialNumber
        ' 
        edtSerialNumber.Location = New Point(336, 32)
        edtSerialNumber.Name = "edtSerialNumber"
        edtSerialNumber.PlaceholderText = "-"
        edtSerialNumber.Size = New Size(143, 23)
        edtSerialNumber.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(256, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(22, 15)
        Label4.TabIndex = 6
        Label4.Text = "SN"
        ' 
        ' edtDireccionIp
        ' 
        edtDireccionIp.Location = New Point(96, 96)
        edtDireccionIp.Name = "edtDireccionIp"
        edtDireccionIp.PlaceholderText = "192.168.0.1"
        edtDireccionIp.Size = New Size(143, 23)
        edtDireccionIp.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 4
        Label3.Text = "Dirección IP"
        ' 
        ' edtNombre
        ' 
        edtNombre.Location = New Point(96, 64)
        edtNombre.Name = "edtNombre"
        edtNombre.Size = New Size(143, 23)
        edtNombre.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 2
        Label2.Text = "Nombre"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"TCP/IP"})
        ComboBox1.Location = New Point(96, 32)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(143, 23)
        ComboBox1.TabIndex = 1
        ComboBox1.Text = "TCP/IP"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Modo"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Dock = DockStyle.Top
        GroupBox2.Location = New Point(0, 192)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(498, 72)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Gestión de datos"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(16, 32)
        Button1.Name = "Button1"
        Button1.Size = New Size(224, 23)
        Button1.TabIndex = 0
        Button1.Text = "Sincronizar fecha y hora"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FichaReloj
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "FichaReloj"
        Size = New Size(498, 280)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents edtDireccionIp As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents edtNombre As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label1 As Label
	Friend WithEvents edtTerminalNumber As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents edtSerialNumber As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents btnProbarConexion As Button
	Friend WithEvents edtPassword As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents ComboBox2 As ComboBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Button1 As Button

End Class
