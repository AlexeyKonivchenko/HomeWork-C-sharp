// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



Console.Clear();

int[] CreateRandomArray(int size, int start, int end)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, 100, 999);
ShowArray(array);
int count = 0;
for (int i = 0; i < size; i++)
{

    if (array[i] % 2 == 0)
    {
        count++;
    }
}
if (count == 1)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"В массиве {count} четное число");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"В массиве {count} четных чисел");
}