// Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.

bool PalinTest(int n)
{
    bool res = false;
    int digit1 = n / 10000;
    int digit2 = n / 1000 % 10;
    int digit3 = n / 10 % 10;
    int digit4 = n % 10;
    res = ((digit1 == digit4) && (digit2 == digit3));
    return res;
}

Console.WriteLine("Введите пятизначное число:");

char[]digit = (Console.ReadLine()??"0").ToCharArray();

if(digit.Length == 5)
{
    Console.WriteLine(PalinTest(int.Parse(digit)));
//    Console.WriteLine(digit[4]);
}

else
{
    Console.WriteLine("Ошибка: Введенное число не пятизначное.");
}

    