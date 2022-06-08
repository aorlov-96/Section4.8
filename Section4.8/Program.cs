using System;

namespace homework;

class Program
{
    static void Main()
    {
        #region Задание 1

        Console.WriteLine("Введите количество строк");
        int line = int.Parse(Console.ReadLine()); // Запрашиваю количество строк добавляю в переменную
        Console.WriteLine("Введите количество столбцов");
        int column = int.Parse(Console.ReadLine()); // Запрашиваю количество столбцов добавляю в переменную
        int[,] array = new int[line, column]; // создаю массив по введенным значениям
        var rand = new Random();
        int sum = 0;
        for (int i = 0; i < line; i++)
        {
            for (int j = 0; j < column; j++)
            {
                array[i, j] = rand.Next(50);        // инициализирую массив
                Console.Write($"{array[i, j]} "); // вывожу масив на экран
                sum = sum + array[i, j];  // считаю сумму элементов
            }
            Console.WriteLine();

        }
        Console.WriteLine($"Сумма всех элементов = {sum}");






        #endregion

        #region Задание 2
        Console.WriteLine("Введите длинну последовательности для проверки");
        int lengthArray = int.Parse(Console.ReadLine()); // добавляю в переменную введенную длинну последовательности
        int[] arraySequence = new int[lengthArray]; // создаю одноерный массив по введенным данным
        int min = int.MaxValue;  // присваиваю минимальномузначению максимум int
        for (int i = 0; i < lengthArray; i++)
        {
            Console.WriteLine("Введите элемент последовательнсти");
            int sequenceElement = int.Parse(Console.ReadLine()); // инициализирую массив с помощью пользователя
            arraySequence[i] = sequenceElement;
            if (arraySequence[i] < min)   // ищу минимальный элемент
                min = arraySequence[i];
        }
        Console.WriteLine($"Минимальный элемент последовательности = {min}");

        #endregion


        #region Задание 3
        Console.WriteLine("Давай сыграем в игру");
        Console.WriteLine("Укажи диапозон а я загадаю число из этого диапозона");
        Console.WriteLine("Затем попробуй уагадать это число");
        Console.WriteLine("Если устали нажмите Enter");
        Console.WriteLine("Введите максимальное число диапозона");
        int maxSize = int.Parse(Console.ReadLine());  
        var random = new Random(); // добавляю максимум диапозона в переменную
        string ent;
        int number = random.Next(maxSize+1); // генерирую число для поиска

        while(true)
        {
            Console.WriteLine("Введи свой вариант");

            ent = Console.ReadLine(); 
            if (ent == string.Empty) // проверка выхода из программы
            {
                Console.WriteLine($"До скорой встречи, загаданное число - {number}");
                break;
            }

            int shot = int.Parse(ent); // преобразование стринга в инт
            
            if (shot == number) // проверка введенного числа 
            { 
                Console.WriteLine($"Поздравляю ты угадал загаданое число {number}");
                break;
            }
            else if (shot > number)
            {
                Console.WriteLine("Загаданное чилсо меньше");

            }
            else
            {
                Console.WriteLine("Загаданное число больше");
            }
                    
            
        }


        #endregion












    }


}

