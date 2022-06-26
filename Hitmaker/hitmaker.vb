Public Class hitmaker
    Private InitialStyle As Integer
    Dim PercentVisible As Decimal
    Private Declare Function ShowCursor& Lib "user32" (ByVal bshow As Long)
    Private Sub hitmaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        PictureBox1.Image = Form1.PictureBox1.Image

        If Form1.TextBox1.Text = "Size (px)" Then

            Else
                PictureBox1.Width = Form1.TextBox1.Text
                PictureBox1.Height = Form1.TextBox1.Text
                Me.Width = Form1.TextBox1.Text
                Me.Height = Form1.TextBox1.Text
            End If

            Me.TopMost = True
            Me.CenterToScreen()
            Timer1.Start()
            Timer2.Start()
            Timer3.Start()
            Dim ctrl As Control
            For Each c As Control In Me.Controls
                c.Enabled = Not c.Enabled
            Next



    End Sub

    Private Const WS_EX_TRANSPARENT As Integer = &H20

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or WS_EX_TRANSPARENT
            Return cp
        End Get
    End Property
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost = True
        Me.CenterToScreen()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox1.Width = Form1.TextBox1.Text
        PictureBox1.Height = Form1.TextBox1.Text
        Me.Width = Form1.TextBox1.Text
        Me.Height = Form1.TextBox1.Text
    End Sub



    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Stop()
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        ShowCursor(False)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PictureBox1.Click
        e.Cancel = True
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PictureBox1.DoubleClick
        e.Cancel = True
    End Sub

    Private Sub PictureBox1_MouseCaptureChanged(sender As Object, e As EventArgs) Handles PictureBox1.MouseCaptureChanged

    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick

    End Sub

    Private Sub PictureBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDoubleClick

    End Sub
End Class