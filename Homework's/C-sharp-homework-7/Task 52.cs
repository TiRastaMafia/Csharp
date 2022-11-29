// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, m];

void PrintMatrix(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            {
                numbers[i, j] = new Random().Next(1, 5);
            }
        }
    }
}

void FillNewMatrix(int[,] newArray, int[,] numbers)
{
    double res = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            res += numbers[i, j];
        }
        res = res / numbers.GetLength(0);
        Console.Write($"|{j + 1}| = {Math.Round(res, 1)}  ");
        res = 0;
    }

}

FillMatrix(numbers);
PrintMatrix(numbers);
int[,] newMass = new int[numbers.GetLength(0), numbers.GetLength(1)];
Console.WriteLine("Среднее арифметическое каждого столбца: ");
FillNewMatrix(newMass, numbers);
