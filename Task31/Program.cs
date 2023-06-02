/*
Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
*/

int [] GetSumPositiveNegativeElem(int[] arr)
{
    int sumPositive = 0;
    int sumNegagive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sumPositive += arr[i];
        else sumNegagive += arr[i];
    }
    return new int[] {sumPositive, sumNegagive};
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    Random rnd = new Random();
    int [] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
// int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
// Console.WriteLine("");
// Console.WriteLine($"Сумма плоложительный элементов = {sumPositiveNegativeElem[0]}");
// Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativeElem[1]}");

int sumPositiveElem = GetSumPositiveElem(array);
int sumNegagiveElem = GetSumNegativeElem(array);
Console.WriteLine($"Сумма плоложительный элементов = {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegagiveElem}");
