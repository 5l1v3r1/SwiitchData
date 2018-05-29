Public Class Form1


    Private Sub LogInButton1_Click(sender As Object, e As EventArgs) Handles cnct.Click
        Timer3.Start()
        If Not IO.Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector") Then

            IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector")


        End If

        If host.Text = String.Empty Or usrname.Text = String.Empty Or paswrd.Text = String.Empty Then
            MsgBox("Tous les champs sont requis", MsgBoxStyle.Exclamation, "Champs vides")
            Timer3.Stop()
            Me.LogInRadialProgressBar1.Value = 0
            Exit Sub
        End If

        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.pbk"), "[VPN]" & vbNewLine & "MEDIA=rastapi" & vbNewLine & "Port=VPN2-0" & vbNewLine & "Device=WAN Miniport (IKEv2)" & vbNewLine & "DEVICE=vpn" & vbNewLine & "PhoneNumber=" & host.Text)
        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"), "rasdial ""VPN"" " & usrname.Text & " " & paswrd.Text & " /phonebook:" & """" & System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.pbk" & """")


        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal

        connect.Start()
        connect.WaitForExit()
        cnct.Enabled = False
        dcnct.Enabled = True
    End Sub

    Private Sub host_TextChanged(sender As Object, e As EventArgs) Handles host.TextChanged

    End Sub

    Private Sub usrname_TextChanged(sender As Object, e As EventArgs) Handles usrname.TextChanged

    End Sub

    Private Sub paswrd_TextChanged(sender As Object, e As EventArgs) Handles paswrd.TextChanged

    End Sub

    Private Sub dcnct_Click(sender As Object, e As EventArgs) Handles dcnct.Click
        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"), "rasdial/d")
        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal

        connect.Start()
        connect.WaitForExit()
        cnct.Enabled = True
        dcnct.Enabled = False
        MsgBox("Déconnecter avec succès !")
        Timer3.Stop()
        Me.LogInRadialProgressBar1.Value = 0
    End Sub

    Private Sub LogInRadialProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogInProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        LogInRadialProgressBar1.Increment(1)
        If LogInRadialProgressBar1.Value = LogInRadialProgressBar1.Maximum Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub SwitchData_Click(sender As Object, e As EventArgs) Handles SwitchData.Click

    End Sub

    Private Sub LogInButton1_Click_1(sender As Object, e As EventArgs) Handles LogInButton1.Click

        Dim SecondForm As New Form2


        SecondForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
