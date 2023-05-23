/*
11. Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
*/

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");
int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    return firstDigit * 10 + secondDigit;
}
int qq = DeleteSecondDigit(number);
Console.WriteLine($"Число без второй цифры -> {qq}");