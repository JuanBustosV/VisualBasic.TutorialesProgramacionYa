Module Module1
    ''' <summary>
    '''  Escribir un programa en el cual: dada una lista de tres valores numéricos distintos se calcule e informe su rango de variación (debe mostrar el mayor y el menor de ellos)
    ''' </summary>

#Region "main"
    Sub Main()
        Console.Title = "PROBLEMA 7 (8 - Estructuras condicionales con condiciones compuestas y operadores lógicos)"

        Dim num1, num2, num3 As Integer

        Console.Write("Ingrese primer valor: ")
        num1 = Console.ReadLine()

        Console.Write("Ingrese segundo valor: ")
        num2 = Console.ReadLine()

        Console.Write("Ingrese tercer valor: ")
        num3 = Console.ReadLine()

        Console.Write(vbNewLine & "Rango de valores: ")

        'Obtengo el mínimo valor
        If num1 < num2 AndAlso num1 < num3 Then
            Console.Write(num1)
        Else
            If num2 < num3 Then
                Console.Write(num2)
            Else
                Console.Write(num3)
            End If
        End If

        Console.Write("-")
        'Obtengo el máximo valor
        If num1 > num2 AndAlso num1 > num3 Then
            Console.WriteLine(num1)
        Else
            If num2 > num3 Then
                Console.WriteLine(num2)
            Else
                Console.WriteLine(num3)
            End If
        End If

        Console.WriteLine(vbNewLine & "Presione cualquier tecla para salir...")
        Console.ReadKey()
    End Sub

#End Region

End Module
