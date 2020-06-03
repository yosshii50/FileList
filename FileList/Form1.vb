Public Class Form1

    Private Sub 追加AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 追加AToolStripMenuItem.Click

        Dim ofd As New OpenFileDialog()

        ofd.Filter = "すべてのファイル(*.*)|*.*"
        ofd.Multiselect = True
        ofd.CheckFileExists = False
        ofd.CheckPathExists = False

        If ofd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する

            For Each WrkStr As String In ofd.FileNames
                ListBox1.Items.Add(WrkStr)
            Next

        End If

    End Sub

    Private Sub フォルダ追加DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles フォルダ追加DToolStripMenuItem.Click

        Dim fbd As New FolderBrowserDialog
        If fbd.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダを表示する
            ListBox1.Items.Add(fbd.SelectedPath & "\")
        End If

    End Sub

    Private Sub 終了ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 終了ToolStripMenuItem.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub 全消去NToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 全消去NToolStripMenuItem.Click
        ListBox1.Items.Clear()
    End Sub
End Class
