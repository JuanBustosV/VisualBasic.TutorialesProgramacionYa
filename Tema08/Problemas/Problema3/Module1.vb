Module Module1
    ''' <summary>
    ''' Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, imprimir en pantalla la leyenda "Todos los números son menores a diez".
    ''' </summary>

#Region "main"
    Sub Main()
        Console.Title = "PROBLEMA 3 (8 - Estructuras condicionales con condiciones compuestas y operadores lógicos)"

        Dim num1, num2, num3 As Integer

        Console.Write("Ingrese primer valor: ")
        num1 = Console.ReadLine()

        Console.Write("Ingrese segundo valor: ")
        num2 = Console.ReadLine()

        Console.Write("Ingrese tercer valor: ")
        num3 = Console.ReadLine()

        If num1 < 10 AndAlso num2 < 10 AndAlso num3 < 10 Then
            Console.WriteLine(vbNewLine & "Todos los números son menores a diez")
        End If

        Console.WriteLine(vbNewLine & "Presione cualquier tecla para salir...")
        Console.ReadKey()
    End Sub

#End Region

End Module
