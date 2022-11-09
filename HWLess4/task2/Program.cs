// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");

int num = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 3; i >= 0; i--)
{
    sum += num / (int)Math.Pow(10.0, i);
    num = num % (int)Math.Pow(10.0, i);
}
Console.WriteLine($"Сумма цифр введенного числа = {sum}");


