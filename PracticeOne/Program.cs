//Задача 2: Даны два числа. Показать большее и меньшее число

//Задача 4: Найти максимальное из трёх чисел.

//Задача 6: Выяснить является ли число чётным

//Задача 8: Показать чётные числа от 1 до N.

//Нужно прислать файл с кодом .cs или ссылку на репозиторий с решениями

Console.Clear();
//Решение задачи №2
Console.WriteLine();
Console.WriteLine("Задача №2");
int numberA = new Random().Next(1, 100);
int numberB = new Random().Next(1, 100);

Console.WriteLine("A= "+numberA+"; B= "+numberB);
if (numberA>numberB) {
    Console.WriteLine("Большее = "+numberA+"; Меньшее = "+numberB);
}
else if (numberB>numberA) {
    Console.WriteLine("Большее = "+numberB+"; Меньшее = "+numberA);
}
else Console.WriteLine("A=B="+numberA);
Console.WriteLine();

//Решение задачи №4

Console.WriteLine("Задача №4");
int number1 = new Random().Next(1, 100);
int number2 = new Random().Next(1, 100);
int number3 = new Random().Next(1, 100);
Console.WriteLine("N1= "+number1+"; N2= "+number2+"; N3= "+number3);
int maxValue = number1;
if (number2>maxValue) {maxValue=number2;};
if (number3>maxValue) {maxValue=number3;};
Console.WriteLine("Наибольшим является значение "+maxValue);

//Решение задачи №6

Console.WriteLine();
Console.WriteLine("Задача №6");
int num = new Random().Next(1, 100);
Console.WriteLine("N= "+num);

if (num%2==0) {
    Console.WriteLine("Число является чётным");
}
else Console.WriteLine("Число НЕ является чётным");

//Решение задачи №8

Console.WriteLine();
Console.WriteLine("Задача №8");
int numb = new Random().Next(1, 100);
Console.WriteLine("N= "+numb);
int index=1;
Console.WriteLine("Четными числами от 1 до "+numb+" являются следующие числа:");

while (index<numb) {
    index++;
    if (index%2==0) {
        Console.Write(index+"; ");
    }
}
if (index == 1) {
    Console.WriteLine("Нет четных чисел в указанном диапозоне");
}