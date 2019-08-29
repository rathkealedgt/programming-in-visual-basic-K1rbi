'''<summary> 
'''       fully working program
'''        needs to be tested  for usability
''' </summary>

Module LuckyUnicornV1
    Sub Main()
        Payout()
        'ask how much
        'Grenerate token 
        ' pay out 
        ' end game



    End Sub
    ''' <summary>
    '''     Integer checking function. Checks if user input is an integer between the values given.
    ''' </summary>
    ''' <param name="LowNumber"> Lower bound of the valid range. </param>
    ''' <param name="HighNumber"> Upper bound of the valid range. </param>
    ''' <returns> The valid user input as an integer. </returns>
    Function IntegerCheck(LowNumber As Integer, HighNumber As Integer) As Integer
        'Housekeeping
        Dim UserResponse As Integer
        Const ERROR_MESSAGE As String = "Whoops! Please enter an integer."
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

            End Try

        End While

        ' Pause program to view output.
        Return UserResponse

    End Function



    Function GetToken() As String
        Randomize()
        Dim tokens() As String = {"Horse", "Horse", "Horse", "Zebra", "Zebra", "Zebra", "Donkey", "Donkey", "Donkey", "Unicorn"}
        Static Dim rand As Random = New Random
        Dim index As Integer = rand.Next(0, 10)

        Return tokens(index)
    End Function

    Public Sub Payout()
        'TODO
        ' if total is less than $1, quit
        ' IF total is $1 or more, ask user if they want to keep going.


        ' house keeping
        Dim Total As Double = 0.0    'assume starting amount - 10
        Dim Token As String = ""
        Dim Feedback As String = ""
        Dim KeepGoing As String = ""

        Console.WriteLine("How much would you like to play with?")
        Total = IntegerCheck(1, 10)

        While KeepGoing = ""
            '  imput a token manualy 
            Token = GetToken()


            ' adjust total based on token 

            If Token = "Unicorn" Then ' - if unicorn, add 4
                Total += 4
                Feedback = "Congradulations! You  won $5.00"

            ElseIf Token = "Donkey" Then ' - if donkey minus 1 
                Total -= 1
                Feedback = "Unlucky this time you lost $1.00, try agian next time."
            Else ' - otherwise, minus 0.5
                Total -= 0.5
                Feedback = "you won 50 cent."
            End If




            'display output based on winnings 
            Console.WriteLine(Feedback)

            'display new total 
            Console.WriteLine(String.Format("you have ${0} to play with", Total.ToString("##0.00")))
            Console.WriteLine()

            If Total < 1 Then
                Console.WriteLine("Sorry, you don't have enough money to continue")
                KeepGoing = "END"
            Else
                Console.WriteLine("Press <enter> to play again or any to to quit")
                KeepGoing = Console.ReadLine()
            End If
        End While

        Console.WriteLine("Thanks for playing. :)")
        Console.ReadLine()

    End Sub

End Module
