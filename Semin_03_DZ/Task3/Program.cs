/*Задача 3: Задайте массив из вещественных чисел
с ненулевой дробной частью. Найдите разницу между
максимальным и минимальным элементов массива.
Пример
массив [2.2 0.4 9.11 7.2 78.98] => 78.58
массив [1.22 4.5 3.33] => 3.28 */

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = rand.NextDouble()*100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write($"{ randomArray[i]:F2} ");
}

}

double raz(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max < randomArray[i])
            max = randomArray[i];
        if (min > randomArray[i])
            min = randomArray[i];
        i = i + 1;
    }
    return max - min;
}

mas(a);
Console.Write($"\nРазница между максимальным и минимальным элементом массива: { raz(randomArray):F2}");
