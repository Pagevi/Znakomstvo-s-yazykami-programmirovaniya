// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа");
string number1 = Console.ReadLine();
string number2 = Console.ReadLine();
string number3 = Console.ReadLine();
int A = int.Parse(number1);
int B = int.Parse(number2);
int C = int.Parse(number3);
int max = A;

if((B > A) && (B > C)) 
{
   max = B;
}
if((C > A) && (C > B)) 
{
   max = C;
}
Console.WriteLine($"Максимальное из этих чисел: {max}");