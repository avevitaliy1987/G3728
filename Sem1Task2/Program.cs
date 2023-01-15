//Задача №2
//Напишите программу, которая на вход принимает
//два числа и выдает, какое число больше, а какое меньше

//выводим запрос на ввод числа
Console.Write("Введите число А  ");
//Считываем данные с консоли 
string? imputNumLine1 = Console.ReadLine();
//выводим запрос на ввод числа
Console.Write("Введите число Б  ");
//Считываем данные с консоли 
string? imputNumLine2 = Console.ReadLine();


// Проверяем, чтобы данные не были пустыми
if(imputNumLine1!=null && imputNumLine2!=null)
{
// Парсим введенное число
    int imputNumberA = int.Parse(imputNumLine1);
  
    int imputNumberБ = int.Parse(imputNumLine2);
    

    //задаем условие 
    if(imputNumberA < imputNumberБ)
    {
     Console.WriteLine("Число Б больше числа А");
    }
    else
    {
     Console.WriteLine("Число А больше числа Б");
    }
    
}

