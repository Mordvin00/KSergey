/*Задача 2:Задайте двумерный массив.
Напишите программу, которая поменяет местами
первую и последнюю строку массива.
Пример
4 3 1 => 4 6 2
2 6 9   2 6 9
4 6 2   4 3 1 */


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void replaceMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        // присваиваем переменной значение элемента первой строки
        int tmp = matrix[0, i];
        // присваиваем элементу первой строки значение элемента tmp строки
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        // присваиваем элементу tmp значение последней строки
        matrix[matrix.GetLength(0) - 1, i] = tmp;
    }
}


Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
replaceMatrix(matrix);
Console.WriteLine("Конечный массив: ");
PrintMatrix(matrix);

