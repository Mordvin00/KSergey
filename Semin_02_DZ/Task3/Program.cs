/*Задача 3:
Напишите программу, которая принимает на вход целое число
из отрезка [10, 99] и показывает наибольшую цифру числа.*/

Console.Clear();
Console.Write("Введите двухзначное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 10 || n > 99)
{
    Console.Write("Данное число за пределами указанного отрезка!\nВведите двухзначное число: ");
    n = int.Parse(Console.ReadLine()!);
}
int firstNumber = n / 10;
int secondNumber = n % 10;

if (firstNumber == secondNumber)
    Console.WriteLine($"Цифры числа равны и составляют: {firstNumber}");
else
if (firstNumber > secondNumber)
    Console.WriteLine($"Наибольшая цифра - первая: {firstNumber}");
else
    Console.WriteLine($"Наибольшая цифра - вторая: {secondNumber}");
