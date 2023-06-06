/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double[] DotCrossing(double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 1);
    double y = Math.Round(k1 * x + b1, 1);
    double[] array = { x, y };
    return array;
}

string CrossingExist(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            return ("The lines are identical");

        }

        return ("The lines are parallel");
    }
    return $"Точка пересечения прямых -> ";
}

double EnterNumber(string message)

{
    Console.WriteLine(message);
    double num = Math.Round(Convert.ToDouble(Console.ReadLine()), 1);
    return num;
}

void PrintArray(double[] arr)
{

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"({arr[i]}; ");
    }
    Console.Write($"{arr[arr.Length - 1]})");
}

double b1 = EnterNumber("Введите коэффициент первой прямой");
double k1 = EnterNumber("Введите угловой коэффициент первой прямой");
double b2 = EnterNumber("Введите коэффициент второй прямой");
double k2 = EnterNumber("Введите угловой коэффициент второй прямой");
Console.Write(CrossingExist(b1, k1, b2, k2));
double[] array = DotCrossing(b1, k1, b2, k2);
PrintArray(array);

