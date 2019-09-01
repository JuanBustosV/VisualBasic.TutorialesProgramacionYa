Module Module1
    ''' <summary>
    ''' De un operario se conoce su sueldo y los años de antigüedad. Se pide confeccionar un programa que lea los datos de entrada e informe:
    ''' a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
    ''' b)Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
    ''' c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios. 
    ''' </summary>

#Region "main"
    Sub Main()
        Console.Title = "PROBLEMA 6 (8 - Estructuras condicionales con condiciones compuestas y operadores lógicos)"

        Dim sueldo As Single
        Dim antiguedad As Integer

        Console.Write("Ingrese sueldo: ")
        sueldo = Console.ReadLine()

        Console.Write("Ingrese antigüedad: ")
        antiguedad = Console.ReadLine()

        If sueldo < 500 AndAlso antiguedad >= 10 Then
            Dim aumento As Single
            Dim sueldoTotal As Single

            aumento = sueldo * 0.2
            sueldoTotal = sueldo + aumento
            Console.WriteLine(vbNewLine & "Sueldo a pagar con aumento del 20%: " & sueldoTotal)
        Else
            If sueldo < 500 Then 'antiguedad < 10
                Dim aumento As Single
                Dim sueldoTotal As Single
                aumento = sueldo * 0.05
                sueldoTotal = sueldo + aumento
                Console.WriteLine(vbNewLine & "Sueldo a pagar con aumento del 5%: " & sueldoTotal)
            Else
                Console.WriteLine(vbNewLine & "Sueldo a pagar: " & sueldo)
            End If

        End If

        Console.WriteLine(vbNewLine & "Presione cualquier tecla para salir...")
        Console.ReadKey()
    End Sub

#End Region

End Module
