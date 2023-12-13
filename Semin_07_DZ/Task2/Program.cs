/*Задача 2:
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
Пример
m = 2, n = 3 -> A(m,n) = 29
m = 3, n = 2 -> A(m,n) = 29 */

int akkerman(int a, int b){
    if (a == 0)
        return b+1;
        if (b == 0)
        return akkerman(a - 1, 1);
    return akkerman(a - 1, akkerman(a, b - 1));;
}

Console.Clear();
Console.Write("Введите натуральное число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("функции Аккермана A(m,n) равно:");
Console.WriteLine($"{akkerman(m, n)}");