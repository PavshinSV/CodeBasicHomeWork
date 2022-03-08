// Задача 67: Показать натуральные числа от N до 1, N задано.

Console.Clear();

void ShowNatural(int n) {
    if (n==0) {
        return;
    }
    Console.Write($"{n} ");
    ShowNatural(n-1);
}

Console.WriteLine();

int n=15;
Console.WriteLine($"Для введенного числа N = {n} все натуральные числа представлены рядом:");
ShowNatural(n);
Console.WriteLine();