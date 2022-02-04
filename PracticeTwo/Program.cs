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
    Console.WriteLine(result);
    return result;
}

bool decimalDepth(int num, int depth) {  //функция проверки разрядности числа num глубине depth
    bool answer = false;
    int min = eXponenta(10, depth-1);
    int max = eXponenta(10, depth);
    if (min == 1) {min = 0;}
    Console.WriteLine("min="+min+" max="+max);
    if (min <= num && num < max) {answer = true;};
    return answer;
}

//Блок решения задач
Console.Clear();
