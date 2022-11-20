// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.WriteLine("Введите данные b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите данные k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите данные b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите данные k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = Convert.ToDouble((b2 - b1) / (k1 - k2));
double y = Convert.ToDouble(k2 * x + b2);

if (k1 == k2)
{
    Console.WriteLine("Линии не пересекаются. Повторите попытку!");
}
else
{
    Console.WriteLine($"Линии пересекаются в координатах({Math.Round(x,1)}; {Math.Round(y,1)})");
}
