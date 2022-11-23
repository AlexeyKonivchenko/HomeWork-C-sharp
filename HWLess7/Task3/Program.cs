// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.WriteLine("Введите колличество строк в массиве: ");
int linesize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество рядов в массиве: ");
int rowsize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое числло массива: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее числло массива: ");
int end = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomArray(linesize, rowsize, start, end);
ShowArray(array);
FindAverage(array);

int[,] CreateRandomArray(int lines, int rows, int min, int max)
{
    int[,] myArray = new int[lines, rows];
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return myArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }
}

double FindAverage(int[,] array)
{
    double average = 0;
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        average = Convert.ToDouble(sum / array.GetLength(0));
        if (i == array.GetLength(1) - 1) Console.Write($"{average:f1}.");
        else Console.Write($"{average:f1}; ");
    }
    return average;
}