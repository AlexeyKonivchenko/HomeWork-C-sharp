//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.


Console.Clear();

Console.WriteLine("Введите первое число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1) Console.WriteLine("Число должно быть больше 1.");
else Shownumbers(n);

void Shownumbers(int n)
{
    Console.Write($"{n} ");
    if (n == 1) return;
    Shownumbers(n - 1);
}