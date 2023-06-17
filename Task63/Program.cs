/*
Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumbers(int num)
{
    if(num == 0) return;
    NaturalNumbers (num - 1);
    Console.Write($"{num} ");
}

int number = EnterNumber("Введите натурально число");
NaturalNumbers(number);

