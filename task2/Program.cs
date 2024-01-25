// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4

//Для начала нужно задать комманду на создание двумерного массива
int[,] Generate2dArray(int x, int y)
{
    Random Any = new Random();
    int[,] array = new int[x,y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Any.Next(1,10); 
        }
    }
    return array;
}

//Теперь нужно задать функцию на выполнение задачи
int FindMasterNumberSum(int[,] array)
{
    int sum = 0;
    int length = array.GetLength(0);
    if(array.GetLength(0) > array.GetLength(1))
    {
        length = array.GetLength(1);
    }
    for (int i = 0; i < length; i++)
    {
        sum = sum + array[i,i];
    }
    return sum;
}

//Осталось сделать функцию которая выводит двумерный массив
void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}
// Теперь осталось проверить код

int[,] array = Generate2dArray(4,6);
Write2dArray(array);
Console.WriteLine(FindMasterNumberSum(array));
