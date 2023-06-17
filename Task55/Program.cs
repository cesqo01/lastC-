/*
Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}

// int[,] ArrayCopy(int[,] arr)
// {
//     int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             newArr[i, j] = arr[i, j];
//         }
//     }
//     return newArr;
// }

void SwapRowsColumns(int[,] matrix)
{
    int[,] clone = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            clone[i, j] = matrix[i, j];
        }
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = clone[j, i];
        }
    }
}

bool IsMatrixSquare(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1)) return true;
    return false;
}

int[,] matr = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matr);
Console.WriteLine();
if (IsMatrixSquare(matr))
{
    SwapRowsColumns(matr);
    PrintMatrix(matr);
}
else
{
    Console.WriteLine("Matrix isn't square!");
}