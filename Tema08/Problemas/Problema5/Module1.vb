Module Module1
    ''' <summary>
    ''' Escribir un programa que pida ingresar la coordenada de un punto en el plano, es decir dos valores enteros x e y (distintos a cero).
    ''' Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x menor 0 Y y > 0, etc.) 
    ''' </summary>

#Region "main"
    Sub Main()
        Console.Title = "PROBLEMA 5 (8 - Estructuras condicionales con condiciones compuestas y operadores lógicos)"

        Dim x, y As Integer

        Console.Write(vbNewLine & "Coordenadas del punto -" & vbNewLine & vbNewLine & "Ingrese valor de X: ")
        x = Console.ReadLine()
        Console.Write("Ingrese valor de Y: ")
        y = Console.ReadLine()

        'Calculo del cuadrante de ese punto
        If x > 0 AndAlso y > 0 Then
            Console.WriteLine(vbNewLine & "El punto ({0}, {1}) está en el primer cuadrante.", x, y)
        ElseIf x < 0 AndAlso y > 0 Then
            Console.WriteLine(vbNewLine & "El punto ({0}, {1}) está en el segundo cuadrante.", x, y)
        ElseIf x < 0 AndAlso y < 0 Then
            Console.WriteLine(vbNewLine & "El punto ({0}, {1}) está en el tercer cuadrante.", x, y)
        Else
            Console.WriteLine(vbNewLine & "El punto ({0}, {1}) está en el cuarto cuadrante.", x, y)

        End If

        Console.WriteLine(vbNewLine & "Presione cualquier tecla para salir...")
        Console.ReadKey()
    End Sub

#End Region

End Module
