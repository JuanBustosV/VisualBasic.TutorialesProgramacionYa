Module Module1

    Sub Main()
        Console.Title = "7 - Estructuras condicionales anidadas"

        Dim nota1, nota2, nota3, promedio As Integer
        Console.Write("Ingrese primera nota:")
        nota1 = Console.ReadLine()
        Console.Write("Ingrese segunda nota:")
        nota2 = Console.ReadLine()
        Console.Write("Ingrese tercera nota:")
        nota3 = Console.ReadLine()

        promedio = (nota1 + nota2 + nota3) / 3

        If promedio >= 7 Then
            Console.Write("Promocionado")
        Else
            If promedio >= 4 Then
                Console.Write("Regular")
            Else
                Console.Write("Suspenso")
            End If
        End If
        Console.ReadKey()
    End Sub

End Module
