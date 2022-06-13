// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа");
string number1 = Console.ReadLine();
string number2 = Console.ReadLine();
int A = int.Parse(number1);
int B = int.Parse(number2);
int max = A;

if(B > max)
{
   max = B;
} 
Console.WriteLine($"Наибольшее число: {max}");