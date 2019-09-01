Module Module1

    Public Class PruebaVector1

        Private ReadOnly sueldos(4) As Integer

        Public Sub Cargar()
            Dim f As Integer
            For f = 0 To 4
                Console.Write("Ingrese importe del sueldo {0}: ", f + 1)
                sueldos(f) = Console.ReadLine()
            Next
        End Sub

        Public Sub Imprimir()
            Dim f As Integer
            For f = 0 To 4
                Console.WriteLine(sueldos(f))
            Next
            Console.WriteLine(vbNewLine & "Se mostraron {0} sueldos.", f)
            Console.ReadKey()
        End Sub

    End Class

    Sub Main()
        Console.Title = "15 - Estructura de datos tipo vector, Problema 1"

        Dim pv As New PruebaVector1()
        pv.Cargar()
        pv.Imprimir()
    End Sub

End Module

