// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



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
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите интервал массива:");
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, start, end);
ShowArray(array);
int sum = 0;
for (int i = 1; i < size; i += 2)
{
    sum += array[i];
}
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Сумма элементов массива стоящих на нечетных позициях = {sum}.");