/*
Задача 39: Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int[] CreateRndArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

void ArrayReverse(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        // temp = arr[i];
        // arr[i] = arr[arr.Length - 1 - i];
        // arr[arr.Length - 1 - i] = temp;
        Swap(arr, i, arr.Length - 1 - i);
    }
}

void Swap(int[] arr, int firstElem, int lastElem)
{
    int temp = arr[firstElem];
    arr[firstElem] = arr[lastElem];
    arr[lastElem] = temp;
}

int[] array = CreateRndArray(6, 1, 10);
PrintArray(array);
ArrayReverse(array);
PrintArray(array);