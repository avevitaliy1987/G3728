// Задача 23
//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.


// Ввод данных
Console.Write("Введите N: ");
int num = int.Parse(Console.ReadLine() ?? "0");

// вывод нахождения степени чисел от 1 до N
string LineBuilder(int N,int p)
{    string s = "";
    for (int i = 1; i <= N; i++)
    {
        s+=Math.Pow(i, p).ToString()+"\t ";
    }
  
    return s;}

// Вывод данных
Console.WriteLine(LineBuilder(num,1));
Console.WriteLine(LineBuilder(num,2));
Console.WriteLine(LineBuilder(num,3));