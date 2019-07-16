Module Module1

    Sub Main()
        Dim lado As Integer
        Dim superficie As Integer

        Console.Title = "Superficie Cuadrado"

        Console.Write("Ingrese el valor del lado del cuadrado: ")
        lado = Console.ReadLine()

        superficie = Math.Pow(lado, 2) 'lado * lado

        Console.Write("La superficie del cuadrado es: ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine(superficie)
        Console.ReadKey()
    End Sub

End Module
