Module Module1
    Class student
        Public Shared Property people As Integer
        Public Property Sid As String
        Public Property Name As String
        Public Property Height As Integer
        Public Property Weight As Integer
        Public Sub SetData()
            Console.Write("請輸入學生學號：")
            Sid = Console.ReadLine
            Console.Write("請輸入學生姓名：")
            Name = Console.ReadLine
            Console.Write("請輸入學生身高：")
            Height = Console.ReadLine
            Console.Write("請輸入學生體重：")
            Weight = Console.ReadLine
            If Weight <= 0 Or Height <= 0 Then
                Throw New SetException
            End If
            If (Weight / (Height / 100) ^ 2) < 18.5 Or (Weight / (Height / 100) ^ 2) >= 24 Then
                Throw New BMIException
            End If

        End Sub
    End Class
    Class SetException
        Inherits Exception

        Public Overrides Function Tostring() As String
            Return "身高或體重不可設為小於等於0的數字"
        End Function
    End Class
    Class BMIException
        Inherits Exception
        Public Overrides Function ToString() As String
            Return "BMI值不正常"
        End Function
    End Class
    Sub Main()
        Dim input As String
        Dim s(200) As student
        Do
            Try
                s(student.people) = New student
                s(student.people).SetData()
                student.people += 1
            Catch ex As BMIException
                Console.WriteLine(ex.ToString())
                student.people += 1
            Catch ex As SetException
                Console.WriteLine(ex.Tostring())
            End Try

            Console.Write("若要停止輸入資料，請輸入Y(大寫) ")
            input = Console.ReadLine
        Loop While input <> "Y"
        For i = 0 To student.people - 1
            Console.WriteLine("第{0}位學生的學號是：{1}", i + 1, s(i).Sid)
            Console.WriteLine("第{0}位學生的姓名是：{1}", i + 1, s(i).Name)
            Console.WriteLine("第{0}位學生的身高是：{1}", i + 1, s(i).Height)
            Console.WriteLine("第{0}位學生的體重是：{1}", i + 1, s(i).Weight)
            Dim bmi As Double = (s(i).Weight / (s(i).Height / 100) ^ 2)
            Console.WriteLine("第{0}位學生的BMI是：{1}({2})", i + 1, bmi, IIf(bmi < 18.5, "過輕", IIf(bmi >= 24, "過重", "正常")))
            Console.WriteLine()

        Next
        Console.ReadLine()
    End Sub

End Module
