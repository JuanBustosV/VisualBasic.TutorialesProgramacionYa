Module Module1

    Sub Main()
        Console.Title = "Problema 3 - 06"

        Dim numero As Integer

        Console.Write("Ingrese un número de dos dígitos (de 0 a 99): ")
        numero = Console.ReadLine()

        If numero > 9 Then
            Console.WriteLine("El número " & numero & " tiene dos dígitos.")
        Else
            Console.WriteLine("El número " & numero & " tiene un dígito.")
        End If

        Console.ReadKey()
    End Sub

End Module
