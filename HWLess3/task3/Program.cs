// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
void Check(int number)
{
    int n5 = number / 10000;
    int n4 = number / 1000 % 10;
    int n1 = number % 10;
    int n2 = n4 % 10;
    if (n5 == n1)
    {
        if (n4 == n2)
        {
            Console.WriteLine($"Число {number} палиндром");
        }
    }
    else
    {
        Console.WriteLine($"Число {number} не палиндром");
    }
}

Console.WriteLine("Введите число из пяти цифр:");
int number = Convert.ToInt32(Console.ReadLine());
Check(number);