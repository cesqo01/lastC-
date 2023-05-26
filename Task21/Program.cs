/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int EnterCoordinate(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}


int xOfA = EnterCoordinate("Enter x for A");
int yOfA = EnterCoordinate("Enter y for A");
int zOfA = EnterCoordinate("Enter z for A");
int xOfB = EnterCoordinate("Enter x for B");
int yOfB = EnterCoordinate("Enter y for B");
int zOfB = EnterCoordinate("Enter z for B");
double result = Distance(xOfA, yOfA, zOfA, xOfB, yOfB, zOfB);

System.Console.WriteLine("Distance between dots: ");
System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));