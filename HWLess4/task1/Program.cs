// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



Console.Clear();

void Pow(int numberA, int numberB)
{
    int result = numberA;
    if (numberB == 0)
        result = 1;

    else if (numberB > 1)
    {
        for (int i = 2; i <= numberB; i++)
        {
            result *= numberA;
        }
    }
    Console.WriteLine($"Число {numberA} возведенное в степень {numberB} = {result}.");
}

Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B < 0)
{

    Console.WriteLine("Второе число должно быть положительным.");

}
else
{
    Pow(A, B);
}