Module Module1
#Region "Método Main"
    ''' <summary>
    ''' Confeccionar un programa que lea por teclado tres números distintos y nos muestre el mayor.
    ''' </summary>
    Sub Main()
        Console.Title = "8 - Estructuras condicionales con condiciones compuestas y operadores lógicos"

        Dim num1, num2, num3 As Integer
        Console.Write("Ingrese primer valor:")
        num1 = Console.ReadLine()
        Console.Write("Ingrese segundo valor:")
        num2 = Console.ReadLine()
        Console.Write("Ingrese tercer valor:")
        num3 = Console.ReadLine()
        If num1 > num2 And num1 > num3 Then
            Console.Write(num1)
        Else
            If num2 > num3 Then
                Console.Write(num2)
            Else
                Console.Write(num3)
            End If
        End If
        Console.ReadKey()
    End Sub
#End Region
End Module
