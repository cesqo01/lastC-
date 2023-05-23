/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


int DoThreeDigitNumber(int num)
{
    if (num / 100 > 0)
    {
        int thirdDigitNumber = num;
        while (thirdDigitNumber >= 1000)
        {
            thirdDigitNumber = thirdDigitNumber / 10;
        }
        return thirdDigitNumber;
    }
    else return 0; // можно сделать новую булеву функция для проверки что у числа определенное количество цифр (на будущее (когда-то(наверно)))
}

int ThirdDigit(int num1)
{
    num1 = num1 % 10;
    return num1;
}


Console.WriteLine("Введите число");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int thirdDigitNum = DoThreeDigitNumber(number);
if (thirdDigitNum > 0)
{
    int thirdDigitNum1 = ThirdDigit(thirdDigitNum);
    Console.WriteLine($"Третья цифра - {thirdDigitNum1}");
}
else Console.WriteLine("Третьего числа нет");

// if (number / 100 > 0)
// {
//     int thirdDigit = number;
//     while (thirdDigit >= 1000)
//     {
//         thirdDigit = thirdDigit / 10;
//     }
//     thirdDigit = (thirdDigit % 100) % 10;
//     Console.WriteLine($"Третья цифра числа {number} - {thirdDigit}");

// }
// else Console.WriteLine("Третьей цифры нет");




