Imports System.IO

Public Class Form1
    Dim img As Bitmap
    Private Declare Function ShowCursor& Lib "user32" (ByVal bshow As Long)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTrackBar1.Value = 15
    End Sub


    Private Function GetMultiNode(ByVal treeNode As TreeNode, ByVal path As String) As Boolean
        If Directory.Exists(path) = False Then
            Return False
        End If

        Dim dirs As DirectoryInfo = New DirectoryInfo(path)
        Dim dir As DirectoryInfo() = dirs.GetDirectories()
        Dim file As FileInfo() = dirs.GetFiles()
        Dim dircount As Integer = dir.Count()
        Dim filecount As Integer = file.Count()
        Dim sumcount As Integer = dircount + filecount

        If sumcount = 0 Then
            Return False
        End If

        For j As Integer = 0 To dircount - 1
            treeNode.Nodes.Add(dir(j).Name)
            Dim pathNodeB As String = path & "\" & dir(j).Name
            GetMultiNode(treeNode.Nodes(j), pathNodeB)
        Next

        For j As Integer = 0 To filecount - 1
            treeNode.Nodes.Add(file(j).Name)
        Next

        Return True
    End Function

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        hitmaker.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Try
            OpenFileDialog1.Title = "Please select a file"
            ' OpenFileDialog1.InitialDirectory = "c:"
            OpenFileDialog1.Filter = "Png |*.png |Jpeg|*.jpg|Show all|*.*"
            OpenFileDialog1.FileName = "Selecte file"
            OpenFileDialog1.ShowDialog()
            PictureBox1.ImageLocation = OpenFileDialog1.FileName.ToString
            PictureBox1.Visible = True
        Catch ex As Exception
            MsgBox("Failed to load")
        End Try



    End Sub


    Private Sub MetroTrackBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles MetroTrackBar1.Scroll
        TextBox1.Text = MetroTrackBar1.Value
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            hitmaker.Dispose()
        Catch ex As Exception

        End Try

    End Sub

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

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton3_Click_1(sender As Object, e As EventArgs) Handles MetroButton3.Click
        hitmaker.Show()
    End Sub

    Private Sub Form1_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        ' ShowCursor(True)
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
