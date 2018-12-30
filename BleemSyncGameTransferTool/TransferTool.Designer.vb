<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferTool
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferTool))
        Me.lblSourcePath = New System.Windows.Forms.Label()
        Me.txtSourcePath = New System.Windows.Forms.TextBox()
        Me.btnSourcePath = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnDestinationPath = New System.Windows.Forms.Button()
        Me.txtDestinationPath = New System.Windows.Forms.TextBox()
        Me.lblDestinationPath = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.lblDisclaimer1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSourcePath
        '
        Me.lblSourcePath.AutoSize = True
        Me.lblSourcePath.Location = New System.Drawing.Point(12, 137)
        Me.lblSourcePath.Name = "lblSourcePath"
        Me.lblSourcePath.Size = New System.Drawing.Size(282, 13)
        Me.lblSourcePath.TabIndex = 0
        Me.lblSourcePath.Text = "Source Path (Your local PC path with all the game folders):"
        '
        'txtSourcePath
        '
        Me.txtSourcePath.Location = New System.Drawing.Point(15, 154)
        Me.txtSourcePath.Name = "txtSourcePath"
        Me.txtSourcePath.Size = New System.Drawing.Size(423, 20)
        Me.txtSourcePath.TabIndex = 1
        '
        'btnSourcePath
        '
        Me.btnSourcePath.Location = New System.Drawing.Point(444, 154)
        Me.btnSourcePath.Name = "btnSourcePath"
        Me.btnSourcePath.Size = New System.Drawing.Size(75, 23)
        Me.btnSourcePath.TabIndex = 2
        Me.btnSourcePath.Text = "Browse"
        Me.btnSourcePath.UseVisualStyleBackColor = True
        '
        'btnDestinationPath
        '
        Me.btnDestinationPath.Location = New System.Drawing.Point(443, 194)
        Me.btnDestinationPath.Name = "btnDestinationPath"
        Me.btnDestinationPath.Size = New System.Drawing.Size(75, 23)
        Me.btnDestinationPath.TabIndex = 5
        Me.btnDestinationPath.Text = "Browse"
        Me.btnDestinationPath.UseVisualStyleBackColor = True
        '
        'txtDestinationPath
        '
        Me.txtDestinationPath.Location = New System.Drawing.Point(14, 194)
        Me.txtDestinationPath.Name = "txtDestinationPath"
        Me.txtDestinationPath.Size = New System.Drawing.Size(423, 20)
        Me.txtDestinationPath.TabIndex = 4
        '
        'lblDestinationPath
        '
        Me.lblDestinationPath.AutoSize = True
        Me.lblDestinationPath.Location = New System.Drawing.Point(11, 177)
        Me.lblDestinationPath.Name = "lblDestinationPath"
        Me.lblDestinationPath.Size = New System.Drawing.Size(295, 13)
        Me.lblDestinationPath.TabIndex = 3
        Me.lblDestinationPath.Text = "Destination Path (USB Drive with empty games folder in root):"
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(445, 228)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 6
        Me.btnProcess.Text = "&GO!"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'lblDisclaimer1
        '
        Me.lblDisclaimer1.AutoSize = True
        Me.lblDisclaimer1.Location = New System.Drawing.Point(11, 9)
        Me.lblDisclaimer1.Name = "lblDisclaimer1"
        Me.lblDisclaimer1.Size = New System.Drawing.Size(478, 13)
        Me.lblDisclaimer1.TabIndex = 7
        Me.lblDisclaimer1.Text = "DISCLAIMER: Not responsible for any lost/replaced files or corruption. Use this t" & _
    "ool at your own risk!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(558, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usage: Select the SOURCE folder containg the path of your games, and the DESTINAT" & _
    "ION path on your USB drive."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(335, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "The Source path must contain all game folders, each folder containg :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(426, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Game.ini, pcsx.cfg, <DISC SERIAL#>.bin, <DISC SERIAL#>.cue, <DISC SERIAL#>.png"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(333, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Multiple bin images are not allowed! no sub-folders should be present!"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(429, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "The destination path will be on your USB drive (See youtube for how to set up ble" & _
    "emsync)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "I.E. L:\Games"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(236, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Click GO! to execute. This will begin the transfer."
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(362, 228)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(447, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "I.E. L:\Games"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(424, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "<Note: If numbered folders already exist in your destination, that number will be" & _
    " skipped!>"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(293, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Suggested to start with a clear games folder for a full re-build!"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 228)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(318, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "This is an un-official app not endorsed by the BleemSync creators."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 246)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Use at your own risk!"
        '
        'TransferTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 259)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDisclaimer1)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.btnDestinationPath)
        Me.Controls.Add(Me.txtDestinationPath)
        Me.Controls.Add(Me.lblDestinationPath)
        Me.Controls.Add(Me.btnSourcePath)
        Me.Controls.Add(Me.txtSourcePath)
        Me.Controls.Add(Me.lblSourcePath)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TransferTool"
        Me.Text = "BleemSync Game Transfer Tool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSourcePath As System.Windows.Forms.Label
    Friend WithEvents txtSourcePath As System.Windows.Forms.TextBox
    Friend WithEvents btnSourcePath As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnDestinationPath As System.Windows.Forms.Button
    Friend WithEvents txtDestinationPath As System.Windows.Forms.TextBox
    Friend WithEvents lblDestinationPath As System.Windows.Forms.Label
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents lblDisclaimer1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
