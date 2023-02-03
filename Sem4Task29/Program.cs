﻿// Задача 29: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.



//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] Gen1DArr(int num, int begin, int end)
//выдача массива
{
    // метод для генерации массива
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int arrLen = ReadData("Введите любое число для вывода массива из 8 элемонтов");
arrLen = 8;

int[] arr = Gen1DArr(arrLen, 0, arrLen);

Print1DArr(arr);



