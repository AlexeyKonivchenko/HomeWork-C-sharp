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


// {Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) *  1.0), 0.5)}"





// Console.Clear();
// Console.Write("Введите X1: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите Z1: ");
// int z1 = int.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("Введите Z2: ");
// int z2 = int.Parse(Console.ReadLine());
// double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

// Console.WriteLine($"d={d:f3}");



// int[] array = GetBinaryArray(8);
// Console.WriteLine($" [ {String.Join(",", array)} ] ");


// int[] GetBinaryArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(2);
//     }

//     return result;
// }





// string[] num = number.Split(',');



// Условияhttps://drive.google.com/file/d/1L-0DJEqvLLWJt3narSBmVOzhgjgxCfxl/view?usp=sharing
// Циклыhttps://drive.google.com/file/d/16HeFPlR_eEEVGCGykwUfTJFrnQJsnGHR/view?usp=sharing
// Массивыhttps://drive.google.com/file/d/1PurYbjxB7zBX5s1oxLmgZq7BRE2DRT5v/view?usp=sharing


// Двумерные массивыhttps://drive.google.com/file/d/1AMYk45d4dpJCqHscJ6doUHjG5EqTRWB4/view?usp=sharing


// https://qna.habr.com/q/519776
// https://docs.google.com/presentation/d/1a61-mEq8z9CS2XRe5mC-egYhwOX5AYsz9cLDL5fkwbk/edit#slide=id.g11745f219f0_0_21



// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {   
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }


// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }






// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         sum_pos += myArray[i];
//     else
//         sum_neg += myArray[i];
// }

// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");



// https://learn.microsoft.com/ru-ru/dotnet/api/system.random.next?view=net-7.0



// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]



// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// int[] array = CreateRandomArray(10 , -100 , 100);
// Console.WriteLine($"{string.Join(" ", array)}");
// for (int i = 0; i < array.Length; i++)
// {
//         array[i]= array[i] * -1;
// }
// Console.WriteLine($"{string.Join(" ", array)}");


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] array = CreateRandomArray(10, -100, 100);
// Console.WriteLine($"{string.Join(" ", array)}");
// Console.WriteLine("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// bool serge = false;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == x)
//     {
//         serge = true;
//     }


// }
// Console.WriteLine(serge?"Да":"нет");


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



// int[] array = CreateRandomArray(123, -200, 200);
// Console.WriteLine($"{string.Join(" ", array)}");
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//         if (array[i] >= 10 && array[i]<= 99)
//         {
//                 count++;
//         }
// }
// Console.WriteLine(count);


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


//  int[] array = CreateRandomArray(12, -200, 200);
// Console.WriteLine($"{string.Join(" ", array)}");
// for (int i = 0; i < array.Length; i++)
// {
        
// }




//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

// Clear();
// Write("Введите элементы массива через пробел: ");
// string elements = ReadLine();
// int[] baseArray = GetArrayFromString(elements);

// WriteLine(String.Join(" ", ResultArray(baseArray)));

// int[] GetArrayFromString(string stringArray)
// {
//     string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//     int[] res = new int[nums.Length];

//     for (int i = 0; i < nums.Length; i++)
//     {
//         res[i] = int.Parse(nums[i]);
//     }
//     return res;
// }

// int[] ResultArray(int[] array)
// {
//     int size = array.Length / 2;
//     if (array.Length % 2 == 1) size++;
//     int[] result = new int[size];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
        
//         result[i] = array[i] * array[array.Length - 1 - i];
//     }
//     if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
//     return result;
// }



