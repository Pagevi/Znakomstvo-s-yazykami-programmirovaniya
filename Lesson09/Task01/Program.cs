// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.

void RecursiveMToN(int M, int N)
{
    if (N < M)
    {
        return;
    }
    else
    {
        {
            if (M % 2 == 0)
            {
                System.Console.Write($"{M}, ");
            }
            RecursiveMToN(M + 1, N);
        }
    }
}

int Prompt(string console)
{
    System.Console.WriteLine(console);
    string numberStr = Console.ReadLine();
    return int.Parse(numberStr);
}

void Solve()
{
    int m = Prompt("Введите нижний предел");
    int n = Prompt("Введите верхний предел");
    RecursiveMToN(m, n);

}



Solve();