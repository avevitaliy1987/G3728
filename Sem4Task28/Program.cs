// Задача №28
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N (факториал).

//подключение необходимых функций - BigInteger
using System.Numerics;

//метод читает данные от пользователя
int ReadData (string msg)

{
        Console.WriteLine(msg);
        return int.Parse(Console.ReadLine() ?? "0");
}
// Выводим результат пользователя
void PrintData(string msg1, BigInteger msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}


//функция принимает число n
BigInteger CalcFact(int num)
{
// задаем переменную
    BigInteger res = 1;

    for(int i = 1; i<=num; i++)
    {
       res = res * i;
    }
    return res;
}
int number = ReadData("Ввеите число: ");

BigInteger fact = CalcFact(number);

PrintData("Факториал равен: ", fact);

