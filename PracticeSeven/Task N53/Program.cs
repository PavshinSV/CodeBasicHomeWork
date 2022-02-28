// Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.

Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет");
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
            arr[i, j] = new Random().Next(0,100);
        }
    }
}

void IndexesOfElement(int[,] arr, int number) {
    bool noEntry=true;
    for (int i =0; i<arr.GetLength(0);i++){
        for (int j=0;j<arr.GetLength(1);j++){
            if (arr[i,j]==number) {
                if (noEntry) {Console.WriteLine("Искомое число находится в массиве по следующим индексам:");}
                Console.Write($"[{i},{j}] ");
                noEntry=false;
            }
        }
    }
    if (noEntry) {Console.WriteLine("Искомое число в массиве не найдено:");}
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
Console.Write("Введите искомое число (от 0 до 99): ");
int questNumber = int.Parse(Console.ReadLine());
Console.WriteLine();
IndexesOfElement(array, questNumber);
