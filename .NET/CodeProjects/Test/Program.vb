Module Module1

    Sub Main()
        Dim matrix1(3, 3) As Integer
        Dim matrix2(3, 3) As Integer
        Dim matrix3(3, 3) As Integer


        Console.WriteLine("Enter Matrix1: ")
        For i = 0 To 2 Step 1
            For j = 0 To 2 Step 1
                Console.Write("Enter element[{0}][{1}]: ", i, j)
                matrix1(i, j) = (Console.ReadLine())
            Next
        Next

        Console.WriteLine("Enter Matrix2: ")
        For i = 0 To 2 Step 1
            For j = 0 To 2 Step 1
                Console.Write("Enter element[{0}][{1}]: ", i, j)
                matrix2(i, j) = (Console.ReadLine())
            Next
        Next

        'Add Matrix1 and Matrix2
        For i = 0 To 2 Step 1
            For j = 0 To 2 Step 1
                matrix3(i, j) = matrix1(i, j) + matrix2(i, j)
            Next
        Next

        Console.WriteLine("Matrix1: ")
        For i = 0 To 2 Step 1
            For j = 0 To 2 Step 1
                Console.Write("{0} ", matrix1(i, j))
            Next
            Console.WriteLine()
        Next

        Console.WriteLine("Matrix2: ")
        For i = 0 To 2 Step 1
            For j = 0 To 2 Step 1
                Console.Write("{0} ", matrix2(i, j))
            Next
            Console.WriteLine()
        Next
        Console.WriteLine("Addition of Matrix1 and Matrix2: ")
        For i = 0 To 2 Step 1
            For j = 0 To 2 Step 1
                Console.Write("{0} ", matrix3(i, j))
            Next
            Console.WriteLine()
        Next

        Console.ReadLine()
    End Sub

End Module