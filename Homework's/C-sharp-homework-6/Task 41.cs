// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, -567, 89, 223-> 3
Console.WriteLine("Введите с клавиатуры M чисел через запятую ");
string? text = Console.ReadLine();
int result = 0;
string[] words = text.Split(new char[] {','});
foreach (string s in words)
{
    string newS = s;
    int newS1 = Convert.ToInt32(s);
    if (newS1 > 0) result++;
}
Console.WriteLine($"{result} чисел больше 0 ввёл пользователь");
