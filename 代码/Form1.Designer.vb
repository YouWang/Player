<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer
        Me.Flash1 = New AxShockwaveFlashObjects.AxShockwaveFlash
        Me.O1 = New System.Windows.Forms.OpenFileDialog
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.文件OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.打开OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.退出QToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.控制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.播放PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.关于AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.MediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MediaPlayer1
        '
        Me.MediaPlayer1.Enabled = True
        Me.MediaPlayer1.Location = New System.Drawing.Point(0, 27)
        Me.MediaPlayer1.Name = "MediaPlayer1"
        Me.MediaPlayer1.OcxState = CType(resources.GetObject("MediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.MediaPlayer1.TabIndex = 0
        '
        'Flash1
        '
        Me.Flash1.Enabled = True
        Me.Flash1.Location = New System.Drawing.Point(0, 27)
        Me.Flash1.Name = "Flash1"
        Me.Flash1.OcxState = CType(resources.GetObject("Flash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Flash1.Size = New System.Drawing.Size(192, 192)
        Me.Flash1.TabIndex = 1
        '
        'O1
        '
        Me.O1.FileName = "O1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件OToolStripMenuItem, Me.控制ToolStripMenuItem, Me.帮助HToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件OToolStripMenuItem
        '
        Me.文件OToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开OToolStripMenuItem, Me.退出QToolStripMenuItem})
        Me.文件OToolStripMenuItem.Name = "文件OToolStripMenuItem"
        Me.文件OToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.文件OToolStripMenuItem.Text = "文件(&F)"
        '
        '打开OToolStripMenuItem
        '
        Me.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem"
        Me.打开OToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.打开OToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.打开OToolStripMenuItem.Text = "打开(&O)"
        '
        '退出QToolStripMenuItem
        '
        Me.退出QToolStripMenuItem.Name = "退出QToolStripMenuItem"
        Me.退出QToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.退出QToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.退出QToolStripMenuItem.Text = "退出(&Q)"
        '
        '控制ToolStripMenuItem
        '
        Me.控制ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.播放PToolStripMenuItem})
        Me.控制ToolStripMenuItem.Name = "控制ToolStripMenuItem"
        Me.控制ToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.控制ToolStripMenuItem.Text = "控制(&C)"
        '
        '播放PToolStripMenuItem
        '
        Me.播放PToolStripMenuItem.Name = "播放PToolStripMenuItem"
        Me.播放PToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.播放PToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.播放PToolStripMenuItem.Text = "播放(&G)"
        '
        '帮助HToolStripMenuItem
        '
        Me.帮助HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于AToolStripMenuItem})
        Me.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem"
        Me.帮助HToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.帮助HToolStripMenuItem.Text = "帮助(&H)"
        '
        '关于AToolStripMenuItem
        '
        Me.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem"
        Me.关于AToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.关于AToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.关于AToolStripMenuItem.Text = "关于(&A)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.Flash1)
        Me.Controls.Add(Me.MediaPlayer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Flash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents O1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 文件OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 打开OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出QToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 控制ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 播放PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
