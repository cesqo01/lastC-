﻿/* 12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если первое число не кратно
второму, то программа выводит остаток от деления.;
*/
int Remainder(int num1, int num2)
{
    int rem = num1 % num2;
    return rem;
}

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);
if (remainder == 0)
{
    Console.WriteLine($"Число {number1} кратно числу {number2}");
}
else
{
    Console.WriteLine($"Число {number1} не кратно числу {number2}. Остаток от деления - {remainder}");
}