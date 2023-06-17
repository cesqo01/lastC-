/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 
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

int[,] SpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = ij + 1;
        }
    }

    for (int j = 3; j < 4; i++)
    {
        for (int i = 1; i < rows; i++)
        {
            int k = 05;
            matrix[i,j] = k;
            k++;
        }
    }




    return matrix;
}