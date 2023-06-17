/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7
*/

// void PrintArray(int[] arr)

// {

//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.WriteLine($"{arr[arr.Length - 1]}");
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

int[] MinCoord(int[,] matrix)
{
    int[] coords = new int[2];
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                coords[0] = i;
                coords[1] = j;
            }
        }
    }
    return coords;
}

int[,] RemoveRowColumn(int[,] matrix, int[] arr)
{
    int rows = matrix.GetLength(0) - 1;
    int columns = matrix.GetLength(1) - 1;
    int[,] newMatr = new int[rows, columns];
    for (int i = 0, m = 0; i < rows; i++, m++)
    {
        if (m == arr[0]) m++;

        for (int j = 0, n = 0; j < columns; j++, n++)
        {
            if (n == arr[1]) n++;

            newMatr[i, j] = matrix[m, n];
        }
    }
    return newMatr;
}
    
int[,] matrix = CreateMartrix(4, 4, 1, 10);
Console.WriteLine();
PrintMatrix(matrix);
int[] minCoor = MinCoord(matrix);
int[,] matrq = RemoveRowColumn(matrix, minCoor);
Console.WriteLine();
PrintMatrix(matrq);
