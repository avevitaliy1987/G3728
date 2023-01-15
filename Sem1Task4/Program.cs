//Задача №4
//Напишите программу, которая на вход принимает
//три числа и выдаетмаксимальное из этих чисел


//выводим запрос на ввод числа
Console.Write("Введите число A  ");
//Считываем данные с консоли 
string? imputNumLine1 = Console.ReadLine();

//выводим запрос на ввод числа
Console.Write("Введите число B  ");
//Считываем данные с консоли 
string? imputNumLine2 = Console.ReadLine();

//выводим запрос на ввод числа
Console.Write("Введите число C  ");
//Считываем данные с консоли 
string? imputNumLine3 = Console.ReadLine();

// Проверяем, чтобы данные не были пустыми
if(imputNumLine1!=null && imputNumLine2!=null && imputNumLine3!=null)
{
// Парсим введенное число
    int imputNumberA = int.Parse(imputNumLine1);
  
    int imputNumberB = int.Parse(imputNumLine2);
   
    int imputNumberC = int.Parse(imputNumLine3);
    
    //задаем условие 
    if(imputNumberA < imputNumberB)
    {
        if(imputNumberB > imputNumberC)
        {
            Console.WriteLine("Максимальное число = - число B = ");
             Console.WriteLine(imputNumLine2);
            }
        
        else
        {
           Console.WriteLine("Максимальное число - число C = "); 
           Console.WriteLine(imputNumLine3);
            
        }

    }
    else
        if(imputNumberA > imputNumberC)
        {
            Console.WriteLine("Максимальное число - число A = ");
            Console.WriteLine(imputNumLine1);
            }
        
        else
        {
            Console.WriteLine("Максимальное число - число C = ");
            Console.WriteLine (imputNumLine3);
           
        }
}
