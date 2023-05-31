/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int Sum(int num)
{
    int remains;
    int sum = 0;
    while (num != 0)
    {
        remains = num % 10;
        sum = sum + remains;
        num = num / 10;
    }
    return sum;
}

int Start(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(Sum(Start("Введите число")));