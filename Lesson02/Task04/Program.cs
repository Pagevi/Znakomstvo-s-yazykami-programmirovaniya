// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int promt (string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}
int numberInt = promt("Введите цифру дня недели: ");
if (numberInt == 6 || numberInt == 7) Console.WriteLine ("Да, это выходной день");
else Console.WriteLine ("Нет, это не выходной день");