// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введие второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write($"{number1} больше,чем {number2}");
}
else
{
    Console.Write($"{number2} больше,чем {number1}");
}