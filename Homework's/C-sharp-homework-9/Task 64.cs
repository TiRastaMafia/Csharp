№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№       Задача 64:           №№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№*/
//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Ведите с какой цифры начать: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ведите с какой цифры начать: ");
int b = Convert.ToInt16(Console.ReadLine());
static string NumbersRec(int a, int b)
    {
     if (a <= b) return NumbersRec(a, b-1) + $"{b}, ";
     else return string.Empty;
    }
Console.WriteLine(NumbersRec(a,b));
