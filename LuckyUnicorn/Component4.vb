Module Component4
    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 4
    '''     Get initial amount from user and check that it is valid.
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
    Public Sub Payout()
        ' house keeping
        Dim Total As Double = 10.0
        'assume starting amount - 10
        Dim Token As String = ""
        Dim Feedback As String = ""



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
        Else
            Total -= 0.5  ' - otherwise, minus 0.5
            Feedback = "you won 50 cent."
        End If




        'display output based on winnings 
        Console.WriteLine(Feedback)

        'display new total 
        Console.WriteLine(String.Format("you have ${0} to play with", Total))
        Console.ReadLine()
    End Sub
End Module
