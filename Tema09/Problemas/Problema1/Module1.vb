Module Module1
    ''' <summary>
    ''' Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
    ''' El valor acumulado de todos los elementos del vector.
    ''' El valor acumulado de los elementos del vector que sean mayores a 36.
    ''' Cantidad de valores mayores a 50.
    ''' </summary>

#Region "clases"
    Class Problema1
        Private ReadOnly elementos(7) As Integer

        Public Sub Cargar()
            Dim f As Integer
            For f = 0 To 7
                Console.WriteLine("Ingrese valor {0}: ", f + 1)
                elementos(f) = Console.ReadLine()
            Next
        End Sub

        Public Sub ValorTotal()
            Dim total As Integer = 0
            Dim f As Integer
            For f = 0 To 7
                total += elementos(f)
            Next
            Console.WriteLine(vbNewLine & "Valor total de los elementos: " & total)

        End Sub

        Public Sub ValorMayores36()
            Dim totalMayores36 As Integer = 0
            Dim f As Integer
            For f = 0 To 7
                If (elementos(f) > 36) Then
                    totalMayores36 += elementos(f)
                End If

            Next
            Console.WriteLine(vbNewLine & "Valor total de los elementos mayores a 36: " & totalMayores36)

        End Sub

        Public Sub CantidadMayores50()
            Dim mayores50 As Integer = 0
            Dim f As Integer
            For f = 0 To 7
                If (elementos(f) > 50) Then
                    mayores50 += 1
                End If

            Next
            Console.WriteLine(vbNewLine & "Cantidad de elementos mayores a 50: " & mayores50)
            Console.ReadKey()

        End Sub

    End Class
#End Region

#Region "main"
    Sub Main()
        Console.Title = "PROBLEMA 1 (15 - Estructura de datos tipo vector)"
        Dim p As New Problema1()

        p.Cargar()
        p.ValorTotal()
        p.ValorMayores36()
        p.CantidadMayores50()
    End Sub
#End Region

End Module
