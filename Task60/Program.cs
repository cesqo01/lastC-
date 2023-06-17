/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
которая будет построчно выводить массив,добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)
*/

int[,,] Create3dMartrix(int rows, int columns, int deep)
{
    int[,,] matrix = new int[rows, columns, deep];
    int[] uniqueNums = new int[90];
    uniqueNums[0] = 10;
    for (int i = 1; i < uniqueNums.Length; i++)
    {
        uniqueNums[i] = uniqueNums[i - 1] + 1;
    }
    int p = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                matrix[i,j,k] = uniqueNums[p];
                p++;
            }
        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],5}({i}, {j}, {k})");
            }
        }
        Console.WriteLine();
    }
    
}

int[,,] arr = Create3dMartrix(2,2,2);
Print3DMatrix(arr);
