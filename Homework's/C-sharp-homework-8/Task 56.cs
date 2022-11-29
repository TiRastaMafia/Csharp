
Console.WriteLine($"\nEnter size massive m x n :");
Console.WriteLine("Enter the number of lines (m): ");
int line = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the number of colonm (n): ");
int colonm = Convert.ToInt16(Console.ReadLine());
int minSumLine = 0;

int[,] array = new int[line, colonm];
CreateArray(array);
Console.WriteLine($"\nMassive: ");
WriteArray(array);

int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    // нахождение строки с минимальной суммой элементов
  int SumLineElem = SumLineElements(array, i);
  if (sumLine > SumLineElem)
  {
    sumLine = SumLineElem;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} line - with the smallest sum elements = {sumLine}");

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
//   Сумма элементов строки
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}


void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-10,10);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(String.Format("{0, 3}", array[i, j]));
    }
    Console.WriteLine();
  }
}
