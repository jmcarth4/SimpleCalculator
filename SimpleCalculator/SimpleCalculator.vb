'Jessica McArthur
'RCET0265
'Spring 2020
'Say My Name
'UrleSFSdf;j

Option Explicit On
Option Strict On

Module SimpleCalculator

    Sub Main()
        'Variables declared
        Dim userResponse As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim operation As String
        Dim result As Integer

        'User picks the first and second number.
        Console.WriteLine("Please enter a number")
        userResponse = Console.ReadLine()
        firstNumber = CInt(userResponse)

        Console.WriteLine("Please enter another number")
        userResponse = Console.ReadLine()
        secondNumber = CInt(userResponse)

        'User picks a operation
        Console.WriteLine("Please choose an operation + or * ")
        operation = Console.ReadLine()

        'The choosen numbers and operation are processed.
        If operation = "+" Then
            result = firstNumber + secondNumber
        ElseIf operation = "*" Then
            result = firstNumber * secondNumber
        End If

        'The choosen numbers operation and results are displayed to the user
        Console.WriteLine($" {firstNumber} {operation} {secondNumber} = {result}")
        Console.ReadLine()


    End Sub

End Module
