Module Module1
    '27784932 is valid for testing'
    Sub Main()
        Dim accountNumber As String
        Dim validNumber As Boolean = False
        Dim number, weighting, sum As Integer

        While validNumber = False
            Console.Write("Enter a valid 8-digit bank account number: ")
            accountNumber = Console.ReadLine()
            sum = 0
            weighting = 8

            If IsNumeric(accountNumber) = True And accountNumber.Length = 8 Then
                'Console.WriteLine("Is numbers")'
                validNumber = True
                For Each digit In accountNumber
                    'Console.WriteLine(digit)'
                    number = CInt(CStr(digit))
                    sum += number * weighting
                    weighting -= 1
                Next
            Else
                validNumber = False
                Console.WriteLine("enter a numerical value")
            End If

            If sum Mod 11 <> 0 Then
                Console.WriteLine("bad numbers")
                validNumber = False
            End If

        End While

        Console.WriteLine("Your bank account number has been accepted!")
        Console.ReadLine()
    End Sub


End Module
