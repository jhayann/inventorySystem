Imports System.IO
Imports System.Net
Public Class backup
    Dim textBoxes() As TextBox
    Private Sub btnSAve_Click(sender As Object, e As EventArgs) Handles btnSAve.Click
        Try

            Dim path As String = txtPath.Text
            Dim usr, pss, addr, fileName As String
            usr = txtUser.Text
            pss = txtPass.Text
            fileName = "backup-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".mdb"
            addr = txtaddress.Text + fileName
            txtFilename.Text = fileName
            My.Computer.Network.UploadFile(path, addr, usr, pss, True, 100)
            MessageBox.Show("DATABASE BACK UP TO SERVER SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openDialog As New OpenFileDialog
        'openDialog.Filter = "Microsoft Access Database (*.mdb)|*.mdb"
        If openDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtPath.Text = openDialog.FileName.ToString
        End If
    End Sub

    Private Sub backup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For i = 0 To textBoxes.Length - 1
            My.Settings.TextBoxValues(i) = textBoxes(i).Text
        Next
        My.Settings.Save()

    End Sub

    Private Sub backup_Load(sender As Object, e As EventArgs) Handles Me.Load
        MessageBox.Show("Note: Saving the backup file required an internet connection. Make sure that you are connected to the internet.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '' dito lahat ng txtbox names ilalagay
        Control.CheckForIllegalCrossThreadCalls = False
        textBoxes = New TextBox() {txtPath, txtUser, txtPass, txtaddress, txtFilename, txtSavePath}

        With My.Settings
            If .TextBoxValues Is Nothing Then .TextBoxValues = New System.Collections.Specialized.StringCollection
            For i = 0 To textBoxes.Length - 1
                If .TextBoxValues.Count <= i Then .TextBoxValues.Add("")
                textBoxes(i).Text = .TextBoxValues(i)
            Next
        End With
        If CheckBox1.CheckState = CheckState.Unchecked Then
            Me.Size = New System.Drawing.Size(541, 311)
        End If
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        txtPass.UseSystemPasswordChar = False
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnBr_Click(sender As Object, e As EventArgs) Handles btnBr.Click
        Dim fbd As New FolderBrowserDialog
        If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtSavePath.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        'Create a WebClient.
        'Dim request As New WebClient()
        ''AddHandler request.DownloadProgressChanged, AddressOf DownloadProgressChanged
        ''AddHandler request.DownloadFileCompleted, AddressOf DownloadDataCompleted
        'MessageBox.Show("PLEASE WAIT WHILE DOWNLOADING THE DATABASE...", "Please wait", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '' Confirm the Network credentials based on the user name and password passed in.
        'request.Credentials = New NetworkCredential(txtUser.Text, txtPass.Text)

        ''Read the file data into a Byte array
        'Dim bytes() As Byte = request.DownloadData(txtaddress.Text + txtFilename.Text)

        'Try
        '    '  Create a FileStream to read the file into
        '    Dim DownloadStream As FileStream = IO.File.Create(txtSavePath.Text + "\" + txtFilename.Text)
        '    '  Stream this data into the file
        '    DownloadStream.Write(bytes, 0, bytes.Length)
        '    '  Close the FileStream
        '    DownloadStream.Close()
        '    MessageBox.Show("File Downloaded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'End Try
        restoreBackup()
    End Sub
    Sub restoreBackup()
        bWorker.RunWorkerAsync()
    End Sub
    Private Sub bWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bWorker.DoWork
        Dim FilePath As String = txtaddress.Text + txtFilename.Text
        Dim buffer(1023) As Byte
        Dim bytesIn As Integer
        Dim totalBytesIn As Integer
        Dim output As IO.Stream
        Dim flLength As Integer
        Dim flKB As Double
        Dim flMB As Double
        Dim totalKB, totalMB As Double
        Try
            Dim FTPRequest As FtpWebRequest = DirectCast(WebRequest.Create(FilePath), FtpWebRequest)
            FTPRequest.Credentials = New NetworkCredential("FTP@studentsportal.x10host.com", "Passmein07")
            FTPRequest.Method = Net.WebRequestMethods.Ftp.GetFileSize
            flLength = CInt(FTPRequest.GetResponse.ContentLength)
            If flLength > 1000 Then
                flKB = flLength / 1000
                lblFileSize.Text = flKB.ToString("0.00") & "KB"
            ElseIf flKB > 1000 Then
                flMB = flKB / 1000
                lblFileSize.Text = flMB.ToString("0.00") & "MB"
            Else
                lblFileSize.Text = flLength & " bytes"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            Dim FTPRequest As FtpWebRequest = DirectCast(WebRequest.Create(FilePath), FtpWebRequest)
            FTPRequest.Credentials = New NetworkCredential(txtUser.Text, txtPass.Text)
            FTPRequest.Method = WebRequestMethods.Ftp.DownloadFile
            Dim stream As System.IO.Stream = FTPRequest.GetResponse.GetResponseStream
            Dim OutputFilePath As String = txtSavePath.Text & "\" & IO.Path.GetFileName(FilePath)
            output = System.IO.File.Create(OutputFilePath)
            bytesIn = 1
            Do Until bytesIn < 1
                bytesIn = stream.Read(buffer, 0, 1024)
                If bytesIn > 0 Then
                    output.Write(buffer, 0, bytesIn)
                    totalBytesIn += bytesIn
                    If totalBytesIn > 1000 Then
                        totalKB = totalBytesIn / 1000
                        lblDownloadedBytes.Text = totalKB.ToString("0.00") & "KB"
                    ElseIf totalKB > 1000 Then
                        totalMB = totalKB / 1000
                        lblDownloadedBytes.Text = totalMB.ToString("0.00") & "MB"
                    Else
                        lblDownloadedBytes.Text = totalBytesIn.ToString & " bytes"
                    End If

                    If flLength > 0 Then
                        Dim perc As Integer = (totalBytesIn / flLength) * 100
                        bWorker.WorkerReportsProgress = True
                        bWorker.ReportProgress(perc)
                    End If
                End If
            Loop
            output.Close()
            stream.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bWorker.ProgressChanged
        pBar.Value = e.ProgressPercentage
        lblPercent.Text = e.ProgressPercentage.ToString & "%"
    End Sub

    Private Sub bWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bWorker.RunWorkerCompleted
        MessageBox.Show("Backup File Downloaded successfully", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CheckBox1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged
        If CheckBox1.CheckState = CheckState.Unchecked Then
            Me.Size = New System.Drawing.Size(541, 311)
        Else
            Me.Size = New System.Drawing.Size(541, 554)
        End If
    End Sub
End Class