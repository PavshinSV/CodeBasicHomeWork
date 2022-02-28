// Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов");
Console.WriteLine();

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,5}", arr[i, j]);
            if (j != arr.GetLength(1) - 1) { Console.Write(";"); }
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
            arr[i, j] = new Random().Next(0,10);
        }
    }
}

void SummaryOfColumn(int[,] arr) {
    double square = 0;
    Console.Write("[");
    for (int i =0; i<arr.GetLength(1);i++){
        int summ=0;
        for (int j=0;j<arr.GetLength(0);j++){
            summ+=arr[j,i];
        }
        square = (double)summ/arr.GetLength(0);
        Console.Write("{0,5:0.00}",square);
        Console.Write(";");
    }
}

int[,] array = new int[5, 5];

FillArray(array);
PrintArray(array);
Console.WriteLine();
SummaryOfColumn(array);
Console.WriteLine();

