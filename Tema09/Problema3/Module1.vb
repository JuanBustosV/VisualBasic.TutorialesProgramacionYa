Module Module1
    ''' <summary>
    ''' Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y 4 por la tarde)
    ''' Confeccionar un programa que permita almacenar los sueldos de los empleados agrupados por turno.
    ''' Imprimir los gastos en sueldos de cada turno.
    ''' </summary>
    ''' 
#Region "clases"
    Public Class PruebaVector3

        Private ReadOnly turnoMan(3) As Single
        Private ReadOnly turnoTar(3) As Single

        Public Sub Cargar()
            Console.WriteLine("Sueldos de empleados del turno de la mañana.")
            Dim f As Integer
            For f = 0 To 3
                Console.Write("Ingrese sueldo {0}: ", f + 1)
                turnoMan(f) = Console.ReadLine()
            Next
            Console.WriteLine(vbNewLine & "Sueldos de empleados del turno de la tarde.")
            For f = 0 To 3
                Console.Write("Ingrese sueldo {0}: ", f + 1)
                turnoTar(f) = Console.ReadLine()
            Next
        End Sub

        Public Sub CalcularGastos()
            Dim gasman As Single = 0
            Dim gastar As Single = 0
            Dim f As Integer
            For f = 0 To 3
                gasman += turnoMan(f)
                gastar += turnoTar(f)
            Next
            Console.WriteLine(vbNewLine & "Total de gastos del turno de la mañana: " & gasman)
            Console.WriteLine("Total de gastos del turno de la tarde: " & gastar)
            Console.ReadKey()
        End Sub
    End Class
#End Region

#Region "main"
    Sub Main()
        Console.Title = "15 - Estructura de datos tipo vector, Problema 3"

        Dim pv3 As New PruebaVector3()

        pv3.Cargar()
        pv3.CalcularGastos()

    End Sub
#End Region

End Module
