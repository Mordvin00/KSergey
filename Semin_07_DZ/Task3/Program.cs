/*Задача 3:
Задайте произвольный массив.
Выведете его элементы, начиная с конца.
Использовать рекурсию, не использовать циклы.
Пример
[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 */

void InputArray(int[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        Array[i] = new Random().Next(1, 11);
}


void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        Console.Write($"{Array[i]} ");
}



void ReversArray(int[] Array, int i = 0)
{
    if (i < Array.Length)
    {
        ReversArray(Array, i + 1);
        Console.Write($"{Array[i]} ");
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!); ;
int[] Array = new int[size];
InputArray(Array);
Console.WriteLine("Исходный массив: ");
PrintArray(Array);
Console.WriteLine();
Console.WriteLine("Рекурсивный вывод элементов, начиная с конца: ");
ReversArray(Array);