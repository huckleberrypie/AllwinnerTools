<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tabAWfunctions = New System.Windows.Forms.TabControl()
        Me.tbADBshell = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPartitions = New System.Windows.Forms.Button()
        Me.btnLaunchDumpBAT = New System.Windows.Forms.Button()
        Me.nandData = New System.Windows.Forms.TextBox()
        Me.txtNandd = New System.Windows.Forms.TextBox()
        Me.btnMountData = New System.Windows.Forms.Button()
        Me.btnPull = New System.Windows.Forms.Button()
        Me.txtPull = New System.Windows.Forms.TextBox()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.txtPush = New System.Windows.Forms.TextBox()
        Me.txtAPKinstall = New System.Windows.Forms.TextBox()
        Me.btnInstallAPK = New System.Windows.Forms.Button()
        Me.btnMountSystem = New System.Windows.Forms.Button()
        Me.btnReboot = New System.Windows.Forms.Button()
        Me.tbOutput = New System.Windows.Forms.TextBox()
        Me.btnCheckDevice = New System.Windows.Forms.Button()
        Me.btnADBShell = New System.Windows.Forms.Button()
        Me.tbAPKs = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSaveLocation = New System.Windows.Forms.Button()
        Me.tbOutAPKFile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbTestkey = New System.Windows.Forms.RadioButton()
        Me.rbPlatform = New System.Windows.Forms.RadioButton()
        Me.btnSaveAPK = New System.Windows.Forms.Button()
        Me.btnBrowseAPKfolder = New System.Windows.Forms.Button()
        Me.tbOutAPKFolder = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFramework = New System.Windows.Forms.Button()
        Me.btnOpenAPK = New System.Windows.Forms.Button()
        Me.tbInputAPK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUnpackSmali = New System.Windows.Forms.Button()
        Me.btnUnpack = New System.Windows.Forms.Button()
        Me.tbFex = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnFexBrowse = New System.Windows.Forms.Button()
        Me.txtFex = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBinBrowse = New System.Windows.Forms.Button()
        Me.txtBin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.odBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.odFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.odSave = New System.Windows.Forms.SaveFileDialog()
        Me.tabAWfunctions.SuspendLayout()
        Me.tbADBshell.SuspendLayout()
        Me.tbAPKs.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbFex.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabAWfunctions
        '
        Me.tabAWfunctions.Controls.Add(Me.tbADBshell)
        Me.tabAWfunctions.Controls.Add(Me.tbAPKs)
        Me.tabAWfunctions.Controls.Add(Me.tbFex)
        Me.tabAWfunctions.Location = New System.Drawing.Point(12, 12)
        Me.tabAWfunctions.Name = "tabAWfunctions"
        Me.tabAWfunctions.SelectedIndex = 0
        Me.tabAWfunctions.Size = New System.Drawing.Size(524, 474)
        Me.tabAWfunctions.TabIndex = 0
        '
        'tbADBshell
        '
        Me.tbADBshell.Controls.Add(Me.Label3)
        Me.tbADBshell.Controls.Add(Me.Label2)
        Me.tbADBshell.Controls.Add(Me.btnPartitions)
        Me.tbADBshell.Controls.Add(Me.btnLaunchDumpBAT)
        Me.tbADBshell.Controls.Add(Me.nandData)
        Me.tbADBshell.Controls.Add(Me.txtNandd)
        Me.tbADBshell.Controls.Add(Me.btnMountData)
        Me.tbADBshell.Controls.Add(Me.btnPull)
        Me.tbADBshell.Controls.Add(Me.txtPull)
        Me.tbADBshell.Controls.Add(Me.btnPush)
        Me.tbADBshell.Controls.Add(Me.txtPush)
        Me.tbADBshell.Controls.Add(Me.txtAPKinstall)
        Me.tbADBshell.Controls.Add(Me.btnInstallAPK)
        Me.tbADBshell.Controls.Add(Me.btnMountSystem)
        Me.tbADBshell.Controls.Add(Me.btnReboot)
        Me.tbADBshell.Controls.Add(Me.tbOutput)
        Me.tbADBshell.Controls.Add(Me.btnCheckDevice)
        Me.tbADBshell.Controls.Add(Me.btnADBShell)
        Me.tbADBshell.Location = New System.Drawing.Point(4, 22)
        Me.tbADBshell.Name = "tbADBshell"
        Me.tbADBshell.Size = New System.Drawing.Size(516, 448)
        Me.tbADBshell.TabIndex = 2
        Me.tbADBshell.Text = "ADB Stuff"
        Me.tbADBshell.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Data location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "System location:"
        '
        'btnPartitions
        '
        Me.btnPartitions.Location = New System.Drawing.Point(399, 115)
        Me.btnPartitions.Name = "btnPartitions"
        Me.btnPartitions.Size = New System.Drawing.Size(100, 23)
        Me.btnPartitions.TabIndex = 15
        Me.btnPartitions.Text = "Partition Info"
        Me.btnPartitions.UseVisualStyleBackColor = True
        '
        'btnLaunchDumpBAT
        '
        Me.btnLaunchDumpBAT.Location = New System.Drawing.Point(275, 115)
        Me.btnLaunchDumpBAT.Name = "btnLaunchDumpBAT"
        Me.btnLaunchDumpBAT.Size = New System.Drawing.Size(118, 23)
        Me.btnLaunchDumpBAT.TabIndex = 14
        Me.btnLaunchDumpBAT.Text = "Dump Firmware"
        Me.btnLaunchDumpBAT.UseVisualStyleBackColor = True
        '
        'nandData
        '
        Me.nandData.Location = New System.Drawing.Point(104, 185)
        Me.nandData.Name = "nandData"
        Me.nandData.Size = New System.Drawing.Size(395, 21)
        Me.nandData.TabIndex = 13
        '
        'txtNandd
        '
        Me.txtNandd.Location = New System.Drawing.Point(104, 149)
        Me.txtNandd.Name = "txtNandd"
        Me.txtNandd.Size = New System.Drawing.Size(395, 21)
        Me.txtNandd.TabIndex = 12
        '
        'btnMountData
        '
        Me.btnMountData.Location = New System.Drawing.Point(135, 115)
        Me.btnMountData.Name = "btnMountData"
        Me.btnMountData.Size = New System.Drawing.Size(134, 23)
        Me.btnMountData.TabIndex = 11
        Me.btnMountData.Text = "Mount /data"
        Me.btnMountData.UseVisualStyleBackColor = True
        '
        'btnPull
        '
        Me.btnPull.Location = New System.Drawing.Point(400, 79)
        Me.btnPull.Name = "btnPull"
        Me.btnPull.Size = New System.Drawing.Size(99, 23)
        Me.btnPull.TabIndex = 10
        Me.btnPull.Text = "Pull from Device"
        Me.btnPull.UseVisualStyleBackColor = True
        '
        'txtPull
        '
        Me.txtPull.Location = New System.Drawing.Point(159, 81)
        Me.txtPull.Name = "txtPull"
        Me.txtPull.Size = New System.Drawing.Size(235, 21)
        Me.txtPull.TabIndex = 9
        '
        'btnPush
        '
        Me.btnPush.Location = New System.Drawing.Point(400, 50)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(99, 23)
        Me.btnPush.TabIndex = 8
        Me.btnPush.Text = "Push to Device"
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'txtPush
        '
        Me.txtPush.Location = New System.Drawing.Point(159, 51)
        Me.txtPush.Name = "txtPush"
        Me.txtPush.Size = New System.Drawing.Size(234, 21)
        Me.txtPush.TabIndex = 7
        '
        'txtAPKinstall
        '
        Me.txtAPKinstall.Location = New System.Drawing.Point(159, 23)
        Me.txtAPKinstall.Name = "txtAPKinstall"
        Me.txtAPKinstall.Size = New System.Drawing.Size(234, 21)
        Me.txtAPKinstall.TabIndex = 6
        '
        'btnInstallAPK
        '
        Me.btnInstallAPK.Location = New System.Drawing.Point(399, 21)
        Me.btnInstallAPK.Name = "btnInstallAPK"
        Me.btnInstallAPK.Size = New System.Drawing.Size(100, 23)
        Me.btnInstallAPK.TabIndex = 5
        Me.btnInstallAPK.Text = "Install APK"
        Me.btnInstallAPK.UseVisualStyleBackColor = True
        '
        'btnMountSystem
        '
        Me.btnMountSystem.Location = New System.Drawing.Point(15, 115)
        Me.btnMountSystem.Name = "btnMountSystem"
        Me.btnMountSystem.Size = New System.Drawing.Size(114, 23)
        Me.btnMountSystem.TabIndex = 4
        Me.btnMountSystem.Text = "Mount /system"
        Me.btnMountSystem.UseVisualStyleBackColor = True
        '
        'btnReboot
        '
        Me.btnReboot.Location = New System.Drawing.Point(15, 79)
        Me.btnReboot.Name = "btnReboot"
        Me.btnReboot.Size = New System.Drawing.Size(129, 23)
        Me.btnReboot.TabIndex = 3
        Me.btnReboot.Text = "Reboot Device"
        Me.btnReboot.UseVisualStyleBackColor = True
        '
        'tbOutput
        '
        Me.tbOutput.BackColor = System.Drawing.Color.Black
        Me.tbOutput.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOutput.ForeColor = System.Drawing.Color.Chartreuse
        Me.tbOutput.Location = New System.Drawing.Point(15, 219)
        Me.tbOutput.MaxLength = 1073741824
        Me.tbOutput.Multiline = True
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.ReadOnly = True
        Me.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbOutput.Size = New System.Drawing.Size(484, 209)
        Me.tbOutput.TabIndex = 2
        '
        'btnCheckDevice
        '
        Me.btnCheckDevice.Location = New System.Drawing.Point(15, 50)
        Me.btnCheckDevice.Name = "btnCheckDevice"
        Me.btnCheckDevice.Size = New System.Drawing.Size(129, 23)
        Me.btnCheckDevice.TabIndex = 1
        Me.btnCheckDevice.Text = "Check for devices"
        Me.btnCheckDevice.UseVisualStyleBackColor = True
        '
        'btnADBShell
        '
        Me.btnADBShell.Location = New System.Drawing.Point(15, 21)
        Me.btnADBShell.Name = "btnADBShell"
        Me.btnADBShell.Size = New System.Drawing.Size(129, 23)
        Me.btnADBShell.TabIndex = 0
        Me.btnADBShell.Text = "Launch ADB Shell"
        Me.btnADBShell.UseVisualStyleBackColor = True
        '
        'tbAPKs
        '
        Me.tbAPKs.Controls.Add(Me.GroupBox2)
        Me.tbAPKs.Controls.Add(Me.GroupBox1)
        Me.tbAPKs.Location = New System.Drawing.Point(4, 22)
        Me.tbAPKs.Name = "tbAPKs"
        Me.tbAPKs.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAPKs.Size = New System.Drawing.Size(516, 448)
        Me.tbAPKs.TabIndex = 1
        Me.tbAPKs.Text = "APK Editing"
        Me.tbAPKs.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnSaveLocation)
        Me.GroupBox2.Controls.Add(Me.tbOutAPKFile)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.rbTestkey)
        Me.GroupBox2.Controls.Add(Me.rbPlatform)
        Me.GroupBox2.Controls.Add(Me.btnSaveAPK)
        Me.GroupBox2.Controls.Add(Me.btnBrowseAPKfolder)
        Me.GroupBox2.Controls.Add(Me.tbOutAPKFolder)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 180)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Repack APK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Decompiled APK source folder:"
        '
        'btnSaveLocation
        '
        Me.btnSaveLocation.Location = New System.Drawing.Point(365, 100)
        Me.btnSaveLocation.Name = "btnSaveLocation"
        Me.btnSaveLocation.Size = New System.Drawing.Size(101, 23)
        Me.btnSaveLocation.TabIndex = 7
        Me.btnSaveLocation.Text = "Browse..."
        Me.btnSaveLocation.UseVisualStyleBackColor = True
        '
        'tbOutAPKFile
        '
        Me.tbOutAPKFile.Location = New System.Drawing.Point(18, 100)
        Me.tbOutAPKFile.Name = "tbOutAPKFile"
        Me.tbOutAPKFile.Size = New System.Drawing.Size(340, 21)
        Me.tbOutAPKFile.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Output APK:"
        '
        'rbTestkey
        '
        Me.rbTestkey.AutoSize = True
        Me.rbTestkey.Location = New System.Drawing.Point(248, 140)
        Me.rbTestkey.Name = "rbTestkey"
        Me.rbTestkey.Size = New System.Drawing.Size(131, 17)
        Me.rbTestkey.TabIndex = 4
        Me.rbTestkey.Text = "Sign with Testkey cert"
        Me.rbTestkey.UseVisualStyleBackColor = True
        '
        'rbPlatform
        '
        Me.rbPlatform.AutoSize = True
        Me.rbPlatform.Checked = True
        Me.rbPlatform.Location = New System.Drawing.Point(108, 140)
        Me.rbPlatform.Name = "rbPlatform"
        Me.rbPlatform.Size = New System.Drawing.Size(133, 17)
        Me.rbPlatform.TabIndex = 3
        Me.rbPlatform.TabStop = True
        Me.rbPlatform.Text = "Sign with Platform cert"
        Me.rbPlatform.UseVisualStyleBackColor = True
        '
        'btnSaveAPK
        '
        Me.btnSaveAPK.Location = New System.Drawing.Point(18, 137)
        Me.btnSaveAPK.Name = "btnSaveAPK"
        Me.btnSaveAPK.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveAPK.TabIndex = 2
        Me.btnSaveAPK.Text = "Save APK"
        Me.btnSaveAPK.UseVisualStyleBackColor = True
        '
        'btnBrowseAPKfolder
        '
        Me.btnBrowseAPKfolder.Location = New System.Drawing.Point(365, 48)
        Me.btnBrowseAPKfolder.Name = "btnBrowseAPKfolder"
        Me.btnBrowseAPKfolder.Size = New System.Drawing.Size(101, 23)
        Me.btnBrowseAPKfolder.TabIndex = 1
        Me.btnBrowseAPKfolder.Text = "Browse..."
        Me.btnBrowseAPKfolder.UseVisualStyleBackColor = True
        '
        'tbOutAPKFolder
        '
        Me.tbOutAPKFolder.Location = New System.Drawing.Point(18, 48)
        Me.tbOutAPKFolder.Name = "tbOutAPKFolder"
        Me.tbOutAPKFolder.Size = New System.Drawing.Size(340, 21)
        Me.tbOutAPKFolder.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFramework)
        Me.GroupBox1.Controls.Add(Me.btnOpenAPK)
        Me.GroupBox1.Controls.Add(Me.tbInputAPK)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnUnpackSmali)
        Me.GroupBox1.Controls.Add(Me.btnUnpack)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unpack APK"
        '
        'btnFramework
        '
        Me.btnFramework.Location = New System.Drawing.Point(158, 74)
        Me.btnFramework.Name = "btnFramework"
        Me.btnFramework.Size = New System.Drawing.Size(119, 23)
        Me.btnFramework.TabIndex = 6
        Me.btnFramework.Text = "Load framework-res"
        Me.btnFramework.UseVisualStyleBackColor = True
        '
        'btnOpenAPK
        '
        Me.btnOpenAPK.Location = New System.Drawing.Point(365, 41)
        Me.btnOpenAPK.Name = "btnOpenAPK"
        Me.btnOpenAPK.Size = New System.Drawing.Size(101, 23)
        Me.btnOpenAPK.TabIndex = 5
        Me.btnOpenAPK.Text = "Browse..."
        Me.btnOpenAPK.UseVisualStyleBackColor = True
        '
        'tbInputAPK
        '
        Me.tbInputAPK.Location = New System.Drawing.Point(18, 41)
        Me.tbInputAPK.Name = "tbInputAPK"
        Me.tbInputAPK.Size = New System.Drawing.Size(340, 21)
        Me.tbInputAPK.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select an APK to be decompiled:"
        '
        'btnUnpackSmali
        '
        Me.btnUnpackSmali.Location = New System.Drawing.Point(364, 74)
        Me.btnUnpackSmali.Name = "btnUnpackSmali"
        Me.btnUnpackSmali.Size = New System.Drawing.Size(102, 23)
        Me.btnUnpackSmali.TabIndex = 2
        Me.btnUnpackSmali.Text = "Unpack with Smali"
        Me.btnUnpackSmali.UseVisualStyleBackColor = True
        '
        'btnUnpack
        '
        Me.btnUnpack.Location = New System.Drawing.Point(283, 74)
        Me.btnUnpack.Name = "btnUnpack"
        Me.btnUnpack.Size = New System.Drawing.Size(75, 23)
        Me.btnUnpack.TabIndex = 1
        Me.btnUnpack.Text = "Unpack"
        Me.btnUnpack.UseVisualStyleBackColor = True
        '
        'tbFex
        '
        Me.tbFex.Controls.Add(Me.GroupBox4)
        Me.tbFex.Controls.Add(Me.GroupBox3)
        Me.tbFex.Location = New System.Drawing.Point(4, 22)
        Me.tbFex.Name = "tbFex"
        Me.tbFex.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFex.Size = New System.Drawing.Size(516, 448)
        Me.tbFex.TabIndex = 0
        Me.tbFex.Text = "BIN/FEX Conversion"
        Me.tbFex.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnFexBrowse)
        Me.GroupBox4.Controls.Add(Me.txtFex)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 151)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(492, 127)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "FEX > BIN"
        '
        'btnFexBrowse
        '
        Me.btnFexBrowse.Location = New System.Drawing.Point(370, 62)
        Me.btnFexBrowse.Name = "btnFexBrowse"
        Me.btnFexBrowse.Size = New System.Drawing.Size(101, 23)
        Me.btnFexBrowse.TabIndex = 11
        Me.btnFexBrowse.Text = "Browse..."
        Me.btnFexBrowse.UseVisualStyleBackColor = True
        '
        'txtFex
        '
        Me.txtFex.Location = New System.Drawing.Point(23, 62)
        Me.txtFex.Name = "txtFex"
        Me.txtFex.Size = New System.Drawing.Size(340, 21)
        Me.txtFex.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(247, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Select a .fex to be converted to an Allwinner .bin:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBinBrowse)
        Me.GroupBox3.Controls.Add(Me.txtBin)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(492, 133)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BIN > FEX"
        '
        'btnBinBrowse
        '
        Me.btnBinBrowse.Location = New System.Drawing.Point(370, 52)
        Me.btnBinBrowse.Name = "btnBinBrowse"
        Me.btnBinBrowse.Size = New System.Drawing.Size(101, 23)
        Me.btnBinBrowse.TabIndex = 8
        Me.btnBinBrowse.Text = "Browse..."
        Me.btnBinBrowse.UseVisualStyleBackColor = True
        '
        'txtBin
        '
        Me.txtBin.Location = New System.Drawing.Point(23, 52)
        Me.txtBin.Name = "txtBin"
        Me.txtBin.Size = New System.Drawing.Size(340, 21)
        Me.txtBin.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Select a script.bin file to be converted to .fex:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(461, 492)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'odBrowse
        '
        Me.odBrowse.DefaultExt = "apk"
        Me.odBrowse.Title = "Open APK"
        '
        'odSave
        '
        Me.odSave.Title = "Save Rebuilt APK"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 529)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tabAWfunctions)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Allwinner A31 Tools v0.1"
        Me.tabAWfunctions.ResumeLayout(False)
        Me.tbADBshell.ResumeLayout(False)
        Me.tbADBshell.PerformLayout()
        Me.tbAPKs.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbFex.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabAWfunctions As System.Windows.Forms.TabControl
    Friend WithEvents tbFex As System.Windows.Forms.TabPage
    Friend WithEvents tbAPKs As System.Windows.Forms.TabPage
    Friend WithEvents tbADBshell As System.Windows.Forms.TabPage
    Friend WithEvents btnADBShell As System.Windows.Forms.Button
    Friend WithEvents btnCheckDevice As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents tbOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnMountSystem As System.Windows.Forms.Button
    Friend WithEvents btnReboot As System.Windows.Forms.Button
    Friend WithEvents txtAPKinstall As System.Windows.Forms.TextBox
    Friend WithEvents btnInstallAPK As System.Windows.Forms.Button
    Friend WithEvents btnPush As System.Windows.Forms.Button
    Friend WithEvents txtPush As System.Windows.Forms.TextBox
    Friend WithEvents btnPull As System.Windows.Forms.Button
    Friend WithEvents txtPull As System.Windows.Forms.TextBox
    Friend WithEvents btnMountData As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOpenAPK As System.Windows.Forms.Button
    Friend WithEvents tbInputAPK As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUnpackSmali As System.Windows.Forms.Button
    Friend WithEvents btnUnpack As System.Windows.Forms.Button
    Friend WithEvents odBrowse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnBrowseAPKfolder As System.Windows.Forms.Button
    Friend WithEvents tbOutAPKFolder As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveAPK As System.Windows.Forms.Button
    Friend WithEvents rbTestkey As System.Windows.Forms.RadioButton
    Friend WithEvents rbPlatform As System.Windows.Forms.RadioButton
    Friend WithEvents nandData As System.Windows.Forms.TextBox
    Friend WithEvents txtNandd As System.Windows.Forms.TextBox
    Friend WithEvents btnLaunchDumpBAT As System.Windows.Forms.Button
    Friend WithEvents btnPartitions As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFramework As System.Windows.Forms.Button
    Friend WithEvents odFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents tbOutAPKFile As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSaveLocation As System.Windows.Forms.Button
    Friend WithEvents odSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFexBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFex As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnBinBrowse As System.Windows.Forms.Button
    Friend WithEvents txtBin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
