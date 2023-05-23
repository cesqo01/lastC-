/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int SecondDigit(int num)
{
    int secondDig = (num / 10) % 10;
    return secondDig;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number} - {secondDigit}");
