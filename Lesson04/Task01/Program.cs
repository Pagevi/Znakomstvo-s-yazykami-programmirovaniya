// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int PromptNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int PowerNat(int based, int power)
{
    if (power == 0) return 1;
    int result = based;
    for (int i = 1; i < power; i++)
    {
        result = result * based;
    }
    return result;
}

int A = PromptNumber("Введите число А ");
int B = PromptNumber("Введите число В ");
Console.WriteLine($"{A} в натуральной степени {B} составляет {PowerNat(A, B)}");