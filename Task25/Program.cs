/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Exponent(int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}

int FirstDigit(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SecondDigit(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(Exponent(FirstDigit("Введите число"), SecondDigit("Введите степень числа")));