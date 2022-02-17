//Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.

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

int[] MinMax(int[] arr) {
    int[] extremums = {0,0};
    for (int i=0; i<arr.Length; i++) {
        if (arr[i]<extremums[0]) {extremums[0]=arr[i];} 
        else if (arr[i]>extremums[1]) {extremums[1]=arr[i];}
    }
    return extremums;
}
 int sizeOfArray = 10;

 int[] array = new int[sizeOfArray];
 FillArray(array);

Console.WriteLine();
Console.WriteLine($"На старте мы имеем массив из {sizeOfArray} элементов:");
PrintArray(array);
Console.WriteLine();

int[] minimax = MinMax(array);
Console.WriteLine($"Минимальное значение = {minimax[0]}, а максимальное значение = {minimax[1]}");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным значениями = {minimax[1] -minimax[0]}");