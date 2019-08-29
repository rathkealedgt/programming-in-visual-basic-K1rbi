Module Component5

    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 5
    '''     Get initial amount from user and check that it is valid.
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
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
        Total = Console.ReadLine

        While KeepGoing = ""
            '  imput a token manualy 
            Console.WriteLine("Please ent a token")
        Token = Console.ReadLine


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
