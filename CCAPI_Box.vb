
Imports PS3Lib
Imports PS3Lib.NET
Imports System.Runtime.InteropServices

Public Class CCAPI_Box

  Dim Pos As Point
    Private Sub SimplaTheme1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SimplaTheme1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub


    ' Public Shared API As New PS3API()
    '   Private CCAPI As New CCAPI()

    Private API As New PS3API()
    Private rand As New Random()

    Private Consoles As List(Of PS3Lib.CCAPI.ConsoleInfo)
    Private PS3 As New PS3API(SelectAPI.ControlConsole)


    Private Sub UpdateConsoles()
        Consoles = PS3.CCAPI.GetConsoleList()
        For Each Console As PS3Lib.CCAPI.ConsoleInfo In Consoles
            ListBox2.Items.Add([String].Format("{0} : {1}", Console.Name, Console.Ip))
        Next
    End Sub

    Private Sub CCAPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateConsoles()
        If ListBox2.Items.Count > 0 Then
            ListBox2.SelectedItem = 0
        Else
            MessageBox.Show("None console to connect :/", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        ListBox2.Items.Clear()

    End Sub

    Private Sub SimplaButton1_Click(sender As Object, e As EventArgs) Handles SimplaButton1.Click

        Label2.Text = "Select to // " & ListBox2.Text

        Try
            Dim Console As PS3Lib.CCAPI.ConsoleInfo = Consoles.ElementAt(ListBox2.SelectedIndex)

            If PS3.ConnectTarget(Console.Ip) Then
                API.CCAPI.AttachProcess()
                MessageBox.Show("Merci de utiliser mon tool !!!" + vbNewLine + "Vous-être connecter en tant que : " + API.GetConsoleName() + "." + vbNewLine + "Trouver moi sur {[ www.VF99.fr ]}", "Connexion de la PS3", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Form1.SimplaButton46.Text = "Disconnect : CEX"
                Form1.SimplaButton2.Enabled = True
                Form1.SimplaButton1.Enabled = False
                Me.Close()
            Else

                MessageBox.Show("None console to connect :/" + API.GetConsoleName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("None console to connect :/" + API.GetConsoleName, "Error X2", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Label2.Text = "Select to */ " & ListBox2.Text
    End Sub
End Class