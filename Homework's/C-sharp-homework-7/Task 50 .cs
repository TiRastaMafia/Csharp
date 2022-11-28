
//  �������� ���������, ������� �� ���� ��������� ������� �������� ���� �������� �������� � ��������� �������,
// � ���������� �������� ���� ������ ����� �������� ��� �� ��������, ��� ������ �������� ���.

Console.WriteLine("������� ����������� ������� ����� �������: ");
string size = Console.ReadLine();
string[] mass = size.Split(",");
int[,] massive = new int[Convert.ToInt32(mass[0]), Convert.ToInt32(mass[1])];
Console.WriteLine("������� ������� �����: ");
int FindNumber = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("������� � ������: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("������� � �������: ");
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
                Console.WriteLine($"{FindNumber} --> ����� ������� ���� � ��������� �� ������� {row}, {colunm}");
            }
            else count++;
            if (count == newArray.GetLength(0) * newArray.GetLength(1))
            {
                Console.WriteLine($"{FindNumber} ����� ����������� � �������");
            }
            if (m == i && n == j)
            {
                Console.WriteLine($"�� �������� ���� ����������� ��������� ����� {array[i, j]}");
            }

        }
    }

}

FillMatrix(massive);
PrintMatrix(massive);
int[,] newMass = new int[massive.GetLength(0), massive.GetLength(1)];
Console.WriteLine();
FillNewMatrix(newMass, massive);
