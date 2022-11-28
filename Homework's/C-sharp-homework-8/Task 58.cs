// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine($"\nEnter size massive m x n :");
Console.WriteLine("Enter the number of lines (m): ");
int line = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the number of colonm (n): ");
int colonm = Convert.ToInt16(Console.ReadLine());

int[,] array = new int[line, colonm];
int[,] array2 = new int[line, colonm];
int[,] arrayResult = new int[line, colonm];

void CreateSumm_array_array2(int[,] arrayResult)
{
  for (int i = 0; i < arrayResult.GetLength(0); i++)
  {
    for (int j = 0; j < arrayResult.GetLength(1); j++)
    {
      arrayResult[i, j] = array[i, j] * array2[i, j];
    }
  }
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-3,3);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(String.Format("{0,3}", array[i, j]));
    }
    Console.WriteLine();
  }
}


CreateArray(array);
CreateArray(array2);
CreateSumm_array_array2(arrayResult);
Console.WriteLine($"\nFirst massive: ");
WriteArray(array);
Console.WriteLine($"\nSecond massive: ");
WriteArray(array2);
Console.WriteLine($"\nResult massive: ");
WriteArray(arrayResult);