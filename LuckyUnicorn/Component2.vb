Module Component2
    ''' <summary>
    '''     Lucky Unicorn Decomposition Task 2
    '''    generate a random token from a list and display it for the user
    ''' </summary>
    ''' <author> Mr. M </author>
    ''' <date> 20Jun19 </date>
    Sub Main()
        ' Housekeeping
        For counter As Integer = 1 To 15
            Dim token As String = GetToken()
            Console.WriteLine(token)
        Next counter
        Console.ReadLine()

    End Sub

    Function GetToken() As String
        Randomize()
        Dim tokens() As String = {"Horse", "Zebra", "Donkey", "Unicorn"}
        Static Dim rand As Random = New Random
        Dim index As Integer = rand.Next(0, 4)

        Return tokens(index)
    End Function

End Module
