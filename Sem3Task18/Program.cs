// Задача №18
//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

int Num = ReadData("Введите номер четверти");
PrintQuterTest(coordx,coordy);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
// Метод определяет четверть по координатам точки
void PrintQuterTest(int Num)
{
    if (Num == 1)(coordx > 0 && coordy > 0) Console.WriteLine(coordx > 0 && coordy > 0)
    if(Num == 2)(coordx > 0 && coordy < 0) Console.WriteLine(coordx > 0 && coordy < 0)
    if(Num == 3)(coordx < 0 && coordy < 0) Console.WriteLine(
    if(Num == 4)(coordx < 0 && coordy > 0) Console.WriteLine
}




if(Num == 1)
{
    Console.WriteLine(" x > 0, y > 0");
}

if(Num == 1)
{
    Console.WriteLine(" x > 0, y > 0");
}

if(Num == 1)
{
    Console.WriteLine(" x > 0, y > 0");
}

if(Num == 1)
{
    Console.WriteLine(" x > 0, y > 0");
}




// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод определяет четверть по координатам точки
void PrintQuterTest()
{
    if(coordx > 0 && coordy > 0) Console.WriteLine("Точка в четверти 1 ");
    if(coordx > 0 && coordy < 0) Console.WriteLine("Точка в четверти 2 ");
    if(coordx < 0 && coordy < 0) Console.WriteLine("Точка в четверти 3 ");
    if(coordx < 0 && coordy > 0) Console.WriteLine("Точка в четверти 4 ");
}
