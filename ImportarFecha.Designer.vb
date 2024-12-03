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
        dtpFechaDesde = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        dtpFechaHasta = New DateTimePicker()
        rdRango = New RadioButton()
        rdTodos = New RadioButton()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' dtpFechaDesde
        ' 
        dtpFechaDesde.Format = DateTimePickerFormat.Custom
        dtpFechaDesde.Location = New Point(127, 62)
        dtpFechaDesde.Name = "dtpFechaDesde"
        dtpFechaDesde.Size = New Size(200, 23)
        dtpFechaDesde.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 1
        Label1.Text = "Fecha desde"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 2
        Label2.Text = "Fecha hasta"
        ' 
        ' dtpFechaHasta
        ' 
        dtpFechaHasta.Format = DateTimePickerFormat.Custom
        dtpFechaHasta.Location = New Point(127, 91)
        dtpFechaHasta.Name = "dtpFechaHasta"
        dtpFechaHasta.Size = New Size(200, 23)
        dtpFechaHasta.TabIndex = 3
        ' 
        ' rdRango
        ' 
        rdRango.AutoSize = True
        rdRango.Location = New Point(26, 37)
        rdRango.Name = "rdRango"
        rdRango.Size = New Size(125, 19)
        rdRango.TabIndex = 4
        rdRango.Text = "Por rango de fecha"
        rdRango.UseVisualStyleBackColor = True
        ' 
        ' rdTodos
        ' 
        rdTodos.AutoSize = True
        rdTodos.Checked = True
        rdTodos.Location = New Point(26, 12)
        rdTodos.Name = "rdTodos"
        rdTodos.Size = New Size(56, 19)
        rdTodos.TabIndex = 5
        rdTodos.TabStop = True
        rdTodos.Text = "Todos"
        rdTodos.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(252, 167)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(171, 167)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 7
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ImportarFecha
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(341, 209)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(rdTodos)
        Controls.Add(rdRango)
        Controls.Add(dtpFechaHasta)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpFechaDesde)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximizeBox = False
        MinimizeBox = False
        Name = "ImportarFecha"
        StartPosition = FormStartPosition.CenterParent
        Text = "Parametros de descarga"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents rdRango As RadioButton
    Friend WithEvents rdTodos As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
