/*�������� ���������, ������� ��������� �� ���� ����������� ����� � ���������, �������� �� ��� �����������.
14212 -> ���
12821 -> ��
23432 -> ��*/

// �������� �� �������� ���� � �� ������
int number = 0;
while (true){
    Console.Write("������� ����������� �����: ");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
}
int oldValue = number;
// �������� �� �� ��� ����� 5 �������
if (oldValue < 9999 || oldValue > 99999){
    Console.Write("�������� �� ����������� �����! ");   
    Console.ReadKey();
    return;      
}
// �������� �� ��������������     
int newValue = 0;
while (number > 0){
    int dig = number % 10;
    newValue = newValue * 10 + dig;
    number = number / 10;
}
// ����� ����������
if (newValue == oldValue)
    Console.WriteLine($"����� {oldValue} �������� �����������");
else
    Console.WriteLine($"����� {oldValue} �� �������� �����������");