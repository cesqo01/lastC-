/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = EnterNumber($"Введите {i + 1}й элемент");
    }
    return array;
}

void PrintArray(int[] arr)

{
    
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
}

int CountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count += 1;
    }
    return count;
}

int EnterNumber(string message)

{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int count = EnterNumber("Введите количество чисел");
int[] array = CreateArray(count);
PrintArray(array);
int countPositive = CountPositive(array);
Console.WriteLine($" -> {countPositive}");
