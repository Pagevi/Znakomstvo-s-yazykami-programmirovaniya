// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

int RecursiveMToNSum(int M, int N)
{
    int total = 0;
    if (N < M)
    {
        return 0;
    }
    else
    {
        {
            total = M + RecursiveMToNSum(M + 1, N);
            return total;

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
    System.Console.WriteLine(RecursiveMToNSum(m, n));

}



Solve();