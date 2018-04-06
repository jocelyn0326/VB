Module Module1

    Sub Main()
        Dim student() As String = {"詹家欣", "杜京珊", "郭宜萱", "葉姿萱"}
        Dim score() As Integer = {500, 545, 740, 755}
        Console.WriteLine("請輸入姓名或分數：")
        Dim x As String = Console.ReadLine
        Dim y As Integer
        If IsNumeric(x) = True Then 'Isnumeric 是判斷輸入值是否為數字型態的函式
            y = CInt(x)
            If Array.IndexOf(score, y) >= 0 Then
                Console.Write(student(Array.IndexOf(score, y)))
            Else
                Console.Write("查無此資料")
            End If
        Else
            If Array.IndexOf(student, x) >= 0 Then
                Console.Write(score(Array.IndexOf(student, x)))
            Else
                Console.Write("查無此資料")
            End If
        End If
        Console.ReadLine()
    End Sub

End Module
