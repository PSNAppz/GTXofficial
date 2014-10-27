Public Class Form1

    Dim drag As Boolean

    Dim mousex As Integer

    Dim mousey As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub


    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()


    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
      
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PropertyGrid1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub ShowWebbrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowWebbrowserToolStripMenuItem.Click


    End Sub

    Private Sub WebbrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebbrowserToolStripMenuItem.Click
        If WebBrowser1.Visible = False Then
            WebBrowser1.Visible = True
            Button5.Visible = True
            Button4.Visible = True
            Button2.Visible = True
            Button6.Visible = True
            Button7.Visible = True
            TextBox1.Visible = True

        Else


            WebBrowser1.Visible = False
            Button5.Visible = False
            Button4.Visible = False
            Button2.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            TextBox1.Visible = False

        End If
    End Sub

    Private Sub GoToWebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToWebsiteToolStripMenuItem.Click
        If WebBrowser1.Visible = False Then
            WebBrowser1.Visible = True
        End If
        WebBrowser1.Navigate("www.thepsnappz.me")
    End Sub

    Private Sub ThisSoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThisSoftwareToolStripMenuItem.Click
        AboutBox1.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateToolStripMenuItem.Click
        Label1.Text = Date.Today


    End Sub

    Private Sub Form1_MouseDown()
        Throw New NotImplementedException
    End Sub

    Private Sub Form1_MouseMove()
        Throw New NotImplementedException
    End Sub

    Private Sub Form1_MouseUp()
        Throw New NotImplementedException
    End Sub

    Private Sub ProgressBar1_Click_1(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub


    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 100 Or ProgressBar1.Value > 0 Then
            ProgressBar1.Increment(-7)
        End If
    End Sub

End Class
