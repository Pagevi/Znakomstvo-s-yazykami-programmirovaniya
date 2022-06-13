// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int A = int.Parse(number);

if(A % 2 == 0)
{
    Console.WriteLine($"Число {A} является четным");
}
else
{
    Console.WriteLine($"Число {A} не является четным");
}