'==========================================================================
'Written By Lamhot Simamora
'LamhotSimamora36@gmail.com
'https://coretancode.wordpress.com
'==========================================================================

Public Class FrmUtama
    Dim inggris As String = Application.StartupPath + "\lang\english.set"
    Dim indonesia As String = Application.StartupPath + "\lang\indonesia.set"
    Dim jerman As String = Application.StartupPath + "\lang\german.set"
    Dim config As String = Application.StartupPath + "\config.ini"
    Dim app As String = Application.StartupPath + "\FormWithLanguange.exe"
    Sub awalinggris()
        X1.Text = ReadALine(inggris, GetNumberOfLines(inggris), 1)
        X2.Text = ReadALine(inggris, GetNumberOfLines(inggris), 2)
        X3.Text = ReadALine(inggris, GetNumberOfLines(inggris), 3)
        Y1.Text = ReadALine(inggris, GetNumberOfLines(inggris), 4)
        Y2.Text = ReadALine(inggris, GetNumberOfLines(inggris), 5)
        lblnama.Text = ReadALine(inggris, GetNumberOfLines(inggris), 8)
        lblage.Text = ReadALine(inggris, GetNumberOfLines(inggris), 9)
        btnsave.Text = ReadALine(inggris, GetNumberOfLines(inggris), 10)
        btnedit.Text = ReadALine(inggris, GetNumberOfLines(inggris), 11)
        BtnDelete.Text = ReadALine(inggris, GetNumberOfLines(inggris), 12)
        BtnCancel.Text = ReadALine(inggris, GetNumberOfLines(inggris), 13)
        With DataGridView1.Columns
            C1.HeaderText = ReadALine(inggris, GetNumberOfLines(inggris), 8)
            C2.HeaderText = ReadALine(inggris, GetNumberOfLines(inggris), 9)
        End With
    End Sub
    Sub awalindonesia()
        X1.Text = ReadALine(indonesia, GetNumberOfLines(indonesia), 1)
        X2.Text = ReadALine(indonesia, GetNumberOfLines(indonesia), 2)
        X3.Text = ReadALine(indonesia, GetNumberOfLines(indonesia), 3)
        Y1.Text = ReadALine(indonesia, GetNumberOfLines(indonesia), 4)
        Y2.Text = ReadALine(indonesia, GetNumberOfLines(indonesia), 5)
        lblnama.Text = ReadALine(indonesia, GetNumberOfLines(indonesia), 8)
        lblage.Text = ReadALine(indonesia, GetNumberOfLines(indonesia), 9)
        btnsave.Text = ReadALine(indonesia, GetNumberOfLines(indonesia), 10)
        btnedit.Text = ReadALine(indonesia, GetNumberOfLines(indonesia), 11)
        BtnDelete.Text = ReadALine(indonesia, GetNumberOfLines(indonesia), 12)
        BtnCancel.Text = ReadALine(indonesia, GetNumberOfLines(indonesia), 13)
        With DataGridView1.Columns
            C1.HeaderText = ReadALine(indonesia, GetNumberOfLines(indonesia), 8)
            C2.HeaderText = ReadALine(indonesia, GetNumberOfLines(indonesia), 9)
        End With
    End Sub
    Sub awaljerman()
        X1.Text = ReadALine(jerman, GetNumberOfLines(jerman), 1)
        X2.Text = ReadALine(jerman, GetNumberOfLines(jerman), 2)
        X3.Text = ReadALine(jerman, GetNumberOfLines(jerman), 3)
        Y1.Text = ReadALine(jerman, GetNumberOfLines(jerman), 4)
        Y2.Text = ReadALine(jerman, GetNumberOfLines(jerman), 5)
        lblnama.Text = ReadALine(jerman, GetNumberOfLines(jerman), 8)
        lblage.Text = ReadALine(jerman, GetNumberOfLines(jerman), 9)
        btnsave.Text = ReadALine(jerman, GetNumberOfLines(jerman), 10)
        btnedit.Text = ReadALine(jerman, GetNumberOfLines(jerman), 11)
        BtnDelete.Text = ReadALine(jerman, GetNumberOfLines(jerman), 12)
        BtnCancel.Text = ReadALine(jerman, GetNumberOfLines(jerman), 13)
        With DataGridView1.Columns
            C1.HeaderText = ReadALine(jerman, GetNumberOfLines(jerman), 8)
            C2.HeaderText = ReadALine(jerman, GetNumberOfLines(jerman), 9)
        End With
    End Sub
    Sub clear()
        X1.Text = ""
        X2.Text = ""
        X3.Text = "'"
        lblnama.Text = ""
        lblage.Text = ""
        btnsave.Text = ""
        btnedit.Text = ""
        BtnDelete.Text = ""
    End Sub
    Sub awal()
        clear()
        Dim file As String
        Using temp As New IO.StreamReader(config)
            file = temp.ReadLine
            If file = "English" Then
                awalinggris()
                EnglishToolStripMenuItem.Checked = True
                IndonesiaToolStripMenuItem.Checked = False
                GermanToolStripMenuItem.Checked = False
            ElseIf file = "Indonesia" Then
                awalindonesia()
                EnglishToolStripMenuItem.Checked = False
                IndonesiaToolStripMenuItem.Checked = True
                GermanToolStripMenuItem.Checked = False
            ElseIf file = "German" Then
                awaljerman()
                EnglishToolStripMenuItem.Checked = False
                IndonesiaToolStripMenuItem.Checked = False
                GermanToolStripMenuItem.Checked = True
            End If
        End Using
    End Sub
    Private Sub FrmUtama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        awal()
    End Sub


    Private Sub EnglishToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnglishToolStripMenuItem.Click
        My.Computer.FileSystem.WriteAllText(config, "English", False)
        Me.Close()
        Process.Start(app)
    End Sub

    Private Sub IndonesiaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IndonesiaToolStripMenuItem.Click
        My.Computer.FileSystem.WriteAllText(config, "Indonesia", False)
        Me.Close()
        Process.Start(app)
    End Sub

    Private Sub GermanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GermanToolStripMenuItem.Click
        My.Computer.FileSystem.WriteAllText(config, "German", False)
        Me.Close()
        Process.Start(app)
    End Sub

    Private Sub X3_Click(sender As System.Object, e As System.EventArgs) Handles X3.Click
        Me.Close()
    End Sub
End Class
