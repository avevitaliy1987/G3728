// Задача №32
//Напишите программу замена элементов массива: положительные 
//элементы замените на соответствующие отрицательные, и наоборот.



// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }


//метод генерации массива
int[] Gen1DArr(int num, int begin, int end)

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

void InvArr(int[] arr)
{
    for(int i = 0; i < arr.Length;i++)
    {
        arr[i]*=-1;
        }
}
int[] testArr = Gen1DArr(12,-9,9);
Print1DArr(testArr);
InvArr(testArr);
Print1DArr(testArr);
