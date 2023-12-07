/*Задача 1:
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Пример
4 3 1 (1,2) => 9
2 6 9 */

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


// int FindElement(int[,] matrix){
//     int a;
//     int b;
//     if (a>matrix.GetLength(0) && b>matrix.GetLength(1))
//     Console.WriteLine("Указанный адрес за пределами массива");
//      else
//     {
//     return matrix.GetValue(a, b);
//  }
// }



Console.Clear();
Console.Write("Введите размеры двумерного массива через пробел: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
Console.Write("Введите индексы запрашиваемого элемента поочерёдно: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > matrix.GetLength(0))
    Console.WriteLine("Указанный адрес за пределами массива");
else
 if (b > matrix.GetLength(1))
    Console.WriteLine("Указанный адрес за пределами массива");
else
{
    Console.WriteLine($"Запрашиваемый элемент: {matrix.GetValue(a, b)}");
}

// Console.WriteLine($"Запрашиваемый элемент: {FindElement(matrix)}");

// Не смог сделать поиск элемента в метод FindElement и ввод индексов через пробел