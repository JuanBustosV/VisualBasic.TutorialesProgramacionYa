Module Module1
    ''' <summary>
    ''' Realizar un programa que pida la carga de dos vectores numéricos enteros de 4 elementos. Obtener la suma de los dos vectores,
    ''' dicho resultado guardarlo en un tercer vector del mismo tamaño. Sumar componente a componente.
    ''' </summary>

#Region "clases"
    Class Problema2
        Private ReadOnly vector1(3) As Integer
        Private ReadOnly vector2(3) As Integer
        Private ReadOnly suma(3) As Integer

        Public Sub Cargar()
            Console.WriteLine("Carga del primer vector.")
            Dim f As Integer
            For f = 0 To 3
                Console.Write("Ingrese valor {0}: ", f + 1)
                vector1(f) = Console.ReadLine()
            Next

            Console.WriteLine(vbNewLine & "Carga del segundo vector.")
            For f = 0 To 3
                Console.Write("Ingrese valor {0}: ", f + 1)
                vector2(f) = Console.ReadLine()
            Next

        End Sub

        Public Sub SumarVectores()
            Dim f As Integer
            Console.Write(vbNewLine & "Suma: ")
            For f = 0 To 3
                suma(f) = vector1(f) + vector2(f)
                Console.Write(suma(f) & " ")
            Next
            Console.WriteLine(vbNewLine & "Presione cualquier tecla para terminar...")
            Console.ReadKey()
        End Sub

    End Class
#End Region

#Region "main"
    Sub Main()
        Console.Title = "PROBLEMA 2 (15 - Estructura de datos tipo vector)"
        Dim p As New Problema2()

        p.Cargar()
        p.SumarVectores()

    End Sub
#End Region

End Module

