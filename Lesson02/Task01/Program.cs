// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

Console.WriteLine($"Число {(paramInt % 100) / 10} - вторая цифра этого числа");