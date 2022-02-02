//Задача 2: Даны два числа. Показать большее и меньшее число

//Задача 4: Найти максимальное из трёх чисел.

//Задача 6: Выяснить является ли число чётным

//Задача 8: Показать чётные числа от 1 до N.

//Нужно прислать файл с кодом .cs или ссылку на репозиторий с решениями

//Решение задачи №2

Console.WriteLine("Задача №2");
int numberA = new Random().Next(1, 100);
int numberB = new Random().Next(1, 100);

Console.WriteLine("A= "+numberA+"; B= "+numberB);
if (numberA>numberB) {
    Console.WriteLine("Большее - "+numberA+"; Меньшее - "+numberB);
}
else if (numberB>numberA) {
    Console.WriteLine("Большее - "+numberB+"; Меньшее - "+numberA);
}
else Console.WriteLine("A=B="+numberA);
