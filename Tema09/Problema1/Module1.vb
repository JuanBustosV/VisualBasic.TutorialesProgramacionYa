Module Module1
    ''' <summary>
    ''' Realizar un programa que imprima en pantalla los números del 1 al 100.
    ''' </summary>

    Sub Main()
        Console.Title = "Problema 1: 09 - Estructura repetitiva Do While (condición) ... Loop"

        Dim x As Integer
        x = 1
        Do While x <= 100
            Console.Write(x)
            Console.Write(" - ")
            x += 1
        Loop
        Console.ReadKey()

    End Sub

End Module
