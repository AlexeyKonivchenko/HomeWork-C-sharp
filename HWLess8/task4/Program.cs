// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.WriteLine("Введите размер квадратного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] newArray = CreateZeroArray(n);
int i = 1;
int x = 0;
int y = -1;
int step_row = 0;
int step_column = 1;

while (i <= Math.Pow(n, 2))
{
    if (x + step_row >= 0 && x + step_row < n && y + step_column >= 0 && y + step_column < n && newArray[x + step_row, y + step_column] == 0)
    {
        x += step_row;
        y += step_column;
        newArray[x, y] = i;
        i++;
    }
    else
    {
        if (step_column == 1)
        {
            step_column = 0;
            step_row = 1;
        }
        else if (step_row == 1)
        {
            step_row = 0;
            step_column = -1;
        }
        else if (step_column == -1)
        {
            step_column = 0;
            step_row = -1;
        }
        else if (step_row == -1)
        {
            step_row = 0;
            step_column = 1;
        }
    }
}

ShowArray(newArray);

int[,] CreateZeroArray(int n)
{
    int[,] array = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = 0;
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }
}