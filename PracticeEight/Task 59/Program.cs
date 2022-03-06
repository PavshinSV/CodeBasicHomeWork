// Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.


Console.Clear();

void ArrayMinLineSumm(int[,] arr)
{
    int indexOfMinSummLine = 0;
    int minSumm=0;
    int summ;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       summ=0;
       for (int j = 0; j < arr.GetLength(1); j++)
       {
           summ+=arr[i,j];
       }
       if (i==0){minSumm=summ;}
       else if (minSumm>summ){
           minSumm=summ;
           indexOfMinSummLine=i;
       };
    }
    Console.WriteLine($"В указанной матрице наименьшей суммой = {minSumm} обладает строка с индексом {indexOfMinSummLine}");
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
int columns = lines;
int[,] testArray = new int[lines, columns];

FillArray(testArray);
Console.WriteLine("На старте имеем несортированный массив:");
PrintArray(testArray);
Console.WriteLine();
ArrayMinLineSumm(testArray);
Console.WriteLine();