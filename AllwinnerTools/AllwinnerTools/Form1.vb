' Application's still feature-incomplete, but it's mostly done anyway.
' I still need to address some issues with the console, for one, and thhat I have a few
' other committments as well.
Public Class Form1
    Private Sub btnADBShell_Click(sender As Object, e As EventArgs) Handles btnADBShell.Click
        If Not System.IO.File.Exists("adb.exe") Then
            MsgBox("ADB.exe appears to be missing. Copy the files to where you launched this tool from, and then try again.")
        Else
            Shell("adb shell", AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
    Private Sub btnCheckDevice_Click(sender As Object, e As EventArgs) Handles btnCheckDevice.Click
        tbOutput.Clear()
        ' code shamelessly taken from stackoverflow.com/questions/8809194/get-the-output-of-a-shell-command-in-vb-net
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("adb.exe")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oStartInfo.Arguments = "devices"
        oProcess.StartInfo = oStartInfo
        oProcess.StartInfo.CreateNoWindow = True
        oProcess.Start()
        ' This is where the console output shit comes in
        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        tbOutput.Text = sOutput
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        odBrowse.Filter = "Android Packages|*.apk|All Files|*.*"
        odSave.Filter = "Android Packages|*.apk|All Files|*.*"
    End Sub
    Private Sub btnOpenAPK_Click(sender As Object, e As EventArgs) Handles btnOpenAPK.Click
        odBrowse.ShowDialog()
        tbInputAPK.Text = odBrowse.FileName
    End Sub
    Private Sub btnPartitions_Click(sender As Object, e As EventArgs) Handles btnPartitions.Click
        tbOutput.Clear()
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("adb.exe")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oStartInfo.Arguments = "shell cat /proc/partitions"
        oProcess.StartInfo = oStartInfo
        oProcess.StartInfo.CreateNoWindow = True
        oProcess.Start()
        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        tbOutput.Text = sOutput
    End Sub
    Private Sub btnReboot_Click(sender As Object, e As EventArgs) Handles btnReboot.Click
        MessageBox.Show("Your device will now restart.")
        Shell("adb shell reboot", AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnMountSystem_Click(sender As Object, e As EventArgs) Handles btnMountSystem.Click
        Dim nandd As String
        nandd = "adb shell mount -o remount,rw -t ext4 /dev/block/" & txtNandd.Text & " " & "/system"
        Shell(nandd, AppWinStyle.NormalFocus)
    End Sub

    Private Sub btnSaveAPK_Click(sender As Object, e As EventArgs) Handles btnSaveAPK.Click
        If rbPlatform.Checked = True Then
            Dim repack As String
            repack = "apktool.bat b" & " " & Chr(34) & tbOutAPKFolder.Text & Chr(34) & " " & "temp.apk"
            Shell(repack, AppWinStyle.NormalFocus, True)
            Shell("java -jar signapk.jar platform.x509.pem platform.pk8 temp.apk tempS.apk", AppWinStyle.NormalFocus, True)
            Shell("zipalign -v 4 tempS.apk " & tbOutAPKFile.Text, AppWinStyle.NormalFocus, True)
            My.Computer.FileSystem.DeleteFile("temp.apk")
            My.Computer.FileSystem.DeleteFile("tempS.apk")
        ElseIf rbTestkey.Checked = True Then
            Dim repack As String
            repack = "apktool.bat b" & " " & Chr(34) & tbOutAPKFolder.Text & Chr(34) & " " & "temp.apk"
            Shell(repack, AppWinStyle.NormalFocus, True)
            Shell("java -jar signapk.jar testkey.x509.pem testkey.pk8 temp.apk tempS.apk", AppWinStyle.NormalFocus, True)
            Shell("zipalign -v 4 tempS.apk " & tbOutAPKFile.Text, AppWinStyle.NormalFocus, True)
            My.Computer.FileSystem.DeleteFile("temp.apk")
            My.Computer.FileSystem.DeleteFile("tempS.apk")
            MessageBox.Show("shit")
        End If
    End Sub
    Private Sub btnFramework_Click(sender As Object, e As EventArgs) Handles btnFramework.Click
        Shell("apktool.bat if framework-res.apk")
    End Sub
    Private Sub btnUnpack_Click(sender As Object, e As EventArgs) Handles btnUnpack.Click
        Dim pakNonSmali As String
        pakNonSmali = "apktool.bat d" & " " & "-s" & " " & Chr(34) & tbInputAPK.Text & Chr(34)
        Shell(pakNonSmali)
    End Sub
    Private Sub btnUnpackSmali_Click(sender As Object, e As EventArgs) Handles btnUnpackSmali.Click
        Dim inputPackage2 As String
        inputPackage2 = " " & "d" & " " & "-f" & " " & Chr(34) & tbInputAPK.Text & Chr(34)
        Shell("apktool.bat" & inputPackage2, AppWinStyle.NormalFocus)
    End Sub
    Private Sub btnBrowseAPKfolder_Click(sender As Object, e As EventArgs) Handles btnBrowseAPKfolder.Click
        odFolder.ShowDialog()
        tbOutAPKFolder.Text = odFolder.SelectedPath
    End Sub
    Private Sub btnSaveLocation_Click(sender As Object, e As EventArgs) Handles btnSaveLocation.Click
        odSave.ShowDialog()
        tbOutAPKFile.Text = odSave.FileName
    End Sub

    Private Sub btnInstallAPK_Click(sender As Object, e As EventArgs) Handles btnInstallAPK.Click
        Dim APKname As String
        APKname = Chr(34) & txtAPKinstall.Text & Chr(34)
        Shell("adb install " & APKname, AppWinStyle.NormalFocus)
    End Sub
End Class
