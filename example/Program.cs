// Console.Clear();
// Console.Write("Введите порядковый номер дня недели: ");

// int day = Convert.ToInt32(Console.ReadLine());

// switch (day)
// {
//     case 1:
//         day = 1;
//         Console.WriteLine("Введенное число соответствует понедельнику");
//         break;
//     case 2:
//         day = 2;
//         Console.WriteLine("Введенное число соответствует вторнику");
//         break;
//     case 3:
//         day = 3;
//         Console.WriteLine("Введенное число соответствует среде");
//         break;
//     case 4:
//         day = 4;
//         Console.WriteLine("Введенное число соответствует четвергу");
//         break;
//     case 5:
//         day = 5;
//         Console.WriteLine("Введенное число соответствует пятнице");
//         break;
//     case 6:
//         day = 6;
//         Console.WriteLine("Введенное число соответствует субботе");
//         break;
//     case 7:
//         day = 7;
//         Console.WriteLine("Введенное число соответствует воскресенью");
//         break;
//     default:
//         Console.WriteLine("Введено некорректное число. Число должно быть от 1 до 7");
//         break;
// }



// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int number = new Random().Next(10, 100);
// Console.WriteLine(number);

// if (number / 10 > number % 10)
// {
//     Console.WriteLine(number / 10);
// }
// else
// {
//     Console.WriteLine(number % 10);
// }


// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int a = number / 100;
// // int b = (number/10)%10;
// int c = number % 10;
// Console.WriteLine($"{a}{c}");
// Console.WriteLine(a * 10 + c);


// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number2 % number1 == 0)
// {
//     Console.WriteLine($"Число {number2} кратно {number1}");
// }
// else
// {
//     Console.WriteLine($"Число {number2} не кратно {number1}");
// }


// Console.WriteLine("Please, enter your number");
// Int32.TryParse(Console.ReadLine(), out int number);
// if ((number % 7 == 0) && (number % 23 == 0))
// {
//     Console.WriteLine($"Число {number} делится на 7 и на 23");
// }
// else
// {
//     Console.WriteLine($"Число {number} не делится на 7 и на 23");
// }


// Console.WriteLine("Please, enter your first number");
// Int32.TryParse(Console.ReadLine(), out int number1);
// Console.WriteLine("Please, enter your second number");
// Int32.TryParse(Console.ReadLine(), out int number2);
// if (number2 * number2 == number1)
// {
//     Console.WriteLine($"Число {number1} является квадратом {number2}");
// }
// else if (number1 * number1 == number2)
// {
//     Console.WriteLine($"Число {number2} является квадратом {number1}");
// }
// else
// {
//     Console.WriteLine($"Ни одно из чисел не является квадратом второго");
// }

// задача 13 дз

// Console.WriteLine("Введите номер: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(Math.Abs(number) > 99)
// {
//     while(Math.Abs(number) > 999)
//     {
//         number = number / 10;
//     }
//     int thirdNum = number % 10;
//     Console.WriteLine(thirdNum);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет в числе");
// }


// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Clear();

// void Coordinate(int Quarter)

// {
//     if (Quarter == 1)
//     {
//         Console.WriteLine("x >0 and y >0");
//     }

//     else if (Quarter == 2)
//     {
//         Console.WriteLine("x < 0 and y >0");
//     }

//     else if (Quarter == 3)
//     {
//         Console.WriteLine("x < 0 and y <0");
//     }
//     else if (Quarter == 4)
//     {
//         Console.WriteLine("x > 0 and y <0");
//     }
//     else
//     {
//         Console.WriteLine("Некорректная четверть");
//     }

// }

// Console.WriteLine("Введите номер четверти");
// int Quarter = Convert.ToInt16(Console.ReadLine());

// Coordinate(Quarter);

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// d = √(xb - xa)2 + (yb - ya)2


// Console.Clear();
// double Distance(int x1, int y1, int x2, int y2)
// {
//     double s = 0;
//     s = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//     return s;
// }
// Console.WriteLine("enter coordinate");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());

// double distance = Distance(x1, y1, x2, y2);

// Console.WriteLine(Math.Round(distance, 3));


// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.Clear();

// void sqr(int N)
// {
//     if (N > 0)
//     {
//         int count = 1;
//         while (count < N)
//         {
//             int result = count * count;
//             Console.Write(result + ", ");
//             count++;
//         }
//         Console.Write(N * N);
//     }
//     else
//     {
        // Console.WriteLine("Введите число больше 1");
//     }
// }
// Console.WriteLine("enter number");
// int N = Convert.ToInt32(Console.ReadLine());
// sqr(N);


{Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) *  1.0), 0.5)}"
