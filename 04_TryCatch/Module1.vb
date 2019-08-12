''' <summary>
'''     This program asks the user for a number until they enter a number between 1 and 10.
''' </summary>
''' <author> Mr M </author>
''' <date> 13Jun19 </date>
Module Module1

    Sub Main()
        Dim UserResponse As Integer
        UserResponse = integerCheck(1, 5)
        Console.WriteLine("You entered the valid number {0}", UserResponse)
        Console.ReadLine()
    End Sub

    Function integerCheck(LowNumber As Integer, HighNumber As Integer) As Integer
        'Housekeeping
        Dim UserResponse As Integer
        Const ERROR_MESSAGE As String = "whoops! Please enter an integer"
        Dim ValidInput As Boolean = False
        Dim OUTPUT_MESSAGE As String = String.Format("Please enter an integer between {0} and {1}.", LowNumber, HighNumber)
        While Not ValidInput
            Try
                ' Ask user for a number and store it.
                Console.WriteLine(OUTPUT_MESSAGE)
                UserResponse = Console.ReadLine()

                If LowNumber <= UserResponse And UserResponse <= HighNumber Then
                    ValidInput = True
                End If



            Catch ex As Exception
                Console.WriteLine(ERROR_MESSAGE)
                Console.WriteLine()

            End Try
        End While

        ' Pause the program to view output.
        Return UserResponse
        'Dim OutPut As String = String.Format("You entered the number {0}", UserResponse.ToString)
        'Console.WriteLine(OutPut)
        'Console.ReadLine()


    End Function


End Module
