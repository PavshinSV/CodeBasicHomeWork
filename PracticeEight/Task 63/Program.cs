// Задача 63: Сформировать трёхмерный массив с не повторяющимися двузначными числами и вывести его на экран построчно, с индексами элементов.


Console.Clear();

void FillArray3D(int[,,] arr)
{
    if (arr.GetLength(0)*arr.GetLength(1)*arr.GetLength(2)>90) {
        Console.WriteLine($"Заполнить массив размерностью {arr.GetLength(0)} x {arr.GetLength(1)} x {arr.GetLength(2)} неповторяющимися значениями не получится потому, что количество значений меньше емкости массива");
        return;
    }
    int number = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int r = 0; r < arr.GetLength(2); r++)
            {
                arr[i, j, r] = number;
                number++;
            }
        }
    }
}

void PrintArray3D(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine($"Строка массива номер {i} содержит в себе следующие данные:");
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int r=0; r<arr.GetLength(2); r++) {
                Console.Write($"[{i},{j},{r}] = {arr[i, j, r]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int lines = 5;      //можно указать любые значения количества строк, колонок и индекса Z
int columns = 6;    //но их произведение не должно быть больше чем 90 иначе, исходя из условий задачи,
int zIndex = 3;     //не хватит значений для того, чтобы заполнить ими все ячейки таблицы. 

int[,,] testArray = new int[lines, columns, zIndex];

FillArray3D(testArray);

PrintArray3D(testArray);
