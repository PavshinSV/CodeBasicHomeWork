/* Задача 71: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29 */

Console.Clear();

double AkkermanMethod(double m, double n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanMethod(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return AkkermanMethod(m - 1, AkkermanMethod(m, n - 1));
    }
    return -1;
}

double m = 3;
double n = 2;

Console.Write($"Для значений m = {m} и n = {n} результат функции Аккермана будет равен: ");
Console.WriteLine(AkkermanMethod(m,n));
Console.WriteLine();