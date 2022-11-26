// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] ProductMatrix(int[,] firstMaxtrix, int[,] secondMaxtrix)
{
    int[,] prodMatrix = new int[firstMaxtrix.GetLength(0), secondMaxtrix.GetLength(1)];
    Console.ForegroundColor = ConsoleColor.Blue;
    for (int i = 0; i < firstMaxtrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMaxtrix.GetLength(0); j++)
        {
            for (int k = 0; k < secondMaxtrix.GetLength(1); k++)
            {
                prodMatrix[i, k] += firstMaxtrix[i, j] * secondMaxtrix[j, k];
            }
        }
    }
    return prodMatrix;
}

Console.WriteLine("Введите количество строк в первой матрице:");
int firstmatrixrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество рядов в первой матрице:");
int firstmatrixcolumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число первой матрицы:");
int firstmatrixstart = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число первой матрицы:");
int firstmatrixend = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк во второй матрице:");
int secondmatrixrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество рядов во второй матрице:");
int secondmatrixcolumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число во второй матрице:");
int secondmatrixstart = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число во второй матрице:");
int secondmatrixend = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] firstMaxtrix = CreateArray(firstmatrixrows, firstmatrixcolumns, firstmatrixstart, firstmatrixend);
int[,] secondMaxtrix = CreateArray(secondmatrixrows, secondmatrixcolumns, secondmatrixstart, secondmatrixend);
if (firstMaxtrix.GetLength(1) != secondMaxtrix.GetLength(0))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Количество строк в первой матрице должно совподать с количество рядов второй матрицы!.");
}
else
{
    ShowArray(firstMaxtrix);
    Console.WriteLine();
    ShowArray(secondMaxtrix);
    int[,] productMatrix = ProductMatrix(firstMaxtrix, secondMaxtrix);
    Console.WriteLine();
    ShowArray(productMatrix);
}