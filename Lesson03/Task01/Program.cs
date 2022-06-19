// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число: ");
string Pal = Console.ReadLine();
int Len = Pal.Length;

bool q = true;

for (int i = 0; i <= Len / 2; i++)
{
    if (Pal[i] != Pal[Len - 1 -i])
    {
        Console.WriteLine($"{Pal} - это не палиндром");
        q = false;
        break;
    }
}

if (q == true)
{
    Console.WriteLine($"{Pal} - это палиндром");
}