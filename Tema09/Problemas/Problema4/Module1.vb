Module Module1
    ''' <summary>
    ''' Cargar un vector de 10 elementos y verificar posteriormente si el mismo está ordenado de menor a mayor.
    ''' </summary>

#Region "clases"
    Class Problema4
        Private ReadOnly vector(9) As Single

        Public Sub Cargar()
            Dim f As Integer
            For f = 0 To 9
                Console.Write("Ingrese valor {0}: ", f + 1)
                vector(f) = Console.ReadLine()
            Next

        End Sub

        Public Sub VerificarOrdenado()
            Dim ordenado As Boolean = True
            Dim f As Integer = 0

            While ordenado = True AndAlso f < 8
                If (vector(f + 1) < vector(f)) Then
                    ordenado = False
                End If
                f += 1
            End While

            If ordenado Then
                Console.WriteLine(vbNewLine & "El vector está ordenado de menor a mayor.")
            Else
                Console.WriteLine(vbNewLine & "El vector no está ordenado de menor a mayor.")
            End If

            Console.WriteLine(vbNewLine & "Presione cualquier tecla para terminar...")
            Console.ReadKey()
        End Sub

    End Class
#End Region

#Region "main"
    Sub Main()
        Console.Title = "PROBLEMA 4 (15 - Estructura de datos tipo vector)"
        Dim p As New Problema4()

        p.Cargar()
        p.VerificarOrdenado()

    End Sub
#End Region

End Module
