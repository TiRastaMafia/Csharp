//  ������� ���������� ������, ����������� ���������� �������. 
// ������� ����� ���������, ������� �� �������� ��������.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("������� ������ �������: ");
int x = Convert.ToInt32(Console.ReadLine());

int[] array = new int[x];

for (int i = 0; i < array.Length; i++)
//���� ���������� �������.
{
    //���������� ���������� ����� �� 0 �� 1000 [i]-���� �������� �������.
    array[i] = new Random().Next(0, 1000);

    Console.Write(array[i] + " ");//����� �� �����.
}
Console.WriteLine("\n���������:");
//���� ������ �������.
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 2) array[i] += array[i] ;
                
    Console.Write(array[i] + " ");
}
