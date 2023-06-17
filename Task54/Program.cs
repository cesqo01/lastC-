/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

void SortMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int temp = matr[i, k];
                    matr[i, k] = matr[i, k + 1];
                    matr[i, k + 1] = temp;
                }
            }
        }
    }
}

// void SortArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         for (int j = 0; j < arr.Length - i - 1; j++)
//         {
//             if (arr[j] > arr[j + 1]) Swap(arr[j], arr[j + 1]);
//         }
//     }
// }

// void SortMatrixRow(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
//             {
//                 if (matrix[i, k] > matrix[i, k + 1]) Swap(matrix[i, k], matrix[i, k + 1]);
//             }
//         }
//     }
// }

void Swap(int elem1, int elem2)
{
    int temp = elem1;
    elem1 = elem2;
    elem2 = temp;
}

// void SortArray(int[] array)
// {
//     for (int i = 1; i < array.Length; i++)
//     {
//         for (int j = 0; j < array.Length - i; j++)
//         {
//             if (array[j] < array[j + 1])
//             {
//                 Swap(array[j], array[j + 1]);
//             }
//         }
//     }
// }

// void SortRowsMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         int length = matr.GetLength(1);
//         for (int j = 0; j < length - 1; j++)
//         {
//             for (int k = 0; k < length - j - 1; k++)
//             {
//                 if (matr[i, k] < matr[i, k + 1])
//                 {
//                     int temp = matr[i, k];
//                     matr[i, k] = matr[i, k + 1];
//                     matr[i, k + 1] = temp;
//                 }
//             }
//         }
//     }
// }

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
}


int[,] matrix = CreateMartrix(4, 4, 1, 10);
Console.WriteLine();
PrintMatrix(matrix);
SortMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);


