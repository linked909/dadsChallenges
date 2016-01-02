Module Module1

    Sub Main()
        Dim number As Integer
        Dim counter As Integer

        Console.WriteLine("Welcome to FizzBuzz")
        Console.WriteLine("Pick any Number")
        number = Console.ReadLine()

        For counter = 1 To number
            If number / counter = 3 Then
                Console.Write("Fizz")
            End If
        Next

        For counter = 1 To number
            If number / counter = 5 Then
                Console.WriteLine("Buzz")
            End If
        Next



        Console.ReadLine()

    End Sub

End Module
