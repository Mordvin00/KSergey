/*Задача 4**(не обязательно):
Дано натуральное число в диапазоне от 1 до 100 000.
Создайте массив, состоящий из цифр этого числа.
Старший разряд числа должен располагаться на 0-м индексе массива,
младший – на последнем.
Размер массива должен быть равен количеству цифр.
Пример
425 => [4 2 5]
8741 => [8 7 4 1]
4 => [4] */


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

Console.Write("Введите количество элементов массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(lengthArray);
PrintArray(arr);

