<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataLogs
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
		ListView1 = New ListView()
		GroupBox1.SuspendLayout()
		SuspendLayout()
		' 
		' GroupBox1
		' 
		GroupBox1.Controls.Add(ListView1)
		GroupBox1.Dock = DockStyle.Fill
		GroupBox1.Location = New Point(0, 0)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(570, 377)
		GroupBox1.TabIndex = 0
		GroupBox1.TabStop = False
		GroupBox1.Text = "Eventos"
		' 
		' ListView1
		' 
		ListView1.Dock = DockStyle.Fill
		ListView1.Location = New Point(3, 19)
		ListView1.Name = "ListView1"
		ListView1.Size = New Size(564, 355)
		ListView1.TabIndex = 0
		ListView1.UseCompatibleStateImageBehavior = False
		ListView1.View = View.Details
		' 
		' DataLogs
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		Controls.Add(GroupBox1)
		Name = "DataLogs"
		Size = New Size(570, 377)
		GroupBox1.ResumeLayout(False)
		ResumeLayout(False)
	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents ListView1 As ListView

End Class
