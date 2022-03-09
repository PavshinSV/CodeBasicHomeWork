/* Задача 73 : Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на друга не делятся)? Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.

Например, для N = 50, M получается 6

Группа 1: 1
Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
Группа 4: 8 12 18 20 27 28 30 42 44 45 50
Группа 5: 7 16 24 36 40
Группа 6: 5 32 48

Группа 1: 1
Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
Группа 4: 8 12 18 20 27 28 30 42 44 45 50
Группа 5: 16 24 36 40
Группа 6: 32 48
 */

Console.Clear();

void ShowQuantitysOfRange(string range, int count = 0)
{
    if (range.Length == 0) return;
    count++;
    string newString = string.Empty;
    string[] rangeArray = range.Split(";", StringSplitOptions.RemoveEmptyEntries);
    string[] quantityIteration = new string[rangeArray.Length];
    for (int i = 1; i < quantityIteration.Length; i++)
    {
        quantityIteration[i] = "0";
    }
    quantityIteration[0] = rangeArray[0];

    for (int i = 1; i < rangeArray.Length; i++)
    {
        bool mutualyNatural = true;

        if (i == 1) { Console.Write($"Группа {count}: {rangeArray[0]}"); }
        for (int j = 0; j < quantityIteration.Length; j++)
        {
            if (quantityIteration[j] != "0" && int.Parse(rangeArray[i]) % int.Parse(quantityIteration[j]) == 0)
            {
                mutualyNatural = false;
            }
        }
        if (mutualyNatural)
        {
            Console.Write($", {rangeArray[i]}");
            quantityIteration[i] = rangeArray[i];
        }
        else newString += $"{rangeArray[i]};";
    }
    Console.WriteLine();
    if (newString.Length != 0) ShowQuantitysOfRange(newString, count);
}

int n = 50;
string baseRange = string.Empty;

for (int i = 0; i < n; i++)
{
    baseRange += $"{i + 1};";
}

ShowQuantitysOfRange(baseRange);