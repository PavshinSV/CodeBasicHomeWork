// Задача 65: Спирально заполнить двумерный массив:

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,5}", arr[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Clear();
int columns = 5;
int lines = 7;
int[,] testArray = new int[lines, columns];
int startI = 0;
int startJ = 0;

int acc = 1;
int i = 0;
int j = 0;
int swap = testArray.GetLength(0);

int repeat = swap / 2 + 1;

for (int k = 0; k < repeat; k++)
{
    for (j = startJ; j < testArray.GetLength(1) - startJ; j++)
    {
        testArray[i, j] = acc++;
    }
    j--;

    for (i = startI + 1; i < testArray.GetLength(0) - startI; i++)
    {
        testArray[i, j] = acc++;
    }
    i--;

    if ((startJ < (testArray.GetLength(1) - startJ-1)) && (startI < (testArray.GetLength(0) - startI-1)))
    {
        for (j = j - 1; j > startJ - 1; j--)
        {
            testArray[i, j] = acc++;
        }
        j++;

        for (i = i - 1; i > startI; i--)
        {
            testArray[i, j] = acc++;
        }

        i++;
    }
    startI++;
    startJ++;
}

PrintArray(testArray);
