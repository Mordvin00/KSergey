// Task 1 "Условие" - Проверка квадрата числа
/*
Console.Clear();
Console.WriteLine("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);
/*
= - действие присвоение значения
== - проверка на равенство
!= - проверка на неравенство */
/*
if (m * m == n) // ; тут не ставить!
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
// Фигурные скобки нужно ставить, когда внуутри конструкции выполняется две строки и более
*/

// Task 2 "Цикл" Вывод диапазона целых чисел (версия 1)
/*
Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
// for (begin, condition, step)
// 1 повторение = 1 итерация
for (int i = -n; i <= n; i++) // i = (-1)*n, i++ <-> i+=1 <-> i = i + 1
    Console.Write($"{i} "); // i  + " "
/*
1: i = -2 -> 2

*/

//Task 2 "Цикл" Вывод диапазона целых чисел (версия 2)
/*
Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int i = -n;
while (i <= n)
{
    Console.Write($"{i} ");
    i++;
}
*/

//Task 3

Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine()!);
// 456 : 10 = 45(ост.6)
// 456 : 100 = 4(ост.56)
int n3 = n % 10;
int n1 = n / 100;
Console.Write(n1 + n3);