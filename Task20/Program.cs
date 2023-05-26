/*A1(x1,y1) A2(x2,y2)
A1A2 
Math.Sqrt(Math.Sqrt)
double d = Math.Sqrt(5); корень из числа
double dRound = Math.Round(d, 2, MidpointRounding.Tozero); округление до двух знаков
Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите координату Х1");
int x1Coor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Х1: {x1Coor}");
Console.WriteLine("Введите координату Y1");
int y1Coor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Y1: {y1Coor}");
Console.WriteLine("Введите координату Х2");
int x2Coor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Х2: {x2Coor}");
Console.WriteLine("Введите координату Y2");
int y2Coor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Y2: {y2Coor}");

double dRound = Distance(x1Coor, y1Coor, x2Coor, y2Coor);
double result = Math.Round(dRound, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точкми -> {result}");

double Distance(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return distance;
}
// int EnterCoordinate(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// double Distance(int x1, int y1, int x2, int y2)
// {
//     return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
// }


// int xOfA = EnterCoordinate("Enter x for A");
// int yOfA = EnterCoordinate("Enter y for A");
// int xOfB = EnterCoordinate("Enter x for B");
// int yOfB = EnterCoordinate("Enter y for B");

// double result = Distance(xOfA, yOfA, xOfB, yOfB );

// System.Console.WriteLine("Distance between dots: ");
// System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));