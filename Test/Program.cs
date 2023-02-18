//Задание № 1
// Таблица умножения

// for (int i = 2; i <=10; i ++)
// {
//     for (int j = 2; j <=10; j ++)
//     {
//         Console.WriteLine($"{i} * (j) = {i * j}");
//     }
// }


//Задание № 2
// Дан текст. В тексте все пробелы заменить черточками, маленькие 
//быквы "к" заменить большими "К", а большие "С" заменить маленькими "с".
//  
//дан текст?  что значит черточками? Какой алфавит?

// String text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//     +"ежели бы вас послали вместо нашего милого Винценгероде,"
//     +"вы бы взяли приступом согласие прусского короля."
//     +"Вы так красноречивы Вы дадите мне чаю?";

// //string s = "qwerty"
// //            0123
// // s[3]  // r   r стоит на 3 месте.
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int lenght = text.Length;
//     for (int i = 2; i < lenght; i ++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(text, 'С', 'с');
// Console.WriteLine(newText);


// // //Задача № 3 
// // //упорядочивание внутри массива 68321457 поменять на 12345678
// // // Найти позицию с мин элементов в неотсортиров части массива, произвести обмен занчений с первой неотсортиров позицией.
// // //Повторять пока есть неотсортированные элекменты.

// int[] arr = {1, 5, 3, 2, 6, 7, 1, 1};

// //вывод массива на экран
// void PrintArray(int [] array)

// {
//     int count = array.Length;
//     for(int i = 0; i < count; i ++)
//     {
//             Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// //упорядочивание массива
// void SelectionSort(int[] array)
// {
//     for(int i = 0; i < array.Lenght - 1; i++)
//     {
//         int minPosition = i;
//         for(int j = i + 1; j < array.Lenght; j++)
//         {
//             if(array[j] < array[minPosition]) 
//             {
//             minPosition = j;
//             }
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

// --------- ИСПОЛЬЗОВАНИЕ $ либо + при выводе данных в строке ------------

// string firstFriend = "Maria";
// string secondFriend = "Sage";
// Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
// Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
// Console.WriteLine("The name " + secondFriend + " has " + secondFriend.Length + " letters.");

// --------- ОБПЕЗКА ПРОБЕЛОВ В СТРОКЕ - TRIM, TRIMSTART,TRIMEND ------------

// string greeting = "      Hello World!       ";
// Console.WriteLine($"[{greeting}]");

// string trimmedGreeting = greeting.TrimStart();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.TrimEnd();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.Trim();
// Console.WriteLine($"[{trimmedGreeting}]");

// // --------- ЗАМЕНА ТЕКСТА  - REPLACE ------------
// // --------- ЗАМЕНА БУКВ НА СТРОЧНЫЕ ИЛИ ЗАГЛАВНЫЕ  - TOUPPER,TOLOWER ------------

// string sayHello = "Hello World!";
// Console.WriteLine(sayHello);
// sayHello = sayHello.Replace("Hello", "Greetings");
// Console.WriteLine(sayHello);
// Console.WriteLine(sayHello.ToUpper());
// Console.WriteLine(sayHello.ToLower());

// // --------- ПОИСК ТЕКСТА В СТРОКЕ - Contains ------------


// string songLyrics = "You say goodbye, and I say hello";
// Console.WriteLine(songLyrics.Contains("goodbye"));
// Console.WriteLine(songLyrics.Contains("greetings"));

// string songLyrics = "You say goodbye, and I say hello";
// Console.WriteLine(songLyrics.StartsWith("You"));
// Console.WriteLine(songLyrics.EndsWith("hello."));





//задаем количество строк и столбцов. [,] - обозначает, что массив двумерный.
// string[,] table = new string[2,5];
//задаем наименование массива и нхождение элемента в нем - 1 строка и 2 столбец. 
//Вся таблица table [0,0] .... table[0,4]
//            table [1,0] .... table[1,4]

// table[1,2] = "слово";
// //заводим счетчик
// for(int rows = 0; rows <2; rows++)
// {
//     for(int columns=0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }





//--------------определяем двумерный массив с 3 строками и 4 столбцами------------------
// int[,] matrix = new int[3, 4];
// // щелкаем строки
// for (int i = 0; i<3; i++)
// {
// //щелкаем столбца
//     for(int j = 0; j<4; j++) 
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }  
// // принудительный переход на новую строку
// Console.WriteLine();
// }







//=============метод вывода двумерной таблицы на экран и заполнения числами------------

// void PrintArray(int[,] matr)
// {

// // щелкаем строки. И определяем количество строк.0 -означает количество строк.
// for (int i = 0; i < matr.GetLength(0); i++)
// {
// //щелкаем столбцы. И определяем количество столбцов.1 -означает количество столбцов.
//     for(int j = 0; j < matr.GetLength(1); j++) 
//     {
//         Console.Write($"{matr[i, j]} ");
//     }  
// // принудительный переход на новую строку
// Console.WriteLine();
// }
// }
// //сам метод заполнения числами матрицы
// void FillArray(int[,] matr)
// {
//     for(int i = 0; i< matr.GetLength(0); i++) 
//     {
//         for(int j = 0; j < matr.GetLength(1); j++) 
//         {
//             matr[i,j] = new Random().Next(1,10); // задаем интервал от 1 до 10
//         }
//     }
// }

// int[,] matrix = new int[3, 4];

// //вывод пустого массива
// PrintArray(matrix);
// FillArray(matrix);

// //вывод заполненного массива
// Console.WriteLine();
// PrintArray(matrix);




// ---------------Рекурсия перебор всех вариантов из заданных симоволов----------------

int n = 1;

void FindWords (string alphabet, char[] word, int lenght = 0)
{
    if (lenght == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }

    for (int i = 0; i < alphabet.Length; i++)

    {
    word[lenght] = alphabet[i];
    FindWords(alphabet, word, lenght +1);

    }
}

FindWords ("фисв", new char[5]);