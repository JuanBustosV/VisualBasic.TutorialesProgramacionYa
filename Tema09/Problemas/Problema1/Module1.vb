Module Module1
    ''' <summary>
    ''' Escribir un programa que solicite ingresar 10 notas de alumnos y nos informe cuántos tienen notas mayores o iguales a 7 y cuántos menores.
    ''' </summary>

#Region "main"

    Sub Main()
        Console.Title = "PROBLEMA 1 (9 - Estructura repetitiva Do While (condición) ... Loop)"

        Dim nota As Single
        Dim notasMayorISiete As Integer = 0
        Dim notasMenorSiete As Integer = 0
        Dim i As Integer = 0

        Console.WriteLine()
        Do While (i < 10)
            Console.Write("Ingrese nota {0}: ", i + 1)
            nota = Console.ReadLine()

            If nota >= 7 Then
                notasMayorISiete += 1
            Else
                notasMenorSiete += 1
            End If

            i += 1
        Loop

        Console.Write(vbNewLine & "Cantidad de alumnos con notas mayores o iguales a 7: ")
        Console.WriteLine(notasMayorISiete)
        Console.Write("Cantidad de alumons con notas menores a 7: ")
        Console.Write(notasMenorSiete)
        Console.ReadKey()
    End Sub

#End Region

End Module
