
//  Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном массиве,
// и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите размерность массива через запятую: ");
string size = Console.ReadLine();
string[] mass = size.Split(",");
int[,] massive = new int[Convert.ToInt32(mass[0]), Convert.ToInt32(mass[1])];
Console.WriteLine("Введите искомое число: ");
int FindNumber = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите № строки: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите № столбца: ");
int n = Convert.ToInt16(Console.ReadLine());
int count = 0;


void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }
}

void FillNewMatrix(int[,] newArray, int[,] array)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (FindNumber == array[i, j])
            {
                int SaveNumber, row, colunm;

                SaveNumber = array[i, j];
                row = i;
                colunm = j;
                Console.WriteLine($"{FindNumber} --> такой элемент есть и находится по индексу {row}, {colunm}");
            }
            else count++;
            if (count == newArray.GetLength(0) * newArray.GetLength(1))
            {
                Console.WriteLine($"{FindNumber} число отсутствует в матрице");
            }
            if (m == i && n == j)
            {
                Console.WriteLine($"по заданным Вами координатам находится число {array[i, j]}");
            }

        }
    }

}

FillMatrix(massive);
PrintMatrix(massive);
int[,] newMass = new int[massive.GetLength(0), massive.GetLength(1)];
Console.WriteLine();
FillNewMatrix(newMass, massive);
