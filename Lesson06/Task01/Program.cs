// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] Numbers(int M)
{
    int[] numM = new int[M];
    for (int i = 0; i < M; i++)
    {
        numM[i] = Prompt($"Введите {i + 1} из {M} чисел ");
    }
    return numM;
}
int PositiveNumbers(int[] array)
{
    int counter = 0;
    foreach (int element in array)
    {
        if (element > 0) counter++;
    }
    return counter;
}


int M = Prompt("Сколько чисел необходимо ввести? ");
int[] myNumbers = Numbers(M);
Console.WriteLine($"Количество положительных чисел из них: {PositiveNumbers(myNumbers)}");
