Module Module1
    Function Sort(ByRef a() As Integer) As Integer
        Dim temp As Integer
        '氣泡排序法
        For y = 1 To 8
            For z = 0 To 9 - y
                If a(z) < a(z + 1) Then
                    temp = a(z)
                    a(z) = a(z + 1)
                    a(z + 1) = temp
                End If
            Next
        Next
        Console.WriteLine("前三大的數字為：{0},{1},{2}", a(0), a(1), a(2))
        Console.ReadLine()
    End Function
    Sub Main()
        Dim a(9), x As Integer
        Dim n As New Random

        For i As Integer = 0 To 9
            Do
                x = n.Next(1, 201)
                If Array.IndexOf(a, x) = -1 Then
                    Exit Do
                End If
            Loop
            a(i) = x
        Next
        For Each h In a
            Console.Write(h & " ")
        Next
        Console.ReadLine()
        Call Sort(a)

    End Sub


End Module
