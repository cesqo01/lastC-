/*
Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

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

int[] InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) arr[i] = arr[i] * -1;
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

int[] array = CreateArrayRndInt(20,-100,100);
PrintArray(array);
Console.WriteLine("");
InverseArray(array);
PrintArray(array);