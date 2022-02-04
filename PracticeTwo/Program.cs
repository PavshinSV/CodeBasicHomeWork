//Задача 10: Показать вторую цифру трёхзначного числа.
//Задача 12: Удалить вторую цифру трёхзначного числа.
//Задача 14: Найти третью цифру числа или сообщить, что её нет.
//Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным

//Блок объявления функций. 
int eXponenta(int num, int eXp) {  //функция возведения числа num в степень eXp
    int index = 1;
    int result = num;
    if (eXp == 0) {
        return 1;
    }
    while (index < eXp) {
        result *= num;
        index++;
    }
    return result;
}

bool decimalDepth(int num, int depth) {  //функция проверки разрядности числа num глубине depth
    bool answer = false;
    int min = eXponenta(10, depth-1);
    int max = eXponenta(10, depth);
    if (min == 1) {min = 0;}
    if (min <= num && num < max) {answer = true;};
    return answer;
}

//Блок решения задач
Console.Clear();

//Задача 10: Показать вторую цифру трёхзначного числа.
Console.WriteLine("Задача 10: Показать вторую цифру трёхзначного числа.");
Console.WriteLine();
int task10number = new Random().Next(100,1000);             //Ввод числа для 10й задачи

if (!decimalDepth(task10number, 3)) {                       //Проверка является ли введенное число трехзначным на случай если кто-то изменит метод ввода числа
    Console.WriteLine("Введо не трехзначное число");
}
int task10result = (task10number - ((task10number/100)*100))/10;
Console.WriteLine("В трехзначном числе "+task10number+" средней цифрой является "+task10result);
Console.WriteLine();

//Задача 12: Удалить вторую цифру трёхзначного числа.
Console.WriteLine("Задача 12: Удалить вторую цифру трёхзначного числа.");
Console.WriteLine();
int task12number = new Random().Next(100,1000);             //Ввод числа для 12й задачи

if (!decimalDepth(task12number, 3)) {                       //Проверка является ли введенное число трехзначным на случай если кто-то изменит метод ввода числа
    Console.WriteLine("Введо не трехзначное число");
}

int task12result = (task12number/100*10) + task12number%10;
Console.WriteLine("Если из трехзначного числа "+task12number+" удалить среднюю цифру получится число "+task12result);
Console.WriteLine();

//Задача 14: Найти третью цифру числа или сообщить, что её нет.
Console.WriteLine("Задача 14: Найти третью цифру числа или сообщить, что её нет.");
Console.WriteLine();
int task14number = new Random().Next(1,10000);             //Ввод числа для 14й задачи
string task14string = task14number.ToString();
Console.WriteLine("Введено число " + task14number);
if (3>task14string.Length) {
    Console.WriteLine("Количество знаков в числе меньше трёх");
}
else {
    Console.WriteLine("Третья цифра (счёт слева) это "+task14string[2]);
}
Console.WriteLine();

//Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным");

string[] task16week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
int task16day = new Random().Next(1,8);
Console.WriteLine("The number of day is "+task16day+". Today is "+task16week[task16day-1]);