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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdTodos = New System.Windows.Forms.RadioButton()
        Me.rdRango = New System.Windows.Forms.RadioButton()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.edtSapPassword = New System.Windows.Forms.TextBox()
        Me.edtSapUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_duplicados = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(295, 379)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 44)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(205, 379)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 44)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_duplicados)
        Me.GroupBox1.Controls.Add(Me.rdTodos)
        Me.GroupBox1.Controls.Add(Me.rdRango)
        Me.GroupBox1.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(373, 244)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Periodo"
        '
        'rdTodos
        '
        Me.rdTodos.AutoSize = True
        Me.rdTodos.Checked = True
        Me.rdTodos.Location = New System.Drawing.Point(18, 32)
        Me.rdTodos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdTodos.Name = "rdTodos"
        Me.rdTodos.Size = New System.Drawing.Size(70, 24)
        Me.rdTodos.TabIndex = 11
        Me.rdTodos.TabStop = True
        Me.rdTodos.Text = "Todos"
        Me.rdTodos.UseVisualStyleBackColor = True
        '
        'rdRango
        '
        Me.rdRango.AutoSize = True
        Me.rdRango.Location = New System.Drawing.Point(18, 64)
        Me.rdRango.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdRango.Name = "rdRango"
        Me.rdRango.Size = New System.Drawing.Size(155, 24)
        Me.rdRango.TabIndex = 10
        Me.rdRango.Text = "Por rango de fecha"
        Me.rdRango.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaHasta.Location = New System.Drawing.Point(155, 149)
        Me.dtpFechaHasta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(164, 27)
        Me.dtpFechaHasta.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha desde"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaDesde.Location = New System.Drawing.Point(155, 107)
        Me.dtpFechaDesde.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(164, 27)
        Me.dtpFechaDesde.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.edtSapPassword)
        Me.GroupBox2.Controls.Add(Me.edtSapUsername)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(7, 252)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(373, 120)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SAP Credenciales"
        '
        'edtSapPassword
        '
        Me.edtSapPassword.Location = New System.Drawing.Point(155, 75)
        Me.edtSapPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.edtSapPassword.Name = "edtSapPassword"
        Me.edtSapPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.edtSapPassword.PlaceholderText = "Password"
        Me.edtSapPassword.Size = New System.Drawing.Size(164, 27)
        Me.edtSapPassword.TabIndex = 3
        '
        'edtSapUsername
        '
        Me.edtSapUsername.Location = New System.Drawing.Point(155, 32)
        Me.edtSapUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.edtSapUsername.Name = "edtSapUsername"
        Me.edtSapUsername.PlaceholderText = "Usuario"
        Me.edtSapUsername.Size = New System.Drawing.Size(164, 27)
        Me.edtSapUsername.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Usuario"
        '
        'chk_duplicados
        '
        Me.chk_duplicados.AutoSize = True
        Me.chk_duplicados.Checked = True
        Me.chk_duplicados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_duplicados.Location = New System.Drawing.Point(18, 200)
        Me.chk_duplicados.Name = "chk_duplicados"
        Me.chk_duplicados.Size = New System.Drawing.Size(340, 24)
        Me.chk_duplicados.TabIndex = 12
        Me.chk_duplicados.Text = "Verificar registros duplicados en base de datos"
        Me.chk_duplicados.UseVisualStyleBackColor = True
        '
        'ImportarFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 437)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImportarFecha"
        Me.Padding = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Parametros de descarga"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents chk_duplicados As CheckBox
End Class
