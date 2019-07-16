Module Module1

    Sub Main()
        Console.Title = "Problema 1 - 06"
        'Declaración variables
        Dim num1, num2 As Integer
        'Entrada datos
        Console.Write("Ingrese el primer número: ")
        num1 = Console.ReadLine()
        Console.Write("Ingrese el segundo número: ")
        num2 = Console.ReadLine()
        'Calculo
        If num1 > num2 Then
            Console.WriteLine("La suma de " & num1 & " y " & num2 & " es: " & num1 + num2)
            Console.WriteLine("La diferencia de " & num1 & " y " & num2 & " es: " & num1 - num2)
        Else
            Console.WriteLine("El producto de " & num1 & " y " & num2 & " es: " & num1 * num2)
            Console.WriteLine("La división de " & num1 & " y " & num2 & " es: " & num1 / num2)
        End If

        Console.ReadKey()

    End Sub

End Module
