/*
Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
*/

void PrintArray(int[] arr)

{

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}");
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

//Array.Sort(arr);

int[] DoArray(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[count] = matrix[i, j];
            count += 1;
        }
    }
    Array.Sort(arr);
    return arr;
}

void CountSameElems(int[] arr)
{
    int count = 1;
    int currentNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == currentNumber) count++;
        else
        {
            Console.WriteLine($"Число {currentNumber} встречается {count} раз");
            currentNumber = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {currentNumber} встречается {count} раз");
}

int[,] matrix = CreateMartrix(5, 4, 2, 8);
PrintMatrix(matrix);
int[] array = DoArray(matrix);
Console.WriteLine();
PrintArray(array);
CountSameElems(array);
