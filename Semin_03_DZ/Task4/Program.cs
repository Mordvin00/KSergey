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

Console.Clear();
int number = new Random().Next(1, 100001);
int n = number;
int count = 0;
while (n > 0){
    n /= 10;
    count++;
}
Console.WriteLine(number);
// Console.WriteLine(count);
int[] array = new int[count];
while (count > 0){
    array[count - 1] = number % 10;
    number /= 10; //  234567 : 10 = 23456
    count--; // count = count - 1
}
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");