/*
Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int SumNumbers(int num)
{
    int sum = 1;
    for (int i = 2; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int Start(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Start("Введите целое положительное число");
if (number <=0)
{
    Console.WriteLine("Nevernoe chislo");
    return;
}
Console.WriteLine(SumNumbers(number));





