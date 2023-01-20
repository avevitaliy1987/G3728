// Задача №17
//Напишите программу, которая принимает на вход координаты 
//точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.

int coordx = ReadData("введите координату X");
int coordy = ReadData("введите координату y");
PrintQuterTest();


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