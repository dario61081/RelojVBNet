<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exportacion
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
        lbltarea = New Label()
        ProgressBar1 = New ProgressBar()
        ProgressBar2 = New ProgressBar()
        lblsubtarea = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbltarea
        ' 
        lbltarea.AutoSize = True
        lbltarea.Location = New Point(24, 88)
        lbltarea.Name = "lbltarea"
        lbltarea.Size = New Size(116, 15)
        lbltarea.TabIndex = 0
        lbltarea.Text = "Iniciando las tareas..."
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(24, 112)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(432, 23)
        ProgressBar1.TabIndex = 1
        ' 
        ' ProgressBar2
        ' 
        ProgressBar2.Location = New Point(24, 168)
        ProgressBar2.Name = "ProgressBar2"
        ProgressBar2.Size = New Size(432, 23)
        ProgressBar2.TabIndex = 2
        ' 
        ' lblsubtarea
        ' 
        lblsubtarea.AutoSize = True
        lblsubtarea.Location = New Point(24, 144)
        lblsubtarea.Name = "lblsubtarea"
        lblsubtarea.Size = New Size(93, 15)
        lblsubtarea.TabIndex = 3
        lblsubtarea.Text = "Cargando tareas"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = My.Resources.Resources.icons8_relojes_de_base_de_datos_32
        PictureBox1.Location = New Point(24, 16)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 40)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Exportacion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 211)
        Controls.Add(PictureBox1)
        Controls.Add(lblsubtarea)
        Controls.Add(ProgressBar2)
        Controls.Add(ProgressBar1)
        Controls.Add(lbltarea)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Exportacion"
        Text = "Ejecución de tareas"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbltarea As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents lblsubtarea As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
End Class
