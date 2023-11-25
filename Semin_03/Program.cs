/*Задание 1. Совместная работа
Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.

Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да*/

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
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
/*
void FindNumberInArray(int num, int[] ar)
{
    bool flag = false;
    foreach (int element in ar)
    {
        if(element == num)
        {
            flag = true;
        }
    }
        if(flag) Console.WriteLine("Да");
        else Console.WriteLine("Нет");
}

int lengthArray = 8;
int[] arr = FillArray(lengthArray);
PrintArray(arr);

int lengthArray2 = 12;
int[] arr2 = FillArray(lengthArray2);
PrintArray(arr2);

Console.Write("Введите число, которое будем искать: ");
int number = Convert.ToInt32(Console.ReadLine());
FindNumberInArray(number, arr);
FindNumberInArray(number, arr2);
*/

/*Задание 2. Работа в сессионных залах
Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6]*/

int lengthArray = 10;
int[] arr = FillArray(lengthArray);
PrintArray(arr);
for (int i = 0; i < arr.Length; i++)
arr[i] = -arr[i];
PrintArray(arr);
