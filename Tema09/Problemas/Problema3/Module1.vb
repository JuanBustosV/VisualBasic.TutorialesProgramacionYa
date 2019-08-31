Module Module1
    ''' <summary>
    ''' Se tienen las notas del primer parcial de los alumnos de dos cursos, el curso A y el curso B, cada curso cuenta con 5 alumnos.
    ''' Realizar un programa que muestre el curso que obtuvo el mayor promedio general.
    ''' </summary>

#Region "clases"
    Class Problema3
        Private ReadOnly notasCursoA(4) As Single
        Private ReadOnly notasCursoB(4) As Single
        Private promedioA As Single
        Private promedioB As Single

        Public Sub Cargar()
            Console.WriteLine("Carga notas curso A.")
            Dim f As Integer
            For f = 0 To 4
                Console.Write("Ingrese valor {0}: ", f + 1)
                notasCursoA(f) = Console.ReadLine()
            Next

            Console.WriteLine(vbNewLine & "Carga notas curso B.")
            For f = 0 To 4
                Console.Write("Ingrese valor {0}: ", f + 1)
                notasCursoB(f) = Console.ReadLine()
            Next

        End Sub

        Public Sub CalcularPromedio()
            Dim sumatoriaA As Single = 0
            Dim sumatoriaB As Single = 0
            Dim f As Integer

            For f = 0 To 4
                sumatoriaA += notasCursoA(f)
                sumatoriaB += notasCursoB(f)

            Next

            promedioA = sumatoriaA / 5
            promedioB = sumatoriaB / 5

            Console.WriteLine(vbNewLine & "Promedio curso A: {0}" & vbNewLine & "Promedio curso B: {1}", promedioA, promedioB)

            If promedioA > promedioB Then
                Console.WriteLine("El curso A obtuvo mayor promedio.")
            Else
                Console.WriteLine("El curso B obtuvo mayor promedio.")
            End If

            Console.WriteLine(vbNewLine & "Presione cualquier tecla para terminar...")
            Console.ReadKey()
        End Sub

    End Class
#End Region

#Region "main"
    Sub Main()
        Console.Title = "PROBLEMA 3 (15 - Estructura de datos tipo vector)"
        Dim p As New Problema3()

        p.Cargar()
        p.CalcularPromedio()

    End Sub
#End Region

End Module
