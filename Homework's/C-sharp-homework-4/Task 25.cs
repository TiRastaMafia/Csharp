
Console.WriteLine("������� ����� A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("������� ����� B");
int B = Convert.ToInt32(Console.ReadLine());
int numt(int A, int B)
{
    int result = A;
    int i = 0;
    for (i = 1; i != B; i++)
    {
        result = result * A;
    }
    return result;
}
Console.Write(numt(A, B));
//=================================================    ������� � 2 ������� ��� Convert.ToInt32    ============================================================================

// while (true)
// {
//     Console.Write("������� ����� A: ");
//     string A = Console.ReadLine();
//     if (int.TryParse(A, out int number1))
//     {
//         Console.Write("������� ����� B: ");
//         string B = Console.ReadLine();
//         if (int.TryParse(B, out int number2))
//         {
//             int A1 = Convert.ToInt32(A);
//             int B1 = Convert.ToInt32(B);
//             int numt(int A1, int B1)
//             {
//                 int result = A1;
//                 int i = 0;
//                 for (i = 1; i != B1; i++)
//                 {
//                     result = result * A1;
//                 }
//                 return result;
//             }
//             Console.Write($"��� ��������� ����� ----> {numt(A1, B1)}");
//             break;
//         }
//         else
//         {
//             Console.WriteLine($"�� ������� ���������� ����� {B}, ���������� ��� ���.");
//             // break;
//         }
//     }
//     else
//     {
//         Console.WriteLine($"�� ������� ���������� ����� {A}, ���������� ��� ���.");
//         // break;
//     }


// }