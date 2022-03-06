// Задача 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

Console.Clear();

void ArrayLineSort(int[,] arr)
{
    int swap = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int k = 1; k < arr.GetLength(1); k++)
        {
            int maxIndexColumn = k - 1;
            for (int j = k; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > arr[i, maxIndexColumn]) { maxIndexColumn = j; }
            }
            if (maxIndexColumn != k - 1)
            {
                swap = arr[i, k - 1];
                arr[i, k - 1] = arr[i, maxIndexColumn];
                arr[i, maxIndexColumn] = swap;
            }
        }
    }
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,5}",arr[i, j]);
        }
        Console.WriteLine();
    }
}

int lines = 5;
int columns = 7;
int[,] testArray = new int[lines, columns];

FillArray(testArray);
Console.WriteLine("На старте имеем несортированный массив:");
PrintArray(testArray);
Console.WriteLine();
ArrayLineSort(testArray);
Console.WriteLine("После применения метода сортировки массива по строкам получаем результат:");
PrintArray(testArray);
Console.WriteLine();