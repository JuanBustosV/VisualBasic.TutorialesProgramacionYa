Module Module1
#Region "Método Main"
    ''' <summary>
    ''' Se carga una fecha (día, mes y año) por teclado. Mostrar un mensaje si corresponde al primer trimestre del año (enero, febrero o marzo) Cargar por teclado el valor numérico del día, mes y año.
    ''' Ejemplo: dia:10 mes:1 año:2016. 
    ''' </summary>
    Sub Main()
        Console.Title = "8 - Operador Or"

        Dim dia, mes, año As Integer

        Console.Write("Ingrese nro de día:")
        dia = Console.ReadLine()
        Console.Write("Ingrese nro de mes:")
        mes = Console.ReadLine()
        Console.Write("Ingrese nro de año:")
        año = Console.ReadLine()

        If mes = 1 Or mes = 2 Or mes = 3 Then
            Console.Write("Corresponde al primer trimestre")
        End If
        Console.ReadKey()
    End Sub
#End Region
End Module
