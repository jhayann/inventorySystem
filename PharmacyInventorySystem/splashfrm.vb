Imports System.Threading
Public Class splashfrm

    Private Sub splashfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Sub inn()
     
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FlatProgressBar1.Value += 1
        If FlatProgressBar1.Value = 20 Then
            TextBox1.AppendText("Reading database..." + Environment.NewLine)
            FlatProgressBar1.Value += 35
            Thread.Sleep(4000)
        ElseIf FlatProgressBar1.Value = 70 Then
            TextBox1.AppendText("Loading Application..." + Environment.NewLine)
            Thread.Sleep(2000)
            FlatProgressBar1.Value += 10
        ElseIf FlatProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class