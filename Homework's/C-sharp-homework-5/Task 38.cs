// // ������� ������ ������������ �����. ������� ������� ����� ������������ � ����������� ��������� �������.

// // [3 7 22 2 78] -> 76

Console.WriteLine("������� ������ �������: ");
int x = Convert.ToInt32(Console.ReadLine());

int[] array = new int[x];
int min = int.MaxValue;
int max = int.MinValue;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
// ������� ������ �������
    Console.Write("{0} ", array[i]);
// ���� ������ 
    if (min > array[i])
    {
        min = array[i];
    }
    if (max < array[i])
    {
        max = array[i];
    }
}

Console.WriteLine($"      ��������� ����� {max} � {min}      ����� => {max - min}");
