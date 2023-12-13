/*Задача 1:
Задайте значения M и N.
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Использовать рекурсию, не использовать циклы.
Пример
M = 1; N = 5 -> "1 2 3 4 5"
M = 4; N = 8 -> "4 5 6 7 8" */

string printNumbers(int a, int b){
    if (a-b == 0 | b < 0) // Исключил переполнение стека в случае некорректного ввода
        return $"{b} ";
    return printNumbers(a, b - 1) + $"{b} ";
}

Console.Clear();
Console.Write("Введите меньшее натуральное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите большее натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Натуральные числа промежутка MN:");
Console.WriteLine(printNumbers(m, n));