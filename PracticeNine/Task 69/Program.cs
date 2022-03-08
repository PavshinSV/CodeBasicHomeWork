/* Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.

M = 1; N = 4 -> 10

M = 4; N = 8. -> 30 */

Console.Clear();
Console.WriteLine();

int ShowSummNatural(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return m + ShowSummNatural(m + 1, n);
}

int m = 4;
int n = 8;

Console.WriteLine($"В диапазоне от M = {m} до N = {n} сумма всех чисел равна:");
Console.WriteLine(ShowSummNatural(m, n));
Console.WriteLine();