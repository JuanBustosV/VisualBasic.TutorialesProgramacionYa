Module Module1

    Sub Main()
        Dim sueldo As Single
        Console.Write("Ingrese el sueldo:")
        sueldo = Console.ReadLine()
        If sueldo > 3000 Then
            Console.Write("Esta persona debe abonar impuestos")
        End If
        Console.ReadKey()
    End Sub

End Module
