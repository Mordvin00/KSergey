﻿/*using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
 if (firstNumber < secondNumber)
                    Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
               else
        if (firstNumber > secondNumber)
                    Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
        else
            Console.WriteLine($"Введенные числа равны `{firstNumber}`");

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 5;
            secondNumber = 5;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}
*/
/*
using System;

public class Answer
{

    static int FindMax(int a, int b, int c)
    {
        // Введите свое решение ниже

        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;

        // int max = a;
        // if (a > max) max = a;
        // if (b > max) max = b;
        // if (c > max) max = c;
        // return max;

        // int max = a;
        // if (max < b)
        // {
        //     max = b;
        // }
        // if (max < c)
        // {
        //     max = c;
        // }
        // return max;

    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int a, b, c;

        if (args.Length >= 3)
        {
            a = int.Parse(args[0]);
            b = int.Parse(args[1]);
            c = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            a = 5;
            b = 6;
            c = 7;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}
*/

using System;

/*
Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит,
является ли число чётным (делится ли оно на два без остатка).
Пример использования:
На входе:
number: '6'
На выходе:
Число `6` чётное
На входе:
number: '3'
На выходе:
Число `3` нечётное
*/
/*
class Answer
{
    static void CheckIfEven(int number)
    {
        // Введите свое решение ниже

        if (number % 2 > 0)
            Console.WriteLine($"Число `{number}` нечётное");
        else
            Console.WriteLine($"Число `{number}` чётное");

        // if ((number % 2) == 0)
        // {
        //     Console.WriteLine($"Число `{number}` чётное");
        // }
        // else
        // {
        //     Console.WriteLine($"Число `{number}` нечётное");

        }


        // Не удаляйте и не меняйте метод Main! 
        static public void Main(string[] args)
        {
            int number;

            if (args.Length >= 1)
            {
                number = int.Parse(args[0]);
            }
            else
            {
                // Здесь вы можете поменять значения для отправки кода на Выполнение
                number = 6;
            }

            // Не удаляйте строки ниже
            CheckIfEven(number);
        }
    }
*/

using System;

// Внутри класса Answer напишите метод PrintEvenNumbers,
// которая на вход принимает число (number),
// а на выходе выводит все чётные числа от 1 до number (включительно),
// разделеные знаком табуляции.

// number = 5 -> 2    4

// number = 8 -> 2    4    6    8


public class Answer
{
    static void PrintEvenNumbers(int number)
    {
        // Введите свое решение ниже

        // for (begin, condition, step)
        // i = (-1)*n, i++ <-> i+=1 <-> i = i + 1

        for (int i = 2; i <= number; i += 2)
            Console.Write($"{i}	"); //Console.Write($"{count}\t")

    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6
            ;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}


/*
        Console.Write($"number = {number} -> ");
        for (int i = 2; i < number; i += 2)
            Console.Write($"{i}    ");
        Console.Write(number);



*/


