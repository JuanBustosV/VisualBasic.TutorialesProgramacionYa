Module Module1
    ''' <summary>
    ''' Se ingresan tres numes por teclado, si todos son iguales se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.
    ''' </summary>

#Region "main"
    Sub Main()
        Console.Title = "PROBLEMA 2 (8 - Estructuras condicionales con condiciones compuestas y operadores lógicos)"

        Dim num1, num2, num3 As Integer

        Console.Write("Ingrese primer valor: ")
        num1 = Console.ReadLine()

        Console.Write("Ingrese segundo valor: ")
        num2 = Console.ReadLine()

        Console.Write("Ingrese tercer valor: ")
        num3 = Console.ReadLine()

        If num1 = num2 AndAlso num1 = num3 Then
            Dim suma, producto As Integer
            suma = num1 + num2
            Console.Write(vbNewLine & "La suma del primero y segundo: ")
            Console.WriteLine(suma)
            producto = suma * num3
            Console.Write("La suma del primero y segundo multiplicado por el tercero: ")
            Console.WriteLine(producto)
        End If

        Console.WriteLine(vbNewLine & "Presione cualquier tecla para salir...")
        Console.ReadKey()
    End Sub

#End Region

End Module
