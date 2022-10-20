// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Clear();


Console.WriteLine("Генерируем случайное число!");
int number = new Random().Next(10, 1000);
Console.WriteLine(number);
if (number > 100)
{
    int num = (number % 10);
    Console.WriteLine($"Третья цифра числа = {num}");
}
else 
{
Console.WriteLine("Число двухзначное");
}
