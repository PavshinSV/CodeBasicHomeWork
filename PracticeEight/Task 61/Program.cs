// Задача 61: Найти произведение двух матриц.


Console.Clear();

int[,] ArrayMultiply(int[,] arr1, int[,] arr2)
{
    int[,] outputArray = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            outputArray[i, j] = 0;
            for (int r = 0; r< arr1.GetLength(1); r++)
            {
                outputArray[i, j] +=arr1[i,r]*arr2[r,j];
            }
        }
    }
    return outputArray;
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,5}", arr[i, j]);
        }
        Console.WriteLine();
    }
}

int linesA = 2;
int columnsA = 3;
int linesB = 3;
int columnsB = 2;
int[,] testArrayA = new int[linesA, columnsA];
int[,] testArrayB = new int[linesB, columnsB];

FillArray(testArrayA);
FillArray(testArrayB);
Console.WriteLine("На старте имеем массив A:");
PrintArray(testArrayA);
Console.WriteLine();
Console.WriteLine("а также массив B:");
PrintArray(testArrayB);
Console.WriteLine();
Console.WriteLine("Результатом произведения А х В будет следующая матрица: ");
Console.WriteLine();
PrintArray(ArrayMultiply(testArrayA,testArrayB));