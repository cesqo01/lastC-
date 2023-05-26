/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
// Да простят меня все боги программирования за этот "GODCODE" 
int CountCompares(int num)  // Я Сломал мозг помогите!!!!! Это типа количество итераций сравнения НО ЗАЧЕМ ????????????????
{
    if (num / 10 > 0 && num / 10 < 10 || (num / 100 > 0 && num / 100 < 10)) return 1;
    if (num / 1000 > 0 && num / 1000 < 10 || (num / 10000 > 0 && num / 10000 < 10)) return 2;
    if (num / 100000 > 0 && num / 100000 < 10 || (num / 1000000 > 0 && num / 1000000 < 10)) return 3;
    if (num / 10000000 > 0 && num / 10000000 < 10 || (num / 100000000 > 0 && num / 100000000 < 10)) return 4;
    if (num / 100000000 > 0 && num / 100000000 < 10 || (num / 1000000000 > 0 && num / 1000000000 < 10)) return 5;
    if (num / 1000000000 > 0 && num / 1000000000 < 10 || (num / 10000000000 > 0 && num / 10000000000 < 10)) return 6;
    if (num / 10000000000 > 0 && num / 10000000000 < 10 || (num / 100000000000 > 0 && num / 100000000000 < 10)) return 7;
    if (num / 100000000000 > 0 && num / 100000000000 < 10 || (num / 1000000000000 > 0 && num / 1000000000000 < 10)) return 8;
    if (num / 1000000000000 > 0 && num / 1000000000000 < 10 || (num / 10000000000000 > 0 && num / 10000000000000 < 10)) return 9;
    if (num / 10000000000000 > 0 && num / 10000000000000 < 10 || (num / 100000000000000 > 0 && num / 100000000000000 < 10)) return 10;
    return 0;
}

string TrueOrFalse(int numb)  // мб можно в bool завернуть
{
    if (numb > 0 && numb < 10) return "Yes";
    int count = CountCompares(numb);
    int countConst = CountCompares(numb);
    int start = 1;
    while (start <= countConst) // ОН ТУТ БЕСПОЛЕЗЕН
    {
        if (countConst == 1)
        {
            if (numb / 10 > 0 && numb / 10 < 10)
            {
                if (numb % 10 == numb / 10) return "Yes";
                return "No";
            }
            else if (numb / 100 > 0 && numb / 100 < 10)
            {
                if (numb % 100 == numb / 100) return "Yes";
                return "No";
            }
        }
        else if (countConst == 2)
        {
            if (numb / 1000 > 0 && numb / 1000 < 10)
            {
                if (numb % 10 == numb / 1000 && (numb % 10) % 10 == ((numb % 10) % 10) % 10) return "Yes";
                return "No";
            }
            else if (numb / 10000 > 0 && numb / 10000 < 10)
            {
                if (numb % 10 == numb / 10000 && (numb % 10) % 10 == (((numb % 10) % 10) % 10) % 10) return "Yes";
                return "No";
            }
        }
        else return "I dont know"; // я сдался 
    }
    return "i dont know";

}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = EnterNumber("Введите число");
string result = TrueOrFalse(number);
Console.WriteLine(result); // *моральная боль* 


