Module Module1
    ''' <summary>
    ''' Escribir un programa que solicite la carga de un valor positivo y nos muestre desde 1 hasta el valor ingresado de uno en uno.
    ''' Ejemplo: Si ingresamos 30 se debe mostrar en pantalla los números del 1 al 30.
    ''' </summary>

#Region "main"

    Sub Main()
        Console.Title = "Problema 2: 09 - Estructura repetitiva Do While (condición) ... Loop"

        Dim n, x As Integer
        Console.Write("Ingrese el valor final: ")
        n = Console.ReadLine()
        x = 1
        Do While x <= n
            Console.Write(x)
            Console.Write(" - ")
            x += 1
        Loop
        Console.ReadKey()
    End Sub

#End Region

End Module
