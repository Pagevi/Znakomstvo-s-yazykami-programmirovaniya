// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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
int SumOddPos(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i = i + 2)
        result = result + array[i];
    return result;
}

int len = Prompt("Введите длину массива: ");
int min = Prompt("Введите нижний предел массива: ");
int max = Prompt("Введите верхний предел массива: ");
int[] myArray = RandomArray(len, min, max);
PrintArray(myArray);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, составляет: {SumOddPos(myArray)}");