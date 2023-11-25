/*Задача 1: Задайте одномерный массив
из 10 целых чисел от 1 до 100.
Найдите количество элементов массива,
значения которых лежат в отрезке [20,90].
Пример
массив [10 21 14 93 23] => 2*/

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
        if(element > 20 && element < 90)
        {
            i++;
        }
    }
        Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20, 90]: {i}");