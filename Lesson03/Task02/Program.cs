// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Promt (string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int x1 = Promt("Введите координаты x первой точки: ");
int y1 = Promt("Введите координаты y первой точки: ");
int z1 = Promt("Введите координаты z первой точки: ");

int x2 = Promt("Введите координаты x второй точки: ");
int y2 = Promt("Введите координаты y второй точки: ");
int z2 = Promt("Введите координаты z второй точки: ");

double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
Console.WriteLine($"Расстояние между точками: {result:F2}");