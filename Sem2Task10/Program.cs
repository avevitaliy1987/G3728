//Задача № 10
//Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.

//ввод числа
int num = int.Parse(Console.ReadLine()??"0");

if(num > 999 || num < 100)

{
    Console.WriteLine("Введите трехзначное число");
}

else

{
    int res = num/10;
    res = res%10;

Console.WriteLine(res);
}

