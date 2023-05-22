// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введие второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введие третье целое число");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"{number1} - наибольшее число");
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"{number2} - наибольшее число");
}
else
{
    Console.WriteLine($"{number3} - наибольшее число");
}