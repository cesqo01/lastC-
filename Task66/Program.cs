/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumMtoN(int m, int n)
{   
    if(m == n) return 0;
    int sum = 0;
    if (m > n) return sum;
    sum = m + SumMtoN(m + 1, n);
    return sum;
}

int EnterNubmer(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = EnterNubmer("Enter M");
int n = EnterNubmer("Enter N");
Console.Write($"Sum from {m} to {n} => {SumMtoN(m,n)}");