/* Задача 46: Написать программу масштабирования фигуры

Для тех, кто ушёл далеко вперёд, — усложнение.
Сделать так, чтобы:
1. Вершины фигуры задавались списком (в одну строку). Например: "(0,0) (2,0) (2,2) (0,2)".
2. Коэффициент масштабирования k задавался отдельно — 2 или 4 или 0.5.
3. В результате были выводились полученные координаты.
При k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

 */

Console.Clear();
Console.WriteLine();
Console.WriteLine("Задача 46: Написать программу масштабирования фигуры.");
Console.WriteLine();
Console.WriteLine("Введите в одну строку координаты вершин фигуры. Координаты должны быть целыми числами разделенные запятой. Наличие пробелов при вводе чисел - непринципиально.");
Console.WriteLine("Пример ввода вершин треугольника: (0,0) ( 25 , 18 ) (20, -7)");
Console.WriteLine("Количество вводимых вершин и значность (разрядность) чисел не имеет значения");
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

void PrintArray2(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        Console.Write($"N{j + 1} - [");
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            Console.Write($"{arr[j, i]}");
            if (i != arr.GetLength(1) - 1) { Console.Write("; "); }
        }
        Console.WriteLine("]");
    }
}

void PrintArray3(double[,] arr)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        Console.Write($"N{j + 1} - [");
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            Console.Write($"{arr[j, i]}");
            if (i != arr.GetLength(1) - 1) { Console.Write("; "); }
        }
        Console.WriteLine("]");
    }
}

double[,] Scale(int[,] arr, double k)
{
    double[,] swap = new double[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            swap[i, j] = arr[i,j] * k;
        }
    }
    return swap;
}

int[,] GetCoordinates(string[] spool)
{
    string[] swap = new string[2];
    int[,] coordinates = new int[spool.Length, 2];
    for (int i = 0; i < spool.Length; i++)
    {
        swap = spool[i].Split(',');
        coordinates[i, 0] = int.Parse(swap[0]);
        coordinates[i, 1] = int.Parse(swap[1]);
    }
    return coordinates;
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

string[] arrayOfWords = swap.Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
PrintArray(arrayOfWords);

int[,] arrayOfCoordinates = GetCoordinates(arrayOfWords);

Console.WriteLine("Вы ввели следующие координаты");
PrintArray2(arrayOfCoordinates);
Console.WriteLine();

Console.WriteLine("Введите коэфициент масштабирования (вместо точки запятая):");
double scale = double.Parse(Console.ReadLine());
Console.WriteLine();

double[,] scaledArray = Scale(arrayOfCoordinates, scale);
Console.WriteLine("Полученные координаты после масштабирования");
PrintArray3(scaledArray);