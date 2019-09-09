Module Module1
    ''' <summary>
    ''' Se ingresan un conjunto de n alturas de personas por teclado. Mostrar la altura promedio de las personas.
    ''' </summary>

#Region "main"

    Sub Main()
        Console.Title = "PROBLEMA 2 (9 - Estructura repetitiva Do While (condición) ... Loop)"

        Dim n, x As Integer
        Dim altura, suma, promedio As Single
        Console.Write("Cuantas personas hay: ")
        n = Console.ReadLine()
        x = 1
        suma = 0

        Do While x <= n
            Console.Write("Ingrese altura {0}: ", x)
            altura = Console.ReadLine()
            suma += altura
            x += 1
        Loop

        promedio = suma / n
        Console.WriteLine(vbNewLine & "La altura promedio es de " & promedio & " m.")

        Console.ReadKey()
    End Sub

#End Region

End Module
