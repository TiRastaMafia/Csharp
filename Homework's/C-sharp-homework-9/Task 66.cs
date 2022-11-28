/*№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№       Задача 66:           №№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№*/
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Ведите с какой цифры начать: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ведите с какой цифры начать: ");
int b = Convert.ToInt16(Console.ReadLine());

int SummNumbers(int a, int b)
{  
 if (a == b) return - b*2 - a;
 else return SummNumbers(a, b-1) + a + b ;
}
Console.WriteLine(SummNumbers(a,b));
