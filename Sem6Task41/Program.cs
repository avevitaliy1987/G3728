// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


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

int SumNum(int[] arr, int numinput)
{   
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {   
                    
        if(arr[i]>0 && arr[i]<numinput)
        {
            sum = sum + 1;
        }
    }
    return sum;
}

int arrLen = ReadData("Введите длину массива: ");
int[] arr = Gen1DArr(arrLen, -20, 20);
Print1DArr(arr);
int sumq = ReadData("Введите число для рассчета: ");
int solut = SumNum(arr, sumq);
Console.WriteLine(solut);


