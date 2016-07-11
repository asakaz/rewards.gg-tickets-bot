Public Class Form1
    'Rewards.GG Tickets Bot - Coded by asakaz@github
    'If you Edit this Source, PLEASE give credit to me as the original creator
    'Enjoy
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Takes user to the theme used in this program
        Dim url As String = "http://pastebin.com/CHBiAdsx"

        Process.Start(url)
    End Sub

    Private Sub RedemptionRoundButton1_Click(sender As Object, e As EventArgs) Handles RedemptionRoundButton1.Click
        'Uses WebControl1 to Navigate to the Get-Tickets Page
        WebControl1.Source = New Uri("https://rewards.gg/get-tickets")
        RedemptionTabControl1.SelectTab(TabPage3)

        'Suspends Layout of WebControl1
        WebControl1.SuspendLayout()
    End Sub

    'Declaration of Mute Key
    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    Const KEYEVENTF_KEYUP As Long = &H2

    Private Sub RedemptionToggle1_CheckedChanged(sender As Object) Handles RedemptionToggle1.CheckedChanged
        'Mute Background Audio Control
        If RedemptionToggle1.Checked = True Then
            Call keybd_event(System.Windows.Forms.Keys.VolumeMute, 0, 0, 0)
        Else
            Call keybd_event(System.Windows.Forms.Keys.VolumeMute, 1, 1, 1)
        End If
    End Sub

    Private Sub RedemptionRoundButton2_Click(sender As Object, e As EventArgs) Handles RedemptionRoundButton2.Click
        'Shows the Login Page via : Awesominum WebControl1
        WebControl1.Source = New Uri("https://rewards.gg/login")
        RedemptionTabControl1.SelectTab(TabPage3)

        'Suspends Layout of WebControl1
        WebControl1.SuspendLayout()
    End Sub

    Private Sub RedemptionRoundButton3_Click(sender As Object, e As EventArgs) Handles RedemptionRoundButton3.Click
        RedemptionTabControl1.SelectTab(TabPage3)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim url As String = "https://github.com/asakaz/rewards.gg-tickets-bot"

        Process.Start(url)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim url As String = "https://github.com/asakaz/rewards.gg-tickets-bot"
        WebControl1.Source = New Uri(url)
    End Sub
End Class
