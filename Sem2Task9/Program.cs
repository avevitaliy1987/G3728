// Задача № 9
//Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

//Вариант 1
System.Random numSintezator = new System.Random();

int rndNum = numSintezator.Next(10, 100);
Console.WriteLine("Случайное число: " + rndNum);

int digit1 = rndNum / 10;
int digit2 = rndNum % 10;

if (digit1 > digit2)
{
    Console.WriteLine("Цифра 1 больше цифры 2: " + digit1 + " " + digit2);
}
else
{
    Console.WriteLine("Цифра 2 больше цифры 1: " + digit1 + " " + digit2);
}

//Вариант 2
// System.Random numSintezator = new System.Random();
// char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
// Console.WriteLine(digits);
// int digit1 = (int)digits[0]-48;
// int digit2 = (int)digits[1]-48;
// int resNum = digit1>digit2?digit1:digit2;
// Console.WriteLine(resNum);


