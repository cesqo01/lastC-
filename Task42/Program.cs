/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
46 -> 101110
13 -> 1101
2 -> 10
*/

int BinaryConvert(int num)
{
    int binary = 0;
    int mult = 1;
    while (num > 0)
    {
        binary = binary + (num % 2 * mult);
        mult = mult * 10;
        num /= 2;
    }

    return binary;
}

int k = BinaryConvert(46);
Console.WriteLine(k);