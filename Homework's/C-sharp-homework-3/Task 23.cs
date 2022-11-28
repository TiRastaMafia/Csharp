/*
Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125;
*/

int getNumberFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 1)
    {
        Console.Write($"Ошибка ввода! Ожидается целое число больше единицы. {userInformation} ");
    }
    return result;
}

int number = getNumberFromUser("Введите целое число N > 1: ");

int[] tableQuarterNumber(int number)
{
int[] result = new int [number];
for(int i = 1; i <= number; i++)
{
result[i - 1] = (int)(Math.Pow(i, 3));
}
return result;
}

int[] table = tableQuarterNumber(number);

foreach (var value in table)
{
Console.Write(value + " ");
}
