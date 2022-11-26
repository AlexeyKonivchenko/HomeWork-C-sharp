// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] CreateArray(int rows, int columns, int min, int max)
{
    int[,] userArray = new int[rows, columns];
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 0; j < userArray.GetLength(1); j++)
        {
            userArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return userArray;
}

void ShowLowestSummaryLine(int[] array)
{
    int min = array[0];
    int x = 1;
    for (int i = 1; i < array.Length; i++)
    {

        if (array[i] < min)
        {
            min = array[i];
            x = i + 1;
        }

    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Минимальная сумма = {min} и находится в строке № {x}.");
}

void ShowArray(int[,] array)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк в массиве:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество рядов в массиве:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число массива:");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число массива:");
int end = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateArray(rows, columns, start, end);
int[] sum = new int[array.GetLength(0)];
ShowArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum[i] += array[i, j];
    }
    
}

ShowLowestSummaryLine(sum);