Module component3_v2

    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 2
    '''    generate a random token from a list and display it for the user
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
    Sub Main()
        ' Housekeeping
        Const HOW_MUCH As Integer = 100 'set start  amount
        Dim CountUnicorns As Integer = 0
            Dim Countzebhor As Integer = 0
            Dim CountDonkey As Integer = 0

        'Play desired amount of hands
        'choose 100 tokens - play 100 rounds 
        For counter As Integer = 1 To HOW_MUCH
                Dim token As String = GetToken()

                If token = "Unicorn" Then
                    CountUnicorns += 1

                ElseIf token = "Donkey" Then
                    CountDonkey += 1

                Else
                    Countzebhor += 1

                End If


                Console.WriteLine(token)
            Next counter

        'calculate total won/lost
        Dim Winnings As Double = CountUnicorns * 5 + (Countzebhor * 0.5)
        Console.WriteLine(vbNewLine & String.Format("You spent ${0}", HOW_MUCH.ToString("##0.00")))
        Console.WriteLine("You go home with ${0}", Winnings)


        Console.WriteLine(vbNewLine & "**** win/ loss calculations **** ")
            Console.WriteLine(String.Format("      Unicorns = {0}", CountUnicorns))
            Console.WriteLine(String.Format("      zebra / horses = {0}", Countzebhor))
            Console.WriteLine(String.Format("      donkey = {0}", CountDonkey))
            Console.ReadLine()

        End Sub
    'TO do


    'count the number of unicorns and multiply by 5
    'count the number of zebra/horse and multiply by 0.5
    'count the number of donkey

    Function GetToken() As String
            Randomize()
        Dim tokens() As String = {"Horse", "Horse", "Horse", "Zebra", "Zebra", "Zebra", "Donkey", "Donkey", "Donkey", "Unicorn"}
        Static Dim rand As Random = New Random
        Dim index As Integer = rand.Next(0, 10)

        Return tokens(index)
        End Function


End Module
