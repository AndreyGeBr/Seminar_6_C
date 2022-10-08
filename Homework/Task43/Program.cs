// Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2. Значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();

Console.Write("введите значение b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.Write("введите значение k1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("введите значение b2: ");
double b2 = int.Parse(Console.ReadLine()!);
Console.Write("введите значение k2: ");
double k2 = int.Parse(Console.ReadLine()!);

double numberX = (b2 - b1)/(k1 - k2);
double numberY = k2 * numberX + b2;

Console.WriteLine($"Точка пересечения двух прямых: ({numberX}, {numberY})");

