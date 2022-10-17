// Задача №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

{
    Console.WriteLine("Введите 3 числа ");

    Console.WriteLine("Введите первое число");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    int c = Convert.ToInt32(Console.ReadLine());

    int max = a;

    if (b > max)
    {
        max = b;
    }
    if (max < c)
    {
        max = c;
    }
    Console.Write("Макимальное число: " + max);
}