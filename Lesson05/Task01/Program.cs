// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[] RandomArray(int len, int min, int max)
{

    int[] RngArray = new int[len];
    for (int i = 0; i < RngArray.Length; i++)
        RngArray[i] = new Random().Next(min, max + 1);
    return RngArray;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int NumberOfEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) result++;
    return result;
}

int len = Prompt("Введите длину массива: ");
int min = Prompt("Введите нижний предел массива: ");
int max = Prompt("Введите верхий предел массива: ");

int[] myArray = RandomArray(len, min, max);
PrintArray(myArray);
Console.WriteLine($"Количество четных чисел в массиве составляет: {NumberOfEven(myArray)}");