/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void PrintNumbers(int num)
{
    if (num == 0)
    {
        return;
    }
    else
    {
        Console.Write($"{num} ");
        PrintNumbers(num- 1);
    }
}

int EnterNubmer(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

PrintNumbers(EnterNubmer("Enter Number"));