// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int PromptNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumNum(int number)
{
    int num = 0;
    while (number > 0)
    {
        num = num + number % 10;
        number = number / 10;
    }
    return num;
}

int number = PromptNumber("Введите число ");
Console.WriteLine($"Сумма цифр в числе {number} составляет {SumNum(number)}");