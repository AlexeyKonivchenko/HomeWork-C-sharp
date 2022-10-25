// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();
void sqr(int N)
{
    if (N > 0)
    {
        int count = 1;
        while (count < N)
        {
            int result = count * count * count;
            Console.Write(result + ", ");
            count++;
        }
        Console.Write(N * N * N);
    }
    else
    {
        Console.WriteLine("Введите число от 1 ");
    }
}
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
sqr(N);