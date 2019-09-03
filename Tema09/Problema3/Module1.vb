Module Module1
    ''' <summary>
    ''' Desarrollar un programa que permita la carga de 10 valores por teclado y nos muestre posteriormente la suma de los valores ingresados y su promedio.
    ''' </summary>

#Region "main"

    Sub Main()
        Console.Title = "Problema 3: 09 - Estructura repetitiva Do While (condición) ... Loop"

        Dim x, suma, valor As Integer
        Dim promedio As Single
        x = 1
        suma = 0
        Do While x <= 10
            Console.Write("Ingrese un valor: ")
            valor = Console.ReadLine()
            suma += valor
            x += 1
        Loop
        promedio = suma / 10
        Console.Write("La suma de los 10 valores es: ")
        Console.WriteLine(suma)
        Console.Write("El promedio es: ")
        Console.Write(promedio)
        Console.ReadKey()
    End Sub

#End Region

End Module
