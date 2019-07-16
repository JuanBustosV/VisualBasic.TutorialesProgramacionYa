Module Module1

    Sub Main()
        Dim horasTrabajadas As Integer
        Dim costoHora As Single
        Dim sueldo As Single

        Console.Title = "Cálculo Sueldo"

        Console.Write("Ingrese Horas trabajadas por el operario:")
        horasTrabajadas = Console.ReadLine()
        Console.Write("Ingrese el pago por hora:")
        costoHora = Console.ReadLine()
        sueldo = horasTrabajadas * costoHora
        Console.Write("El sueldo total del operario es:")
        Console.Write(sueldo)
        Console.ReadKey()
    End Sub

End Module
