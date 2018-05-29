Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form2

    Private Sub LogInButton4_Click(sender As Object, e As EventArgs) Handles LogInButton4.Click

        Dim webAddress As String = "https://www.vpnbook.com/"
        Process.Start(webAddress)

    End Sub

    Private Sub LogInButton2_Click(sender As Object, e As EventArgs) Handles LogInButton2.Click

        Dim webAddress As String = "http://freel2tpvpn.com/"
        Process.Start(webAddress)

    End Sub

    Private Sub LogInButton3_Click(sender As Object, e As EventArgs) Handles LogInButton3.Click

        Dim webAddress As String = "https://freevpn.me/accounts/"
        Process.Start(webAddress)

    End Sub

    Private Sub LogInButton1_Click(sender As Object, e As EventArgs) Handles LogInButton1.Click

        Dim webAddress As String = "http://www.freevpnaccess.com/"
        Process.Start(webAddress)

    End Sub
End Class
