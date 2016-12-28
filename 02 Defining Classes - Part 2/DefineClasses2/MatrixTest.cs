namespace DefineClasses2
{
    using Matrix;
    using System;

    [Version("2.11")]
    class MatrixTest
    {
        [Version("1.2")]
        public static void Run()
        {
            var m1 = new int[,]
            {
                { 2, 3, 4},
                { 3, 0, 5},
                { 5, 6, 2 }
            };
            var m2 = new int[,]
            {
                { 1, 1, 4},
                { 3, 2, 6},
                { 4, 2, 7 }
            };
            var firstMatrix = new Matrix<int>(m1);
            var secondmatrix = new Matrix<int>(m2);

            Console.WriteLine("--- Display the created matrices ---");
            Console.WriteLine();            
            Console.WriteLine($@"Matrix 1: 
{firstMatrix}

Matrix 2: 
{secondmatrix}
");

            Console.WriteLine("--- Demonstrate indexer ---");
            Console.WriteLine();
            Console.WriteLine("The elements at index [1, 1] in Matrix 1 is: {0}", firstMatrix[1, 1]);
            Console.WriteLine("The elements at index [1, 1] in Matrix 2 is: {0}", secondmatrix[1, 1]);
            Console.WriteLine();

            Console.WriteLine("--- Sum of Matrix 1 and Matrix 2 ---");
            Console.WriteLine();
            Console.WriteLine(firstMatrix + secondmatrix);
            Console.WriteLine();

            Console.WriteLine("--- Subtraction of Matrix 1 and Matrix 2 ---");
            Console.WriteLine();
            Console.WriteLine(firstMatrix - secondmatrix);
            Console.WriteLine();

            Console.WriteLine("--- Multiplication of Matrix 1 and Matrix 2 ---");
            Console.WriteLine();
            Console.WriteLine(firstMatrix * secondmatrix);
            Console.WriteLine();

            Console.WriteLine("--- Are there zero elements? ---");
            Console.WriteLine();
            Console.WriteLine(@"In Matrix 1: {0}
In Matrix 2: {1}", !(bool)firstMatrix, !(bool)secondmatrix);
            Console.WriteLine();
        }
    }
}