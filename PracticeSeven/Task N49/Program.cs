// Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.

Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача 49: Показать двумерный массив размером m x n, заполненный вещественными числами.");
Console.WriteLine();

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,6:0.00}", arr[i, j]);
            if (j != arr.GetLength(1) - 1) { Console.Write("; "); }
        }
        Console.WriteLine("]");
    }
}

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble() * 100;
        }
    }
}
Console.Write("Введите количество строк в массиве: ");
int stringQuantity = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество столбцов в массиве: ");
int columnQuantity = int.Parse(Console.ReadLine());
Console.WriteLine();

double[,] array = new double[stringQuantity, columnQuantity];

FillArray(array);
PrintArray(array);