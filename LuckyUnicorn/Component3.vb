Module Component3
    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 2
    '''    generate a random token from a list and display it for the user
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
    Sub Main()
        ' Housekeeping
        Const HOW_MUCH As Integer = 100
        Dim CountUnicorns As Integer = 0
        Dim Countzebhor As Integer = 0
        Dim CountDonkey As Integer = 0



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

        Console.WriteLine(vbNewLine & "**** win/ loss calculations **** ")
        Console.WriteLine(String.Format("      Unicorns = {0}", CountUnicorns))
        Console.WriteLine(String.Format("      zebra / horses = {0}", Countzebhor))
        Console.WriteLine(String.Format("      donkey = {0}", CountDonkey))
        Console.ReadLine()

    End Sub
    'TO do
    'set start  amount
    'choose 100 tokens - play 100 rounds 
    'count the number of unicorns and multiply by 5
    'count the number of zebra/horse and multiply by 0.5
    'count the number of donkey
    'calculate total won/lost
    Function GetToken() As String
        Randomize()
        Dim tokens() As String = {"Horse", "Zebra", "Donkey", "Unicorn"}
        Static Dim rand As Random = New Random
        Dim index As Integer = rand.Next(0, 4)

        Return tokens(index)
    End Function
End Module
