/*

Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8

int FactorialRec(int n)
 {
     if (n == 1) return 1;
     else return n * FactorialRec(n - 1);
 }

 Console.WriteLine(FactorialRec(10)); // 3628800
*/


int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int EsqNumbers(int num, int expo)
{
    if (expo == 0) return 1;
    return num * EsqNumbers(num, expo - 1);
}


int number = EnterNumber("Enter number");
int exp = EnterNumber("Enter Exponentiation of number");
Console.WriteLine($"{exp} - я степень числа {number} = {EsqNumbers(number, exp)}");