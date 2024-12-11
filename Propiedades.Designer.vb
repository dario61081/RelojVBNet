<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Propiedades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Propiedades))
        FichaReloj1 = New FichaReloj()
        btnAceptar = New Button()
        SuspendLayout()
        ' 
        ' FichaReloj1
        ' 
        FichaReloj1.Dock = DockStyle.Top
        FichaReloj1.Location = New Point(6, 6)
        FichaReloj1.Name = "FichaReloj1"
        FichaReloj1.Size = New Size(492, 328)
        FichaReloj1.TabIndex = 0
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(392, 416)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(96, 40)
        btnAceptar.TabIndex = 1
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' Propiedades
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(504, 469)
        Controls.Add(btnAceptar)
        Controls.Add(FichaReloj1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Propiedades"
        Padding = New Padding(6)
        StartPosition = FormStartPosition.CenterParent
        Text = "Propiedades"
        ResumeLayout(False)
    End Sub

    Friend WithEvents FichaReloj1 As FichaReloj
    Friend WithEvents btnAceptar As Button
End Class
