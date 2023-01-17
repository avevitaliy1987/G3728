//Задача №11
//Напишите программу, которая выводит случайное трёхзначное 
//число и удаляет вторую цифру этого числа.


System.Random numSintezator = new System.Random();
int Num = numSintezator.Next(100,1000);
Console.WriteLine(Num);
int digit1 = Num/100;
int digit2 = Num%10;
Console.WriteLine(digit1*10 + digit2);



