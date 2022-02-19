// Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.

Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.");
Console.WriteLine();
Console.WriteLine("Введите в одну строку несколько чисел раделенных между собой точкой с запятой. Наличие пробелов перед числом и после числа - непринципиально.");
Console.WriteLine("Пример ввода: -45 ; 3; 192;-12");
Console.WriteLine("Количество вводимых чисел и их значность (разрядность) не имеет значения");
Console.WriteLine();

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length - 1) { Console.Write("; "); }
    }
    Console.WriteLine("]");
}

string inputString = Console.ReadLine();

string swap = String.Empty;
for (int i = 0; i < inputString.Length; i++)
{
    if (inputString[i] != ' ')
    {
        swap += inputString[i];
    }
}

string[] arrayOfWords = swap.Split(";");
int[] arrayOfNumbers = new int[arrayOfWords.Length];

Console.WriteLine("В результате ввода строки имеем следующий массив чисел:");
Console.WriteLine();
PrintArray(arrayOfWords);
Console.WriteLine();
int positives=0;
for (int i = 0; i < arrayOfNumbers.Length; i++)
{
    arrayOfNumbers[i] = int.Parse(arrayOfWords[i]);
    if (arrayOfNumbers[i] > 0)
    {
        positives++;
    }
}
Console.WriteLine($"Количество введенных положительных чисел: {positives}");
Console.WriteLine();