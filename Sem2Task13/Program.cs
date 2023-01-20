// Задача 13
// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.


//Вариант вывода третьей цифры от правого края

// int num = int.Parse(Console.ReadLine()??"0");

// if(num < 99)

// {
//     Console.WriteLine("Третьей цифры нет");
// }

// else

// {
//     int res = num/100;
//     res = res%10;

// Console.WriteLine(res);
// }



//Вариант вывода третьей цифры от левого края

char[]digit = (Console.ReadLine()??"0").ToCharArray();

if(digit.Length >= 3)
{
    Console.WriteLine(digit[2]);
}

else
{
    Console.WriteLine("Третьей цифры нет");
}
