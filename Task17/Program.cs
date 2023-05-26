/*
17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.
*/

Console.WriteLine("Введите координату Х");
int xCoor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Х: {xCoor}");
Console.WriteLine("Введите координату Y");
int yCoor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Y: {yCoor}");
int quarter = Quarter(xCoor, yCoor);
string result = quarter > 0 ? $"Указанные координаты соответствуют четверти -> {quarter}"
: "Введены некорректные координаты";
Console.WriteLine(result);
// if (quarter == 0)
// {
//     Console.WriteLine("Вы ввели 0");
// }
// else Console.WriteLine($"Четверть - {quarter}");

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}


//if ((x > 0 || x < 0) && (y > 0 || y < 0))