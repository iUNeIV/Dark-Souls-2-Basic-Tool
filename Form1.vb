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
    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        Label32.Text = NumericUpDown2.Value
    End Sub

    Private Sub NumericUpDown6_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown6.ValueChanged
        Label31.Text = NumericUpDown6.Value
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Label30.Text = NumericUpDown1.Value
    End Sub

    Private Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.ValueChanged
        Label29.Text = NumericUpDown7.Value
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        Label28.Text = NumericUpDown3.Value
    End Sub

    Private Sub NumericUpDown8_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown8.ValueChanged
        Label27.Text = NumericUpDown8.Value
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        Label26.Text = NumericUpDown4.Value
    End Sub

    Private Sub NumericUpDown9_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown9.ValueChanged
        Label25.Text = NumericUpDown9.Value
    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        Label24.Text = NumericUpDown5.Value
    End Sub
#End Region
#Region "Custom Stats Box 1"
    Private Sub SimplaButton15_Click(sender As Object, e As EventArgs) Handles SimplaButton15.Click

        Dim input As Integer = Integer.Parse(Me.NumericUpDown2.Value.ToString)
        API.Extension.WriteInt32(848436453, input)


    End Sub

    Private Sub SimplaButton16_Click(sender As Object, e As EventArgs) Handles SimplaButton16.Click

        Dim input As Integer = Integer.Parse(Me.NumericUpDown1.Value.ToString)
        API.Extension.WriteInt32(&H32921CE9, input)

    End Sub

    Private Sub SimplaButton17_Click(sender As Object, e As EventArgs) Handles SimplaButton17.Click
        Dim Wins As String = Me.NumericUpDown3.Value.ToString()
        Dim WinsX As Integer = Convert.ToInt32(Wins)
        Dim WinsX1 As Byte() = BitConverter.GetBytes(WinsX)
        API.SetMemory(&H32921CED, WinsX1)
    End Sub

    Private Sub SimplaButton22_Click(sender As Object, e As EventArgs) Handles SimplaButton22.Click
        Dim Wins As String = Me.NumericUpDown8.Value.ToString()
        Dim WinsX As Integer = Convert.ToInt32(Wins)
        Dim WinsX1 As Byte() = BitConverter.GetBytes(WinsX)
        API.SetMemory(&H32921CEF, WinsX1)
    End Sub

    Private Sub SimplaButton21_Click(sender As Object, e As EventArgs) Handles SimplaButton21.Click
        Dim Wins As String = Me.NumericUpDown7.Value.ToString()
        Dim WinsX As Integer = Convert.ToInt32(Wins)
        Dim WinsX1 As Byte() = BitConverter.GetBytes(WinsX)
        API.SetMemory(&H32921CEB, WinsX1)
    End Sub

    Private Sub SimplaButton20_Click(sender As Object, e As EventArgs) Handles SimplaButton20.Click
        Dim Wins As String = Me.NumericUpDown6.Value.ToString()
        Dim WinsX As Integer = Convert.ToInt32(Wins)
        Dim WinsX1 As Byte() = BitConverter.GetBytes(WinsX)
        API.SetMemory(&H32921CE7, WinsX1)
    End Sub

    Private Sub SimplaButton19_Click(sender As Object, e As EventArgs) Handles SimplaButton19.Click
        Dim Wins As String = Me.NumericUpDown5.Value.ToString()
        Dim WinsX As Integer = Convert.ToInt32(Wins)
        Dim WinsX1 As Byte() = BitConverter.GetBytes(WinsX)
        API.SetMemory(&H32921CF3, WinsX1)
    End Sub

    Private Sub SimplaButton18_Click(sender As Object, e As EventArgs) Handles SimplaButton18.Click
        Dim Wins As String = Me.NumericUpDown4.Value.ToString()
        Dim WinsX As Integer = Convert.ToInt32(Wins)
        Dim WinsX1 As Byte() = BitConverter.GetBytes(WinsX)
        API.SetMemory(&H32921CF5, WinsX1)
    End Sub

    Private Sub SimplaButton23_Click(sender As Object, e As EventArgs) Handles SimplaButton23.Click
        Dim Wins As String = Me.NumericUpDown9.Value.ToString()
        Dim WinsX As Integer = Convert.ToInt32(Wins)
        Dim WinsX1 As Byte() = BitConverter.GetBytes(WinsX)
        API.SetMemory(&H32921CF1, WinsX1)
    End Sub
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
    Private Sub SimplaButton33_Click(sender As Object, e As EventArgs) Handles SimplaButton33.Click
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
    Private Sub SimplaButton11_Click(sender As Object, e As EventArgs) Handles SimplaButton11.Click
        Try

            API.SetMemory(&H32921CE5, BitConverter.GetBytes(Convert.ToInt32(Label15.Text())))
            API.SetMemory(&H32921CE9, BitConverter.GetBytes(Convert.ToInt32(Label16.Text())))
            API.SetMemory(&H32921CED, BitConverter.GetBytes(Convert.ToInt32(Label17.Text())))
            API.SetMemory(&H32921CEF, BitConverter.GetBytes(Convert.ToInt32(Label18.Text())))
            API.SetMemory(&H32921CEB, BitConverter.GetBytes(Convert.ToInt32(Label19.Text())))
            API.SetMemory(&H32921CE7, BitConverter.GetBytes(Convert.ToInt32(Label20.Text())))
            API.SetMemory(&H32921CF3, BitConverter.GetBytes(Convert.ToInt32(Label21.Text())))
            API.SetMemory(&H32921CF5, BitConverter.GetBytes(Convert.ToInt32(Label22.Text())))
            API.SetMemory(&H32921CF1, BitConverter.GetBytes(Convert.ToInt32(Label23.Text())))

            API.SetMemory(&H32921CE5, BitConverter.GetBytes(Convert.ToInt32(NumericUpDown2.Value())))
            API.SetMemory(&H32921CE9, BitConverter.GetBytes(Convert.ToInt32(NumericUpDown6.Value())))
            API.SetMemory(&H32921CED, BitConverter.GetBytes(Convert.ToInt32(NumericUpDown1.Value())))
            API.SetMemory(&H32921CEF, BitConverter.GetBytes(Convert.ToInt32(NumericUpDown7.Value())))
            API.SetMemory(&H32921CEB, BitConverter.GetBytes(Convert.ToInt32(NumericUpDown3.Value())))
            API.SetMemory(&H32921CE7, BitConverter.GetBytes(Convert.ToInt32(NumericUpDown8.Value())))
            API.SetMemory(&H32921CF3, BitConverter.GetBytes(Convert.ToInt32(NumericUpDown4.Value())))
            API.SetMemory(&H32921CF5, BitConverter.GetBytes(Convert.ToInt32(NumericUpDown9.Value())))
            API.SetMemory(&H32921CF1, BitConverter.GetBytes(Convert.ToInt32(NumericUpDown5.Value())))

        Catch ex As Exception
            MessageBox.Show("Program Error", "Erreur 0x100")
        End Try

    End Sub
