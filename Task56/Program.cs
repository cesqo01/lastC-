﻿/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[] SumElemsRows(int[,] matrix)
{
    int[] sumArr = new int[matrix.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[i, j];
        }
        sumArr[i] = sum;
        sum = 0;
    }
    return sumArr;
}

void NumberMinRowMatrix(int[] arrSum)
{
    int min = arrSum[0];
    int minIndex = 0;
    for (int i = 0; i < arrSum.Length; i++)
    {
        if (min > arrSum[i])
        {
            min = arrSum[i];
            minIndex = i;
        }
    }
    Console.Write($"Наименьшая сумма элементов находится в {minIndex + 1} - й строке");
}

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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]} ");
}

int[,] matrix = CreateMartrix(4, 4, 1, 10);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
int[] sumRows = SumElemsRows(matrix);
PrintArray(sumRows);
Console.WriteLine();
NumberMinRowMatrix(sumRows);

