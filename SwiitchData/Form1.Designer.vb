<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SwitchData = New SwiitchData.LogInThemeContainer()
        Me.LogInRadialProgressBar1 = New SwiitchData.LogInRadialProgressBar()
        Me.paswrd = New System.Windows.Forms.TextBox()
        Me.usrname = New System.Windows.Forms.TextBox()
        Me.host = New System.Windows.Forms.TextBox()
        Me.LogInLabel3 = New SwiitchData.LogInLabel()
        Me.LogInLabel2 = New SwiitchData.LogInLabel()
        Me.LogInLabel1 = New SwiitchData.LogInLabel()
        Me.dcnct = New SwiitchData.LogInButton()
        Me.cnct = New SwiitchData.LogInButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.LogInButton1 = New SwiitchData.LogInButton()
        Me.SwitchData.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SwitchData
        '
        Me.SwitchData.AllowClose = True
        Me.SwitchData.AllowMaximize = False
        Me.SwitchData.AllowMinimize = True
        Me.SwitchData.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SwitchData.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SwitchData.BorderColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SwitchData.CloseChoice = SwiitchData.LogInThemeContainer.__CloseChoice.Form
        Me.SwitchData.ContainerColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.SwitchData.Controls.Add(Me.LogInButton1)
        Me.SwitchData.Controls.Add(Me.LogInRadialProgressBar1)
        Me.SwitchData.Controls.Add(Me.paswrd)
        Me.SwitchData.Controls.Add(Me.usrname)
        Me.SwitchData.Controls.Add(Me.host)
        Me.SwitchData.Controls.Add(Me.LogInLabel3)
        Me.SwitchData.Controls.Add(Me.LogInLabel2)
        Me.SwitchData.Controls.Add(Me.LogInLabel1)
        Me.SwitchData.Controls.Add(Me.dcnct)
        Me.SwitchData.Controls.Add(Me.cnct)
        Me.SwitchData.Controls.Add(Me.PictureBox1)
        Me.SwitchData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SwitchData.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SwitchData.FontSize = 12
        Me.SwitchData.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SwitchData.Location = New System.Drawing.Point(0, 0)
        Me.SwitchData.Movable = True
        Me.SwitchData.Name = "SwitchData"
        Me.SwitchData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SwitchData.ShowIcon = False
        Me.SwitchData.Sizable = False
        Me.SwitchData.Size = New System.Drawing.Size(800, 450)
        Me.SwitchData.SmartBounds = True
        Me.SwitchData.TabIndex = 0
        Me.SwitchData.Text = "SwitchData | Rev 0.1 By @Eawhitehat"
        '
        'LogInRadialProgressBar1
        '
        Me.LogInRadialProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInRadialProgressBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadialProgressBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadialProgressBar1.Location = New System.Drawing.Point(370, 348)
        Me.LogInRadialProgressBar1.Maximum = 100
        Me.LogInRadialProgressBar1.Name = "LogInRadialProgressBar1"
        Me.LogInRadialProgressBar1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LogInRadialProgressBar1.RotationAngle = 255
        Me.LogInRadialProgressBar1.Size = New System.Drawing.Size(78, 78)
        Me.LogInRadialProgressBar1.StartingAngle = 110
        Me.LogInRadialProgressBar1.TabIndex = 13
        Me.LogInRadialProgressBar1.Text = "LogInRadialProgressBar1"
        Me.LogInRadialProgressBar1.Value = 0
        '
        'paswrd
        '
        Me.paswrd.Location = New System.Drawing.Point(342, 306)
        Me.paswrd.Name = "paswrd"
        Me.paswrd.Size = New System.Drawing.Size(220, 20)
        Me.paswrd.TabIndex = 10
        '
        'usrname
        '
        Me.usrname.Location = New System.Drawing.Point(364, 280)
        Me.usrname.Name = "usrname"
        Me.usrname.Size = New System.Drawing.Size(198, 20)
        Me.usrname.TabIndex = 9
        '
        'host
        '
        Me.host.Location = New System.Drawing.Point(311, 254)
        Me.host.Name = "host"
        Me.host.Size = New System.Drawing.Size(251, 20)
        Me.host.TabIndex = 8
        '
        'LogInLabel3
        '
        Me.LogInLabel3.AutoSize = True
        Me.LogInLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.Location = New System.Drawing.Point(253, 308)
        Me.LogInLabel3.Name = "LogInLabel3"
        Me.LogInLabel3.Size = New System.Drawing.Size(83, 15)
        Me.LogInLabel3.TabIndex = 6
        Me.LogInLabel3.Text = "Mot de passe :"
        '
        'LogInLabel2
        '
        Me.LogInLabel2.AutoSize = True
        Me.LogInLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.Location = New System.Drawing.Point(253, 282)
        Me.LogInLabel2.Name = "LogInLabel2"
        Me.LogInLabel2.Size = New System.Drawing.Size(105, 15)
        Me.LogInLabel2.TabIndex = 5
        Me.LogInLabel2.Text = "Nom d'utilisateur :"
        '
        'LogInLabel1
        '
        Me.LogInLabel1.AutoSize = True
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(253, 256)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(52, 15)
        Me.LogInLabel1.TabIndex = 4
        Me.LogInLabel1.Text = "Serveur :"
        '
        'dcnct
        '
        Me.dcnct.BackColor = System.Drawing.Color.Transparent
        Me.dcnct.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.dcnct.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.dcnct.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dcnct.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dcnct.Location = New System.Drawing.Point(454, 363)
        Me.dcnct.Name = "dcnct"
        Me.dcnct.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.dcnct.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dcnct.Size = New System.Drawing.Size(108, 44)
        Me.dcnct.TabIndex = 2
        Me.dcnct.Text = "Se déconnecter"
        '
        'cnct
        '
        Me.cnct.BackColor = System.Drawing.Color.Transparent
        Me.cnct.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.cnct.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cnct.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cnct.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.cnct.Location = New System.Drawing.Point(256, 363)
        Me.cnct.Name = "cnct"
        Me.cnct.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.cnct.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cnct.Size = New System.Drawing.Size(108, 44)
        Me.cnct.TabIndex = 1
        Me.cnct.Text = "Se connecter"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(132, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(570, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer3
        '
        '
        'LogInButton1
        '
        Me.LogInButton1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButton1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButton1.Location = New System.Drawing.Point(342, 212)
        Me.LogInButton1.Name = "LogInButton1"
        Me.LogInButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton1.Size = New System.Drawing.Size(142, 30)
        Me.LogInButton1.TabIndex = 14
        Me.LogInButton1.Text = "Proxy List"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SwitchData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SwitchData.ResumeLayout(False)
        Me.SwitchData.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SwitchData As LogInThemeContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dcnct As LogInButton
    Friend WithEvents cnct As LogInButton
    Friend WithEvents LogInLabel3 As LogInLabel
    Friend WithEvents LogInLabel2 As LogInLabel
    Friend WithEvents LogInLabel1 As LogInLabel
    Friend WithEvents paswrd As TextBox
    Friend WithEvents usrname As TextBox
    Friend WithEvents host As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LogInRadialProgressBar1 As LogInRadialProgressBar
    Friend WithEvents Timer3 As Timer
    Friend WithEvents LogInButton1 As LogInButton
End Class
