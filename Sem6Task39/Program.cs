// Задача №39
//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на
//первом месте, а первый - на последнем и т.д.)


//задаем метод генерации массива, где len - длина массива, 
//max - максимальное число в массиве,  min-минимальное число в массиве
int[] Gen1DArray(int len, int max, int min)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    // задаем неотрицательное случайное целое число от min до max
    {      
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

// задаем метод вывода данных в массиве через запятую в квадратных скобках
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//задаем метод подсчета суммы чисел массива, которые расположены на нечетных позициях
void ChangeArr(int[] arr)
{   
    
    // int temp=0;
    // делим когда на 2, мы ограничиваем работу счетчика на половине массива.
    for(int i=0;i<arr.Length/2;i++)

        //  используем формулу взаимной замены переменной (x,y) = (y,x)
        (arr[i], arr[arr.Length-1-i]) = (arr[arr.Length-1-i], arr[i]);
        
        // temp=arr[i];
        // //меняем первый элемент на последний
        // arr[i]=arr[arr.Length-1-i];
        // // меняем последний элемент на первый
        // arr[arr.Length-1-i]=temp;
    
}
  
//задаем массив с переменным именем и параметры значений для запуска метода (длина массива, мах числе и мин число),
// чтобы определить длину массима и ограничить его заданными числами.
int[] writeArr = Gen1DArray(16, 100, 1);
Print1DArr(writeArr);
ChangeArr(writeArr);
Console.WriteLine();
Print1DArr(writeArr);