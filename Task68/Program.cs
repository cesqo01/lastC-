/*
Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
// Честно говоря я сам в шоке что сделал эту домашку, но тут все работает :)
// С рекурсией еще не в лучших отношениях

int AccermanFunc(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return AccermanFunc(n - 1, 1);
    }
    else return AccermanFunc(n - 1, AccermanFunc(n, m - 1));
}

int EnterNubmer(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int n = EnterNubmer("Enter N");
int m = EnterNubmer("Enter M");
Console.Write($"A({n},{m}) => {AccermanFunc(n,m)}");