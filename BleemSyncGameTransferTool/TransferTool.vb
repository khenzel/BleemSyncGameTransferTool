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
        'GO! button click event handler
        Try
            'check that the user has entered a source and destination path
            If txtDestinationPath.Text.ToString.Length <= 0 Or txtSourcePath.Text.ToString.Length <= 0 Then
                MsgBox("Error: You must select a source + destination path!", MsgBoxStyle.Critical, "No Path Selected Error")
                Exit Sub
            End If

            Dim FileSystem As Object
            Dim HostFolder As String = txtSourcePath.Text.ToString & "\"

            FileSystem = CreateObject("Scripting.FileSystemObject")

            ProcessFolderTransfer(FileSystem.GetFolder(HostFolder))
        Catch ex As Exception
            MsgBox("An exception was encountered in btnProcess_Click: " & ex.Message, MsgBoxStyle.Critical, "Exception Encountered")
        End Try
    End Sub

    Private Sub ProcessFolderTransfer(HostFolder)
        'Process that grabs all game folders and initiates folder copy to the destination path
        Try
            Dim destinationFolder As String = txtDestinationPath.Text.ToString & "\"
            Dim SubFolder
            Dim folderIterator = 1
            Dim arr(2500) As String 'just max this out, empty positions will be ignored later in Len(SubFolder) > 1 test

            For Each SubFolder In HostFolder.SubFolders
                'add all subfolders (game folders) to our array
                arr(folderIterator) = SubFolder.Path
                folderIterator = folderIterator + 1
            Next

            'Sort the array to alphabetize our folder (game list) order
            Array.Sort(arr)

            'notify the user of the process about to be carried out
            Dim result As DialogResult = MessageBox.Show("Found " & folderIterator - 1 & " folders to copy FROM path : " &
                                                         vbCrLf & txtSourcePath.Text.ToString & vbCrLf & "TO PSClassic USB Path: " & vbCrLf &
                                                         destinationFolder & vbCrLf & vbCrLf & "Is this correct? PRESS YES AT YOUR OWN DISCRESSION!" &
                                                         vbCrLf & "Pressing OK will initiate the batch transfer process, plese be patient!", _
                                  "Begin Batch Transfer?", _
                                  MessageBoxButtons.YesNo)

            If (result <> vbYes) Then
                MsgBox("Aborting.", vbExclamation, "User Initiated Abort")
                Exit Sub 'exit if the user decides to abort the transfer
            End If

            folderIterator = 1

            For Each SubFolder In arr
                If Len(SubFolder) > 1 Then
                    'if the subfolder has a name (null positions in the array are ignored), process it
                    Dim objFSO As Object
                    objFSO = CreateObject("Scripting.FileSystemObject")

                    If Dir(destinationFolder & folderIterator & "\GameData", vbDirectory) = "" Then
                        'if the #\GameData folder does not exist, create it and initiate the game copy
                        'if the folder does exist, ignore the copy (skip the copy of the current game folder) and move on
                        MkDir(destinationFolder & folderIterator)
                        MkDir(destinationFolder & folderIterator & "\GameData")

                        objFSO.CopyFolder(SubFolder, destinationFolder & folderIterator & "\GameData")
                    End If

                    'iterate our game folder counter
                    folderIterator = folderIterator + 1
                End If

            Next

            MsgBox("Transfer completed. " & folderIterator - 1 & " games transferred to your USB device.", vbInformation, "Transfer Complete")

        Catch ex As Exception
            MsgBox("An exception was encountered in ProcessFolderTransfer: " & ex.Message, MsgBoxStyle.Critical, "Exception Encountered")
        End Try

    End Sub


End Class
