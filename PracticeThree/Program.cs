/*
Домашняя работа к тертьему семинару по теме "Знакомство с языками программирования. С#"
Задача 18: Проверить истинность утверждения
¬(X ⋁ Y) = ¬X ⋀ ¬Y
Задача 20: Задать номер четверти, показать диапазоны для возможных координат
Задача 22: Найти расстояние между точками в пространстве 2D/3D
Задача 24: Найти кубы чисел от 1 до N

 */
Console.Clear();
Console.WriteLine("Задача 18: Проверить истинность утверждения");
Console.WriteLine();
//Задача 18: Проверить истинность утверждения
//¬(X ⋁ Y) = ¬X ⋀ ¬Y
 
bool[] x = new bool[] {true,false};
bool[] y = new bool[] {true,false};

Console.WriteLine($"-----------------------------------------");
Console.WriteLine($"|   x   |   y   |!(X||Y)| !X&&!Y| Result|");
for (int i=0; i < x.Length; i++) {
    Console.WriteLine($"-----------------------------------------");
                        
    for (int j = 0; j < y.Length; j++)
    {
        bool firstExpression = !(x[i] || y[j]);
        bool secondExpression = !x[i] && !y[j];
        Console.WriteLine($"|{x[i],6} |{y[j],6} |{firstExpression,6} |{secondExpression,6} |{firstExpression==secondExpression,6} |");
    }                         
}
Console.WriteLine($"-----------------------------------------");
Console.WriteLine();

//Задача 20: Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine($"Задача 20: Задать номер четверти, показать диапазоны для возможных координат");
bool inputFail = true;
int quadrant = new int{};
while (inputFail) 
{
    Console.Write($"Введите номер четверти (квадранта), целое число от 1 до 4: ");
    quadrant = int.Parse(Console.ReadLine());
    if (quadrant>4 && 0>quadrant) 
    {
        Console.WriteLine("Input Error");
    } else 
        {
            inputFail=false;
        }

}

if (quadrant==1) 
{
    Console.WriteLine($"Диапозон возможных значений - х>0, у>0");
} else if (quadrant==2) 
        {
            Console.WriteLine($"Диапозон возможных значений - х<0, у>0");
} else if (quadrant==3) 
        {
            Console.WriteLine($"Диапозон возможных значений - х<0, у<0");
} else if (quadrant==4) 
        {
            Console.WriteLine($"Диапозон возможных значений - х>0, у<0");
}
Console.WriteLine();

