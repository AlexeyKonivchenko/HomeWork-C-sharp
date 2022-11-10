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
    Console.WriteLine($"Number {numberA} to the power of {numberB} is {result}.");
}

Console.WriteLine("Please enter first number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second number: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Second number is incorrect: it must must be 0 or greater.");

}
else
{
    Pow(A, B);
}