Public Class Form2
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

    Public Sub CheckForUpdates()
        If ProgressBar1.Value = 100 Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://ge.tt/5Tcg8I32/v/0")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If currentversion = newestversion Then
                Button1.Text = ("You are up todate!")
                Label2.Text = currentversion
                Label3.Text = newestversion
            Else
                Button1.Text = ("Update Available Download it from the site below!")


            End If
        End If



    End Sub
    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            If ProgressBar1.Value = 100 Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://ge.tt/5Tcg8I32/v/0")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If currentversion = newestversion Then
                    Button1.Text = ("You are up todate!")

                Else
                    Button1.Text = ("Update Available Download it from the site below!")
                    TextBox1.Text = "https://www.dropbox.com/sh/qk8gyja8e17oawz/AABCBbE_0HSu2uZM5VvHy-92a?dl=0"
                    Label2.Text = currentversion
                    Label3.Text = newestversion

                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button1.Text = "Checking for updates..."
        Timer1.Start()
        CheckForUpdates()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class