// ���� ��������� ���� ����� �� ���� X Y Z
/*double distance;
Console.Write("������� �������� x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("������� �������� x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("������� �������� y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("������� �������� y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("������� �������� z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("������� �������� z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"���������� ����� ����� ������� � ������������ ����� {distance}");
Console.ReadKey();*/






internal class Program
{
    private static void Main(string[] args)
    {
// ����������� � ����� ���������
        Console.WriteLine("������� ����� ������ �������� x1, y1, z1, x2, y2, z2, ������� enter"); 
// �������� ������� � ����������������� ��������� � ���������� 
        double[] array = Console.ReadLine().Split(' ').Select(i => double.Parse(i)).ToArray();
// �������� �� ������������ ���������� ���������� ��������� ��� ������ �������
            if (array.Length != 6){
            System.Console.WriteLine("�� ����� ������������ ����������");
                return;
            }
// ������ ���������� ����� 2-�� ������� � ������������ �� ������� https://calculatorium.ru/math/distance-between-two-points-in-3d
        Console.WriteLine(Math.Sqrt(Math.Pow(array[3] - array[0], 2) + Math.Pow(array[4] - array[1], 2) + Math.Pow(array[5] - array[2], 2)));
    }
}
