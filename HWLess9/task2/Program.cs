// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();


Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    Console.WriteLine("Необходимо поменять местами числа!");
    Console.Write($"Результат между {n} и {m} = ");
    SumBetweenNumbers(n, m, 0);
}
else
{
    Console.Write($"Результат между {n} и {m} = ");
    SumBetweenNumbers(m, n, 0);
}

void SumBetweenNumbers(int start, int end, int sum)
{
    sum += end;
    if (end <= start)
    {
        Console.WriteLine($" {sum} ");
        return;
    }
    SumBetweenNumbers(start, end - 1, sum);
}
