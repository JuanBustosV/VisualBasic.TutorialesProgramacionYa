Module Module1
    ''' <summary>
    ''' Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.     
    ''' </summary>

#Region "main"

    Sub Main()
        Console.Title = "PROBLEMA 1 (8 - Estructuras condicionales con condiciones compuestas y operadores lógicos)"

        Dim d, m, a As Integer

        Console.Write("Día: ")
        d = Console.ReadLine()

        Console.Write("Mes: ")
        m = Console.ReadLine()

        Console.Write("Año: ")
        a = Console.ReadLine()

        Console.WriteLine()
        If d = 25 AndAlso m = 12 Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.BackgroundColor = ConsoleColor.Blue
            Console.WriteLine(" ¡La fecha ingresada corresponde a navidad.!")
            Console.ResetColor()
        Else
            Console.WriteLine(" La fecha ingresada NO corresponde a navidad.")
        End If

        Console.ReadKey()
    End Sub

#End Region

End Module
