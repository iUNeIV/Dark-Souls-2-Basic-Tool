'==================================================='
'                                                   '
'             BY iUNeIV                             '
'                                                   '
'            Open-Source = TEAM                     '
'                                                   '
'                                                   '
'                                                   '
'                                                   '
'==================================================='


Imports PS3Lib
Imports PS3Lib.NET

Public Class Form1

    ' Public Shared API As New PS3API()
    Private CCAPI As New CCAPI_Box()

    Private API As New PS3API()
    Private rand As New Random()

#Region "Custom Stats Box"



#End Region
#Region "Custom Stats Box"
   
#End Region

#Region "Custom Stats Box 1"
    
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable Then


        Else
            MessageBox.Show("You are not connected to a network.", "Network connection error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SimplaButton2_Click(sender As Object, e As EventArgs) Handles SimplaButton2.Click

        CCAPI_Box.ShowDialog()

    End Sub
    Private Sub SimplaButton1_Click(sender As Object, e As EventArgs) Handles SimplaButton1.Click
        Try
            If API.TMAPI.ConnectTarget() Then

                If API.TMAPI.AttachProcess() Then
                    MessageBox.Show("Thank you for using my tool !!!" + vbNewLine + "You are logged in as : " + API.GetConsoleName() + "." + vbNewLine + "Find me on {[ www.vf99.fr ]}", "Connecting the PS3", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    SimplaButton46.Text = "Disconnect : DEX"
                    SimplaButton2.Enabled = True
                Else
                    MessageBox.Show("You had a problem attach with the PlayStation 3 {TMAPI}", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Else

                MessageBox.Show("You had a problem attach with the  PlayStation 3 {TMAPI}", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("The program is crashing.", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End Try
    End Sub
    Private Sub SimplaButton46_Click(sender As Object, e As EventArgs) Handles SimplaButton46.Click
        SimplaButton46.Text = "Disconnect API"
        API.DisconnectTarget()
        SimplaButton1.Enabled = True
        SimplaButton2.Enabled = True
    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' lor du close du tool // close API PS3
        API.DisconnectTarget()

    End Sub
    Private Sub Label41_Click(sender As Object, e As EventArgs)
        API.DisconnectTarget()
    End Sub
    Private Sub SimplaButton3_Click(sender As Object, e As EventArgs) Handles SimplaButton3.Click
        ' Max Souls
        Dim bytes As Byte() = New Byte() {&H7F, &HFF, &HFF, &HFF}
        API.SetMemory(&H32921DC8, bytes)
    End Sub

    Private Sub SimplaButton4_Click(sender As Object, e As EventArgs) Handles SimplaButton4.Click
        ' God Mode
        Dim bytes As Byte() = New Byte() {&H10, &H0}
        API.SetMemory(&H328A771C, bytes)
        API.SetMemory(&H328A7724, bytes)
    End Sub

    Private Sub SimplaButton5_Click(sender As Object, e As EventArgs) Handles SimplaButton5.Click
        ' Damage
        Dim bytes As Byte() = New Byte() {&H10, &H0, &H0}
        API.SetMemory(&H32921D34, bytes)

        Dim bytes2 As Byte() = New Byte() {&H10, &H0, &H0}
        API.SetMemory(&H32921D40, bytes2)
    End Sub

    Private Sub SimplaButton6_Click(sender As Object, e As EventArgs) Handles SimplaButton6.Click
        ' Souffe
        Dim bytes As Byte() = New Byte() {&H7F, &HFF, &HFF, &HFF}
        API.SetMemory(&H328A7760, bytes)
        API.SetMemory(&H328A7768, bytes)
    End Sub

    Private Sub SimplaButton7_Click(sender As Object, e As EventArgs) Handles SimplaButton7.Click
        ' Level
        Dim bytes As Byte() = New Byte() {&HFF, &HFF}
        API.SetMemory(&H32921DAE, bytes)
    End Sub
    Private Sub SimplaButton33_Click(sender As Object, e As EventArgs)
        'def
        Dim bytes As Byte() = New Byte() {&H10, &H0}
        API.SetMemory(&H32921D2C, bytes)
    End Sub
    Private Sub SimplaButton8_Click(sender As Object, e As EventArgs) Handles SimplaButton8.Click
        If SimplaButton8.Text = "All Auto {ON}" Then
            SimplaButton8.Text = "All Auto {OFF}"
            Timer1.Start()

        ElseIf SimplaButton8.Text = "All Auto {OFF}" Then
            SimplaButton8.Text = "All Auto {ON}"
            Timer1.Stop()

        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim bytes1 As Byte() = New Byte() {&H7F, &HFF, &HFF, &HFF}
        API.SetMemory(&H32921DC8, bytes1)

        Dim bytes2 As Byte() = New Byte() {&H10, &H0}
        API.SetMemory(&H328A771C, bytes2)
        API.SetMemory(&H328A7724, bytes2)

        Dim bytes3 As Byte() = New Byte() {&H10, &H0, &H0}
        API.SetMemory(&H32921D34, bytes3)

        Dim bytes4 As Byte() = New Byte() {&H7F, &HFF, &HFF, &HFF}
        API.SetMemory(&H328A7760, bytes4)
        API.SetMemory(&H328A7768, bytes4)

    End Sub
#Region "Custom Stats"
   
#End Region
  
    Private Sub SimplaButton13_Click(sender As Object, e As EventArgs)

        Dim text As String = 100000000
        Dim num As Integer = Convert.ToInt32(text)
        API.Extension.WriteInt32(&H32921DC8, num)

        Dim bytes As Byte() = New Byte() {&H63}
        API.SetMemory(848436453, bytes)
        API.SetMemory(848436467, bytes)
        API.SetMemory(848436465, bytes)
        API.SetMemory(848436459, bytes)
        API.SetMemory(848436457, bytes)
        API.SetMemory(848436455, bytes)
        API.SetMemory(848436461, bytes)
        API.SetMemory(848436453, bytes)
        API.SetMemory(848436463, bytes)

    End Sub

    Private Sub SimplaButton12_Click(sender As Object, e As EventArgs)
        Dim text As String = 999999999
        Dim num As Integer = Convert.ToInt32(text)
        API.Extension.WriteInt32(&H32921DC8, num)

        Dim bytes As Byte() = New Byte() {&HFF}
        Dim bytes1 As Byte() = New Byte() {&H8C, &H2}

        API.SetMemory(&H32921DAE, bytes1)
        API.SetMemory(&H32921CF5, bytes)
        API.SetMemory(&H32921CF3, bytes)
        API.SetMemory(&H32921CF1, bytes)
        API.SetMemory(&H32921CEB, bytes)
        API.SetMemory(&H32921CE9, bytes)
        API.SetMemory(&H32921CE7, bytes)
        API.SetMemory(&H32921CED, bytes)
        API.SetMemory(&H32921CE5, bytes)
        API.SetMemory(&H32921CEF, bytes)
    End Sub

    Private Sub SimplaButton14_Click(sender As Object, e As EventArgs)
        Dim bytes As Byte() = New Byte() {&H1}
        Dim bytes1 As Byte() = New Byte() {&H0, &H1}
        Dim bytes2 As Byte() = New Byte() {&H0, &H0, &H0, &H0}
        API.SetMemory(&H32921CF5, bytes)
        API.SetMemory(&H32921CF3, bytes)
        API.SetMemory(&H32921CF1, bytes)
        API.SetMemory(&H32921CEB, bytes)
        API.SetMemory(&H32921CE9, bytes)
        API.SetMemory(&H32921CE7, bytes)
        API.SetMemory(&H32921CED, bytes)
        API.SetMemory(&H32921CE5, bytes)
        API.SetMemory(&H32921CEF, bytes)
        API.SetMemory(&H32921DAE, bytes1)
        API.SetMemory(&H32921DC8, bytes2)
    End Sub
    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://www.iUNeIV.xyz")
    End Sub
    Private Sub SimplaButton25_Click(sender As Object, e As EventArgs) Handles SimplaButton25.Click

        'Normal
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H10}
        API.SetMemory(&H328A8DB0, bytes1)
    End Sub
    Private Sub SimplaButton37_Click(sender As Object, e As EventArgs)

        Dim bytes As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB0, bytes)

        Dim bytes2 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB8, bytes2)

    End Sub
    Private Sub SimplaButton26_Click(sender As Object, e As EventArgs) Handles SimplaButton26.Click
        'Normal
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'green
        Dim bytes1 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB4, bytes1)
    End Sub

    Private Sub SimplaButton27_Click(sender As Object, e As EventArgs) Handles SimplaButton27.Click
        'red flash
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB0, bytes1)
    End Sub

    Private Sub SimplaButton28_Click(sender As Object, e As EventArgs) Handles SimplaButton28.Click
        ' Transparent
        Dim bytes As Byte() = New Byte() {&H60}
        API.SetMemory(&H328A8DBC, bytes)
    End Sub

    Private Sub SimplaButton29_Click(sender As Object, e As EventArgs) Handles SimplaButton29.Click
        'Normal
        Dim bytes1 As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes1)
        API.SetMemory(&H328A8DB8, bytes1)
        API.SetMemory(&H328A8DB4, bytes1)
        API.SetMemory(&H328A8DBC, bytes1)

    End Sub

    Private Sub SimplaButton32_Click(sender As Object, e As EventArgs)
        'vite
        Dim bytes As Byte() = New Byte() {&HFF}
        API.SetMemory(&H328A7829, bytes)
    End Sub

    Private Sub SimplaButton34_Click(sender As Object, e As EventArgs)
        'lent
        Dim bytes As Byte() = New Byte() {&H0}
        API.SetMemory(&H328A7829, bytes)
    End Sub

    Private Sub SimplaButton30_Click(sender As Object, e As EventArgs)
        'nomal viteasse
        Dim bytes As Byte() = New Byte() {&H80}
        API.SetMemory(&H328A7829, bytes)
    End Sub
    Private Sub SimplaButton37_Click_1(sender As Object, e As EventArgs) Handles SimplaButton37.Click
        'Normal
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'whate
        Dim bytes1 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB0, bytes1)
        API.SetMemory(&H328A8DB8, bytes1)
        API.SetMemory(&H328A8DB4, bytes1)

    End Sub

    Private Sub SimplaButton39_Click(sender As Object, e As EventArgs) Handles SimplaButton39.Click
        'YELLOW
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB0, bytes1)
        API.SetMemory(&H328A8DB4, bytes1)
    End Sub

    Private Sub SimplaButton36_Click(sender As Object, e As EventArgs) Handles SimplaButton36.Click
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB8, bytes1)
        API.SetMemory(&H328A8DB8, bytes1)
        API.SetMemory(&H328A8DB0, bytes1)
    End Sub

    Private Sub SimplaButton38_Click(sender As Object, e As EventArgs) Handles SimplaButton38.Click
        ' Transparent
        Dim bytes As Byte() = New Byte() {&H43}
        API.SetMemory(&H328A8DBC, bytes)
    End Sub

    Private Sub SimplaButton40_Click(sender As Object, e As EventArgs) Handles SimplaButton40.Click
        If SimplaButton40.Text = "RANDOM ON" Then
            SimplaButton40.Text = "RANDOM OFF"
            Timer3.Start()
        ElseIf SimplaButton40.Text = "RANDOM OFF" Then
            SimplaButton40.Text = "RANDOM ON"
            Timer3.Stop()
        End If
    End Sub

    Private Sub SimplaButton31_Click_1(sender As Object, e As EventArgs)
        ' God Mode
        Dim bytes As Byte() = New Byte() {&HFF, &HFF}
        API.SetMemory(&H328A771C, bytes)
        API.SetMemory(&H328A7724, bytes)
    End Sub

    Private Sub SimplaButton32_Click_1(sender As Object, e As EventArgs) Handles SimplaButton32.Click
        'vite
        Dim bytes As Byte() = New Byte() {&HFF}
        API.SetMemory(&H328A7829, bytes)
    End Sub

    Private Sub SimplaButton42_Click(sender As Object, e As EventArgs) Handles SimplaButton42.Click
        'lent
        Dim bytes As Byte() = New Byte() {&H0}
        API.SetMemory(&H328A7829, bytes)
    End Sub

    Private Sub SimplaButton35_Click(sender As Object, e As EventArgs) Handles SimplaButton35.Click
        'nomal viteasse
        Dim bytes As Byte() = New Byte() {&H80}
        API.SetMemory(&H328A7829, bytes)
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Process.Start("https://github.com/iUNeIV/Dark-Souls-2-Basic-Tool")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Process.Start("https://vf99.fr/threads/dark-souls-2-basic-tool.177/")
    End Sub

    Private Sub SimplaButton9_Click_1(sender As Object, e As EventArgs) Handles SimplaButton9.Click
        Try
            If SimplaTextBox2.Text = "" Then
                MessageBox.Show("Which levels you wanted ?")
            Else
                Dim input As Integer = Integer.Parse(SimplaTextBox2.Text)
                API.Extension.WriteInt32(848436652, input)
            End If
            '  TextBox1.Text = String.Concat(API.Extension.ReadInt32(&H32921DC8))
        Catch ex As Exception
            MessageBox.Show("He had an error in the requested number" + vbNewLine + "The numbers are 1 to 1 000 000 000 for the levels", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimplaButton12_Click_1(sender As Object, e As EventArgs) Handles SimplaButton12.Click
        Try
            If SimplaTextBox3.Text = "" Then
                MessageBox.Show("How many souls you wanted ?")
            Else
                Dim input As Integer = Integer.Parse(Me.SimplaTextBox3.Text)
                API.Extension.WriteInt32(848436680, input)
            End If

        Catch ex As Exception
            MessageBox.Show("He had an error in the requested number" + vbNewLine + "The numbers are from 1 to 99 999 999 for the Souls [The Max. It is 2,147,483,647 but then it becomes the default of 99,999,999]", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimplaButton56_Click(sender As Object, e As EventArgs) Handles SimplaButton56.Click

        Dim bytes As Byte() = New Byte() {&H0}
        API.SetMemory(&H32921CE5, bytes)
        API.SetMemory(&H32921CE7, bytes)
        API.SetMemory(&H32921CE9, bytes)
        API.SetMemory(&H32921CEB, bytes)
        API.SetMemory(&H32921CED, bytes)
        API.SetMemory(&H32921CEF, bytes)
        API.SetMemory(&H32921CF5, bytes)
        API.SetMemory(&H32921CF1, bytes)
        API.SetMemory(&H32921CF3, bytes)

    End Sub

    Private Sub SimplaButton54_Click(sender As Object, e As EventArgs) Handles SimplaButton54.Click
        Dim bytes As Byte() = New Byte() {&H63}
        API.SetMemory(&H32921CE5, bytes)
        API.SetMemory(&H32921CE7, bytes)
        API.SetMemory(&H32921CE9, bytes)
        API.SetMemory(&H32921CEB, bytes)
        API.SetMemory(&H32921CED, bytes)
        API.SetMemory(&H32921CEF, bytes)
        API.SetMemory(&H32921CF5, bytes)
        API.SetMemory(&H32921CF1, bytes)
        API.SetMemory(&H32921CF3, bytes)
    End Sub

    Private Sub SimplaButton55_Click(sender As Object, e As EventArgs) Handles SimplaButton55.Click
        Dim bytes As Byte() = New Byte() {&HFF}
        API.SetMemory(&H32921CE5, bytes)
        API.SetMemory(&H32921CE7, bytes)
        API.SetMemory(&H32921CE9, bytes)
        API.SetMemory(&H32921CEB, bytes)
        API.SetMemory(&H32921CED, bytes)
        API.SetMemory(&H32921CEF, bytes)
        API.SetMemory(&H32921CF5, bytes)
        API.SetMemory(&H32921CF1, bytes)
        API.SetMemory(&H32921CF3, bytes)
    End Sub

    Private Sub SimplaButton15_Click(sender As Object, e As EventArgs) Handles SimplaButton15.Click
        Dim bytes As Byte() = New Byte() {&H0}
        API.SetMemory(&H32921CE5, bytes)
    End Sub

    Private Sub SimplaButton31_Click(sender As Object, e As EventArgs) Handles SimplaButton31.Click
        Dim bytes As Byte() = New Byte() {&H63}
        API.SetMemory(&H32921CE5, bytes)
    End Sub

    Private Sub SimplaButton30_Click_1(sender As Object, e As EventArgs) Handles SimplaButton30.Click
        Dim bytes As Byte() = New Byte() {&HFF}
        API.SetMemory(&H32921CE5, bytes)
    End Sub

    Private Sub SimplaButton33_Click_1(sender As Object, e As EventArgs) Handles SimplaButton33.Click
        Dim bytes As Byte() = New Byte() {&H0}
        API.SetMemory(&H32921CE7, bytes)
    End Sub

    Private Sub SimplaButton22_Click(sender As Object, e As EventArgs) Handles SimplaButton22.Click
        Dim bytes As Byte() = New Byte() {&H63}
        API.SetMemory(&H32921CE7, bytes)
    End Sub

    Private Sub SimplaButton23_Click(sender As Object, e As EventArgs) Handles SimplaButton23.Click
        Dim bytes As Byte() = New Byte() {&HFF}
        API.SetMemory(&H32921CE7, bytes)
    End Sub

    Private Sub SimplaButton47_Click(sender As Object, e As EventArgs) Handles SimplaButton47.Click
        Dim bytes As Byte() = New Byte() {&H0}
        API.SetMemory(&H32921CE9, bytes)
    End Sub

    Private Sub SimplaButton44_Click(sender As Object, e As EventArgs) Handles SimplaButton44.Click
        Dim bytes As Byte() = New Byte() {&H63}
        API.SetMemory(&H32921CE9, bytes)
    End Sub

    Private Sub SimplaButton45_Click(sender As Object, e As EventArgs) Handles SimplaButton45.Click
        Dim bytes As Byte() = New Byte() {&HFF}
        API.SetMemory(&H32921CE9, bytes)
    End Sub

    Private Sub SimplaButton53_Click(sender As Object, e As EventArgs) Handles SimplaButton53.Click
        Dim bytes As Byte() = New Byte() {&H0}
        API.SetMemory(&H32921CED, bytes)
    End Sub

    Private Sub SimplaButton51_Click(sender As Object, e As EventArgs) Handles SimplaButton51.Click
        Dim bytes As Byte() = New Byte() {&H63}
        API.SetMemory(&H32921CED, bytes)
    End Sub

    Private Sub SimplaButton52_Click(sender As Object, e As EventArgs) Handles SimplaButton52.Click
        Dim bytes As Byte() = New Byte() {&HFF}
        API.SetMemory(&H32921CED, bytes)
    End Sub

    Private Sub SimplaButton18_Click(sender As Object, e As EventArgs) Handles SimplaButton18.Click
        Dim bytes As Byte() = New Byte() {&H0}
        API.SetMemory(&H32921CEF, bytes)
    End Sub

    Private Sub SimplaButton16_Click(sender As Object, e As EventArgs) Handles SimplaButton16.Click
        Dim bytes As Byte() = New Byte() {&H63}
        API.SetMemory(&H32921CEF, bytes)
    End Sub

    Private Sub SimplaButton17_Click(sender As Object, e As EventArgs) Handles SimplaButton17.Click
        Dim bytes As Byte() = New Byte() {&HFF}
        API.SetMemory(&H32921CEF, bytes)
    End Sub

    Private Sub SimplaButton21_Click(sender As Object, e As EventArgs) Handles SimplaButton21.Click
        Dim bytes As Byte() = New Byte() {&H0}
        API.SetMemory(&H32921CF5, bytes)
    End Sub

    Private Sub SimplaButton19_Click(sender As Object, e As EventArgs) Handles SimplaButton19.Click
        Dim bytes As Byte() = New Byte() {&H63}
        API.SetMemory(&H32921CF5, bytes)
    End Sub

    Private Sub SimplaButton20_Click(sender As Object, e As EventArgs) Handles SimplaButton20.Click
        Dim bytes As Byte() = New Byte() {&HFF}
        API.SetMemory(&H32921CF5, bytes)
    End Sub

    Private Sub SimplaButton43_Click(sender As Object, e As EventArgs) Handles SimplaButton43.Click
        Dim bytes As Byte() = New Byte() {&H0}
        API.SetMemory(&H32921CF1, bytes)
    End Sub

    Private Sub SimplaButton34_Click_1(sender As Object, e As EventArgs) Handles SimplaButton34.Click
        Dim bytes As Byte() = New Byte() {&H63}
        API.SetMemory(&H32921CF1, bytes)
    End Sub

    Private Sub SimplaButton41_Click(sender As Object, e As EventArgs) Handles SimplaButton41.Click
        Dim bytes As Byte() = New Byte() {&HFF}
        API.SetMemory(&H32921CF1, bytes)
    End Sub

    Private Sub SimplaButton50_Click(sender As Object, e As EventArgs) Handles SimplaButton50.Click
        Dim bytes As Byte() = New Byte() {&H0}
        API.SetMemory(&H32921CF3, bytes)
    End Sub

    Private Sub SimplaButton48_Click(sender As Object, e As EventArgs) Handles SimplaButton48.Click
        Dim bytes As Byte() = New Byte() {&H63}
        API.SetMemory(&H32921CF3, bytes)
    End Sub

    Private Sub SimplaButton49_Click(sender As Object, e As EventArgs) Handles SimplaButton49.Click
        Dim bytes As Byte() = New Byte() {&HFF}
        API.SetMemory(&H32921CF3, bytes)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If Label2.Text = "0" Then
            'Normal
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'whate
            Dim bytes1 As Byte() = New Byte() {&H45}
            API.SetMemory(&H328A8DB0, bytes1)
            API.SetMemory(&H328A8DB8, bytes1)
            API.SetMemory(&H328A8DB4, bytes1)
            Label2.Text = "1"
        ElseIf Label2.Text = "1" Then
            'Normal
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'red
            Dim bytes1 As Byte() = New Byte() {&H10}
            API.SetMemory(&H328A8DB8, bytes1)
            Label2.Text = "2"
        ElseIf Label2.Text = "2" Then
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'red
            Dim bytes1 As Byte() = New Byte() {&H41}
            API.SetMemory(&H328A8DB8, bytes1)
            API.SetMemory(&H328A8DB0, bytes1)
            Label2.Text = "3"
        ElseIf Label2.Text = "3" Then
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'red
            Dim bytes1 As Byte() = New Byte() {&H41}
            API.SetMemory(&H328A8DB4, bytes1)
            API.SetMemory(&H328A8DB8, bytes1)
            Label2.Text = "4"
        ElseIf Label2.Text = "4" Then
            'Normal
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'green
            Dim bytes1 As Byte() = New Byte() {&H45}
            API.SetMemory(&H328A8DB4, bytes1)
            Label2.Text = "5"
        ElseIf Label2.Text = "5" Then
            'red flash
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'red
            Dim bytes1 As Byte() = New Byte() {&H40}
            API.SetMemory(&H328A8DB8, bytes1)
            API.SetMemory(&H328A8DB0, bytes1)
            Label2.Text = "6"
        ElseIf Label2.Text = "6" Then
            'Normal
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'Black
            Dim bytes1 As Byte() = New Byte() {&H41}
            API.SetMemory(&H328A8DB4, bytes1)
            API.SetMemory(&H328A8DB8, bytes1)
            API.SetMemory(&H328A8DB0, bytes1)
            Label2.Text = "7"
        ElseIf Label2.Text = "7" Then
            'Normal
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'red
            Dim bytes1 As Byte() = New Byte() {&H45}
            API.SetMemory(&H328A8DB4, bytes1)
            API.SetMemory(&H328A8DB0, bytes1)
            Dim bytes2 As Byte() = New Byte() {&H41}
            API.SetMemory(&H328A8DB8, bytes2)
            Label2.Text = "8"
        ElseIf Label2.Text = "8" Then
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'red
            Dim bytes1 As Byte() = New Byte() {&H45}
            API.SetMemory(&H328A8DB8, bytes1)
            API.SetMemory(&H328A8DB8, bytes1)
            API.SetMemory(&H328A8DB0, bytes1)
            Label2.Text = "9"
        ElseIf Label2.Text = "9" Then
            'Normal
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'blue
            Dim bytes1 As Byte() = New Byte() {&H41}
            API.SetMemory(&H328A8DB4, bytes1)
            Dim bytes2 As Byte() = New Byte() {&H42}
            API.SetMemory(&H328A8DB8, bytes2)
            Label2.Text = "10"
        ElseIf Label2.Text = "10" Then
            'Normal
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'green
            Dim bytes1 As Byte() = New Byte() {&H45}
            API.SetMemory(&H328A8DB4, bytes1)
            Label2.Text = "11"
        ElseIf Label2.Text = "11" Then
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'Black
            Dim bytes1 As Byte() = New Byte() {&H1}
            API.SetMemory(&H328A8DB0, bytes1)
            API.SetMemory(&H328A8DB8, bytes1)
            API.SetMemory(&H328A8DB4, bytes1)
            Label2.Text = "12"
        ElseIf Label2.Text = "12" Then
            'Normal
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'red
            Dim bytes1 As Byte() = New Byte() {&H45}
            API.SetMemory(&H328A8DB8, bytes1)
            Dim bytes2 As Byte() = New Byte() {&H41}
            API.SetMemory(&H328A8DB0, bytes2)
            Dim bytes3 As Byte() = New Byte() {&H45}
            API.SetMemory(&H328A8DB4, bytes3)
            Label2.Text = "13"
        ElseIf Label2.Text = "13" Then
            'red flash
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'red
            Dim bytes1 As Byte() = New Byte() {&HFF}
            API.SetMemory(&H328A8DBC, bytes1)
            Dim bytes2 As Byte() = New Byte() {&H0}
            API.SetMemory(&H328A8DB4, bytes2)
            API.SetMemory(&H328A8DB8, bytes2)
            API.SetMemory(&H328A8DB0, bytes2)
            Label2.Text = "0"
        End If
    End Sub

    Private Sub SimplaButton13_Click_1(sender As Object, e As EventArgs) Handles SimplaButton13.Click
        'Normal
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'Black
        Dim bytes1 As Byte() = New Byte() {&H41}
        API.SetMemory(&H328A8DB4, bytes1)
        API.SetMemory(&H328A8DB8, bytes1)
        API.SetMemory(&H328A8DB0, bytes1)
    End Sub

    Private Sub SimplaButton74_Click(sender As Object, e As EventArgs) Handles SimplaButton74.Click
        Dim bytes As Byte() = New Byte() {&H0}
        API.SetMemory(&H32921CEB, bytes)
    End Sub

    Private Sub SimplaButton72_Click(sender As Object, e As EventArgs) Handles SimplaButton72.Click
        Dim bytes As Byte() = New Byte() {&H63}
        API.SetMemory(&H32921CEB, bytes)
    End Sub

    Private Sub SimplaButton73_Click(sender As Object, e As EventArgs) Handles SimplaButton73.Click
        Dim bytes As Byte() = New Byte() {&HFF}
        API.SetMemory(&H32921CEB, bytes)
    End Sub

    Private Sub SimplaButton11_Click(sender As Object, e As EventArgs) Handles SimplaButton11.Click
        'Normal
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H10}
        API.SetMemory(&H328A8DB8, bytes1)
    End Sub

    Private Sub SimplaButton59_Click(sender As Object, e As EventArgs) Handles SimplaButton59.Click
        'Normal
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB4, bytes1)
        API.SetMemory(&H328A8DB0, bytes1)
        Dim bytes2 As Byte() = New Byte() {&H41}
        API.SetMemory(&H328A8DB8, bytes2)
    End Sub

    Private Sub SimplaButton65_Click(sender As Object, e As EventArgs) Handles SimplaButton65.Click
       
    End Sub

    Private Sub SimplaButton10_Click(sender As Object, e As EventArgs) Handles SimplaButton10.Click
         Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H10}
        API.SetMemory(&H328A8DB4, bytes1)
    End Sub

    Private Sub SimplaButton58_Click(sender As Object, e As EventArgs) Handles SimplaButton58.Click
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H41}
        API.SetMemory(&H328A8DB8, bytes1)
        API.SetMemory(&H328A8DB0, bytes1)
    End Sub

    Private Sub SimplaButton64_Click(sender As Object, e As EventArgs) Handles SimplaButton64.Click
      
    End Sub

    Private Sub SimplaButton14_Click_1(sender As Object, e As EventArgs) Handles SimplaButton14.Click
        'Normal
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'blue
        Dim bytes1 As Byte() = New Byte() {&H41}
        API.SetMemory(&H328A8DB4, bytes1)
        Dim bytes2 As Byte() = New Byte() {&H42}
        API.SetMemory(&H328A8DB8, bytes2)
    End Sub

    Private Sub SimplaButton61_Click(sender As Object, e As EventArgs) Handles SimplaButton61.Click
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB4, bytes1)
        Dim bytes2 As Byte() = New Byte() {&H42}
        API.SetMemory(&H328A8DB8, bytes2)
    End Sub

    Private Sub SimplaButton67_Click(sender As Object, e As EventArgs) Handles SimplaButton67.Click
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H41}
        API.SetMemory(&H328A8DB4, bytes1)
        API.SetMemory(&H328A8DB8, bytes1)
    End Sub

    Private Sub SimplaButton57_Click(sender As Object, e As EventArgs) Handles SimplaButton57.Click
         'Normal
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'green
        Dim bytes1 As Byte() = New Byte() {&H41}
        API.SetMemory(&H328A8DB4, bytes1)
    End Sub

    Private Sub SimplaButton63_Click(sender As Object, e As EventArgs) Handles SimplaButton63.Click
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H0}
        API.SetMemory(&H328A8DB8, bytes1)
        API.SetMemory(&H328A8DB0, bytes1)
    End Sub

    Private Sub SimplaButton60_Click(sender As Object, e As EventArgs) Handles SimplaButton60.Click
        'Normal
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB8, bytes1)
        Dim bytes2 As Byte() = New Byte() {&H41}
        API.SetMemory(&H328A8DB0, bytes2)
        Dim bytes3 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB4, bytes3)
    End Sub

    Private Sub SimplaButton66_Click(sender As Object, e As EventArgs) Handles SimplaButton66.Click
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'Black
        Dim bytes1 As Byte() = New Byte() {&H1}
        API.SetMemory(&H328A8DB0, bytes1)
        API.SetMemory(&H328A8DB8, bytes1)
        API.SetMemory(&H328A8DB4, bytes1)
    End Sub

    Private Sub SimplaButton69_Click(sender As Object, e As EventArgs) Handles SimplaButton69.Click
        'Normal
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'green
        Dim bytes1 As Byte() = New Byte() {&H41}
        API.SetMemory(&H328A8DB8, bytes1)
        API.SetMemory(&H328A8DB0, bytes1)
        Dim bytes2 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB4, bytes2)
    End Sub

    Private Sub SimplaButton24_Click(sender As Object, e As EventArgs) Handles SimplaButton24.Click
        'red flash
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H40}
        API.SetMemory(&H328A8DB8, bytes1)
        API.SetMemory(&H328A8DB0, bytes1)
    End Sub

    Private Sub SimplaButton62_Click(sender As Object, e As EventArgs) Handles SimplaButton62.Click
        'red flash
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H10}
        API.SetMemory(&H328A8DB4, bytes1)
        API.SetMemory(&H328A8DB8, bytes1)
    End Sub

    Private Sub SimplaButton68_Click(sender As Object, e As EventArgs) Handles SimplaButton68.Click
        'red flash
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H10}
        API.SetMemory(&H328A8DB4, bytes1)
        API.SetMemory(&H328A8DB8, bytes1)
        Dim bytes2 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB0, bytes2)
    End Sub

    Private Sub SimplaButton71_Click(sender As Object, e As EventArgs) Handles SimplaButton71.Click
        'red flash
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&HFF}
        API.SetMemory(&H328A8DBC, bytes1)
        Dim bytes2 As Byte() = New Byte() {&H0}
        API.SetMemory(&H328A8DB4, bytes2)
        API.SetMemory(&H328A8DB8, bytes2)
        API.SetMemory(&H328A8DB0, bytes2)
    End Sub

    Private Sub SimplaButton70_Click(sender As Object, e As EventArgs) Handles SimplaButton70.Click
        Dim bytes As Byte() = New Byte() {&H47}
        API.SetMemory(&H328A8DBC, bytes)
    End Sub
End Class
