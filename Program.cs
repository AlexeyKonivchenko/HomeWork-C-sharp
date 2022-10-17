// Задача №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
{
    Console.WriteLine("Введите 2 числа для их сравнения");
int num1;
int num2;

Console.WriteLine("Введите первое число - ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число - ");
num2 = Convert.ToInt32(Console.ReadLine());

bool nums1 = num1 > num2;
bool nums2 = num1 == num2;
bool nums3 = num1 < num2;

if (nums1)
{
    Console.WriteLine($"Число {num1} больше чем {num2}");
}
if (nums2)
{
    Console.WriteLine($"Числа {num1} и {num2} равны");
}
else
{
    Console.WriteLine($"Число {num2} больше чем {num1}");
}
}