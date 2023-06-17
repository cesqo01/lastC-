/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] CreateMartrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)

{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiplicationMatrixes(int[,] matrixA, int[,] matrixB)
{
    int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(1); k++)
            {
                result[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return result;
}

bool MltpExist(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(0) == matrix2.GetLength(1);
}

int[,] matrixA = CreateMartrix(2, 2, 2, 4);
PrintMatrix(matrixA);
int[,] matrixB = CreateMartrix(2, 2, 2, 4);
PrintMatrix(matrixB);

if (MltpExist(matrixA, matrixB))
{
    int[,] mltpAB = MultiplicationMatrixes(matrixA, matrixB);
    PrintMatrix(mltpAB);
}
else Console.WriteLine("Muliplication doesn't exist");