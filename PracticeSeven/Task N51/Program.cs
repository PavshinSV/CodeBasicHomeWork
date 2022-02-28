// Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.

Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача 51: Задать двумерный массив следующим правилом: A[m,n] = m+n.");
Console.WriteLine();

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,5}", arr[i, j]);
            if (j != arr.GetLength(1) - 1) { Console.Write("; "); }
        }
        Console.WriteLine("]");
    }
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i+j;
        }
    }
}
Console.Write("Введите количество строк в массиве: ");
int stringQuantity = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество столбцов в массиве: ");
int columnQuantity = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[stringQuantity, columnQuantity];

FillArray(array);
PrintArray(array);