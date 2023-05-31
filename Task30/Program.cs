/*
Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
// int[] array = new int[8];
// int[] array1 = new int[8] { 2, 5, 6, 5, 7, 2, 5, 1 };
// int[] array2 = new int[] { 2, 5, 6, 5, 7, 2, 5, 1 };
// int[] array3 = { 2, 5, 6, 5, 7, 2, 5, 1 };
// var array4 = new int[8];

int[] array = new int[8];

int[] result = FillArray(array);

PrintArray(result);

void PrintArray(int[] arr)
{
    Console.WriteLine("");
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine("");
}

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;
}

// int CreateRandom()
// {
//     return new Random().Next(2);
// }
// void FillArray(int[] array)
//             {
//                 var rnd = new Random();
//                 for (int i = 0; i < array.Length; i++)
//                 {
//                     array[i] = rnd.Next(2);
//                 }
//             }


//             void PrintArray(int[] array)
//             {
//                 for (int i = 0; i < array.Length; i++)
//                 {
//                     Console.Write(array[i] + " ");
//                 }
//             }

//             int[] array1 = new int[8];
//             FillArray(array1);
//             PrintArray(array1);