#End Region
    Private Sub SimplaButton10_Click(sender As Object, e As EventArgs) Handles SimplaButton10.Click
        Try
            If TextBox2.Text = "" Then
                MessageBox.Show("How many souls you wanted ?")
            Else
                Dim input As Integer = Integer.Parse(Me.TextBox2.Text)
                API.Extension.WriteInt32(848436680, input)
            End If

        Catch ex As Exception
            MessageBox.Show("He had an error in the requested number" + vbNewLine + "The numbers are from 1 to 99,999,999 for the Souls [The Max. It is 2,147,483,647 but then it becomes the default of 99,999,999]", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SimplaButton24_Click(sender As Object, e As EventArgs) Handles SimplaButton24.Click
        Try
            If TextBox1.Text = "" Then
                MessageBox.Show("Which levels you wanted ?")
            Else
                Dim input As Integer = Integer.Parse(TextBox1.Text)
                API.Extension.WriteInt32(848436652, input)
            End If
            '  TextBox1.Text = String.Concat(API.Extension.ReadInt32(&H32921DC8))
        Catch ex As Exception
            MessageBox.Show("He had an error in the requested number" + vbNewLine + "The numbers are 1 to 1 000 000 000 for the levels", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimplaButton9_Click(sender As Object, e As EventArgs) Handles SimplaButton9.Click
        Try
            Label15.Text = API.Extension.ReadByte(&H32921CE5)
            NumericUpDown2.Value = API.Extension.ReadByte(&H32921CE5)
            Label16.Text = API.Extension.ReadByte(&H32921CE7)
            NumericUpDown6.Value = API.Extension.ReadByte(&H32921CE7)
            Label17.Text = API.Extension.ReadByte(&H32921CE9)
            NumericUpDown1.Value = API.Extension.ReadByte(&H32921CE9)
            Label18.Text = API.Extension.ReadByte(&H32921CEB)
            NumericUpDown7.Value = API.Extension.ReadByte(&H32921CEB)
            Label19.Text = API.Extension.ReadByte(&H32921CED)
            NumericUpDown3.Value = API.Extension.ReadByte(&H32921CED)
            Label20.Text = API.Extension.ReadByte(&H32921CEF)
            NumericUpDown8.Value = API.Extension.ReadByte(&H32921CEF)
            Label21.Text = API.Extension.ReadByte(&H32921CF5)
            NumericUpDown4.Value = API.Extension.ReadByte(&H32921CF5)
            Label22.Text = API.Extension.ReadByte(&H32921CF1)
            NumericUpDown9.Value = API.Extension.ReadByte(&H32921CF1)
            Label23.Text = API.Extension.ReadByte(&H32921CF3)
            NumericUpDown5.Value = API.Extension.ReadByte(&H32921CF3)
        Catch ex As Exception
            MessageBox.Show("Program Error", "Erreur 0x110")
        End Try

    End Sub

    Private Sub SimplaButton13_Click(sender As Object, e As EventArgs) Handles SimplaButton13.Click

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

    Private Sub SimplaButton12_Click(sender As Object, e As EventArgs) Handles SimplaButton12.Click
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

    Private Sub SimplaButton14_Click(sender As Object, e As EventArgs) Handles SimplaButton14.Click
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
        Process.Start("https://www.iUNeIV.com")
    End Sub
    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click
        Process.Start("https://www.youtube.com/user/iUNeIV")
    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click
        Process.Start("https://www.twitter.com/iuneiv")
    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click
        Process.Start("https://realitygaming.fr/members/iuneiv.198122/")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://realitygaming.fr/teams/fench-hacker-gamer.1609/")
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Process.Start("https://www.iunieiv.com/dack-souls-2-basic.html")
    End Sub
    Private Sub SimplaButton25_Click(sender As Object, e As EventArgs) Handles SimplaButton25.Click

        'Normal
        Dim bytes As Byte() = New Byte() {&H3F}
        API.SetMemory(&H328A8DB0, bytes)
        API.SetMemory(&H328A8DB8, bytes)
        API.SetMemory(&H328A8DB4, bytes)
        API.SetMemory(&H328A8DBC, bytes)
        'red
        Dim bytes1 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB0, bytes1)
    End Sub
    Private Sub SimplaButton37_Click(sender As Object, e As EventArgs)

        Dim bytes As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB0, bytes)

        Dim bytes2 As Byte() = New Byte() {&H45}
        API.SetMemory(&H328A8DB8, bytes2)

    End Sub
    Private Sub SimplaButton26_Click(sender As Object, e As EventArgs) Handles SimplaButton26.Click

        If SimplaButton26.Text = "BLUE" Then

            'Normal
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'blue
            Dim bytes1 As Byte() = New Byte() {&H45}
            API.SetMemory(&H328A8DB8, bytes1)
            SimplaButton26.Text = "CYAN"
        ElseIf SimplaButton26.Text = "CYAN" Then

            'Normal
            Dim bytes As Byte() = New Byte() {&H3F}
            API.SetMemory(&H328A8DB0, bytes)
            API.SetMemory(&H328A8DB8, bytes)
            API.SetMemory(&H328A8DB4, bytes)
            API.SetMemory(&H328A8DBC, bytes)
            'red
            Dim bytes1 As Byte() = New Byte() {&H45}
            API.SetMemory(&H328A8DB4, bytes1)
            Dim bytes2 As Byte() = New Byte() {&H45}
            API.SetMemory(&H328A8DB8, bytes2)
            SimplaButton26.Text = "BLUE"
        End If
       
    End Sub

    Private Sub SimplaButton27_Click(sender As Object, e As EventArgs) Handles SimplaButton27.Click
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
        'Normal
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

    Private Sub SimplaButton36_Click(sender As Object, e As EventArgs) Handles SimplaButton36.Click
        'Normal
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

    Private Sub SimplaButton38_Click(sender As Object, e As EventArgs) Handles SimplaButton38.Click
        ' Transparent
        Dim bytes As Byte() = New Byte() {&H35}
        API.SetMemory(&H328A8DBC, bytes)
    End Sub

    Private Sub SimplaButton40_Click(sender As Object, e As EventArgs) Handles SimplaButton40.Click
        If SimplaButton40.Text = "RANDOM OFF" Then
            SimplaButton40.Text = "RANDOM ON"
            Timer3.Start()
        ElseIf SimplaButton40.Text = "RANDOM ON" Then
            SimplaButton40.Text = "RANDOM OFF"
            Timer3.Stop()
        End If


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

            If Label99.Text = "1" Then
                'Normal
                Dim bytes As Byte() = New Byte() {&H3F}
                API.SetMemory(&H328A8DB0, bytes)
                API.SetMemory(&H328A8DB8, bytes)
                API.SetMemory(&H328A8DB4, bytes)
                API.SetMemory(&H328A8DBC, bytes)
                'red
                Dim bytes1 As Byte() = New Byte() {&H45}
                API.SetMemory(&H328A8DB0, bytes1)
                Label99.Text = "2"

            ElseIf Label99.Text = "2" Then

                'Normal
                Dim bytes10 As Byte() = New Byte() {&H3F}
                API.SetMemory(&H328A8DB0, bytes10)
                API.SetMemory(&H328A8DB8, bytes10)
                API.SetMemory(&H328A8DB4, bytes10)
                API.SetMemory(&H328A8DBC, bytes10)
                'blue
                Dim bytes11 As Byte() = New Byte() {&H45}
                API.SetMemory(&H328A8DB8, bytes11)
                Label99.Text = "3"

            ElseIf Label99.Text = "3" Then

                Dim bytes As Byte() = New Byte() {&H3F}
                API.SetMemory(&H328A8DB0, bytes)
                API.SetMemory(&H328A8DB8, bytes)
                API.SetMemory(&H328A8DB4, bytes)
                API.SetMemory(&H328A8DBC, bytes)
                'green
                Dim bytes1 As Byte() = New Byte() {&H45}
                API.SetMemory(&H328A8DB4, bytes1)
                Label99.Text = "4"

            ElseIf Label99.Text = "4" Then

                'Normal
                Dim bytes As Byte() = New Byte() {&H3F}
                API.SetMemory(&H328A8DB0, bytes)
                API.SetMemory(&H328A8DB8, bytes)
                API.SetMemory(&H328A8DB4, bytes)
                API.SetMemory(&H328A8DBC, bytes)
                'red
                Dim bytes1 As Byte() = New Byte() {&H45}
                API.SetMemory(&H328A8DB4, bytes1)
                Dim bytes2 As Byte() = New Byte() {&H45}
                API.SetMemory(&H328A8DB8, bytes2)
                SimplaButton26.Text = "BLUE"
                Label99.Text = "5"

            ElseIf Label99.Text = "5" Then
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
                Label99.Text = "6"

            ElseIf Label99.Text = "6" Then
                'Normal
                Dim bytes As Byte() = New Byte() {&H3F}
                API.SetMemory(&H328A8DB0, bytes)
                API.SetMemory(&H328A8DB8, bytes)
                API.SetMemory(&H328A8DB4, bytes)
                API.SetMemory(&H328A8DBC, bytes)
                'red
                Dim bytes1 As Byte() = New Byte() {&H45}
                API.SetMemory(&H328A8DB0, bytes1)
                API.SetMemory(&H328A8DB4, bytes1)
                Label99.Text = "7"

            ElseIf Label99.Text = "7" Then
                'Normal
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
                Label99.Text = "8"

            ElseIf Label99.Text = "8" Then
                'Normal
                Dim bytes1 As Byte() = New Byte() {&H3F}
                API.SetMemory(&H328A8DB0, bytes1)
                API.SetMemory(&H328A8DB8, bytes1)
                API.SetMemory(&H328A8DB4, bytes1)
                API.SetMemory(&H328A8DBC, bytes1)
                Label99.Text = "1"

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "BLUS41045 EBOOT DEX" Then
            Process.Start("http://download855.mediafire.com/b6z3d66uy2gg/unvkv0h121a9b00/DEX_EBOOT_Dark_Souls_2.BIN")
        ElseIf ComboBox1.Text = "BLUS41045 UPDATE PKG" Then
            Process.Start("http://b0.ww.np.dl.playstation.net/tppkg/np/BLUS41045/BLUS41045_T9/0a5a8fbf345a58b4/UP0700-BLUS41045_00-DARKSOULS2PT0110-A0110-V0100-PE.pkg")
        ElseIf ComboBox1.Text = "--------------------------" Then

        ElseIf ComboBox1.Text = "BLES01959 UPDATE PKG" Then
            Process.Start("http://b0.ww.np.dl.playstation.net/tppkg/np/BLES01959/BLES01959_T9/f42dcf8e342dcbac/EP0700-BLES01959_00-DARKSOULS2PT0110-A0110-V0100-PE.pkg")

        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://vf99.fr/threads/dark-souls-2-basic-tool.177/")
    End Sub
End Class
