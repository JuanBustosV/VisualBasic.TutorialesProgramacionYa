Module Module1
    ''' <summary>
    ''' Una planta que fabrica perfiles de hierro posee un lote de n piezas.
    ''' Confeccionar un programa que pida ingresar por teclado la cantidad de piezas a procesar y luego ingrese la longitud de cada perfil;
    ''' sabiendo que la pieza cuya longitud esté comprendida en el rango de 1,20 y 1,30 son aptas. Imprimir por pantalla la cantidad de piezas
    ''' aptas que hay en el lote. 
    ''' </summary>

#Region "main"

    Sub Main()
        Console.Title = "Problema 4: 09 - Estructura repetitiva Do While (condición) ... Loop"

        Dim x, cantidad, n As Integer
        Dim largo As Single
        x = 1
        cantidad = 0
        Console.Write("Cuantas piezar procesará: ")
        n = Console.ReadLine()

        Console.WriteLine()
        Do While x <= n
            Console.Write("Ingrese la medida de la pieza: ")
            largo = Console.ReadLine()
            If largo >= 1.2 And largo <= 1.3 Then
                cantidad += 1
            End If
            x += 1
        Loop
        Console.Write(vbNewLine & "La cantidad de piezas aptas son: ")
        Console.Write(cantidad)
        Console.ReadKey()
    End Sub

#End Region

End Module

