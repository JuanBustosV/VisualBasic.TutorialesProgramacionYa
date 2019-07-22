Module Module1

#Region "Método Main"
    ''' <summary>
    ''' Confeccionar un programa que permita cargar un número entero positivo de hasta tres cifras y muestre un mensaje
    ''' indicando si tiene 1, 2, o 3 cifras. Mostrar un mensaje de error si el número de cifras es mayor.
    ''' </summary>
    Sub Main()
        Console.Title = "7- Problema 03"
        'TODO Tarea1: Realizar el problema 3
        'Variable
        Dim numero As Integer

        'Petición del número al usuario
        Console.Write("Introcuzca un número entero positivo de hasta tres cifras: ")
        numero = Console.ReadLine()

        Console.WriteLine(vbCrLf & "-------------------------------------" & vbCrLf)

        If numero < 10 And numero >= 0 Then
            Console.WriteLine("El número {0} tiene una cifra.", numero)
        Else
            If numero < 100 And numero >= 0 Then
                Console.WriteLine("El número {0} tiene dos cifras.", numero)
            Else
                If numero < 1000 And numero >= 0 Then
                    Console.WriteLine("El número {0} tiene tres cifras.", numero)
                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("ERROR: El número {0} tiene más de tres cifras o es negativo.", numero)
                    Console.ResetColor()
                End If
            End If
        End If

        Console.WriteLine(vbCrLf & "-------------------------------------" & vbCrLf)

        Console.ReadKey()
    End Sub

#End Region
End Module
