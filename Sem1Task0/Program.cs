//Задача № 0
//Напишите программу, которая на вход принимает
//число и выдает его квадрат (число умноженное на само себя)

//считываем данные с консоли
string? inputNum = Console.ReadLine();


{
    // парсим введенное число
    int number = int.Parse(inputNum);
    //Находим квадрат числа
    int result = number*number;


    //выводим данные в консоль
    Console.WriteLine(result);

}