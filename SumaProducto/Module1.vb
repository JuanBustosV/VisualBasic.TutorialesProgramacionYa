Module Module1

    Sub Main()
        Console.Title = "Suma y Producto de dos números"

        Dim num1, num2, suma, producto As Integer
        Console.Write("Ingrese primer valor: ")
        num1 = Console.ReadLine()
        Console.Write("Ingrese segundo valor: ")
        num2 = Console.ReadLine()
        suma = num1 + num2
        producto = num1 * num2
        Console.Write("La suma de los dos valores es: ")
        Console.WriteLine(suma)
        Console.Write("El producto de los dos valores es: ")
        Console.WriteLine(producto)
        Console.ReadKey()
    End Sub

End Module
