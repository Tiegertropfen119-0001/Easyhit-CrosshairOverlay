# How the programm works

```   
Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTrackBar1.Value = 15
End Sub
```
This is for the slider to set the normal value to 15

```
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
```
The first if line is to check that the textbox for the size has a number
The ``` Me.TopMost = True  ``` is that the programm is the current selected window
The ``` Me.CenterToScreen()  ``` is that the programm is in the middle of the screen

```    
Private Const WS_EX_TRANSPARENT As Integer = &H20

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or WS_EX_TRANSPARENT
            Return cp
        End Get
    End Property
 ```
This code is that your mouse is hidden and when you click on the maker that you not minimize the game
