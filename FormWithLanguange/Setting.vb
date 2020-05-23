Imports System.IO
Module Setting
    Public Function ReadALine(ByVal File_Path As String, ByVal TotalLine As Integer, ByVal Line2Read As Integer) As String
        Dim Buffer As Array
        Dim Line As String
        If TotalLine <= Line2Read Then
            Return "No Such Line"
        End If
        Buffer = File.ReadAllLines(File_Path)
        Line = Buffer(Line2Read)
        Return Line
    End Function
    Public Function GetNumberOfLines(ByVal file_path As String) As Integer
        Dim temp As New StreamReader(file_path)
        Dim NumberOfLines As Integer
        Do While temp.Peek >= 0
            temp.ReadLine()
            NumberOfLines += 1
        Loop
        Return NumberOfLines
        temp.Close()
        temp.Dispose()
    End Function

End Module
'=================================================================================================================