using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
        //Напишите свое решение здесь
        // Заранее задаем массив длиной количеством строк входного двумерного массива
        int[] Result = new int[array.GetLength(0)];
        // Первый фор для обеспечения прохода по индексам строк
        for (int i = 0; i < array.GetLength(0); i++)
        {
            // Второй фор для обеспечения прохода по индексам столбцов
            for (int j = 0; j < array.GetLength(1); j++)
            {
                // В результирующий одномерный в элемент с индексом строки суммируем значения строки входного массива
                Result[i] += array[i, j];
            }
        }
        // возврат результата
        return Result;
    }

    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    {
        // Присваиваем для старта цикла в минимальное значение 
        int MinimalValue = array[0];
        // Так же кладём в доп переменную индекс значения
        int MinimalIndex = 0;
        // Фор для прохода по каждому значнению в массиве
        for (int i = 0; i < array.GetLength(0); i++)
        {
            // Если по текущему индексу значение меньше,чем в зарезервированном, то мы их меняем местами и сохраняем индекс строки
            if (array[i] < MinimalValue)
            {
                MinimalValue = array[i];
                MinimalIndex = i;
            }
        }
        // Возврат индекса строки
        return MinimalIndex;
    }
    public static void PrintResult(int[,] numbers)
    {
        //Напишите свое решение здесь
        Console.WriteLine(MinIndex(SumRows(numbers)));
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

                numbers = new int[,] {
                // {1, 2, 3},
                // {4, 5, 6},
                // {7, 8, 9},
                // {10, 11, 12}
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
    };
            }
            UserInputToCompileForTest.PrintResult(numbers);
        }
    }
}