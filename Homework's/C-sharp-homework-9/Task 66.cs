/*�����������������������������������       ������ 66:           ������������������������������������������������������������������������������*/
// ������� �������� M � N. �������� ���������, ������� ����� ����� ����������� ��������� � ���������� �� M �� N.

Console.WriteLine("������ � ����� ����� ������: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("������ � ����� ����� ������: ");
int b = Convert.ToInt16(Console.ReadLine());

int SummNumbers(int a, int b)
{  
 if (a == b) return - b*2 - a;
 else return SummNumbers(a, b-1) + a + b ;
}
Console.WriteLine(SummNumbers(a,b));
