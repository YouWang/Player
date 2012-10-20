Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "阚迪生媒体播放器"
        Flash1.Width = Me.Width
        Flash1.Height = Me.Height
        MediaPlayer1.Width = Me.Width
        MediaPlayer1.Height = Me.Height
        MediaPlayer1.Visible = False
        Flash1.Visible = True
        O1.FileName = ""
        O1.Filter = ("所有媒体|*.swf;*.dat;*.mpg;*.mp3;*.mp2;*.wma;*.wmv;*avi|动画文件|*.swf|视频文件|*.dat;*.mpg;*.wmv;*.avi|音频文件|*.mp2;*.mp3;*.wma|所有文件|*.*")
    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Flash1.Width = Me.Width
        Flash1.Height = Me.Height
        MediaPlayer1.Width = Me.Width
        MediaPlayer1.Height = Me.Height
    End Sub
    Private Sub 打开OToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打开OToolStripMenuItem.Click
        On Error Resume Next 'Tell The Error Resume Cancle
        Dim KDS, ABC, AAA As String 'Tell The Using Val
        If O1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            AAA = O1.FileName
            KDS = Microsoft.VisualBasic.Right(O1.FileName, 3)
            ABC = KDS.ToLower
            Select Case ABC
                Case "swf"
                    Flash1.Visible = True
                    MediaPlayer1.Visible = False
                    MediaPlayer1.URL = ""
                    Flash1.Movie = O1.FileName
                Case "dat"
                    Flash1.Visible = False
                    MediaPlayer1.Visible = True
                    MediaPlayer1.URL = O1.FileName
                Case "mpg"
                    Flash1.Visible = False
                    MediaPlayer1.Visible = True
                    MediaPlayer1.URL = O1.FileName
                Case "wmv"
                    Flash1.Visible = False
                    MediaPlayer1.Visible = True
                    MediaPlayer1.URL = O1.FileName
                Case "avi"
                    Flash1.Visible = False
                    MediaPlayer1.Visible = True
                    MediaPlayer1.URL = O1.FileName
                Case "mp2"
                    Flash1.Visible = False
                    MediaPlayer1.Visible = True
                    MediaPlayer1.URL = O1.FileName
                Case "mp3"
                    Flash1.Visible = False
                    MediaPlayer1.Visible = True
                    MediaPlayer1.URL = O1.FileName
                    Flash1.Movie = ""
                    Flash1.Refresh()
                Case "wma"
                    Flash1.Visible = False
                    MediaPlayer1.Visible = True
                    MediaPlayer1.URL = O1.FileName
                Case Else
                    Flash1.Visible = False
                    MediaPlayer1.Visible = True
                    MediaPlayer1.URL = O1.FileName
            End Select
        End If
    End Sub
    Private Sub 退出QToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出QToolStripMenuItem.Click
        End
    End Sub
    Private Sub 关于AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于AToolStripMenuItem.Click
        MsgBox("本软件版权属于阚迪生,盗版必究!" & Chr(13) & "Email:kandisheng@21cn.com" & Chr(13) & "QQ:474028891", MsgBoxStyle.Information, "注意")
    End Sub

    Private Sub 播放PToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 播放PToolStripMenuItem.Click
        Select Case Flash1.Visible
            Case True
                Flash1.Play()
            Case False
                MediaPlayer1.Refresh()
        End Select
    End Sub
End Class
