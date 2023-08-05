int[,] matrix1 = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] matrix2 = new int[,] { { 3, 4 }, { 3, 3 } };
int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

for (int i = 0; i < matrix1.GetLength(0); i++)
{

    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
    
        int sum = 0;
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            sum += matrix1[i, k] * matrix2[k, j];
        }

        result[i, j] = sum;
    }
}

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}