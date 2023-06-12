/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет
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
}

bool CheckElement(int row, int column, int[,] matr)
{
    if (row >= matr.GetLength(0) || column >= matr.GetLength(1)) return false;
    if (row < 0 || column < 0) return false;
    return true;
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] matrix = CreateMartrix(5, 7, 10, 40);
PrintMatrix(matrix);
Console.WriteLine();
int y = EnterNumber("Введите строку");
int x = EnterNumber("Введите столбик");
Console.WriteLine();
Console.WriteLine(CheckElement(y, x, matrix) ? $"Элемент массива -> {matrix[y, x]}" : " такого элемента нет");





