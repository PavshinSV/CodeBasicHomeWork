/* Домашка к четвертому семинару введение в языыки программирования. С#

Задача 26: Возведите число А в натуральную степень B, используя цикл.
Задача 28: Подсчитайте сумму цифр в числе.
Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру.
Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран */



//Задача 26: Возведите число А в натуральную степень B, используя цикл.

Console.Clear();

Console.WriteLine();
Console.WriteLine("Задача 26: Возведите число А в натуральную степень B, используя цикл.");
Console.WriteLine();
int a = new Random().Next(1,100);
int b = new Random().Next(1,100);
double exp(int basis, int extent){
    //Console.WriteLine(extent);
    if (extent==0) {
        return 1;
    } else return basis*exp(basis, extent-1);
}

Console.WriteLine($"Введены значения А = {a} и В = {b}");
Console.WriteLine($"{a} возведенное в степень {b} равно {exp(a,b)}");

//Задача 28: Подсчитайте сумму цифр в числе.
Console.WriteLine();
Console.WriteLine("Задача 28: Подсчитайте сумму цифр в числе.");
Console.WriteLine();
int var28 = new Random().Next(1,1000);
int summary(int num) {
    if (num<10) {
        return num;
    } else return num%10+summary(num/10);
}
Console.WriteLine($"Для числа {var28} сумма числел равна {summary(var28)}");

//Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру.
Console.WriteLine();
Console.WriteLine("Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру.");
Console.WriteLine();
int limit = 100;
for (int index = 2; index < limit; index += 2) {
    Console.WriteLine($"Третья степень числа {index} равна {exp(index,3)}");
}
Console.WriteLine();

//Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран 
Console.WriteLine();
Console.WriteLine("Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран");
Console.WriteLine();
int[] array = new int[8];
void FillArray01(int[] arr){
    for (int i=0; i<arr.Length; i++) {
        arr[i]=new Random().Next(0,2);
    }
}

void PrintArray(int[] arr) {
    Console.WriteLine();
    for (int i=0; i<arr.Length; i++) {
        Console.Write($"а[{i}] = {arr[i]}; ");
    }
    Console.WriteLine();
}

FillArray01(array);
PrintArray(array);