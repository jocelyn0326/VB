Module Module1
    Class shape
        Public x As Integer
        Public y As Integer
        Public Overridable Sub area()
        End Sub

    End Class
    Class circle
        Inherits shape
        Public Overrides Sub area()
            Console.WriteLine("圓形面積為：{0}", x * x * 3.14)
        End Sub

    End Class
    Class triangle
        Inherits shape
        Public Overrides Sub area()
            Console.WriteLine("三角形面積為：{0}", x * y / 2)

        End Sub
    End Class
    Class rectangle
        Inherits shape
        Public Overrides Sub area()
            Console.Write("長方形的面積為：{0}", x * y)
        End Sub
    End Class
    Sub Main()
        Dim input As String
        Dim _shape As shape
        Dim _circle As New circle
        Dim _triangle As New triangle
        Dim _rectangle As New rectangle

        Console.Write("請輸入要計算圓形、三角形或長方形：")
        input = Console.ReadLine()
        Select Case input
            Case "圓形"
                _shape = _circle
                Console.Write("請輸入圓形半徑：")
                _shape.x = Console.ReadLine
                Call _shape.area()
            Case "三角形"
                _shape = _triangle
                Console.Write("請輸入三角形的底：")
                _shape.x = Console.ReadLine
                Console.Write("請輸入三角形的高：")
                _shape.y = Console.ReadLine()
                Call _shape.area()
            Case "長方形"
                _shape = _rectangle
                Console.Write("請輸入長方形的長：")
                _shape.x = Console.ReadLine
                Console.Write("請輸入長方形的寬：")
                _shape.y = Console.ReadLine
                Call _shape.area()
        End Select
        Console.ReadLine()
    End Sub

End Module
