Module Module1
    ''' <summary>
    ''' Definir un vector de 5 componentes de tipo Single que representen las alturas de 5 personas.
    ''' Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.
    ''' </summary>

#Region "Clases"
    Public Class PruebaVector2
        Private ReadOnly alturas(4) As Single
        Private promedio As Single = 0

        Public Sub Cargar()
            Dim f As Integer
            For f = 0 To 4
                Console.Write("Ingrese la altura de la persona {0}: ", f + 1)
                alturas(f) = Console.ReadLine()
            Next
        End Sub

        Public Sub CalcularPromedio()
            Dim suma As Single
            suma = 0
            Dim f As Integer
            For f = 0 To 4
                suma += alturas(f)
            Next
            promedio = suma / 5
            Console.WriteLine(vbNewLine & "Promedio de alturas: " & promedio & " m.")
        End Sub

        Public Sub MayoresMenores()
            Dim may, men As Integer
            may = 0
            men = 0
            Dim f As Integer
            For f = 0 To 4
                If alturas(f) > promedio Then
                    may += 1
                Else
                    If alturas(f) < promedio Then
                        men += 1
                    End If
                End If
            Next
            Console.WriteLine(vbNewLine & "Cantidad de personas mayores al promedio: " & may)
            Console.WriteLine("Cantidad de personas menores al promedio: " & men)
            Console.ReadKey()
        End Sub
    End Class
#End Region

#Region "Main"
    Sub Main()
        Console.Title = "15 - Estructura de datos tipo vector, Problema 2"

        Dim pv2 As New PruebaVector2()
        pv2.Cargar()
        pv2.CalcularPromedio()
        pv2.MayoresMenores()
    End Sub
#End Region

End Module

