using System;

class MatrixCalculator
{
    static void Main()
    {
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };

        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("Matrix 2:");
        PrintMatrix(matrix2);

        int[,] sum = AddMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix Sum:");
        PrintMatrix(sum);

        int[,] product = MultiplyMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix Product:");
        PrintMatrix(product);

        Console.ReadLine();
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);
        int[,] sum = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                sum[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return sum;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int columns2 = matrix2.GetLength(1);

        if (columns1 != rows2)
        {
            throw new Exception("Invalid matrix dimensions for multiplication");
        }

        int[,] product = new int[rows1, columns2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                for (int k = 0; k < columns1; k++)
                {
                    product[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return product;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
