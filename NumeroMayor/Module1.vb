Module Module1

    Sub Main()
        Dim num1, num2 As Integer
        Console.Write("Ingrese primer valor:")
        num1 = Console.ReadLine()
        Console.Write("Ingrese segundo valor:")
        num2 = Console.ReadLine()
        If num1 > num2 Then
            Console.Write(num1)
        Else
            Console.Write(num2)
        End If
        Console.ReadKey()
    End Sub

End Module
