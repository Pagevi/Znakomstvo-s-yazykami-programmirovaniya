// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Promt (string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

void Result(int N)
{
    int index = 1;
    while (index <= N)
    {
        Console.WriteLine(index * index * index);
        index++;
    }
}

int number = Promt("Введите число N: ");

Result(number);