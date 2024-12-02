Imports System.Drawing.Drawing2D

Public Class CustomToolbar

    Private Sub DrawBackground()
        ' Colores de estilo Grid XP: gris claro a gris medio
        Dim colorInicio As Color = Color.FromArgb(240, 240, 240)  ' Gris muy claro
        Dim colorFin As Color = Color.FromArgb(210, 215, 220)     ' Gris medio

        Dim gradienteBrocha As New LinearGradientBrush(
            Me.ClientRectangle,
            colorInicio,
            colorFin,
            LinearGradientMode.Vertical
        )

        Me.BackgroundImage = New Bitmap(Me.Width, Me.Height)
        Using g As Graphics = Graphics.FromImage(Me.BackgroundImage)
            g.FillRectangle(gradienteBrocha, Me.ClientRectangle)
        End Using

        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub



    Protected Overrides Sub OnInvalidated(e As InvalidateEventArgs)
        MyBase.OnInvalidated(e)




    End Sub
    Private Sub CustomToolbar_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint





    End Sub
End Class
