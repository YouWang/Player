Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "�۵���ý�岥����"
        Flash1.Width = Me.Width
        Flash1.Height = Me.Height
        MediaPlayer1.Width = Me.Width
        MediaPlayer1.Height = Me.Height
        MediaPlayer1.Visible = False
        Flash1.Visible = True
        O1.FileName = ""
        O1.Filter = ("����ý��|*.swf;*.dat;*.mpg;*.mp3;*.mp2;*.wma;*.wmv;*avi|�����ļ�|*.swf|��Ƶ�ļ�|*.dat;*.mpg;*.wmv;*.avi|��Ƶ�ļ�|*.mp2;*.mp3;*.wma|�����ļ�|*.*")
    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Flash1.Width = Me.Width
        Flash1.Height = Me.Height
        MediaPlayer1.Width = Me.Width
        MediaPlayer1.Height = Me.Height
    End Sub
    Private Sub ��OToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ��OToolStripMenuItem.Click
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
    Private Sub �˳�QToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �˳�QToolStripMenuItem.Click
        End
    End Sub
    Private Sub ����AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����AToolStripMenuItem.Click
        MsgBox("�������Ȩ�����۵���,����ؾ�!" & Chr(13) & "Email:kandisheng@21cn.com" & Chr(13) & "QQ:474028891", MsgBoxStyle.Information, "ע��")
    End Sub

    Private Sub ����PToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����PToolStripMenuItem.Click
        Select Case Flash1.Visible
            Case True
                Flash1.Play()
            Case False
                MediaPlayer1.Refresh()
        End Select
    End Sub
End Class
