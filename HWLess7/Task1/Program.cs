// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Clear();

double[,] CreateArray(int linesize, int rowsize, int start, int end)
{
    double[,] newArray = new double[linesize, rowsize];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            double rnd = new Random().Next(start, end + 1);
            newArray[i, j] = new Random().NextDouble() * (rnd);
        }
    }
    return newArray;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f1}  ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество рядов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте первое число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("задайте последнее число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] UserArray = CreateArray(m, n, min, max);
Console.ForegroundColor = ConsoleColor.DarkGreen;
ShowArray(UserArray);