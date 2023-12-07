/*Задача 3:
Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку
с наименьшей суммой элементов.
Пример
4 3 1 => Строка с индексом 0
2 6 9
4 6 2 
*/

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


int summLine(int[,] matrix, int i)
{
    int result = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        result += matrix[i, j];
    }
return result;
}

Console.Clear();
Console.Write("Введите размер прямоугольного двумерного массива: ");
int size = int.Parse(Console.ReadLine()!); ;
int[,] matrix = new int[size, size];
InputMatrix(matrix);

int minSumLine = 0;
int sumLine = summLine(matrix, 0);
for (int i = 0; i < matrix.GetLength(0); i++)
{
  int tempSumLine = summLine(matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i + 1;
  }
} 
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
Console.WriteLine($"Минимальная сумма элементов ({sumLine}) в строке с индексом {minSumLine}");