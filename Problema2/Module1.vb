Module Module1

    Sub Main()
        Console.Title = "Problema 2 - 06"

        Dim nota1, nota2, nota3 As Integer
        Dim promedio As Single

        Console.Write("Ingrese la primera nota: ")
        nota1 = Console.ReadLine()
        Console.Write("Ingrese la segunda nota: ")
        nota2 = Console.ReadLine()
        Console.Write("Ingrese la tercera nota: ")
        nota3 = Console.ReadLine()

        promedio = (nota1 + nota2 + nota3) / 3

        If promedio >= 7 Then
            Console.WriteLine("Promocionado")
        End If

        Console.ReadKey()

    End Sub

End Module
