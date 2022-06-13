// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int N = int.Parse(number);
int i = 2;

while(i <= N)
{
    Console.WriteLine($"{i}");
    i = i + 2;
}