/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] CreateArrayRndDouble(int size, int min, int max, int round = 2)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }

    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

// double Difference(double[] arr) ТАК ПРИНЯТО ?? ДВА ЦИКЛА В ОДНОМ МЕТОДЕ
// { 
//     double max = arr[0];
//     double min = arr[0];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > max) max = arr[i];
//     }

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] < min) min = arr[i];
//     }
//     return max - min;
// }

double MaxElem(double[] arr) 
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinElem(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double Difference(double max, double min)
{
    double diff = Math.Round(max - min, 2);
    return diff;
}

double[] array = CreateArrayRndDouble(10, 1, 30);
PrintArrayDouble(array);
Console.WriteLine($" => {MaxElem(array)} - {MinElem(array)} = {Difference(MaxElem(array), MinElem(array))}"); //[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76