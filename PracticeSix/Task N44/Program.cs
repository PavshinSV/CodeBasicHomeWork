// Задача 44: Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы

Console.Clear();
Console.WriteLine();
Console.WriteLine(" Задача 44: Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы");
Console.WriteLine();

void PrintEquation(int k, int b)
{
    Console.Write("y = ");
    if (k == 1)
    {
        Console.Write("x");
    }
    else if (k == -1)
    {
        Console.Write("-x");
    }
    else
    {
        Console.Write($"{k}x");
    }
    if (b >= 0)
    {
        Console.Write($" +{b}");
    }
    else
    {
        Console.Write($" {b}");
    }
}

int b1 = new Random().Next(-10, 11);
int k1 = new Random().Next(-10, 11);
int b2 = new Random().Next(-10, 11);
int k2 = new Random().Next(-10, 11);
double x = 0;
double y = 0;

Console.Write("Имеем два уравнения прямых ");
PrintEquation(k1,b1);
Console.Write(" и ");
PrintEquation(k2,b2);

Console.WriteLine();

if (k1 - k2 == 0)
{
    if (b1 - b2 == 0)
    {
        Console.WriteLine("Прямые совпадают. Бесконечное количество решений");
    }
    else { Console.WriteLine("Прямые параллельны. Решения отсутствуют"); }
}
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Система уравнений имеет решение х = {x}, у = {y}");
}