Module Module1

#Region "Método Main"
    ''' <summary>
    ''' Se ingresa por teclado un valor entero, mostrar una leyenda que indique si el número es positivo, nulo o negativo.
    ''' </summary>
    Sub Main()
        Console.Title = "7- Problema 02"

        Dim valor As Integer

        Console.Write("Ingrese un valor entero: ")
        valor = Console.ReadLine()

        Console.WriteLine(vbCrLf & "-------------------------------------" & vbCrLf)

        If valor > 0 Then
            Console.WriteLine("El número {0} es mayor que cero (positivo).", valor)
        ElseIf valor = 0 Then
            Console.WriteLine("El número {0} es igual cero (nulo).", valor)
        Else
            Console.WriteLine("El número {0} es menor cero (negativo).", valor)
        End If

        Console.ReadKey()
    End Sub
#End Region

End Module
