<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportarFecha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportarFecha))
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        rdTodos = New RadioButton()
        rdRango = New RadioButton()
        dtpFechaHasta = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        dtpFechaDesde = New DateTimePicker()
        GroupBox2 = New GroupBox()
        edtSapPassword = New TextBox()
        edtSapUsername = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.Location = New Point(258, 246)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 33)
        Button1.TabIndex = 6
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.Location = New Point(179, 246)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 33)
        Button2.TabIndex = 7
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rdTodos)
        GroupBox1.Controls.Add(rdRango)
        GroupBox1.Controls.Add(dtpFechaHasta)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(dtpFechaDesde)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(6, 6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(327, 144)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Periodo"
        ' 
        ' rdTodos
        ' 
        rdTodos.AutoSize = True
        rdTodos.Checked = True
        rdTodos.Location = New Point(16, 24)
        rdTodos.Name = "rdTodos"
        rdTodos.Size = New Size(56, 19)
        rdTodos.TabIndex = 11
        rdTodos.TabStop = True
        rdTodos.Text = "Todos"
        rdTodos.UseVisualStyleBackColor = True
        ' 
        ' rdRango
        ' 
        rdRango.AutoSize = True
        rdRango.Location = New Point(16, 48)
        rdRango.Name = "rdRango"
        rdRango.Size = New Size(125, 19)
        rdRango.TabIndex = 10
        rdRango.Text = "Por rango de fecha"
        rdRango.UseVisualStyleBackColor = True
        ' 
        ' dtpFechaHasta
        ' 
        dtpFechaHasta.Format = DateTimePickerFormat.Custom
        dtpFechaHasta.Location = New Point(136, 112)
        dtpFechaHasta.Name = "dtpFechaHasta"
        dtpFechaHasta.Size = New Size(144, 23)
        dtpFechaHasta.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 8
        Label2.Text = "Fecha hasta"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(56, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 7
        Label1.Text = "Fecha desde"
        ' 
        ' dtpFechaDesde
        ' 
        dtpFechaDesde.Format = DateTimePickerFormat.Custom
        dtpFechaDesde.Location = New Point(136, 80)
        dtpFechaDesde.Name = "dtpFechaDesde"
        dtpFechaDesde.Size = New Size(144, 23)
        dtpFechaDesde.TabIndex = 6
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(edtSapPassword)
        GroupBox2.Controls.Add(edtSapUsername)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Dock = DockStyle.Top
        GroupBox2.Location = New Point(6, 150)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(327, 90)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "SAP Credenciales"
        ' 
        ' edtSapPassword
        ' 
        edtSapPassword.Location = New Point(136, 56)
        edtSapPassword.Name = "edtSapPassword"
        edtSapPassword.PasswordChar = "*"c
        edtSapPassword.PlaceholderText = "Password"
        edtSapPassword.Size = New Size(144, 23)
        edtSapPassword.TabIndex = 3
        ' 
        ' edtSapUsername
        ' 
        edtSapUsername.Location = New Point(136, 24)
        edtSapUsername.Name = "edtSapUsername"
        edtSapUsername.PlaceholderText = "Usuario"
        edtSapUsername.Size = New Size(144, 23)
        edtSapUsername.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 1
        Label4.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 0
        Label3.Text = "Usuario"
        ' 
        ' ImportarFecha
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(339, 284)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ImportarFecha"
        Padding = New Padding(6)
        StartPosition = FormStartPosition.CenterParent
        Text = "Parametros de descarga"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdTodos As RadioButton
    Friend WithEvents rdRango As RadioButton
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents edtSapPassword As TextBox
    Friend WithEvents edtSapUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
