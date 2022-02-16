//Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.
Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.");

void FillArray(int[] arr)                   //Метод заполнения массива arr производьными целыми числами
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] arr)                  //Метод вывода элементов массива arr в консоль
{                 
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length - 1) { Console.Write("; "); }
    }
    Console.WriteLine("]");
}

int[] CountEvenOdd(int[] arr)
{
    int odd = 0;
    int even = 0;
    for (int i=0; i<arr.Length;i++) {
        if (arr[i]%2==0) {
            even++;
        } else odd++;
    }
    return new int[] {even,odd};
}

int sizeOfArray = 10;
int[] array = new int[sizeOfArray];
FillArray(array);
Console.WriteLine();
Console.WriteLine($"На старте мы имеем массив из {sizeOfArray} элементов:");
PrintArray(array);
Console.WriteLine();
int[] evenOdd=CountEvenOdd(array);
Console.WriteLine($"В нем {evenOdd[0]} четных элементов и {evenOdd[1]} нечетных");
