Imports System.Text 'para uso Encoding

Module Module1

    Sub Main()
        Console.Title = "5 - Estructura de programación secuencial"
        Console.OutputEncoding = Encoding.UTF8


        Console.WriteLine("1) Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo" &
                       vbCrLf & "(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro)" & vbCrLf)
        'Declaración variables
        Dim lado, perimetro As Integer

        Console.WriteLine("Introduzca el valor del lado del cuadrado: ")
        lado = Console.ReadLine()

        perimetro = lado * 4

        Console.WriteLine("El valor del perímetro de un cuadrado de lado " & lado & " es: " & perimetro)

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")

        Console.WriteLine("2) Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de" &
                        vbCrLf & "los dos primeros y el producto del tercero y el cuarto." & vbCrLf)
        Dim num1, num2, num3, num4, suma, producto As Integer

        Console.WriteLine("Introduzca el valor del primer número:")
        num1 = Console.ReadLine()
        Console.WriteLine("Introduzca el valor del segundo número:")
        num2 = Console.ReadLine()
        Console.WriteLine("Introduzca el valor del tercer número:")
        num3 = Console.ReadLine()
        Console.WriteLine("Introduzca el valor del cuarto número:")
        num4 = Console.ReadLine()

        suma = num1 + num2
        producto = num3 * num4

        Console.WriteLine("La suma de " & num1 & " + " & num2 & " es: " & suma)
        Console.WriteLine("El producto de " & num3 & " * " & num4 & " es: " & producto)

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")

        Console.WriteLine("3) Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio." & vbCrLf)

        Dim n1, n2, n3, n4, sumatoria As Integer
        Dim promedio As Single

        Console.WriteLine("Introduzca el valor del primer número:")
        n1 = Console.ReadLine()
        Console.WriteLine("Introduzca el valor del segundo número:")
        n2 = Console.ReadLine()
        Console.WriteLine("Introduzca el valor del tercer número:")
        n3 = Console.ReadLine()
        Console.WriteLine("Introduzca el valor del cuarto número:")
        n4 = Console.ReadLine()

        sumatoria = n1 + n2 + n3 + n4
        promedio = sumatoria / 4

        Console.WriteLine("La suma de los números es: " & sumatoria)
        Console.WriteLine("El promedio es: " & promedio)

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")

        Console.WriteLine("4) Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad" &
                        vbCrLf & "que lleva el cliente. Mostrar lo que debe abonar el comprador." & vbCrLf)

        Dim precio, total As Single
        Dim cantidad As Integer

        Console.WriteLine("Introduzca el precio del artículo: ")
        precio = Console.ReadLine()

        Console.WriteLine("Introduzca la cantidad del artículo: ")
        cantidad = Console.ReadLine()

        total = precio * cantidad

        Console.WriteLine("El comprador debe abonar: " & total & " €" & vbCrLf)

        Console.WriteLine("Presione cualquier tecla para terminar...")
        Console.ReadKey()

    End Sub

End Module
