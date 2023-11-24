﻿/*Задача 3:
/*Напишите программу, которая на вход принимает натуральное
число N, а на выходе показывает его цифры через запятую.*/

Console.Clear();
Console.Write("Введите натуральное число: ");
int N = int.Parse(Console.ReadLine()!);

if (N < 0)
{
    Console.WriteLine($"{N} - число то отрицательное!");
}
else
if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    while (N > 0)
    {
        int currentDigit = N % 10;
        N /= 10;
        if (N > 0)
        {
            Console.Write(currentDigit + ",");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
}
