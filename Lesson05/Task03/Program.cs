// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double PromptD(string message)
{
    Console.Write(message);
    double number = double.Parse(Console.ReadLine());
    return number;
}
double[] RandomArray(int len, double min, double max)
{

    double[] RngArray = new double[len];
    for (int i = 0; i < RngArray.Length; i++)
        RngArray[i] = new Random().NextDouble() * (max - min) + min;
    return RngArray;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]:f2} ");
    }
    Console.WriteLine($"{array[array.Length - 1]:f2} ]");
}
double MinMaxDiff(double[] array)
{
    double result = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) { max = array[i]; }
        if (array[i] < min) { min = array[i]; }
    }
    result = max - min;
    return result;
}

int len = Prompt("Введите длину массива: ");
double min = PromptD("Введите нижний предел массива: ");
double max = PromptD("Введите верхний предел массива: ");
double[] myArray = RandomArray(len, min, max);
PrintArray(myArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива составляет: {MinMaxDiff(myArray):f2}");