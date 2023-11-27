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

/*
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
*/


void inputArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new arr[i]; // [0; 9]
}


// int formingNumber(int[] array)
// {
//     int result = 0;
//     int i = array.Length - 1;
//     foreach (int el in array){
//         result += el * Convert.ToInt32(Math.Pow(10, i));
//         i--;
//     }
//     return result;
// }


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 0 || n > 100000){
    Console.Write("Вы ошиблись! Введите число от 0 до 100000: ");
    n = int.Parse(Console.ReadLine()!);
}

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
while (n > 0){   //на вход принимает натуральное число N, а на выходе показывает его цифры через запятую
    int x = n % 10;
    Console.Write($"{inputArray(x)}, ");
    n /= 10;
}

// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Результат: {formingNumber(array)}");
// Console.WriteLine($"Результат: {string.Join("", array)}");


