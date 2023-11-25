/*Задача 2: Задайте массив на 10 целых чисел.
Напишите программу, которая определяет
количество чётных чисел в массиве.
Пример
массив [6 7 19 34 3 1 4 7 9 1] => 3
массив [1 8 43 4 55 60 3 2 1 3] => 4 */

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write(inArray[i] + " ");
    }
    Console.WriteLine();
}

int lengthArray = 10;
int[] arr = FillArray(lengthArray);
PrintArray(arr);

int i = 0;
    foreach (int element in arr)
    {
        if(element % 2 == 0)
        {
            i++;
        }
    }
        Console.WriteLine($"Количество чётных чисел в массиве: {i}");