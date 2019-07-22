Module Module1

#Region "Método Main"
    ''' <summary>
    ''' Un postulante a un empleo, realiza un test de capacitación, se obtuvo la siguiente información: cantidad total
    ''' de preguntas que se le realizaron y la cantidad de preguntas que contestó correctamente. Se pide confeccionar 
    ''' un programa que ingrese los dos datos por teclado e informe el nivel del mismo según el porcentaje de respuestas
    ''' correctas que ha obtenido, y sabiendo que:
    ''' Nivel máximo:	Porcentaje>=90%.
    ''' Nivel medio:	Porcentaje>=75% y menor 90%.
    ''' Nivel regular:	Porcentaje>=50% y menor 75%.
    ''' Fuera de nivel:	Porcentaje menor que 50%.
    ''' </summary>
    Sub Main()
        'TODO Tarea1: Relizar problema
        Console.Title = "7- Problema 04"

        Dim cantPreguntas, cantRespuestasCorrectas As Integer
        Dim porcentaje As Single

        Console.Write("Introcuzca el número de preguntas del Test: ")
        cantPreguntas = Console.ReadLine()

        Console.Write("Introcuzca el número de respuestas correctas: ")
        cantRespuestasCorrectas = Console.ReadLine()

        'Calculo porcentaje
        porcentaje = cantRespuestasCorrectas * 100 / cantPreguntas

        Console.WriteLine(vbCrLf & "-------------------------------------" & vbCrLf)

        If porcentaje >= 90 Then
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Nivel Máximo (%:{0} >= 90%)", porcentaje)
            Console.ResetColor()
        Else
            If porcentaje >= 75 Then
                Console.WriteLine("Nivel Medio (%:{0} [75%, 90%))", porcentaje)
            Else
                If porcentaje >= 50 Then
                    Console.WriteLine("Nivel Regular (%:{0} [50%, 75%))", porcentaje)
                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Fuera de nivel! (%:{0} < 50%)", porcentaje)
                    Console.ResetColor()
                End If
            End If
        End If

        Console.WriteLine(vbCrLf & "-------------------------------------" & vbCrLf)

        Console.ReadKey()

    End Sub
#End Region
End Module
