Console.Clear();
Console.Write("Введите порядковый номер дня недели: ");

int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        day = 1;
        Console.WriteLine("Введенное число соответствует понедельнику");
        break;
    case 2:
        day = 2;
        Console.WriteLine("Введенное число соответствует вторнику");
        break;
    case 3:
        day = 3;
        Console.WriteLine("Введенное число соответствует среде");
        break;
    case 4:
        day = 4;
        Console.WriteLine("Введенное число соответствует четвергу");
        break;
    case 5:
        day = 5;
        Console.WriteLine("Введенное число соответствует пятнице");
        break;
    case 6:
        day = 6;
        Console.WriteLine("Введенное число соответствует субботе");
        break;
    case 7:
        day = 7;
        Console.WriteLine("Введенное число соответствует воскресенью");
        break;
    default:
        Console.WriteLine("Введено некорректное число. Число должно быть от 1 до 7");
        break;
}



Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
Console.WriteLine(number);

if (number / 10 > number % 10)
{
    Console.WriteLine(number / 10);
}
else
{
    Console.WriteLine(number % 10);
}


int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int a = number / 100;
// int b = (number/10)%10;
int c = number % 10;
Console.WriteLine($"{a}{c}");
Console.WriteLine(a * 10 + c);


int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 % number1 == 0)
{
    Console.WriteLine($"Число {number2} кратно {number1}");
}
else
{
    Console.WriteLine($"Число {number2} не кратно {number1}");
}


Console.WriteLine("Please, enter your number");
Int32.TryParse(Console.ReadLine(), out int number);
if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine($"Число {number} делится на 7 и на 23");
}
else
{
    Console.WriteLine($"Число {number} не делится на 7 и на 23");
}


Console.WriteLine("Please, enter your first number");
Int32.TryParse(Console.ReadLine(), out int number1);
Console.WriteLine("Please, enter your second number");
Int32.TryParse(Console.ReadLine(), out int number2);
if (number2 * number2 == number1)
{
    Console.WriteLine($"Число {number1} является квадратом {number2}");
}
else if (number1 * number1 == number2)
{
    Console.WriteLine($"Число {number2} является квадратом {number1}");
}
else
{
    Console.WriteLine($"Ни одно из чисел не является квадратом второго");
}
