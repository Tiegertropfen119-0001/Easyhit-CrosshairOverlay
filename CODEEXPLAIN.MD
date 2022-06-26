# How the programm works

```   
Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTrackBar1.Value = 15
End Sub
```
This is for the slider to set the normal value to 15

```
  Private Sub MetroButton3_Click_1(sender As Object, e As EventArgs) Handles MetroButton3.Click
        hitmaker.Show()
    End Sub
 ```
This is the button to start the maker

```
  Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            hitmaker.Dispose()
        Catch ex As Exception

        End Try

        Try

            OpenFileDialog1.Title = "Please select a file"
            OpenFileDialog1.InitialDirectory = "c:"
            OpenFileDialog1.Filter = "Png |*.png |Jpeg|*.jpg|Show all|*.*"
            OpenFileDialog1.ShowDialog()
            PictureBox1.ImageLocation = OpenFileDialog1.FileName.ToString
            PictureBox1.Visible = True

        Catch ex As Exception
            MsgBox("Failed to load")
        End Try


    End Sub


```
This is the code to load coustom picture files as maker
```
   Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            hitmaker.Dispose()
        Catch ex As Exception

        End Try

    End Sub
   
   ```
This is the code to close the maker
```
    Private Sub MetroTrackBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles MetroTrackBar1.Scroll
        TextBox1.Text = MetroTrackBar1.Value
    End Sub
    ```
To sync the value from the slider to the textbox

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

```
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost = True
        Me.CenterToScreen()
    End Sub
    
 ```
This is to make sure that the maker is always on top on the game

```
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox1.Width = Form1.TextBox1.Text
        PictureBox1.Height = Form1.TextBox1.Text
        Me.Width = Form1.TextBox1.Text
        Me.Height = Form1.TextBox1.Text
    End Sub
```
This is to sync the size of the maker from the GUI

