// ������ 41: ������������ ������ � ���������� M �����. ����������, ������� ����� ������ 0 ��� ������������.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, -567, 89, 223-> 3
Console.WriteLine("������� � ���������� M ����� ����� ������� ");
string? text = Console.ReadLine();
int result = 0;
string[] words = text.Split(new char[] {','});
foreach (string s in words)
{
    string newS = s;
    int newS1 = Convert.ToInt32(s);
    if (newS1 > 0) result++;
}
Console.WriteLine($"{result} ����� ������ 0 ��� ������������");