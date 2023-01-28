// Задача 27: Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Выводим результат пользователю
void PrintData(int msg)
{
    Console.WriteLine(msg);
}

// задаем метод
int SumSym(int num)
{
    int res = 0;
//описание функции метода
    while(num>0)
    {
        res=res+num%10;
        num=num/10;
    }
// завершение выполнение метода и возврат результата функции вызвавшему методу
return res;
}

int num = ReadData("Введите число: ");

int sum = SumSym(num);

PrintData(sum);