//Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.

Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.");

void FillArray(int[] arr)                   //Метод заполнения массива arr производьными целыми числами
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }
}

void PrintArray(int[] arr)
{                 //Метод вывода элементов массива arr в консоль
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length - 1) { Console.Write("; "); }
    }
    Console.WriteLine("]");
}

 int sizeOfArray = 10;

 int[] array = new int[sizeOfArray];
 FillArray(array);

Console.WriteLine();
Console.WriteLine($"На старте мы имеем массив из {sizeOfArray} элементов:");
PrintArray(array);
Console.WriteLine();
int summaryOfOddIndexValues = 0;
for (int i = 1; i<array.Length; i+=2) {
    summaryOfOddIndexValues+=array[i];
}
Console.WriteLine($"Сумма чисел стоящих на нечетной позиции равна {summaryOfOddIndexValues}:");