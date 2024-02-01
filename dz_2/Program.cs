using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Печать массива
    public static void PrintArray(int[,] array)
    {
        //Напишите свое решение здесь

        // Первый фор для индекса строк
        for (int i = 0; i < array.GetLength(0); i++)
        {
            // Второй фор для индекса столбцов
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                // Вывод на экран
                Console.Write(array[i, j] + "\t");
            }
        }
    }

    // Обмен первой с последней строкой
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        //Напишите свое решение здесь

        int FirstRow = 0;
        // Индекс последний строки
        int LastRow = array.GetLength(0) - 1;

        // Цикл который пробегает по числу элементов в строке
        for (int i = 0; i < array.GetLength(1); i++)
        {
            // Мы из одной строки берём значение, кладём его в буфер, на его место кладём значение из другой строки, а туда кладём значение из буфера как бы поменяв их местами
            int buff = array[FirstRow, i];
            array[FirstRow, i] = array[LastRow, i];
            array[LastRow, i] = buff;
        }
        // Возврат массива
        return array;
    }

    // Обмен элементами массива
    public static void SwapItems(int[,] array, int i)
    {
        //Напишите свое решение здесь
    }

    public static void PrintResult(int[,] numbers)
    {
        //Напишите свое решение здесь
        PrintArray( SwapFirstLastRows(numbers));
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}