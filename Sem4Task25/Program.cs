// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int Pow(int a, int b)
{
    int res = 1;
    while(b>0)
    {
        b=b-1;
        res=res*a;
    }
// завершение выполнение метода и возврат результата функции вызвавшему методу
return res;
}

int a = ReadData("Введите первое число А: ");
int b = ReadData("Введите второе число Б: ");

int result = Pow(a, b);

PrintData("Результат возведения числа Ав степень числа Б равен:", result);
