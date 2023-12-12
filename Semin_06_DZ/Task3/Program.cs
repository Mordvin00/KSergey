/*Задача 3:
Задайте произвольную строку.
Выясните, является ли она палиндромом.
Пример
“aBcD1ef!-” => Нет
“шалаш” => Да
“55655” => Да */

{
// Входная строка для проверки
// string input = "шалаш";
Console.Clear();
Console.Write("Введите слово для проверки, является ли оно палиндромом: ");
string input = Console.ReadLine()!;
// Вызов метода для проверки, является ли строка палиндромом
bool isPalindrome = IsPalindrome(input);
// Вывод результата
Console.WriteLine(isPalindrome ? "Да" : "Нет");
}
// Метод для проверки, является ли строка палиндромом
static bool IsPalindrome(string str)
{
// Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// Сравнение строки с ее перевернутым вариантом
return normalized.SequenceEqual(normalized.Reverse());
}