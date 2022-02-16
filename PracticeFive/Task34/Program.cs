//Задача 34: Написать программу для замены элементов массива на противоположные.
Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача 34: Написать программу для замены элементов массива на противоположные.");

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

int[] MirrorByZero(int[] arr)
{
    int[] swap = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        swap[i] = arr[i] * (-1);
    }
    return swap;
}

int[] MirrorByArray(int[] arr)
{
    int j = arr.Length;
    int[] swap = new int[arr.Length];
    if (j % 2 != 0) { swap[j / 2] = arr[j / 2]; }

    for (int i = 0; i < arr.Length / 2; i++)
    {
        swap[i] = arr[j - 1];
        swap[j - 1] = arr[i];
        j--;
    }
    return swap;
}

int sizeOfArray = 9;   // Здесь можно изменить длинну массива
int[] testArray = new int[sizeOfArray];
FillArray(testArray);
Console.WriteLine();
Console.WriteLine($"На старте мы имеем массив из {sizeOfArray} элементов:");
PrintArray(testArray);
Console.WriteLine();
Console.WriteLine($"Если элементы массива заменить на противоположные относительно начала системы отсчета то получим массив:");
PrintArray(MirrorByZero(testArray));
Console.WriteLine();
Console.WriteLine($"А если элементы первоначального массива заменить на противоположные относительно положения в массиве то получим массив:");
PrintArray(MirrorByArray(testArray));