/*�����������������������������������       ������ 64:           ������������������������������������������������������������������������������*/
//  ������� �������� M � N. �������� ���������, ������� ������� ��� ����������� ����� � ���������� �� M �� N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("������ � ����� ����� ������: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("������ � ����� ����� ������: ");
int b = Convert.ToInt16(Console.ReadLine());
static string NumbersRec(int a, int b)
    {
     if (a <= b) return NumbersRec(a, b-1) + $"{b}, ";
     else return string.Empty;
    }
Console.WriteLine(NumbersRec(a,b));