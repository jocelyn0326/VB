Module Module1

    Sub Main()
        Dim num, i, sum As Integer
        Console.Write("請輸入一個整數：")
        num = Console.ReadLine()
        Do While i <= num
            sum += i

            i += 2
        Loop

        Console.WriteLine()
        Console.WriteLine("0~{0}的偶數總和為{1}", num, sum)
        Console.ReadLine()
    End Sub

End Module
