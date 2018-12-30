Public Class TransferTool

    Private Sub btnSourcePath_Click(sender As Object, e As EventArgs) Handles btnSourcePath.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtSourcePath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub btnDestinationPath_Click(sender As Object, e As EventArgs) Handles btnDestinationPath.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtDestinationPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim FileSystem As Object
        Dim HostFolder As String

        If txtDestinationPath.Text.ToString.Length <= 0 Or txtSourcePath.Text.ToString.Length <= 0 Then
            MsgBox("Error: You must select a source + destination path!", MsgBoxStyle.Critical, "No Path Selected Error")
            Exit Sub

        End If

        HostFolder = txtSourcePath.Text.ToString & "\"

        FileSystem = CreateObject("Scripting.FileSystemObject")

        DoFolder(FileSystem.GetFolder(HostFolder))
    End Sub

    Private Sub DoFolder(Folder)
        Dim destinationFolder As String = txtDestinationPath.Text.ToString & "\"
        Dim SubFolder
        Dim folderIterator
        folderIterator = 1
        Dim arr(2500) As String 'just max this out, array will be trimmed later in the copy.

        For Each SubFolder In Folder.SubFolders
            arr(folderIterator) = SubFolder.Path
            folderIterator = folderIterator + 1
        Next

        Array.Sort(arr)

        Dim result As DialogResult = MessageBox.Show("Found " & folderIterator - 1 & " folders to copy FROM path : " & vbCrLf & txtSourcePath.Text.ToString & vbCrLf & "TO PSClassic USB Path: " & vbCrLf &
                                                     destinationFolder & vbCrLf & vbCrLf & "Is this correct? PRESS YES AT YOUR OWN DISCRESSION!" & vbCrLf & "Pressing OK will initiate the batch transfer process, plese be patient!", _
                              "Begin Batch Transfer?", _
                              MessageBoxButtons.YesNo)

        If (result <> vbYes) Then
            MsgBox("Aborting.", vbExclamation, "User Initiated Abort")
            Exit Sub

        End If

        folderIterator = 1
        For Each SubFolder In arr
            If Len(SubFolder) > 1 Then
                Dim objFSO As Object
                objFSO = CreateObject("Scripting.FileSystemObject")
                If Dir(destinationFolder & folderIterator & "\GameData", vbDirectory) = "" Then
                    MkDir(destinationFolder & folderIterator)
                    MkDir(destinationFolder & folderIterator & "\GameData")

                    objFSO.CopyFolder(SubFolder, destinationFolder & folderIterator & "\GameData")
                End If
                folderIterator = folderIterator + 1
            End If

        Next

        MsgBox("Transfer completed. " & folderIterator - 1 & " games transferred to your USB device.", vbInformation, "Transfer Complete")



    End Sub


End Class
