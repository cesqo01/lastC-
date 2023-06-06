/*
Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/

//Каждая сторона треугольника меньше суммы двух других сторон

bool TriangleExist(int a, int b, int c)
{
    return a < b + c && b < a + c && c < b + a;
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int side1 = EnterNumber("Введите длину стороны a");
int side2 = EnterNumber("Введите длину стороны b");
int side3 = EnterNumber("Введите длину стороны c");
Console.WriteLine(TriangleExist(side1, side2, side3) ?
"Треугольник может существовать" : "Треугольник не может существовать");