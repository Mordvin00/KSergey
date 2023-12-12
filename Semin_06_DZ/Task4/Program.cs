/*Задача 4*(не обязательная):
Задайте строку, состоящую из слов, разделенных пробелами.
Сформировать строку, в которой слова расположены в обратном порядке.
В полученной строке слова должны быть также разделены пробелами.
Пример
“Hello my world” => “world my Hello” */

{
// Входная строка со словами, разделенными пробелами
// string input = "Hello my world";
Console.Clear();
Console.Write("Введите предложение для зеркальной перестановки слов: ");
string input = Console.ReadLine()!;
// Вызов метода для обращения порядка слов в строке
string result = ReverseWords(input);
// Вывод результата
Console.WriteLine(result);
}
// Метод для обращения порядка слов в строке
static string ReverseWords(string str)
{
// Разделение строки на слова
string[] words = str.Split(' ');
// Обращение порядка слов
Array.Reverse(words);
// Соединение слов обратно в строку с пробелами
return string.Join(" ", words);
}