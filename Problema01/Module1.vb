Module Module1

    Sub Main()
        Console.Title = "7- Problema 01"

        Dim num1, num2, num3 As Integer
        Console.Write("Ingrese primer valor:")
        num1 = Console.ReadLine()
        Console.Write("Ingrese segunda valor:")
        num2 = Console.ReadLine()
        Console.Write("Ingrese tercer valor:")
        num3 = Console.ReadLine()
        If num1 > num2 Then
            If num1 > num3 Then
                Console.Write("El mayor número fue el primero: {0}", num1)
            Else
                Console.Write("El mayor número fue el tercero: {0}", num3)
            End If
        Else
            If num2 > num3 Then
                Console.Write("El mayor número fue el segundo: {0}", num2)
            Else
                Console.Write("El mayor número fue el tercero: {0}", num3)
            End If
        End If

        Console.ReadKey()
    End Sub

End Module
