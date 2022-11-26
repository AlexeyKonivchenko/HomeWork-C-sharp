// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
Console.WriteLine("Введите колличество строк в массиве:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество рядов в массиве");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число массива:");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число массива:");
int end = Convert.ToInt32(Console.ReadLine());

int max = 0;
int[,] array = CreateArray(rows, columns, start, end);
ShowArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int k = j + 1; k < array.GetLength(1); k++)
        {
            if (array[i, j] < array[i, k])
            {
                max = array[i, k];
                array[i, k] = array[i, j];
                array[i, j] = max;
            }
        }
    }
}
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine();
ShowArray(array);