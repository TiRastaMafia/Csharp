// «адача 47. «адайте двумерный массив размером min, заполненный случайными вещественными числами.

// m = 3, n = 4.


void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-10, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "     ");
        }
        Console.WriteLine("");
    }
}

double[,] numbers = new double[3, 4];
FillArray(numbers);
PrintArray(numbers);
