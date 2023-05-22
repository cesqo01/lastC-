// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введие целое число");
int number = Convert.ToInt32(Console.ReadLine());
int ostatok = number % 2;
if (ostatok == 0)
{
    Console.WriteLine($"{number} - четное число");
}
else
{
    Console.WriteLine($"{number} - нечетное число");
}

